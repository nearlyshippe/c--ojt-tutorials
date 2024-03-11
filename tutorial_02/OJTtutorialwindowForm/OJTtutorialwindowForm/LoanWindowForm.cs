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
            int loanAmount = int.Parse(txtloanAmt.Text);
            int interestRate= int.Parse(txtInterestRate.Text);
            int loanDuration= int.Parse(txtDuration.Text);
            int interestAmount = loanAmount * (interestRate * loanDuration) / 100;
            int totalAmount=loanAmount+interestAmount;
            lblInterest.Text = interestAmount.ToString();
            lblTotal.Text = totalAmount.ToString();
        }
    }
}
