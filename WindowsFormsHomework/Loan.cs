using System;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class Loan : Form, IPanel
    {
        public Loan()
        {
            InitializeComponent();
        }

        public void Open(Form mdiParent, Control parent, Action onOpen)
        {
            MdiParent = mdiParent; //設定窗體的父子關係
            Parent = parent; //設定子窗體的容器為父窗體中的Panel
            onOpen?.Invoke();
            Show();
        }

        private void monthlyPayButton_Click(object sender, EventArgs e)
        {
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
        }

        private void Keep()
        {
        }
    }
}