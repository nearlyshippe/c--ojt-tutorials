namespace fitnessTracker
{
    partial class staffInfomation
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.pbStaff = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 149);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(132, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(335, 9);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(0, 32);
            this.lblNo.TabIndex = 1;
            // 
            // pbStaff
            // 
            this.pbStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbStaff.Location = new System.Drawing.Point(18, 12);
            this.pbStaff.Name = "pbStaff";
            this.pbStaff.Size = new System.Drawing.Size(135, 125);
            this.pbStaff.TabIndex = 2;
            this.pbStaff.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(431, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 32);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // staffInfomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 467);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pbStaff);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblWelcome);
            this.Name = "staffInfomation";
            this.Text = "staffInfomation";
            this.Load += new System.EventHandler(this.staffInfomation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.PictureBox pbStaff;
        private System.Windows.Forms.Button btnLogout;
    }
}