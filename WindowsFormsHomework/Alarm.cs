using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class Alarm : MyForm
    {
        private int hour;
        private int minute;
        private int second;

        private double flash;
        public Alarm()
        {
            InitializeComponent();
        }

        private void setCheckBox_Click(object sender, EventArgs e)
        {
            if (setCheckBox.Checked)
            {
                int.TryParse(hourTextBox.Text, out hour);
                int.TryParse(minuteTextBox.Text, out minute);
                int.TryParse(secondTextBox.Text, out second);
                flash = 20;
            }

            else this.BackColor = DefaultBackColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeNow.Text = DateTime.Now.ToString("HH:mm:ss");

            if (hour == DateTime.Now.Hour)
            {
                if (minute == DateTime.Now.Minute)
                {
                    if (second == DateTime.Now.Second)
                    {
                        this.BackColor = Color.Red;
                    }
                }
            }
        }

        private void colortimer_Tick(object sender, EventArgs e)
        {

            if (flash > 0 && this.BackColor == Color.Red)
            {
                this.BackColor = Color.Black;
                flash--;
            }

            else if (flash > 0 && this.BackColor == Color.Black)
            {
                this.BackColor = Color.Red;
                flash--;
            }
        }
    }
}

