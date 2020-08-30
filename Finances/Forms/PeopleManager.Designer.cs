namespace Finances.Forms
{
    partial class PeopleManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleManager));
            this.gridview_People = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_MugShot = new System.Windows.Forms.Label();
            this.tbox_FirstName = new System.Windows.Forms.TextBox();
            this.tbox_LastName = new System.Windows.Forms.TextBox();
            this.Btn_ChoosePhoto = new System.Windows.Forms.Button();
            this.Dia_PhotoSelector = new System.Windows.Forms.OpenFileDialog();
            this.pbox_MugPreview = new System.Windows.Forms.PictureBox();
            this.Btn_NewPhoto = new System.Windows.Forms.Button();
            this.tbox_Email = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_CreateNew = new System.Windows.Forms.Button();
            this.tbox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.tbox_Id = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_People = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSource_Transactions = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_People)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_MugPreview)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_People)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview_People
            // 
            this.gridview_People.AllowUserToDeleteRows = false;
            this.gridview_People.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_People.AutoGenerateColumns = false;
            this.gridview_People.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_People.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.Email,
            this.dateCreatedDataGridViewTextBoxColumn});
            this.gridview_People.DataSource = this.bindingSource_People;
            this.gridview_People.Location = new System.Drawing.Point(21, 386);
            this.gridview_People.MultiSelect = false;
            this.gridview_People.Name = "gridview_People";
            this.gridview_People.RowTemplate.Height = 28;
            this.gridview_People.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_People.Size = new System.Drawing.Size(838, 400);
            this.gridview_People.TabIndex = 9;
            this.gridview_People.SelectionChanged += new System.EventHandler(this.gridview_People_SelectionChanged);
            this.gridview_People.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridview_People_KeyDown);
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.ForeColor = System.Drawing.Color.White;
            this.lbl_FirstName.Location = new System.Drawing.Point(16, 50);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(141, 29);
            this.lbl_FirstName.TabIndex = 1;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastName.ForeColor = System.Drawing.Color.White;
            this.lbl_LastName.Location = new System.Drawing.Point(16, 79);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(137, 29);
            this.lbl_LastName.TabIndex = 2;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.White;
            this.lbl_Email.Location = new System.Drawing.Point(16, 114);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(79, 29);
            this.lbl_Email.TabIndex = 3;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(16, 146);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(188, 29);
            this.lbl_PhoneNumber.TabIndex = 4;
            this.lbl_PhoneNumber.Text = "Phone Number";
            // 
            // lbl_MugShot
            // 
            this.lbl_MugShot.AutoSize = true;
            this.lbl_MugShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MugShot.ForeColor = System.Drawing.Color.White;
            this.lbl_MugShot.Location = new System.Drawing.Point(16, 175);
            this.lbl_MugShot.Name = "lbl_MugShot";
            this.lbl_MugShot.Size = new System.Drawing.Size(123, 29);
            this.lbl_MugShot.TabIndex = 5;
            this.lbl_MugShot.Text = "Mug Shot";
            // 
            // tbox_FirstName
            // 
            this.tbox_FirstName.Location = new System.Drawing.Point(209, 50);
            this.tbox_FirstName.Name = "tbox_FirstName";
            this.tbox_FirstName.Size = new System.Drawing.Size(134, 26);
            this.tbox_FirstName.TabIndex = 1;
            // 
            // tbox_LastName
            // 
            this.tbox_LastName.Location = new System.Drawing.Point(209, 82);
            this.tbox_LastName.Name = "tbox_LastName";
            this.tbox_LastName.Size = new System.Drawing.Size(134, 26);
            this.tbox_LastName.TabIndex = 2;
            // 
            // Btn_ChoosePhoto
            // 
            this.Btn_ChoosePhoto.BackColor = System.Drawing.Color.Black;
            this.Btn_ChoosePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChoosePhoto.ForeColor = System.Drawing.Color.White;
            this.Btn_ChoosePhoto.Location = new System.Drawing.Point(209, 178);
            this.Btn_ChoosePhoto.Name = "Btn_ChoosePhoto";
            this.Btn_ChoosePhoto.Size = new System.Drawing.Size(192, 43);
            this.Btn_ChoosePhoto.TabIndex = 5;
            this.Btn_ChoosePhoto.Text = "Choose Photo";
            this.Btn_ChoosePhoto.UseVisualStyleBackColor = false;
            this.Btn_ChoosePhoto.Click += new System.EventHandler(this.Btn_ChoosePhoto_Click);
            // 
            // Dia_PhotoSelector
            // 
            this.Dia_PhotoSelector.FileName = "openFileDialog1";
            this.Dia_PhotoSelector.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // pbox_MugPreview
            // 
            this.pbox_MugPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_MugPreview.BackColor = System.Drawing.Color.FloralWhite;
            this.pbox_MugPreview.Location = new System.Drawing.Point(547, 82);
            this.pbox_MugPreview.Name = "pbox_MugPreview";
            this.pbox_MugPreview.Size = new System.Drawing.Size(312, 164);
            this.pbox_MugPreview.TabIndex = 9;
            this.pbox_MugPreview.TabStop = false;
            // 
            // Btn_NewPhoto
            // 
            this.Btn_NewPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_NewPhoto.BackColor = System.Drawing.Color.Black;
            this.Btn_NewPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NewPhoto.ForeColor = System.Drawing.Color.White;
            this.Btn_NewPhoto.Location = new System.Drawing.Point(738, 29);
            this.Btn_NewPhoto.Name = "Btn_NewPhoto";
            this.Btn_NewPhoto.Size = new System.Drawing.Size(121, 42);
            this.Btn_NewPhoto.TabIndex = 6;
            this.Btn_NewPhoto.Text = "Clear";
            this.Btn_NewPhoto.UseVisualStyleBackColor = false;
            this.Btn_NewPhoto.Click += new System.EventHandler(this.Btn_NewPhoto_Click);
            // 
            // tbox_Email
            // 
            this.tbox_Email.Location = new System.Drawing.Point(209, 114);
            this.tbox_Email.Name = "tbox_Email";
            this.tbox_Email.Size = new System.Drawing.Size(314, 26);
            this.tbox_Email.TabIndex = 3;
            this.tbox_Email.Leave += new System.EventHandler(this.tbox_Email_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Btn_CreateNew);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Whatchu Wanna Do?";
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.Black;
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.Red;
            this.Btn_Save.Location = new System.Drawing.Point(327, 47);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(204, 49);
            this.Btn_Save.TabIndex = 8;
            this.Btn_Save.Text = "Save Edits";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_CreateNew
            // 
            this.Btn_CreateNew.BackColor = System.Drawing.Color.Black;
            this.Btn_CreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreateNew.ForeColor = System.Drawing.Color.White;
            this.Btn_CreateNew.Location = new System.Drawing.Point(9, 47);
            this.Btn_CreateNew.Name = "Btn_CreateNew";
            this.Btn_CreateNew.Size = new System.Drawing.Size(204, 49);
            this.Btn_CreateNew.TabIndex = 7;
            this.Btn_CreateNew.Text = "Create New";
            this.Btn_CreateNew.UseVisualStyleBackColor = false;
            this.Btn_CreateNew.Click += new System.EventHandler(this.Btn_CreateNew_Click);
            // 
            // tbox_PhoneNumber
            // 
            this.tbox_PhoneNumber.Location = new System.Drawing.Point(209, 146);
            this.tbox_PhoneNumber.Name = "tbox_PhoneNumber";
            this.tbox_PhoneNumber.Size = new System.Drawing.Size(239, 26);
            this.tbox_PhoneNumber.TabIndex = 4;
            // 
            // tbox_Id
            // 
            this.tbox_Id.Enabled = false;
            this.tbox_Id.Location = new System.Drawing.Point(209, 18);
            this.tbox_Id.Name = "tbox_Id";
            this.tbox_Id.Size = new System.Drawing.Size(134, 26);
            this.tbox_Id.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(16, 21);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(38, 29);
            this.lbl_ID.TabIndex = 14;
            this.lbl_ID.Text = "ID";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First ";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.dateCreatedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Addded";
            this.dateCreatedDataGridViewTextBoxColumn.MaxInputLength = 15;
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.Width = 200;
            // 
            // bindingSource_People
            // 
            this.bindingSource_People.DataSource = typeof(Finances.People);
            // 
            // BindingSource_Transactions
            // 
            this.BindingSource_Transactions.DataSource = typeof(Finances.Transaction);
            // 
            // PeopleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(871, 798);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.tbox_Id);
            this.Controls.Add(this.tbox_PhoneNumber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbox_Email);
            this.Controls.Add(this.Btn_NewPhoto);
            this.Controls.Add(this.pbox_MugPreview);
            this.Controls.Add(this.Btn_ChoosePhoto);
            this.Controls.Add(this.tbox_LastName);
            this.Controls.Add(this.tbox_FirstName);
            this.Controls.Add(this.lbl_MugShot);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.gridview_People);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeopleManager";
            this.Text = "Folks Manager";
            this.Load += new System.EventHandler(this.PeopleManager_Load);
            this.Shown += new System.EventHandler(this.PeopleManager_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_People)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_MugPreview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_People)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_Transactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridview_People;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Label lbl_MugShot;
        private System.Windows.Forms.TextBox tbox_FirstName;
        private System.Windows.Forms.TextBox tbox_LastName;
        private System.Windows.Forms.Button Btn_ChoosePhoto;
        private System.Windows.Forms.OpenFileDialog Dia_PhotoSelector;
        private System.Windows.Forms.PictureBox pbox_MugPreview;
        private System.Windows.Forms.Button Btn_NewPhoto;
        private System.Windows.Forms.TextBox tbox_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_CreateNew;
        private System.Windows.Forms.TextBox tbox_PhoneNumber;
        private System.Windows.Forms.BindingSource bindingSource_People;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbox_Id;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.BindingSource BindingSource_Transactions;
    }
}