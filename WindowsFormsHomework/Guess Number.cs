using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class Guess_Number : MyForm
    {
        Random randoanswer = new Random();

        private int answer;

        public int number
        {
            private set
            {
                answer = value;
            }

            get
            {
                return answer;
            }
        }
        public Guess_Number()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            number = randoanswer.Next(1, 101);

            InputNumber guessnumberbox = new InputNumber();
            guessnumberbox.Owner = this;
            guessnumberbox.ShowDialog();
        }

        private void showAnswerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Answer：{number}");
        }
    }
}
