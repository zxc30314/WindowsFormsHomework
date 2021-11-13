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
    public partial class StudentsGrade : MyForm
    {
        public StudentsGrade()
        {
            InitializeComponent();
        }

        Person student;

        private void loanButton_Click(object sender, EventArgs e)
        {
            keep();
            string fileName = student.name.PadRight(35);
            label11.Text += $"{fileName}{student.chinesescore}{student.englishscore,10}{student.mathscore,10}\n";
        }

        private void keep()
        {
            student.name = nameTextBox.Text;
            int.TryParse(chineseTextBox.Text, out student.chinesescore);
            int.TryParse(englishTextBox.Text, out student.englishscore);
            int.TryParse(mathTextBox.Text, out student.mathscore);
        }
    }

    public struct Person
    {
        public string name;
        public int chinesescore;
        public int englishscore;
        public int mathscore;
    }

}
