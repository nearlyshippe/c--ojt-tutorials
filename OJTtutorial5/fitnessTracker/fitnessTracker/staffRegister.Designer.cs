namespace fitnessTracker
{
    partial class txt
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
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbluserPwd = new System.Windows.Forms.Label();
            this.lblphoneNo1 = new System.Windows.Forms.Label();
            this.lblStaffNo = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lbluserName = new System.Windows.Forms.Label();
            this.lblStaffType = new System.Windows.Forms.Label();
            this.txtstaffNo = new System.Windows.Forms.TextBox();
            this.txtphoneNo1 = new System.Windows.Forms.TextBox();
            this.txtstaffName = new System.Windows.Forms.TextBox();
            this.dpJoin = new System.Windows.Forms.DateTimePicker();
            this.dpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbstaffType = new System.Windows.Forms.ComboBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.lblPhoneNo2 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtphoneNo2 = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.pbStaff = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.txtNRC = new System.Windows.Forms.TextBox();
            this.lblNRC = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblSID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.staffInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCfPassword = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtCFPwd = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.staffData1 = new fitnessTracker.staffData();
            this.staffInfoTableAdapter = new fitnessTracker.staffDataTableAdapters.staffInfoTableAdapter();
            this.staffInfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.Location = new System.Drawing.Point(256, 571);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(107, 35);
            this.btnAddUpdate.TabIndex = 17;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(501, 569);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 38);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbluserPwd
            // 
            this.lbluserPwd.AutoSize = true;
            this.lbluserPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserPwd.Location = new System.Drawing.Point(12, 267);
            this.lbluserPwd.Name = "lbluserPwd";
            this.lbluserPwd.Size = new System.Drawing.Size(121, 29);
            this.lbluserPwd.TabIndex = 25;
            this.lbluserPwd.Text = "Join From";
            // 
            // lblphoneNo1
            // 
            this.lblphoneNo1.AutoSize = true;
            this.lblphoneNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoneNo1.Location = new System.Drawing.Point(514, 138);
            this.lblphoneNo1.Name = "lblphoneNo1";
            this.lblphoneNo1.Size = new System.Drawing.Size(121, 29);
            this.lblphoneNo1.TabIndex = 24;
            this.lblphoneNo1.Text = "Phone No";
            // 
            // lblStaffNo
            // 
            this.lblStaffNo.AutoSize = true;
            this.lblStaffNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffNo.Location = new System.Drawing.Point(12, 129);
            this.lblStaffNo.Name = "lblStaffNo";
            this.lblStaffNo.Size = new System.Drawing.Size(92, 29);
            this.lblStaffNo.TabIndex = 20;
            this.lblStaffNo.Text = "StaffNo";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(12, 172);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(125, 29);
            this.lblStaffName.TabIndex = 21;
            this.lblStaffName.Text = "StaffName";
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserName.Location = new System.Drawing.Point(12, 217);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(149, 29);
            this.lbluserName.TabIndex = 22;
            this.lbluserName.Text = "Date Of Birth";
            // 
            // lblStaffType
            // 
            this.lblStaffType.AutoSize = true;
            this.lblStaffType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffType.Location = new System.Drawing.Point(12, 321);
            this.lblStaffType.Name = "lblStaffType";
            this.lblStaffType.Size = new System.Drawing.Size(121, 29);
            this.lblStaffType.TabIndex = 23;
            this.lblStaffType.Text = "Staff Type";
            // 
            // txtstaffNo
            // 
            this.txtstaffNo.Location = new System.Drawing.Point(256, 136);
            this.txtstaffNo.Name = "txtstaffNo";
            this.txtstaffNo.Size = new System.Drawing.Size(157, 22);
            this.txtstaffNo.TabIndex = 28;
            // 
            // txtphoneNo1
            // 
            this.txtphoneNo1.Location = new System.Drawing.Point(758, 145);
            this.txtphoneNo1.Name = "txtphoneNo1";
            this.txtphoneNo1.Size = new System.Drawing.Size(169, 22);
            this.txtphoneNo1.TabIndex = 26;
            // 
            // txtstaffName
            // 
            this.txtstaffName.Location = new System.Drawing.Point(256, 179);
            this.txtstaffName.Name = "txtstaffName";
            this.txtstaffName.Size = new System.Drawing.Size(157, 22);
            this.txtstaffName.TabIndex = 27;
            // 
            // dpJoin
            // 
            this.dpJoin.CustomFormat = "";
            this.dpJoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpJoin.Location = new System.Drawing.Point(256, 281);
            this.dpJoin.Name = "dpJoin";
            this.dpJoin.Size = new System.Drawing.Size(157, 22);
            this.dpJoin.TabIndex = 30;
            // 
            // dpDOB
            // 
            this.dpDOB.CustomFormat = "";
            this.dpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDOB.Location = new System.Drawing.Point(256, 231);
            this.dpDOB.Name = "dpDOB";
            this.dpDOB.Size = new System.Drawing.Size(157, 22);
            this.dpDOB.TabIndex = 29;
            // 
            // cbstaffType
            // 
            this.cbstaffType.FormattingEnabled = true;
            this.cbstaffType.Items.AddRange(new object[] {
            "Full-Time",
            "Part-Time"});
            this.cbstaffType.Location = new System.Drawing.Point(256, 328);
            this.cbstaffType.Name = "cbstaffType";
            this.cbstaffType.Size = new System.Drawing.Size(157, 24);
            this.cbstaffType.TabIndex = 31;
            this.cbstaffType.SelectedIndexChanged += new System.EventHandler(this.cbstaffType_SelectedIndexChanged);
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(17, 636);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(1052, 232);
            this.dgvStaff.TabIndex = 32;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // lblPhoneNo2
            // 
            this.lblPhoneNo2.AutoSize = true;
            this.lblPhoneNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo2.Location = new System.Drawing.Point(514, 190);
            this.lblPhoneNo2.Name = "lblPhoneNo2";
            this.lblPhoneNo2.Size = new System.Drawing.Size(121, 29);
            this.lblPhoneNo2.TabIndex = 33;
            this.lblPhoneNo2.Text = "Phone No";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(514, 88);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(94, 29);
            this.lblGender.TabIndex = 34;
            this.lblGender.Text = "Gender";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(514, 240);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(80, 29);
            this.lblImage.TabIndex = 35;
            this.lblImage.Text = "Image";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(514, 390);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(102, 29);
            this.lblAddress.TabIndex = 36;
            this.lblAddress.Text = "Address";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(842, 95);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 24);
            this.rbFemale.TabIndex = 37;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(758, 95);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 24);
            this.rbMale.TabIndex = 38;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // txtphoneNo2
            // 
            this.txtphoneNo2.Location = new System.Drawing.Point(758, 197);
            this.txtphoneNo2.Name = "txtphoneNo2";
            this.txtphoneNo2.Size = new System.Drawing.Size(169, 22);
            this.txtphoneNo2.TabIndex = 39;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(758, 397);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(157, 96);
            this.txtAddress.TabIndex = 40;
            this.txtAddress.Text = "";
            // 
            // pbStaff
            // 
            this.pbStaff.Location = new System.Drawing.Point(758, 240);
            this.pbStaff.Name = "pbStaff";
            this.pbStaff.Size = new System.Drawing.Size(113, 85);
            this.pbStaff.TabIndex = 41;
            this.pbStaff.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(758, 331);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(113, 38);
            this.btnChoose.TabIndex = 42;
            this.btnChoose.Text = "Choose Image";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // txtNRC
            // 
            this.txtNRC.Location = new System.Drawing.Point(256, 388);
            this.txtNRC.Name = "txtNRC";
            this.txtNRC.Size = new System.Drawing.Size(157, 22);
            this.txtNRC.TabIndex = 44;
            // 
            // lblNRC
            // 
            this.lblNRC.AutoSize = true;
            this.lblNRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRC.Location = new System.Drawing.Point(12, 381);
            this.lblNRC.Name = "lblNRC";
            this.lblNRC.Size = new System.Drawing.Size(65, 29);
            this.lblNRC.TabIndex = 45;
            this.lblNRC.Text = "NRC";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(256, 88);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(157, 22);
            this.txtID.TabIndex = 46;
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSID.Location = new System.Drawing.Point(12, 88);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(36, 29);
            this.lblSID.TabIndex = 47;
            this.lblSID.Text = "ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(758, 571);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 35);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 28);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registerToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 436);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 50;
            this.lblPassword.Text = "Password";
            // 
            // lblCfPassword
            // 
            this.lblCfPassword.AutoSize = true;
            this.lblCfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfPassword.Location = new System.Drawing.Point(12, 488);
            this.lblCfPassword.Name = "lblCfPassword";
            this.lblCfPassword.Size = new System.Drawing.Size(210, 29);
            this.lblCfPassword.TabIndex = 51;
            this.lblCfPassword.Text = "Confirm Password";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(256, 436);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(157, 22);
            this.txtPwd.TabIndex = 52;
            // 
            // txtCFPwd
            // 
            this.txtCFPwd.Location = new System.Drawing.Point(256, 488);
            this.txtCFPwd.Name = "txtCFPwd";
            this.txtCFPwd.PasswordChar = '*';
            this.txtCFPwd.Size = new System.Drawing.Size(157, 22);
            this.txtCFPwd.TabIndex = 53;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(419, 433);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(64, 29);
            this.btnShow.TabIndex = 54;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // staffData1
            // 
            this.staffData1.DataSetName = "staffData";
            this.staffData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffInfoTableAdapter
            // 
            this.staffInfoTableAdapter.ClearBeforeFill = true;
            // 
            // staffInfoBindingSource3
            // 
            this.staffInfoBindingSource3.DataMember = "staffInfo";
            this.staffInfoBindingSource3.DataSource = this.staffData1;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(402, 888);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 55;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(614, 888);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 56;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(310, 888);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 57;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(705, 888);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 58;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 934);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtCFPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblCfPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblNRC);
            this.Controls.Add(this.txtNRC);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pbStaff);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtphoneNo2);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPhoneNo2);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.cbstaffType);
            this.Controls.Add(this.txtstaffNo);
            this.Controls.Add(this.txtphoneNo1);
            this.Controls.Add(this.txtstaffName);
            this.Controls.Add(this.dpJoin);
            this.Controls.Add(this.dpDOB);
            this.Controls.Add(this.lbluserPwd);
            this.Controls.Add(this.lblphoneNo1);
            this.Controls.Add(this.lblStaffNo);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lbluserName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblStaffType);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "txt";
            this.Text = "adminRegister";
            this.Load += new System.EventHandler(this.adminRegister_Load);
            this.Click += new System.EventHandler(this.staffRegister_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbluserPwd;
        private System.Windows.Forms.Label lblphoneNo1;
        private System.Windows.Forms.Label lblStaffNo;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.Label lblStaffType;
        private System.Windows.Forms.TextBox txtstaffNo;
        private System.Windows.Forms.TextBox txtphoneNo1;
        private System.Windows.Forms.TextBox txtstaffName;
        private System.Windows.Forms.DateTimePicker dpJoin;
        private System.Windows.Forms.DateTimePicker dpDOB;
        private System.Windows.Forms.ComboBox cbstaffType;
        private System.Windows.Forms.DataGridView dgvStaff;
        private staffData staffData1;
        private System.Windows.Forms.BindingSource staffInfoBindingSource;
        private staffDataTableAdapters.staffInfoTableAdapter staffInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPhoneNo2;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtphoneNo2;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.PictureBox pbStaff;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtNRC;
        private System.Windows.Forms.Label lblNRC;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.BindingSource staffInfoBindingSource2;
        private System.Windows.Forms.BindingSource staffInfoBindingSource1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource staffInfoBindingSource3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCfPassword;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtCFPwd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
    }
}