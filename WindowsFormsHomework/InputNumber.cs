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
    public partial class InputNumber : Form //guess number 表單輸入數字
    {

        private int iguessnumber;
        private int maxnumber = 100;
        private int minnumber = 1;

        public InputNumber()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int.TryParse(inputTextBox.Text, out iguessnumber);
            Guess_Number guess = (Guess_Number)this.Owner;

            if (iguessnumber != guess.number)
            {
                if (iguessnumber > guess.number)
                {
                    maxnumber = iguessnumber;
                    guess.guessnumberLabel.Text = $"too large\nbetween {minnumber} and {maxnumber}";
                }

                else
                {
                    minnumber = iguessnumber;
                    guess.guessnumberLabel.Text = $"too large\nbetween {minnumber} and {maxnumber}";
                }
            }

            else MessageBox.Show($"You got {guess.number}");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
