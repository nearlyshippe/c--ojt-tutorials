namespace OJTtuutorial3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblstaffNo = new Label();
            lblName = new Label();
            lblImg = new Label();
            lblDOB = new Label();
            lbladdress = new Label();
            lblstaffType = new Label();
            lblJoin = new Label();
            lblGender = new Label();
            lblNRC = new Label();
            lblAge = new Label();
            lblph1 = new Label();
            lblph2 = new Label();
            txtStaffNo = new TextBox();
            txtStaffName = new TextBox();
            txtAge = new TextBox();
            txtNRC = new TextBox();
            txtPh1 = new TextBox();
            txtPh2 = new TextBox();
            txtAddress = new RichTextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            btnDelete = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            cbType = new ComboBox();
            pbStaff = new PictureBox();
            btnChoose = new Button();
            dgvStaff = new DataGridView();
            dpJoin = new DateTimePicker();
            dpDOB = new DateTimePicker();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)pbStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            SuspendLayout();
            // 
            // lblstaffNo
            // 
            lblstaffNo.AutoSize = true;
            lblstaffNo.Location = new Point(108, 76);
            lblstaffNo.Name = "lblstaffNo";
            lblstaffNo.Size = new Size(64, 20);
            lblstaffNo.TabIndex = 0;
            lblstaffNo.Text = "Staff No";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(108, 130);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Staff Name";
            // 
            // lblImg
            // 
            lblImg.AutoSize = true;
            lblImg.Location = new Point(553, 251);
            lblImg.Name = "lblImg";
            lblImg.Size = new Size(51, 20);
            lblImg.TabIndex = 3;
            lblImg.Text = "Image";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(108, 248);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(40, 20);
            lblDOB.TabIndex = 2;
            lblDOB.Text = "DOB";
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Location = new Point(553, 366);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(62, 20);
            lbladdress.TabIndex = 7;
            lbladdress.Text = "Address";
            // 
            // lblstaffType
            // 
            lblstaffType.AutoSize = true;
            lblstaffType.Location = new Point(108, 366);
            lblstaffType.Name = "lblstaffType";
            lblstaffType.Size = new Size(75, 20);
            lblstaffType.TabIndex = 6;
            lblstaffType.Text = "Staff Type";
            // 
            // lblJoin
            // 
            lblJoin.AutoSize = true;
            lblJoin.Location = new Point(108, 192);
            lblJoin.Name = "lblJoin";
            lblJoin.Size = new Size(73, 20);
            lblJoin.TabIndex = 5;
            lblJoin.Text = "Join From";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(553, 79);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender";
            // 
            // lblNRC
            // 
            lblNRC.AutoSize = true;
            lblNRC.Location = new Point(108, 432);
            lblNRC.Name = "lblNRC";
            lblNRC.Size = new Size(65, 20);
            lblNRC.TabIndex = 11;
            lblNRC.Text = "NRC No.";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(108, 306);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 20);
            lblAge.TabIndex = 10;
            lblAge.Text = "Age";
            // 
            // lblph1
            // 
            lblph1.AutoSize = true;
            lblph1.Location = new Point(553, 133);
            lblph1.Name = "lblph1";
            lblph1.Size = new Size(77, 20);
            lblph1.TabIndex = 9;
            lblph1.Text = "Phone No.";
            // 
            // lblph2
            // 
            lblph2.AutoSize = true;
            lblph2.Location = new Point(553, 195);
            lblph2.Name = "lblph2";
            lblph2.Size = new Size(77, 20);
            lblph2.TabIndex = 8;
            lblph2.Text = "Phone No.";
            // 
            // txtStaffNo
            // 
            txtStaffNo.Location = new Point(299, 76);
            txtStaffNo.Name = "txtStaffNo";
            txtStaffNo.Size = new Size(154, 27);
            txtStaffNo.TabIndex = 12;
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(299, 130);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(154, 27);
            txtStaffName.TabIndex = 13;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(299, 306);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(154, 27);
            txtAge.TabIndex = 16;
            // 
            // txtNRC
            // 
            txtNRC.Location = new Point(299, 425);
            txtNRC.Name = "txtNRC";
            txtNRC.Size = new Size(154, 27);
            txtNRC.TabIndex = 17;
            // 
            // txtPh1
            // 
            txtPh1.Location = new Point(724, 133);
            txtPh1.Name = "txtPh1";
            txtPh1.Size = new Size(154, 27);
            txtPh1.TabIndex = 18;
            // 
            // txtPh2
            // 
            txtPh2.Location = new Point(724, 195);
            txtPh2.Name = "txtPh2";
            txtPh2.Size = new Size(154, 27);
            txtPh2.TabIndex = 19;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(724, 366);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(241, 92);
            txtAddress.TabIndex = 20;
            txtAddress.Text = "";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(724, 80);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 21;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(887, 80);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 22;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(724, 524);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(510, 524);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(299, 524);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Full-Time", "Part-Time" });
            cbType.Location = new Point(302, 366);
            cbType.Name = "cbType";
            cbType.Size = new Size(151, 28);
            cbType.TabIndex = 26;
            // 
            // pbStaff
            // 
            pbStaff.BackgroundImageLayout = ImageLayout.Zoom;
            pbStaff.Location = new Point(724, 257);
            pbStaff.Name = "pbStaff";
            pbStaff.Size = new Size(94, 62);
            pbStaff.TabIndex = 27;
            pbStaff.TabStop = false;
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(715, 325);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(115, 29);
            btnChoose.TabIndex = 28;
            btnChoose.Text = "Choose Image";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(12, 663);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.Size = new Size(978, 188);
            dgvStaff.TabIndex = 29;
            dgvStaff.CellClick += dgvStaff_CellClick;
            // 
            // dpJoin
            // 
            dpJoin.CustomFormat = " ";
            dpJoin.Format = DateTimePickerFormat.Custom;
            dpJoin.Location = new Point(299, 185);
            dpJoin.Name = "dpJoin";
            dpJoin.Size = new Size(154, 27);
            dpJoin.TabIndex = 30;
            dpJoin.ValueChanged += dateTimePicker1_ValueChanged;
            dpJoin.KeyDown += dateTimePicker1_KeyDown;
            // 
            // dpDOB
            // 
            dpDOB.CustomFormat = " ";
            dpDOB.Format = DateTimePickerFormat.Custom;
            dpDOB.Location = new Point(299, 241);
            dpDOB.Name = "dpDOB";
            dpDOB.Size = new Size(154, 27);
            dpDOB.TabIndex = 31;
            dpDOB.Value = new DateTime(2024, 3, 12, 15, 18, 45, 0);
            dpDOB.ValueChanged += dateTimePicker2_ValueChanged;
            dpDOB.KeyDown += dateTimePicker2_KeyDown;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(299, 559);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 882);
            Controls.Add(btnUpdate);
            Controls.Add(dpDOB);
            Controls.Add(dpJoin);
            Controls.Add(dgvStaff);
            Controls.Add(btnChoose);
            Controls.Add(pbStaff);
            Controls.Add(cbType);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(txtAddress);
            Controls.Add(txtPh2);
            Controls.Add(txtPh1);
            Controls.Add(txtNRC);
            Controls.Add(txtAge);
            Controls.Add(txtStaffName);
            Controls.Add(txtStaffNo);
            Controls.Add(lblNRC);
            Controls.Add(lblAge);
            Controls.Add(lblph1);
            Controls.Add(lblph2);
            Controls.Add(lbladdress);
            Controls.Add(lblstaffType);
            Controls.Add(lblJoin);
            Controls.Add(lblGender);
            Controls.Add(lblImg);
            Controls.Add(lblDOB);
            Controls.Add(lblName);
            Controls.Add(lblstaffNo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblstaffNo;
        private Label lblName;
        private Label lblImg;
        private Label lblDOB;
        private Label lbladdress;
        private Label lblstaffType;
        private Label lblJoin;
        private Label lblGender;
        private Label lblNRC;
        private Label lblAge;
        private Label lblph1;
        private Label lblph2;
        private TextBox txtStaffNo;
        private TextBox txtStaffName;
        private TextBox txtAge;
        private TextBox txtNRC;
        private TextBox txtPh1;
        private TextBox txtPh2;
        private RichTextBox txtAddress;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Button btnDelete;
        private Button btnClear;
        private Button btnAdd;
        private ComboBox cbType;
        private PictureBox pbStaff;
        private Button btnChoose;
        private DataGridView dgvStaff;
        private DateTimePicker dpJoin;
        private DateTimePicker dpDOB;
        private Button btnUpdate;
    }
}
