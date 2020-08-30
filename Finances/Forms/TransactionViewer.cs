using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finances.Database;
using IBSampleApp.util;
using System.Net.Mail;

namespace Finances.Forms
{
    public partial class TransactionViewer : Form
    {
        public TransactionViewer(DatabaseManager dbManager)
        {
            InitializeComponent();
            Initialize();
            DBManager = dbManager;
        }
        public DatabaseManager DBManager { get; private set; }
        public bool HasShown { get; set; }
        private IEnumerable<Transaction> LastFoundTransactions;
        private void TransactionViewer_Load(object sender, EventArgs e)
        {
            BindingSource_People.DataSource = DBManager.DBContext.Peoples;
            BindingSource_Categories.DataSource = DBManager.DBContext.Categories;
            BindingSource_TransactionType.DataSource = DBManager.DBContext.TransactionTypes;
            transactionBindingSource.DataSource = DBManager.DBContext.Transactions;
            cmbbox_filters.Text = "Person";

            LastFoundTransactions = DBManager.DBContext.Transactions;
        }

        private void TransactionViewer_Shown(object sender, EventArgs e)
        {
            HasShown = true;
        }
        private void Initialize()
        {
            HasShown = false;
        }

        private void btn_GoFilter_Click(object sender, EventArgs e)
        {
            Requery();
        }

        private void Requery()
        {
            var filter = cmbbox_filters.Text.Trim().ToUpper();
            LastFoundTransactions = null;
            switch (filter)
            {
                case "PERSON":
                    var peep = cmbbox_Person.SelectedItem as People;
                    if (peep == null)
                    {
                        Utils.UserMessage("Person not specified", Globals.MessageTypes.Status);
                    }
                    LastFoundTransactions = DBManager.GetTransactionsByPeople(peep);
                    break;
                case "CATEGORY":
                    var category = cmbbox_Category.SelectedItem as Category;
                    if (category == null)
                    {
                        Utils.UserMessage("Category not specified", Globals.MessageTypes.Status);
                    }
                    LastFoundTransactions = OrderTransactions(DBManager.GetTransactionsByCategory(category));
                    break;

                case "TRANS. TYPE":
                    var transactionType = cmbbox_TransType.SelectedItem as TransactionType;
                    if (transactionType == null)
                    {
                        Utils.UserMessage("Transaction type not specified", Globals.MessageTypes.Status);
                    }
                    LastFoundTransactions = OrderTransactions((DBManager.GetTransactionsByTransactionType(transactionType)));
                    break;

                case "PERSON-CATEGORY":
                    var peepSpecified = cmbbox_Person.SelectedItem as People;
                    var categorySpecified = cmbbox_Category.SelectedItem as Category;
                    if (peepSpecified == null)
                    {
                        Utils.UserMessage("Person not specified", Globals.MessageTypes.Status);
                    }
                    if (categorySpecified == null)
                    {
                        Utils.UserMessage("Category not specified", Globals.MessageTypes.Status);
                    }
                    LastFoundTransactions = OrderTransactions((DBManager.GetTransactionsByPersonAndCategory(peepSpecified, categorySpecified)));
                    break;
                case "CATEGORY-TRANS.TYPE":
                    var transactionTypeItem = cmbbox_TransType.SelectedItem as TransactionType;
                    var categoryItem = cmbbox_Category.SelectedItem as Category;
                    if (categoryItem == null)
                    {
                        Utils.UserMessage("Category not specified", Globals.MessageTypes.Status);
                    }
                    if (transactionTypeItem == null)
                    {
                        Utils.UserMessage("Transaction Type not specified", Globals.MessageTypes.Status);
                    }
                    LastFoundTransactions = OrderTransactions(DBManager.GetTransactionsByCategoryAndTransactionType(categoryItem, transactionTypeItem));
                    break;
            }

            //below handles instances when transaction object is null or contains no relevant transactions
            if (LastFoundTransactions == null)
            {
                Utils.UserMessage("Transactions object was found to be null.", Globals.MessageTypes.Error); return;
            }

            if (LastFoundTransactions.Any() == false) Utils.UserMessage("No transactions found that match this search.", Globals.MessageTypes.Status);

            if (LastFoundTransactions == null || !LastFoundTransactions.Any()) return;
            SetTransactionBinding(LastFoundTransactions);
            return;
        }
        private void SetTransactionBinding(IEnumerable<Transaction> transactions)
        {
            transactionBindingSource.DataSource = LastFoundTransactions;
            Summary(transactions);
            gridviewer_Transactions.Refresh();
        }
        //updates summary area of form
        private void Summary(IEnumerable<Transaction> transactionsEnumerable)
        {
            decimal netFlow = 0;
            try
            {
                foreach (var transaction in transactionsEnumerable)
                {
                    //adds to in/ out variables based on category name
                    switch (transaction.TransactionTypeName)
                    {
                        case "Money Out":
                            netFlow -= transaction.Amount;
                            break;
                        case "Money In":
                            netFlow += transaction.Amount;
                            break;
                    }
                }
                tbox_NetFlow.Text = $"    ${netFlow}";
                tbox_NetFlow.ForeColor = netFlow < 0 ? Color.Red : Color.ForestGreen;
                tbox_NumberOfTransactions.Text = $"    {transactionsEnumerable.Count()}";
            }
            catch (Exception e)
            {
                return;
                throw;
            }

            this.Refresh();
        }

        private void WriteCsvFile(string fileName, IEnumerable<Transaction> transactions)
        {
            var writer = new CsvFileWriter(fileName);
            var row = new CsvStringRow
            {
                "Transaction Amount",
                "Transaction Type",
                "Person Name",
                "Category",
                "Note",
                "Date Created"
            };

            writer.WriteRow(row);
            foreach (var transaction in transactions)
            {
                var note = string.Empty;
                note = string.IsNullOrEmpty(transaction.Note) ? "<None>" : transaction.Note;

                row = new CsvStringRow
                {
                    transaction.Amount.ToString("C"),
                    transaction.TransactionType.TransactionTypeName,
                    $"{transaction.People.FirstName} {transaction.People.LastName}" ,
                    transaction.Categoryname,
                    note,
                    transaction.DateOfTransaction.ToString("d")
                };
                writer.WriteRow(row);
            }
            writer.Close();
        }

        private void Btn_CsvWrite_Click(object sender, EventArgs e)
        {
            var filepath = global::Finances.Properties.Settings.Default.CsvPath;
            var filespec = $"{filepath}\\Transaction-{DateTime.Now:yy-MM-dd}.csv";

            if (LastFoundTransactions!= null && LastFoundTransactions.Any())
            {
                WriteCsvFile(filespec, LastFoundTransactions);
                SendEmail(filespec, $"Filtered Finances {DateTime.Now:f}", "Stupid before smart.");
            }

        }
        //orders transactions by date created
        private IEnumerable<Transaction> OrderTransactions(IEnumerable<Transaction> transactions)
        {
            return transactions.OrderBy(transaction => transaction.DateOfTransaction);
        }
   
        private void SendEmail(string filePath, string subject, string message = "", string senderAddress = "jett2.718hays@gmail.com", string recipientAddress = "jettblufabrications@gmail.com")
        {
            var pWord = Properties.Settings.Default.EmailPassword;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(senderAddress);
                mail.To.Add(recipientAddress);
                mail.Subject = subject;
                mail.Body = message;

                var attachment = new Attachment(filePath);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(senderAddress, pWord);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Utils.UserMessage("File saved. Email sent with a smile.", Globals.MessageTypes.Status);
            }
            catch (Exception ex)
            {
                Utils.UserMessage("Email not sent. Hint: check 'less secure access' setting on your GMail account. P.S.: File was most likely saved.", Globals.MessageTypes.Status);
            }
        }

        private void gridviewer_Transactions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != (char)Keys.Delete) return;
            if (!Utils.ProcessMessageBoxYesNo("Are you sure you want to erase this transaction?", "Delete?")) return;
            if (!(sender is DataGridView dgv)) return;
            var row = dgv.CurrentRow;
            var trans = row.DataBoundItem as Transaction;
            try
            {
                var status = DBManager.DBContext.DeleteTransactionById(trans.ID);
                DBManager.DBContext.SubmitChanges();
                Requery();
                gridviewer_Transactions.Refresh();
            }
            catch (Exception exception)
            {
                Utils.UserMessage($"{exception}", Globals.MessageTypes.Error);
                throw;
            }
        }
    }
}
