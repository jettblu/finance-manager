using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finances.Database;
using System.Text.RegularExpressions;

namespace Finances.Forms
{
    public partial class PeopleManager : Form
    {
        public PeopleManager(DatabaseManager dbManager)
        {
            InitializeComponent();
            Initialize();
            DBManager = dbManager;
        }

        public DatabaseManager DBManager { get; private set; }
        public bool HasShown { get; set; }
        private string ImageFileSpec { get; set; }

        #region ======================== Form Load/Show Events ==========================

        private void PeopleManager_Load(object sender, EventArgs e)
        {
            bindingSource_People.DataSource = DBManager.DBContext.Peoples;
            BindingSource_Transactions.DataSource = DBManager.DBContext.Transactions;
        }
        private void PeopleManager_Shown(object sender, EventArgs e)
        {
            HasShown = true;
        }

        private void Initialize()
        {
            SetFieldStatus(false);
            HasShown = false;
        }
        #endregion

        private void Btn_NewPhoto_Click(object sender, EventArgs e)
        {
            pbox_MugPreview.Image = null;
            Dia_PhotoSelector.FileName = "";
            ImageFileSpec = "";
        }

        private void SetFieldStatus(bool enabled)
        {
            tbox_FirstName.Enabled = enabled;
            tbox_LastName.Enabled = enabled;
            tbox_Email.Enabled = enabled;
            tbox_PhoneNumber.Enabled = enabled;
            pbox_MugPreview.Enabled = enabled;
        }

        //allows user to choose image file upon clicking choose photo button
        private void Btn_ChoosePhoto_Click(object sender, EventArgs e)
        {
            if (Dia_PhotoSelector.ShowDialog() != DialogResult.OK) return;
            ImageFileSpec = $"{Properties.Settings.Default.ImagesPath}\\{Path.GetFileName(Dia_PhotoSelector.FileName)}";
            File.Copy(Dia_PhotoSelector.FileName, ImageFileSpec, true);

            pbox_MugPreview.Load(ImageFileSpec);
            pbox_MugPreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //adds person to database upon clicking save button
        private void Btn_Save_Click(object sender, EventArgs e)
        {   if(tbox_Id == null || tbox_Id.Text == "") Utils.UserMessage("Create or update before you save noob.", Globals.MessageTypes.Status);
            if (Convert.ToInt32(tbox_Id.Text) == 0)
            {
                var p = DBManager.CreatePerson(tbox_FirstName.Text, tbox_LastName.Text, tbox_Email.Text, tbox_PhoneNumber.Text, ImageFileSpec);
                RefreshPeopleGrid();
                tbox_FirstName.Text = string.Empty;
                tbox_LastName.Text = string.Empty;
                tbox_Email.Text = string.Empty;
                tbox_PhoneNumber.Text = string.Empty;
                pbox_MugPreview.Image = null;
                tbox_Id.Text = "0";
                return;
            }
            DBManager.UpdatePerson(tbox_FirstName.Text, tbox_LastName.Text, tbox_Email.Text, tbox_PhoneNumber.Text, ImageFileSpec);
            RefreshPeopleGrid();
        }

        //clears input fields 
        private void Btn_CreateNew_Click(object sender, EventArgs e)
        {   
            SetFieldStatus(true);
            tbox_FirstName.Text = string.Empty;
            tbox_LastName.Text = string.Empty;
            tbox_Email.Text = string.Empty;
            tbox_PhoneNumber.Text = string.Empty;
            pbox_MugPreview.Image = null;
            tbox_Id.Text = "0";
        }

        //updates fields at top of form
        private void UpdateDialogue(People p)
        {   
             pbox_MugPreview.Image = null;
            if (p == null) return;
            tbox_Id.Text = p.ID.ToString("D");
            tbox_FirstName.Text = p.FirstName;
            tbox_LastName.Text = p.LastName;
            tbox_Email.Text = p.Email;
            tbox_PhoneNumber.Text = p.PhoneNumber;
            Dia_PhotoSelector.FileName = p.MugFilePath;
            ImageFileSpec = p.MugFilePath;
            this.Refresh();

            if (!File.Exists(p.MugFilePath)) return;
            pbox_MugPreview.Load(p.MugFilePath);
            pbox_MugPreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //refereshes grid at bottom of form
        private void RefreshPeopleGrid()
        {
            bindingSource_People.DataSource = DBManager.GetAllPersons();
            
            gridview_People.Refresh();
        }

        //validates email
        private void tbox_Email_Leave(object sender, EventArgs e)
        {
            if (tbox_Email.Text.Trim() == string.Empty) return;

            var mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

            if (mRegxExpression.IsMatch(tbox_Email.Text.Trim())) return;

            MessageBox.Show("Email address format is not correct.", "Email Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbox_Email.Refresh();
        }

        private void gridview_People_SelectionChanged(object sender, EventArgs e)
        {
            if (!HasShown || gridview_People.SelectedRows.Count < 1) return;

            var selectedPerson = gridview_People.SelectedRows[0].DataBoundItem as People;
            UpdateDialogue(selectedPerson);
        }

        private void gridview_People_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != (char)Keys.Delete) return;
            if (!(sender is DataGridView dgv)) return;
            var row = dgv.CurrentRow;
            var people = row.DataBoundItem as People;
            var personTransactions = DBManager.GetTransactionsByPeople(people);
            if (personTransactions.Count() == 0)
            {
                Utils.UserMessage($"There are no transactions associated with {people.FirstName} {people.LastName}.", Globals.MessageTypes.Status);
                return;
            }
            
            if (!Utils.ProcessMessageBoxYesNo($"You are about to delete {personTransactions.Count()} transactions assigned to {people.FirstName} {people.LastName}", "Delete?")) return;
            try
            {
                var status = DBManager.DBContext.DeleteTransactionsByPeopleID(people.ID);
                DBManager.DBContext.SubmitChanges();
                Utils.UserMessage("Transactions have been wiped off the face of this planet.", Globals.MessageTypes.Status);
            }
            catch (Exception exception)
            {
                Utils.UserMessage($"{exception}", Globals.MessageTypes.Error);
                throw;
            }
        }
    }
}
