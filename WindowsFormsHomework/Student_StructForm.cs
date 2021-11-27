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
    public partial class Student_StructForm : MyForm
    {
        public Student_StructForm()
        {
            InitializeComponent();
        }

        Keep student;

        Dictionary<string, int> dict = new Dictionary<string, int>();

        private void keepButton_Click(object sender, EventArgs e)
        {
            dict.Clear();

            student.name = nameTextBox.Text;
            int.TryParse(chineseTextBox.Text, out student.chinesescore);
            int.TryParse(englishTextBox.Text, out student.englishscore);
            int.TryParse(mathTextBox.Text, out student.mathscore);

            dict.Add("國語", student.chinesescore);
            dict.Add("英文", student.englishscore);
            dict.Add("數學", student.mathscore);
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            nameLabel.Text = "姓名：" + student.name;
            chineseScoreLabel.Text = "國語：" + student.chinesescore + "分";
            englishScoreLabel.Text = "英文：" + student.englishscore + "分";
            mathScoreLabel.Text = "數學：" + student.mathscore + "分";
        }

        private void highestLowestButton_Click(object sender, EventArgs e)
        {
            try
            {
                int maxscore = 0;
                int maxvalue = 0;
                highestLabel.Text = "最高科目成績為：";

                string maxkey = dict.FirstOrDefault(x => x.Value == dict.Values.Max()).Key;
                dict.TryGetValue(maxkey, out maxscore);

                if (maxscore != 0)
                {
                    highestLabel.Text += maxkey;
                    dict.Remove(maxkey);
                    maxvalue = dict.FirstOrDefault(x => x.Value == dict.Values.Max()).Value;

                    while (maxvalue == maxscore)
                    {
                        maxkey = dict.FirstOrDefault(x => x.Value == dict.Values.Max()).Key;
                        highestLabel.Text += "," + maxkey;
                        dict.Remove(maxkey);
                        maxvalue = dict.FirstOrDefault(x => x.Value == dict.Values.Max()).Value;
                    }

                    highestLabel.Text += $"{"  "}{maxscore} 分";
                }

                int minscore;
                int minvalue;
                lowestLabel.Text = "最低科目成績為：";

                string minkey = dict.FirstOrDefault(x => x.Value == dict.Values.Min()).Key;
                dict.TryGetValue(minkey, out minscore);

                lowestLabel.Text += minkey;
                dict.Remove(minkey);
                minvalue = dict.FirstOrDefault(x => x.Value == dict.Values.Min()).Value;

                while (minvalue == minscore)
                {
                    minkey = dict.FirstOrDefault(x => x.Value == dict.Values.Min()).Key;
                    lowestLabel.Text += "," + minkey;
                    dict.Remove(minkey);
                    minvalue = dict.FirstOrDefault(x => x.Value == dict.Values.Min()).Value;
                }

                lowestLabel.Text += $"{"  "}{minscore} 分";
            }
            catch { }
        }
    }

    public struct Keep
    {
        public string name;
        public int chinesescore;
        public int englishscore;
        public int mathscore;
    }
}