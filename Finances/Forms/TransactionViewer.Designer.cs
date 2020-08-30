namespace Finances.Forms
{
    partial class TransactionViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionViewer));
            this.gridviewer_Transactions = new System.Windows.Forms.DataGridView();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peeopleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_CsvWrite = new System.Windows.Forms.Button();
            this.BindingSource_People = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbbox_filters = new System.Windows.Forms.ComboBox();
            this.cmbbox_TransType = new System.Windows.Forms.ComboBox();
            this.BindingSource_TransactionType = new System.Windows.Forms.BindingSource(this.components);
            this.cmbbox_Person = new System.Windows.Forms.ComboBox();
            this.cmbbox_Category = new System.Windows.Forms.ComboBox();
            this.BindingSource_Categories = new System.Windows.Forms.BindingSource(this.components);
            this.btn_GoFilter = new System.Windows.Forms.Button();
            this.gbox_Summary = new System.Windows.Forms.GroupBox();
            this.lbl_NumberOfTransactions = new System.Windows.Forms.Label();
            this.tbox_NumberOfTransactions = new System.Windows.Forms.TextBox();
            this.lbl_NetMoney = new System.Windows.Forms.Label();
            this.tbox_NetFlow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewer_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_People)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_TransactionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Categories)).BeginInit();
            this.gbox_Summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridviewer_Transactions
            // 
            this.gridviewer_Transactions.AllowUserToAddRows = false;
            this.gridviewer_Transactions.AllowUserToDeleteRows = false;
            this.gridviewer_Transactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewer_Transactions.AutoGenerateColumns = false;
            this.gridviewer_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewer_Transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.peeopleNameDataGridViewTextBoxColumn,
            this.categorynameDataGridViewTextBoxColumn,
            this.transactionTypeNameDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.dateOfTransactionDataGridViewTextBoxColumn});
            this.gridviewer_Transactions.DataSource = this.transactionBindingSource;
            this.gridviewer_Transactions.Location = new System.Drawing.Point(12, 254);
            this.gridviewer_Transactions.Name = "gridviewer_Transactions";
            this.gridviewer_Transactions.ReadOnly = true;
            this.gridviewer_Transactions.RowTemplate.Height = 28;
            this.gridviewer_Transactions.Size = new System.Drawing.Size(990, 438);
            this.gridviewer_Transactions.TabIndex = 0;
            this.gridviewer_Transactions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridviewer_Transactions_KeyDown);
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 120;
            // 
            // peeopleNameDataGridViewTextBoxColumn
            // 
            this.peeopleNameDataGridViewTextBoxColumn.DataPropertyName = "PeeopleName";
            this.peeopleNameDataGridViewTextBoxColumn.HeaderText = "Person";
            this.peeopleNameDataGridViewTextBoxColumn.Name = "peeopleNameDataGridViewTextBoxColumn";
            this.peeopleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.peeopleNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "Categoryname";
            this.categorynameDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            this.categorynameDataGridViewTextBoxColumn.ReadOnly = true;
            this.categorynameDataGridViewTextBoxColumn.Width = 160;
            // 
            // transactionTypeNameDataGridViewTextBoxColumn
            // 
            this.transactionTypeNameDataGridViewTextBoxColumn.DataPropertyName = "TransactionTypeName";
            this.transactionTypeNameDataGridViewTextBoxColumn.HeaderText = "Trans. Type";
            this.transactionTypeNameDataGridViewTextBoxColumn.Name = "transactionTypeNameDataGridViewTextBoxColumn";
            this.transactionTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionTypeNameDataGridViewTextBoxColumn.Width = 115;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 280;
            // 
            // dateOfTransactionDataGridViewTextBoxColumn
            // 
            this.dateOfTransactionDataGridViewTextBoxColumn.DataPropertyName = "DateOfTransaction";
            this.dateOfTransactionDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateOfTransactionDataGridViewTextBoxColumn.Name = "dateOfTransactionDataGridViewTextBoxColumn";
            this.dateOfTransactionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfTransactionDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(Finances.Transaction);
            // 
            // transactionBindingSource1
            // 
            this.transactionBindingSource1.DataSource = typeof(Finances.Transaction);
            // 
            // Btn_CsvWrite
            // 
            this.Btn_CsvWrite.BackColor = System.Drawing.Color.Black;
            this.Btn_CsvWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_CsvWrite.ForeColor = System.Drawing.Color.White;
            this.Btn_CsvWrite.Location = new System.Drawing.Point(795, 70);
            this.Btn_CsvWrite.Name = "Btn_CsvWrite";
            this.Btn_CsvWrite.Size = new System.Drawing.Size(198, 54);
            this.Btn_CsvWrite.TabIndex = 15;
            this.Btn_CsvWrite.Text = "Write to csv";
            this.Btn_CsvWrite.UseVisualStyleBackColor = false;
            this.Btn_CsvWrite.Click += new System.EventHandler(this.Btn_CsvWrite_Click);
            // 
            // BindingSource_People
            // 
            this.BindingSource_People.DataSource = typeof(Finances.People);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbbox_filters);
            this.groupBox1.Controls.Add(this.cmbbox_TransType);
            this.groupBox1.Controls.Add(this.cmbbox_Person);
            this.groupBox1.Controls.Add(this.cmbbox_Category);
            this.groupBox1.Controls.Add(this.btn_GoFilter);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 228);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // cmbbox_filters
            // 
            this.cmbbox_filters.FormattingEnabled = true;
            this.cmbbox_filters.Items.AddRange(new object[] {
            "Person",
            "Category",
            "Trans. Type",
            "Person-Category",
            "Category-Trans.Type"});
            this.cmbbox_filters.Location = new System.Drawing.Point(223, 44);
            this.cmbbox_filters.Name = "cmbbox_filters";
            this.cmbbox_filters.Size = new System.Drawing.Size(208, 28);
            this.cmbbox_filters.TabIndex = 21;
            // 
            // cmbbox_TransType
            // 
            this.cmbbox_TransType.BackColor = System.Drawing.Color.White;
            this.cmbbox_TransType.DataSource = this.BindingSource_TransactionType;
            this.cmbbox_TransType.DisplayMember = "TransactionTypeName";
            this.cmbbox_TransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_TransType.FormattingEnabled = true;
            this.cmbbox_TransType.Location = new System.Drawing.Point(8, 134);
            this.cmbbox_TransType.Name = "cmbbox_TransType";
            this.cmbbox_TransType.Size = new System.Drawing.Size(190, 28);
            this.cmbbox_TransType.TabIndex = 20;
            // 
            // BindingSource_TransactionType
            // 
            this.BindingSource_TransactionType.DataSource = typeof(Finances.TransactionType);
            // 
            // cmbbox_Person
            // 
            this.cmbbox_Person.BackColor = System.Drawing.Color.White;
            this.cmbbox_Person.DataSource = this.BindingSource_People;
            this.cmbbox_Person.DisplayMember = "FirstName";
            this.cmbbox_Person.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_Person.FormattingEnabled = true;
            this.cmbbox_Person.Location = new System.Drawing.Point(8, 87);
            this.cmbbox_Person.Name = "cmbbox_Person";
            this.cmbbox_Person.Size = new System.Drawing.Size(190, 28);
            this.cmbbox_Person.TabIndex = 19;
            // 
            // cmbbox_Category
            // 
            this.cmbbox_Category.BackColor = System.Drawing.Color.White;
            this.cmbbox_Category.DataSource = this.BindingSource_Categories;
            this.cmbbox_Category.DisplayMember = "Name";
            this.cmbbox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_Category.FormattingEnabled = true;
            this.cmbbox_Category.Location = new System.Drawing.Point(8, 44);
            this.cmbbox_Category.Name = "cmbbox_Category";
            this.cmbbox_Category.Size = new System.Drawing.Size(190, 28);
            this.cmbbox_Category.TabIndex = 18;
            // 
            // BindingSource_Categories
            // 
            this.BindingSource_Categories.DataSource = typeof(Finances.Category);
            // 
            // btn_GoFilter
            // 
            this.btn_GoFilter.BackColor = System.Drawing.Color.Black;
            this.btn_GoFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_GoFilter.ForeColor = System.Drawing.Color.White;
            this.btn_GoFilter.Location = new System.Drawing.Point(302, 78);
            this.btn_GoFilter.Name = "btn_GoFilter";
            this.btn_GoFilter.Size = new System.Drawing.Size(135, 42);
            this.btn_GoFilter.TabIndex = 17;
            this.btn_GoFilter.Text = "Go";
            this.btn_GoFilter.UseVisualStyleBackColor = false;
            this.btn_GoFilter.Click += new System.EventHandler(this.btn_GoFilter_Click);
            // 
            // gbox_Summary
            // 
            this.gbox_Summary.Controls.Add(this.lbl_NumberOfTransactions);
            this.gbox_Summary.Controls.Add(this.tbox_NumberOfTransactions);
            this.gbox_Summary.Controls.Add(this.lbl_NetMoney);
            this.gbox_Summary.Controls.Add(this.tbox_NetFlow);
            this.gbox_Summary.ForeColor = System.Drawing.Color.White;
            this.gbox_Summary.Location = new System.Drawing.Point(542, 122);
            this.gbox_Summary.Name = "gbox_Summary";
            this.gbox_Summary.Size = new System.Drawing.Size(451, 115);
            this.gbox_Summary.TabIndex = 21;
            this.gbox_Summary.TabStop = false;
            this.gbox_Summary.Text = "Summary";
            // 
            // lbl_NumberOfTransactions
            // 
            this.lbl_NumberOfTransactions.AutoSize = true;
            this.lbl_NumberOfTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberOfTransactions.ForeColor = System.Drawing.Color.White;
            this.lbl_NumberOfTransactions.Location = new System.Drawing.Point(13, 75);
            this.lbl_NumberOfTransactions.Name = "lbl_NumberOfTransactions";
            this.lbl_NumberOfTransactions.Size = new System.Drawing.Size(220, 29);
            this.lbl_NumberOfTransactions.TabIndex = 26;
            this.lbl_NumberOfTransactions.Text = "# of Transactions:";
            // 
            // tbox_NumberOfTransactions
            // 
            this.tbox_NumberOfTransactions.BackColor = System.Drawing.Color.White;
            this.tbox_NumberOfTransactions.Location = new System.Drawing.Point(241, 76);
            this.tbox_NumberOfTransactions.Multiline = true;
            this.tbox_NumberOfTransactions.Name = "tbox_NumberOfTransactions";
            this.tbox_NumberOfTransactions.ReadOnly = true;
            this.tbox_NumberOfTransactions.Size = new System.Drawing.Size(181, 28);
            this.tbox_NumberOfTransactions.TabIndex = 11;
            // 
            // lbl_NetMoney
            // 
            this.lbl_NetMoney.AutoSize = true;
            this.lbl_NetMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NetMoney.ForeColor = System.Drawing.Color.White;
            this.lbl_NetMoney.Location = new System.Drawing.Point(13, 29);
            this.lbl_NetMoney.Name = "lbl_NetMoney";
            this.lbl_NetMoney.Size = new System.Drawing.Size(125, 29);
            this.lbl_NetMoney.TabIndex = 20;
            this.lbl_NetMoney.Text = "Net Flow:";
            // 
            // tbox_NetFlow
            // 
            this.tbox_NetFlow.BackColor = System.Drawing.Color.White;
            this.tbox_NetFlow.Location = new System.Drawing.Point(144, 29);
            this.tbox_NetFlow.Multiline = true;
            this.tbox_NetFlow.Name = "tbox_NetFlow";
            this.tbox_NetFlow.ReadOnly = true;
            this.tbox_NetFlow.Size = new System.Drawing.Size(181, 28);
            this.tbox_NetFlow.TabIndex = 10;
            // 
            // TransactionViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1014, 700);
            this.Controls.Add(this.gbox_Summary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_CsvWrite);
            this.Controls.Add(this.gridviewer_Transactions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransactionViewer";
            this.Text = "Filtered H2O";
            this.Load += new System.EventHandler(this.TransactionViewer_Load);
            this.Shown += new System.EventHandler(this.TransactionViewer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewer_Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_People)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_TransactionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Categories)).EndInit();
            this.gbox_Summary.ResumeLayout(false);
            this.gbox_Summary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewer_Transactions;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.BindingSource transactionBindingSource1;
        private System.Windows.Forms.Button Btn_CsvWrite;
        private System.Windows.Forms.BindingSource BindingSource_People;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GoFilter;
        private System.Windows.Forms.ComboBox cmbbox_TransType;
        private System.Windows.Forms.ComboBox cmbbox_Person;
        private System.Windows.Forms.ComboBox cmbbox_Category;
        private System.Windows.Forms.ComboBox cmbbox_filters;
        private System.Windows.Forms.BindingSource BindingSource_TransactionType;
        private System.Windows.Forms.BindingSource BindingSource_Categories;
        private System.Windows.Forms.GroupBox gbox_Summary;
        private System.Windows.Forms.Label lbl_NumberOfTransactions;
        public System.Windows.Forms.TextBox tbox_NumberOfTransactions;
        private System.Windows.Forms.Label lbl_NetMoney;
        public System.Windows.Forms.TextBox tbox_NetFlow;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peeopleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfTransactionDataGridViewTextBoxColumn;
    }
}