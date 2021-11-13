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

        private bool loantrue;
        private bool limittrue;
        private bool interesttrue;

        public Loan()
        {
            InitializeComponent();
        }

        private void monthlyPayButton_Click(object sender, EventArgs e)
        {
            Keep();

            if (loantrue && limittrue && interesttrue)
            {
                Compute();

                MessageBox.Show(monthlyPay.ToString() + "元");
            }
            else MessageBox.Show("請輸入完整資訊");
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            Keep();

            if (loantrue && limittrue && interesttrue)
            {
                Compute();

                MessageBox.Show(total.ToString() + "元");
            }
            else MessageBox.Show("請輸入完整資訊");
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Keep();

            if (loantrue && limittrue && interesttrue)
            {
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
            else MessageBox.Show("請輸入完整資訊");
        }

        private void Keep()
        {
            loantrue = int.TryParse(loanTextBox.Text, out loan);
            limittrue = int.TryParse(limitTextBox.Text, out limit);
            interesttrue = double.TryParse(interestTextBox.Text, out interest);
            int.TryParse(downpaymentTextBox.Text, out downpayment);
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