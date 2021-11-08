using System;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class Loan : MyForm
    {
        private int loan;
        private int limit;
        private double interest;
        private int downpayment;

        private int monthlyPay;
        private int total;

        public Loan()
        {
            InitializeComponent();
        }


        private void monthlyPayButton_Click(object sender, EventArgs e)
        {
            Keep();
            Compute();

            MessageBox.Show(monthlyPay.ToString() + "元");

        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            Keep();
            Compute();

            MessageBox.Show(total.ToString() + "元");
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Keep();
            Compute();

            LoanReport windowsLoanReport = new LoanReport();
            windowsLoanReport.loanLabel.Text = loan.ToString();
            windowsLoanReport.limitLabel.Text = limit.ToString();
            windowsLoanReport.interestLabel.Text = interest.ToString();
            windowsLoanReport.downpaymentLabel.Text = downpayment.ToString();
            windowsLoanReport.monthlyPayLabel.Text = monthlyPay.ToString();
            windowsLoanReport.totalPayLabel.Text = total.ToString();
            windowsLoanReport.Show();
        }

        private void Keep()
        {
            Int32.TryParse(loanTextBox.Text, out loan);
            Int32.TryParse(limitTextBox.Text, out limit);
            double.TryParse(interestTextBox.Text, out interest);
            Int32.TryParse(downpaymentTextBox.Text, out downpayment);
        }

        private void Compute()
        {
            double a = Math.Pow((1 + interest / 100 / 12), (limit * 12));
            double b = Math.Pow((1 + interest / 100 / 12), (limit * 12));
            double monthlyPayFormula = ((a * (interest / 100 / 12)) / (b - 1));

            monthlyPay = (int)((loan - downpayment) * monthlyPayFormula);

            total = monthlyPay * (limit * 12);

        }
    }
}