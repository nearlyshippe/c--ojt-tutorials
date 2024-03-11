namespace OJTtutorialwindowForm
{
    partial class LoanWindowForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblInterest = new Label();
            lblTotal = new Label();
            txtDuration = new TextBox();
            txtInterestRate = new TextBox();
            txtloanAmt = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 47);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Loan Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 104);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Interest Rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 157);
            label3.Name = "label3";
            label3.Size = new Size(162, 20);
            label3.TabIndex = 2;
            label3.Text = "Loan Duration(Months)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 276);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 3;
            label4.Text = "Interest Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 345);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 4;
            label5.Text = "Total Amount";
            // 
            // lblInterest
            // 
            lblInterest.AutoSize = true;
            lblInterest.BackColor = SystemColors.Control;
            lblInterest.ForeColor = SystemColors.ActiveCaptionText;
            lblInterest.Location = new Point(546, 276);
            lblInterest.Name = "lblInterest";
            lblInterest.Size = new Size(0, 20);
            lblInterest.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = SystemColors.ActiveCaptionText;
            lblTotal.Location = new Point(546, 345);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 6;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(486, 157);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(125, 27);
            txtDuration.TabIndex = 7;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(486, 97);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(125, 27);
            txtInterestRate.TabIndex = 8;
            // 
            // txtloanAmt
            // 
            txtloanAmt.Location = new Point(486, 47);
            txtloanAmt.Name = "txtloanAmt";
            txtloanAmt.Size = new Size(125, 27);
            txtloanAmt.TabIndex = 9;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(376, 230);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(txtloanAmt);
            Controls.Add(txtInterestRate);
            Controls.Add(txtDuration);
            Controls.Add(lblTotal);
            Controls.Add(lblInterest);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblInterest;
        private Label lblTotal;
        private TextBox txtDuration;
        private TextBox txtInterestRate;
        private TextBox txtloanAmt;
        private Button btnCalculate;
    }
}
