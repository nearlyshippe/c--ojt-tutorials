namespace OJTtutorialwindowForm
{
    public partial class LoanWindowForm : Form
    {
        public LoanWindowForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtloanAmt.Text== "")
            {
                MessageBox.Show("Enter Vaild loan Amount!", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtloanAmt.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtInterestRate.Text == "")
            {
                MessageBox.Show("Enter Vaild Interest Rate (eg.10%)", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtInterestRate.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDuration.Text == "")
            {
                MessageBox.Show("Enter Loan Duration in months (eg. 4months = 4)", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtloanAmt.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int loanAmount = int.Parse(txtloanAmt.Text);
                int interestRate = int.Parse(txtInterestRate.Text);
                int loanDuration = int.Parse(txtDuration.Text);
                int interestAmount = loanAmount * (interestRate * loanDuration) / 100;
                int totalAmount = loanAmount + interestAmount;
                lblInterest.Text = interestAmount.ToString();
                lblTotal.Text = totalAmount.ToString();
            }
            
        }
    }
}
