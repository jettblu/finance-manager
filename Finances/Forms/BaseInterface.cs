using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finances.Database;
using Finances.Forms;
using System.IO;

namespace Finances
{
    public partial class BaseInterface : Form
    {
        public BaseInterface()
        {
            InitializeComponent();
            Initialize();
            Summary(DBManager.GetAllTransactions());
            Initialize2();
        }

        public DatabaseManager DBManager { get; set; }
        public bool HasShown { get; set; }
        private void Initialize()
        {
            try
            {
                DBManager = new DatabaseManager();
                var retries = 3;
                while (DBManager.DBContext.Connection.State == ConnectionState.Connecting)
                {
                    retries--;
                    if (retries == 0)
                    {
                        // ToDo:  Add better error handler
                        return;
                    }

                    // Utils.PostConsoleMessage(string.Format("   -> MMDataFlowProcessor.ProcessHDRequest - Waiting for DB Connection . . ."));
                    Thread.SpinWait(500);
                    if (DBManager.DBContext.Connection.State == ConnectionState.Open) continue;
                }
            }
            catch (Exception e)
            {
                Utils.UserMessage("Error encountered while connecting to database.", Globals.MessageTypes.Status);
                Console.WriteLine(e);
                throw;
            }
        }

        private void Initialize2()
        {
            SetFieldStatus(false);
            HasShown = false;
        }

        private void SetFieldStatus(bool enabled)
        {
            tbox_Amount.Enabled = enabled;
            cmbbox_Category.Enabled = enabled;
            cmbbox_Person.Enabled = enabled;
            dtp_Date.Enabled = enabled;
            cmbbox_TransType.Enabled = enabled;
        }

        private void BaseInterface_Load(object sender, EventArgs e)
        {
            BindingSource_Categories.DataSource = DBManager.DBContext.Categories;
            BindingSource_People.DataSource = DBManager.DBContext.Peoples;
            BindingSource_TransactionType.DataSource = DBManager.DBContext.TransactionTypes;
            BindingSource_Transactions.DataSource = DBManager.DBContext.Transactions;
            
            gridview_Transactions.Refresh();
        }

        private void BaseInterface_Shown(object sender, EventArgs e)
        {
            HasShown = true;
        }

        private void Btn_PeopleManager_Click(object sender, EventArgs e)
        {
            try
            {
                var PeopleForm = new PeopleManager(DBManager);
                PeopleForm.ShowDialog();
            }
            catch (Exception exception)
            {
                Utils.UserMessage($"{exception}", Globals.MessageTypes.Error);
                throw;
            }
        }

        private void UpdateDialogue(Transaction trans)
        {
            if (trans == null) return;
            tbox_Id.Text = trans.ID.ToString("D");
            tbox_Amount.Text = trans.Amount.ToString("F");
            cmbbox_Category.Text = DBManager.GetCategoryByID(trans.CategoryID).Name;
            var person = DBManager.GetPersonByID(trans.PeopleID);
            cmbbox_Person.Text = $"{person.FirstName} {person.LastName}";
            dtp_Date.Text = trans.DateOfTransaction.ToString("F");
            cmbbox_TransType.Text = trans.TransactionTypeName;
            //cmbbox_Person.Text = $"{person.FirstName} {person.LastName}";
            cmbbox_Person.Enabled = false;
            tbox_Note.Text = trans.Note;
            if (!File.Exists(trans.People.MugFilePath))
            {
                pbox_MugPreview.Image = null;
                return;
            }
            
            pbox_MugPreview.Load(trans.People.MugFilePath);
            pbox_MugPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Refresh();
        }

        private void Btn_SaveTransaction_Click(object sender, EventArgs e)
        {
            var transType = cmbbox_TransType.SelectedItem as TransactionType;
            var personType = cmbbox_Person.SelectedItem as People;
            var categoryType = cmbbox_Category.SelectedItem as Category;
            var date = dtp_Date.Value;

            if (transType == null || personType == null || categoryType == null) return;

            if (Convert.ToInt32(tbox_Id.Text) == 0)
            {  
                var Trans = DBManager.CreateTransaction(Convert.ToDecimal(tbox_Amount.Text), date, transType, personType, categoryType, tbox_Note.Text.Trim());
                RefreshTransactionGrid();
                ClearFields();
                return;
            }

            DBManager.UpdateTransaction(Trans_Id: Convert.ToInt32(tbox_Id.Text), amount: Convert.ToDecimal(tbox_Amount.Text), dateCreated: Convert.ToDateTime(dtp_Date.Text),
                note: tbox_Note.Text);
            RefreshTransactionGrid();
        }

        private void RefreshTransactionGrid()
        {
            BindingSource_Transactions.DataSource = DBManager.GetAllTransactions();
            gridview_Transactions.Refresh();
            Summary(DBManager.GetAllTransactions());
        }

        private void btn_CreateNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void gridview_Transactions_SelectionChanged(object sender, EventArgs e)
        {
            if (!HasShown || gridview_Transactions.SelectedRows.Count < 1) return;
            var selectedTransaction = gridview_Transactions.CurrentRow.DataBoundItem as Transaction;
            SetFieldStatus(true);
            UpdateDialogue(selectedTransaction);
        }

        private void tbox_Amount_Leave(object sender, EventArgs e)
        {
            decimal dDecimal;
            if (decimal.TryParse(tbox_Amount.Text, out dDecimal)) return;
            Utils.UserMessage("Amount is invalid", Globals.MessageTypes.Status);
        }

        //updates summary area of form
        private void Summary(IEnumerable<Transaction> transactionsEnumerable)
        {
            decimal amountAvailable = 0;
            decimal moneyOut = 0;
            decimal moneyIn = 0;
            decimal netFlow = 0;
            try
            {
                foreach (var transaction in transactionsEnumerable)
                {
                    //adds to in/ out variables based on category name
                    switch (transaction.TransactionTypeName)
                    {
                        case "Money Out":
                            moneyOut += transaction.Amount;
                            break;
                        case "Money In":
                            moneyIn += transaction.Amount;
                            break;
                    }

                    amountAvailable += transaction.Amount;
                }

                netFlow = moneyIn - moneyOut;
                tbox_MoneyIn.Text = $"    ${moneyIn}";
                tbox_MoneyOut.Text = $"    ${moneyOut}";
                tbox_NetFlow.Text = $"    ${Math.Abs(netFlow)}";
                tbox_MoneyAvailable.Text = $"        ${amountAvailable}";
                //if less money comes in then out, text is red...otherwise text is green
                tbox_NetFlow.ForeColor = netFlow < 0 ? Color.Red : Color.ForestGreen;
            }
            catch (Exception e)
            {
                Utils.UserMessage("No transactions available for load.", Globals.MessageTypes.Status);
                throw;
            }
            
        }

       

        private void pbox_MugPreview_Click(object sender, EventArgs e)
        {
            pbox_MugPreview.Image = null;
        }

        private void cmbbox_Person_Leave(object sender, EventArgs e)
        {
            var personType = cmbbox_Person.SelectedItem as People;
            if (!File.Exists(personType.MugFilePath))
            {
                pbox_MugPreview.Image = null;
                return;
            }
            pbox_MugPreview.Load(personType.MugFilePath);
            pbox_MugPreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_Trans_Click(object sender, EventArgs e)
        {
            try
            {
                var TransFilterForm = new TransactionViewer(DBManager);
                TransFilterForm.ShowDialog();
            }
            catch (Exception exception)
            {
                Utils.UserMessage($"{exception}", Globals.MessageTypes.Status);
                throw;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {   
                cmbbox_Person.ResetBindings();
                cmbbox_Category.ResetBindings();
                cmbbox_TransType.ResetBindings();
                RefreshTransactionGrid();
                ClearFields();
            }
            catch (Exception exception)
            {
                Utils.UserMessage("Could not refresh.", Globals.MessageTypes.Status);
                throw;
            }
        }

        private void ClearFields()
        {
            SetFieldStatus(true);
            tbox_Amount.Text = "";
            cmbbox_Category.Text = "";
            cmbbox_Person.Text = "";
            dtp_Date.Text = "";
            tbox_Note.Text = "";
            cmbbox_TransType.Text = "";
            tbox_Id.Text = "0";
            try
            {
                pbox_MugPreview.Image = null;
            }
            catch (Exception exception)
            {
                return;
                throw;
            }
        }

        //private void RefreshPage()
        //{
        //    BindingSource_Categories.DataSource = DBManager.DBContext.Categories;
        //    BindingSource_People.DataSource = DBManager.DBContext.Peoples;
        //    BindingSource_TransactionType.DataSource = DBManager.DBContext.TransactionTypes;
        //    BindingSource_Transactions.DataSource = DBManager.DBContext.Transactions;
        //    cmbbox_Person.Refresh();
        //    cmbbox_Category.Refresh();
        //    cmbbox_TransType.Refresh();
        //    gridview_Transactions.Refresh();
        //    ClearFields();
        //}
    }
}
