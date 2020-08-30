namespace Finances
{
    partial class BaseInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseInterface));
            this.BindingSource_People = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSource_Transactions = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSource_Categories = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSource_TransactionType = new System.Windows.Forms.BindingSource(this.components);
            this.cmbbox_Category = new System.Windows.Forms.ComboBox();
            this.Btn_SaveTransaction = new System.Windows.Forms.Button();
            this.Btn_PeopleManager = new System.Windows.Forms.Button();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_People = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tbox_Amount = new System.Windows.Forms.TextBox();
            this.tbox_Note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbox_Person = new System.Windows.Forms.ComboBox();
            this.cmbbox_TransType = new System.Windows.Forms.ComboBox();
            this.lbl_TransType = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.tbox_Id = new System.Windows.Forms.TextBox();
            this.btn_CreateNew = new System.Windows.Forms.Button();
            this.dateOfTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_Transactions = new System.Windows.Forms.DataGridView();
            this.gbox_Summary = new System.Windows.Forms.GroupBox();
            this.lbl_MoneyAvailable = new System.Windows.Forms.Label();
            this.tbox_MoneyAvailable = new System.Windows.Forms.TextBox();
            this.lbl_MoneyOut = new System.Windows.Forms.Label();
            this.tbox_MoneyOut = new System.Windows.Forms.TextBox();
            this.lbl_MoneyIn = new System.Windows.Forms.Label();
            this.tbox_MoneyIn = new System.Windows.Forms.TextBox();
            this.lbl_NetMoney = new System.Windows.Forms.Label();
            this.tbox_NetFlow = new System.Windows.Forms.TextBox();
            this.pbox_MugPreview = new System.Windows.Forms.PictureBox();
            this.btn_Trans = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_People)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Categories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_TransactionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_Transactions)).BeginInit();
            this.gbox_Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_MugPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // BindingSource_People
            // 
            this.BindingSource_People.DataSource = typeof(Finances.People);
            // 
            // BindingSource_Transactions
            // 
            this.BindingSource_Transactions.DataSource = typeof(Finances.Transaction);
            // 
            // BindingSource_Categories
            // 
            this.BindingSource_Categories.DataSource = typeof(Finances.Category);
            // 
            // BindingSource_TransactionType
            // 
            this.BindingSource_TransactionType.DataSource = typeof(Finances.TransactionType);
            // 
            // cmbbox_Category
            // 
            this.cmbbox_Category.BackColor = System.Drawing.Color.White;
            this.cmbbox_Category.DataSource = this.BindingSource_Categories;
            this.cmbbox_Category.DisplayMember = "Name";
            this.cmbbox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_Category.FormattingEnabled = true;
            this.cmbbox_Category.Location = new System.Drawing.Point(136, 91);
            this.cmbbox_Category.Name = "cmbbox_Category";
            this.cmbbox_Category.Size = new System.Drawing.Size(190, 28);
            this.cmbbox_Category.TabIndex = 2;
            // 
            // Btn_SaveTransaction
            // 
            this.Btn_SaveTransaction.BackColor = System.Drawing.Color.Black;
            this.Btn_SaveTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveTransaction.ForeColor = System.Drawing.Color.Red;
            this.Btn_SaveTransaction.Location = new System.Drawing.Point(695, 402);
            this.Btn_SaveTransaction.Name = "Btn_SaveTransaction";
            this.Btn_SaveTransaction.Size = new System.Drawing.Size(233, 50);
            this.Btn_SaveTransaction.TabIndex = 12;
            this.Btn_SaveTransaction.Text = "Save Transaction";
            this.Btn_SaveTransaction.UseVisualStyleBackColor = false;
            this.Btn_SaveTransaction.Click += new System.EventHandler(this.Btn_SaveTransaction_Click);
            // 
            // Btn_PeopleManager
            // 
            this.Btn_PeopleManager.BackColor = System.Drawing.Color.Black;
            this.Btn_PeopleManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_PeopleManager.ForeColor = System.Drawing.Color.White;
            this.Btn_PeopleManager.Location = new System.Drawing.Point(463, 134);
            this.Btn_PeopleManager.Name = "Btn_PeopleManager";
            this.Btn_PeopleManager.Size = new System.Drawing.Size(189, 43);
            this.Btn_PeopleManager.TabIndex = 14;
            this.Btn_PeopleManager.Text = "People Manager";
            this.Btn_PeopleManager.UseVisualStyleBackColor = false;
            this.Btn_PeopleManager.Click += new System.EventHandler(this.Btn_PeopleManager_Click);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.White;
            this.lbl_Category.Location = new System.Drawing.Point(12, 91);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(118, 29);
            this.lbl_Category.TabIndex = 4;
            this.lbl_Category.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount";
            // 
            // lbl_People
            // 
            this.lbl_People.AutoSize = true;
            this.lbl_People.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_People.ForeColor = System.Drawing.Color.White;
            this.lbl_People.Location = new System.Drawing.Point(12, 133);
            this.lbl_People.Name = "lbl_People";
            this.lbl_People.Size = new System.Drawing.Size(96, 29);
            this.lbl_People.TabIndex = 6;
            this.lbl_People.Text = "Person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtp_Date.Location = new System.Drawing.Point(135, 226);
            this.dtp_Date.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(322, 30);
            this.dtp_Date.TabIndex = 5;
            // 
            // tbox_Amount
            // 
            this.tbox_Amount.BackColor = System.Drawing.Color.White;
            this.tbox_Amount.Location = new System.Drawing.Point(135, 46);
            this.tbox_Amount.Multiline = true;
            this.tbox_Amount.Name = "tbox_Amount";
            this.tbox_Amount.Size = new System.Drawing.Size(117, 28);
            this.tbox_Amount.TabIndex = 1;
            this.tbox_Amount.Leave += new System.EventHandler(this.tbox_Amount_Leave);
            // 
            // tbox_Note
            // 
            this.tbox_Note.Location = new System.Drawing.Point(133, 279);
            this.tbox_Note.Multiline = true;
            this.tbox_Note.Name = "tbox_Note";
            this.tbox_Note.Size = new System.Drawing.Size(324, 189);
            this.tbox_Note.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Note";
            // 
            // cmbbox_Person
            // 
            this.cmbbox_Person.BackColor = System.Drawing.Color.White;
            this.cmbbox_Person.DataSource = this.BindingSource_People;
            this.cmbbox_Person.DisplayMember = "FirstName";
            this.cmbbox_Person.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_Person.FormattingEnabled = true;
            this.cmbbox_Person.Location = new System.Drawing.Point(136, 134);
            this.cmbbox_Person.Name = "cmbbox_Person";
            this.cmbbox_Person.Size = new System.Drawing.Size(190, 28);
            this.cmbbox_Person.TabIndex = 3;
            this.cmbbox_Person.Leave += new System.EventHandler(this.cmbbox_Person_Leave);
            // 
            // cmbbox_TransType
            // 
            this.cmbbox_TransType.BackColor = System.Drawing.Color.White;
            this.cmbbox_TransType.DataSource = this.BindingSource_TransactionType;
            this.cmbbox_TransType.DisplayMember = "TransactionTypeName";
            this.cmbbox_TransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_TransType.FormattingEnabled = true;
            this.cmbbox_TransType.Location = new System.Drawing.Point(136, 181);
            this.cmbbox_TransType.Name = "cmbbox_TransType";
            this.cmbbox_TransType.Size = new System.Drawing.Size(190, 28);
            this.cmbbox_TransType.TabIndex = 4;
            // 
            // lbl_TransType
            // 
            this.lbl_TransType.AutoSize = true;
            this.lbl_TransType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransType.ForeColor = System.Drawing.Color.White;
            this.lbl_TransType.Location = new System.Drawing.Point(12, 181);
            this.lbl_TransType.Name = "lbl_TransType";
            this.lbl_TransType.Size = new System.Drawing.Size(72, 29);
            this.lbl_TransType.TabIndex = 15;
            this.lbl_TransType.Text = "Type";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.White;
            this.lbl_Id.Location = new System.Drawing.Point(12, 8);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(38, 29);
            this.lbl_Id.TabIndex = 17;
            this.lbl_Id.Text = "ID";
            // 
            // tbox_Id
            // 
            this.tbox_Id.BackColor = System.Drawing.Color.White;
            this.tbox_Id.Location = new System.Drawing.Point(133, 9);
            this.tbox_Id.Multiline = true;
            this.tbox_Id.Name = "tbox_Id";
            this.tbox_Id.ReadOnly = true;
            this.tbox_Id.Size = new System.Drawing.Size(117, 28);
            this.tbox_Id.TabIndex = 0;
            // 
            // btn_CreateNew
            // 
            this.btn_CreateNew.BackColor = System.Drawing.Color.Black;
            this.btn_CreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateNew.ForeColor = System.Drawing.Color.White;
            this.btn_CreateNew.Location = new System.Drawing.Point(463, 402);
            this.btn_CreateNew.Name = "btn_CreateNew";
            this.btn_CreateNew.Size = new System.Drawing.Size(233, 50);
            this.btn_CreateNew.TabIndex = 13;
            this.btn_CreateNew.Text = "Create New";
            this.btn_CreateNew.UseVisualStyleBackColor = false;
            this.btn_CreateNew.Click += new System.EventHandler(this.btn_CreateNew_Click);
            // 
            // dateOfTransactionDataGridViewTextBoxColumn
            // 
            this.dateOfTransactionDataGridViewTextBoxColumn.DataPropertyName = "DateOfTransaction";
            this.dateOfTransactionDataGridViewTextBoxColumn.HeaderText = "DateOfTransaction";
            this.dateOfTransactionDataGridViewTextBoxColumn.Name = "dateOfTransactionDataGridViewTextBoxColumn";
            this.dateOfTransactionDataGridViewTextBoxColumn.Width = 200;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionTypeName";
            this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            this.transactionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionTypeDataGridViewTextBoxColumn.Width = 120;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 250;
            // 
            // peopleDataGridViewTextBoxColumn
            // 
            this.peopleDataGridViewTextBoxColumn.DataPropertyName = "PeeopleName";
            this.peopleDataGridViewTextBoxColumn.HeaderText = "People";
            this.peopleDataGridViewTextBoxColumn.Name = "peopleDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Categoryname";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.FillWeight = 75F;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // gridview_Transactions
            // 
            this.gridview_Transactions.AllowUserToDeleteRows = false;
            this.gridview_Transactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_Transactions.AutoGenerateColumns = false;
            this.gridview_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_Transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.peopleDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn,
            this.dateOfTransactionDataGridViewTextBoxColumn});
            this.gridview_Transactions.DataSource = this.BindingSource_Transactions;
            this.gridview_Transactions.Location = new System.Drawing.Point(12, 474);
            this.gridview_Transactions.Name = "gridview_Transactions";
            this.gridview_Transactions.RowTemplate.Height = 28;
            this.gridview_Transactions.Size = new System.Drawing.Size(911, 379);
            this.gridview_Transactions.TabIndex = 7;
            this.gridview_Transactions.SelectionChanged += new System.EventHandler(this.gridview_Transactions_SelectionChanged);
            // 
            // gbox_Summary
            // 
            this.gbox_Summary.Controls.Add(this.lbl_MoneyAvailable);
            this.gbox_Summary.Controls.Add(this.tbox_MoneyAvailable);
            this.gbox_Summary.Controls.Add(this.lbl_MoneyOut);
            this.gbox_Summary.Controls.Add(this.tbox_MoneyOut);
            this.gbox_Summary.Controls.Add(this.lbl_MoneyIn);
            this.gbox_Summary.Controls.Add(this.tbox_MoneyIn);
            this.gbox_Summary.Controls.Add(this.lbl_NetMoney);
            this.gbox_Summary.Controls.Add(this.tbox_NetFlow);
            this.gbox_Summary.ForeColor = System.Drawing.Color.White;
            this.gbox_Summary.Location = new System.Drawing.Point(463, 196);
            this.gbox_Summary.Name = "gbox_Summary";
            this.gbox_Summary.Size = new System.Drawing.Size(465, 200);
            this.gbox_Summary.TabIndex = 20;
            this.gbox_Summary.TabStop = false;
            this.gbox_Summary.Text = "Summary";
            // 
            // lbl_MoneyAvailable
            // 
            this.lbl_MoneyAvailable.AutoSize = true;
            this.lbl_MoneyAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoneyAvailable.ForeColor = System.Drawing.Color.White;
            this.lbl_MoneyAvailable.Location = new System.Drawing.Point(6, 158);
            this.lbl_MoneyAvailable.Name = "lbl_MoneyAvailable";
            this.lbl_MoneyAvailable.Size = new System.Drawing.Size(160, 29);
            this.lbl_MoneyAvailable.TabIndex = 26;
            this.lbl_MoneyAvailable.Text = "Money Tree:";
            // 
            // tbox_MoneyAvailable
            // 
            this.tbox_MoneyAvailable.BackColor = System.Drawing.Color.White;
            this.tbox_MoneyAvailable.Location = new System.Drawing.Point(137, 159);
            this.tbox_MoneyAvailable.Multiline = true;
            this.tbox_MoneyAvailable.Name = "tbox_MoneyAvailable";
            this.tbox_MoneyAvailable.ReadOnly = true;
            this.tbox_MoneyAvailable.Size = new System.Drawing.Size(181, 28);
            this.tbox_MoneyAvailable.TabIndex = 11;
            // 
            // lbl_MoneyOut
            // 
            this.lbl_MoneyOut.AutoSize = true;
            this.lbl_MoneyOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoneyOut.ForeColor = System.Drawing.Color.White;
            this.lbl_MoneyOut.Location = new System.Drawing.Point(6, 67);
            this.lbl_MoneyOut.Name = "lbl_MoneyOut";
            this.lbl_MoneyOut.Size = new System.Drawing.Size(145, 29);
            this.lbl_MoneyOut.TabIndex = 24;
            this.lbl_MoneyOut.Text = "Money Out:";
            // 
            // tbox_MoneyOut
            // 
            this.tbox_MoneyOut.BackColor = System.Drawing.Color.White;
            this.tbox_MoneyOut.Location = new System.Drawing.Point(137, 68);
            this.tbox_MoneyOut.Multiline = true;
            this.tbox_MoneyOut.Name = "tbox_MoneyOut";
            this.tbox_MoneyOut.ReadOnly = true;
            this.tbox_MoneyOut.Size = new System.Drawing.Size(181, 28);
            this.tbox_MoneyOut.TabIndex = 9;
            // 
            // lbl_MoneyIn
            // 
            this.lbl_MoneyIn.AutoSize = true;
            this.lbl_MoneyIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoneyIn.ForeColor = System.Drawing.Color.White;
            this.lbl_MoneyIn.Location = new System.Drawing.Point(6, 24);
            this.lbl_MoneyIn.Name = "lbl_MoneyIn";
            this.lbl_MoneyIn.Size = new System.Drawing.Size(125, 29);
            this.lbl_MoneyIn.TabIndex = 22;
            this.lbl_MoneyIn.Text = "Money In:";
            // 
            // tbox_MoneyIn
            // 
            this.tbox_MoneyIn.BackColor = System.Drawing.Color.White;
            this.tbox_MoneyIn.Location = new System.Drawing.Point(137, 25);
            this.tbox_MoneyIn.Multiline = true;
            this.tbox_MoneyIn.Name = "tbox_MoneyIn";
            this.tbox_MoneyIn.ReadOnly = true;
            this.tbox_MoneyIn.Size = new System.Drawing.Size(181, 28);
            this.tbox_MoneyIn.TabIndex = 8;
            // 
            // lbl_NetMoney
            // 
            this.lbl_NetMoney.AutoSize = true;
            this.lbl_NetMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NetMoney.ForeColor = System.Drawing.Color.White;
            this.lbl_NetMoney.Location = new System.Drawing.Point(6, 112);
            this.lbl_NetMoney.Name = "lbl_NetMoney";
            this.lbl_NetMoney.Size = new System.Drawing.Size(125, 29);
            this.lbl_NetMoney.TabIndex = 20;
            this.lbl_NetMoney.Text = "Net Flow:";
            // 
            // tbox_NetFlow
            // 
            this.tbox_NetFlow.BackColor = System.Drawing.Color.White;
            this.tbox_NetFlow.Location = new System.Drawing.Point(137, 112);
            this.tbox_NetFlow.Multiline = true;
            this.tbox_NetFlow.Name = "tbox_NetFlow";
            this.tbox_NetFlow.ReadOnly = true;
            this.tbox_NetFlow.Size = new System.Drawing.Size(181, 28);
            this.tbox_NetFlow.TabIndex = 10;
            // 
            // pbox_MugPreview
            // 
            this.pbox_MugPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_MugPreview.BackColor = System.Drawing.Color.FloralWhite;
            this.pbox_MugPreview.Location = new System.Drawing.Point(658, 12);
            this.pbox_MugPreview.Name = "pbox_MugPreview";
            this.pbox_MugPreview.Size = new System.Drawing.Size(270, 165);
            this.pbox_MugPreview.TabIndex = 21;
            this.pbox_MugPreview.TabStop = false;
            this.pbox_MugPreview.Click += new System.EventHandler(this.pbox_MugPreview_Click);
            // 
            // btn_Trans
            // 
            this.btn_Trans.BackColor = System.Drawing.Color.Black;
            this.btn_Trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Trans.ForeColor = System.Drawing.Color.White;
            this.btn_Trans.Location = new System.Drawing.Point(463, 76);
            this.btn_Trans.Name = "btn_Trans";
            this.btn_Trans.Size = new System.Drawing.Size(189, 43);
            this.btn_Trans.TabIndex = 22;
            this.btn_Trans.Text = "Trans. Filter";
            this.btn_Trans.UseVisualStyleBackColor = false;
            this.btn_Trans.Click += new System.EventHandler(this.btn_Trans_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Gray;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(463, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(189, 43);
            this.btn_refresh.TabIndex = 23;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // BaseInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(940, 865);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_Trans);
            this.Controls.Add(this.pbox_MugPreview);
            this.Controls.Add(this.gbox_Summary);
            this.Controls.Add(this.btn_CreateNew);
            this.Controls.Add(this.tbox_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_TransType);
            this.Controls.Add(this.cmbbox_TransType);
            this.Controls.Add(this.cmbbox_Person);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_Note);
            this.Controls.Add(this.tbox_Amount);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_People);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.gridview_Transactions);
            this.Controls.Add(this.Btn_PeopleManager);
            this.Controls.Add(this.Btn_SaveTransaction);
            this.Controls.Add(this.cmbbox_Category);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseInterface";
            this.Text = "Money Trees";
            this.Load += new System.EventHandler(this.BaseInterface_Load);
            this.Shown += new System.EventHandler(this.BaseInterface_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_People)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Categories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_TransactionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_Transactions)).EndInit();
            this.gbox_Summary.ResumeLayout(false);
            this.gbox_Summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_MugPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource BindingSource_People;
        private System.Windows.Forms.BindingSource BindingSource_Transactions;
        private System.Windows.Forms.BindingSource BindingSource_Categories;
        private System.Windows.Forms.BindingSource BindingSource_TransactionType;
        private System.Windows.Forms.ComboBox cmbbox_Category;
        private System.Windows.Forms.Button Btn_SaveTransaction;
        private System.Windows.Forms.Button Btn_PeopleManager;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_People;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tbox_Amount;
        private System.Windows.Forms.TextBox tbox_Note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbox_Person;
        private System.Windows.Forms.ComboBox cmbbox_TransType;
        private System.Windows.Forms.Label lbl_TransType;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Button btn_CreateNew;
        public System.Windows.Forms.TextBox tbox_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfTransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gridview_Transactions;
        private System.Windows.Forms.GroupBox gbox_Summary;
        private System.Windows.Forms.Label lbl_MoneyAvailable;
        public System.Windows.Forms.TextBox tbox_MoneyAvailable;
        private System.Windows.Forms.Label lbl_MoneyOut;
        public System.Windows.Forms.TextBox tbox_MoneyOut;
        private System.Windows.Forms.Label lbl_MoneyIn;
        public System.Windows.Forms.TextBox tbox_MoneyIn;
        private System.Windows.Forms.Label lbl_NetMoney;
        public System.Windows.Forms.TextBox tbox_NetFlow;
        private System.Windows.Forms.PictureBox pbox_MugPreview;
        private System.Windows.Forms.Button btn_Trans;
        private System.Windows.Forms.Button btn_refresh;
    }
}

