using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsHomework.FieldDef;

namespace WindowsFormsHomework
{
    public partial class StudentsGrade_List : MyForm
    {
        public StudentsGrade_List()
        {
            InitializeComponent();
        }

        Person1 student;

        double scoreall;
        string average;

        string highestscore, lowestscore;

        List<Dictionary<string, object>> list_data = new List<Dictionary<string, object>>();//放資料

        List<string> list_string = new List<string>();//放排版過的資料

        FixWidthColTextHelper score =
              new FixWidthColTextHelper(Encoding.GetEncoding(950),//樣式
              new FieldDef("姓名", 16), new FieldDef("國文", 3, true),
              new FieldDef("英文", 7, true), new FieldDef("數學", 6, true),
              new FieldDef("總分", 7, true), new FieldDef("平均", 7, true),
              new FieldDef("最低", 8, true), new FieldDef("最高", 8, true));

        private void addButton_Click(object sender, EventArgs e)
        {
            student.name = nameTextBox.Text;
            bool chinesescoretrue = double.TryParse(chineseTextBox.Text, out student.chinesescore);
            bool englishscoretrue = double.TryParse(englishTextBox.Text, out student.englishscore);
            bool mathscoretrue = double.TryParse(mathTextBox.Text, out student.mathscore);

            if (chinesescoretrue && englishscoretrue && mathscoretrue && student.name != null)
            {
                removeButton.Enabled = true;
                countButton.Enabled = true;
                Compute();
                AddData();
            }
            else MessageBox.Show("請輸入完整資訊", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            student.name = nameTextBox.Text;
            bool chinesescoretrue = double.TryParse(chineseTextBox.Text, out student.chinesescore);
            bool englishscoretrue = double.TryParse(englishTextBox.Text, out student.englishscore);
            bool mathscoretrue = double.TryParse(mathTextBox.Text, out student.mathscore);

            if (chinesescoretrue && englishscoretrue && mathscoretrue && student.name != null)
            {
                removeButton.Enabled = true;
                countButton.Enabled = true;
                Compute();
                InsertData();
            }
            else MessageBox.Show("請輸入完整資訊", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void countButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            insertButton.Enabled = false;
            removeButton.Enabled = false;
            countButton.Enabled = false;

            object chinesescore;
            object englishscore;
            object mathscore;

            double chinesescoreall = 0;
            double englishscoreall = 0;
            double mathscoreall = 0;

            double highestchinesescore = 0;
            double highestenglishscore = 0;
            double highestmathscore = 0;

            double lowestchinesescore = 100;
            double lowestenglishscore = 100;
            double lowestmathscore = 100;

            foreach (Dictionary<string, object> eachscore in list_data)
            {
                eachscore.TryGetValue("國文", out chinesescore);
                eachscore.TryGetValue("英文", out englishscore);
                eachscore.TryGetValue("數學", out mathscore);
                chinesescoreall += Convert.ToDouble(chinesescore);
                englishscoreall += Convert.ToDouble(englishscore);
                mathscoreall += Convert.ToDouble(mathscore);

                if (highestchinesescore < (double)chinesescore)
                {
                    highestchinesescore = (double)chinesescore;
                }

                if (highestenglishscore < (double)englishscore)
                {
                    highestenglishscore = (double)englishscore;
                }

                if (highestmathscore < (double)mathscore)
                {
                    highestmathscore = (double)mathscore;
                }

                if (lowestchinesescore > (double)chinesescore)
                {
                    lowestchinesescore = (double)chinesescore;
                }

                if (lowestenglishscore > (double)englishscore)
                {
                    lowestenglishscore = (double)englishscore;
                }

                if (lowestmathscore > (double)mathscore)
                {
                    lowestmathscore = (double)mathscore;
                }
            }

            double chineseaverage = Math.Round(chinesescoreall / list_data.Count, 1, MidpointRounding.AwayFromZero);
            double englishaverage = Math.Round(englishscoreall / list_data.Count, 1, MidpointRounding.AwayFromZero);
            double mathaverage = Math.Round(mathscoreall / list_data.Count, 1, MidpointRounding.AwayFromZero);

            eachscoreallLabel.Text += $"{chinesescoreall,26}{englishscoreall,11}{mathscoreall,9}";
            eachaverageLabel.Text += $"{chineseaverage.ToString("0.0"),27}{englishaverage.ToString("0.0"),12}{mathaverage.ToString("0.0"),10}";
            eachhightestLabel.Text += $"{highestchinesescore,24}{highestenglishscore,13}{highestmathscore,11}";
            eachlowestLabel.Text += $"{lowestchinesescore,24}{lowestenglishscore,13}{lowestmathscore,11}";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            list_data.RemoveAt(0);
            list_string.RemoveAt(0);

            scoreLabel.Text = null;

            foreach (string score_string in list_string)
            {
                scoreLabel.Text += score_string + "\n";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            insertButton.Enabled = true;
            removeButton.Enabled = false;
            list_data.Clear();
            list_string.Clear();
            scoreLabel.Text = null;
            eachscoreallLabel.Text = "總分";
            eachaverageLabel.Text = "平均";
            eachhightestLabel.Text = "最高分";
            eachlowestLabel.Text = "最低分";
        }

        private void searchchineseButton_Click(object sender, EventArgs e)
        {
            scoreLabel.Text = "";
            int max_chinese_range;
            int min_chinese_range;
            int.TryParse(maxChineseTextBox.Text, out max_chinese_range);
            int.TryParse(minChineseTextBox.Text, out min_chinese_range);

            List<string> list_chinese_range = new List<string>();

            foreach (Dictionary<string, object> eachdata in list_data)
            {
                eachdata.TryGetValue("國文", out object chinese_value);

                if (min_chinese_range <= Convert.ToDouble(chinese_value) && Convert.ToDouble(chinese_value) <= max_chinese_range)
                {
                    list_chinese_range.Add(score.DumpData(eachdata));
                }
            }

            foreach (string eachdata_string in list_chinese_range)
            {
                scoreLabel.Text += eachdata_string + "\n";
            }
        }

        private void AddData()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();

            data.Add("姓名", student.name);
            data.Add("國文", student.chinesescore);
            data.Add("英文", student.englishscore);
            data.Add("數學", student.mathscore);
            data.Add("總分", scoreall);
            data.Add("平均", average);
            data.Add("最低", lowestscore);
            data.Add("最高", highestscore);

            string test = score.DumpData(data);

            if (!score.error)
            {
                scoreLabel.Text = null;
                list_data.Add(data);
                list_string.Add(test);

                foreach (string score_string in list_string)
                {
                    scoreLabel.Text += score_string + "\n";
                }
            }
        }

        private void InsertData()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();

            data.Add("姓名", student.name);
            data.Add("國文", student.chinesescore);
            data.Add("英文", student.englishscore);
            data.Add("數學", student.mathscore);
            data.Add("總分", scoreall);
            data.Add("平均", average);
            data.Add("最低", lowestscore);
            data.Add("最高", highestscore);

            string test = score.DumpData(data);

            if (!score.error)
            {
                scoreLabel.Text = null;
                list_data.Insert(0, data);
                list_string.Insert(0, test);

                foreach (string score_string in list_string)
                {
                    scoreLabel.Text += score_string + "\n";
                }
            }
        }

        private void Compute()
        {
            scoreall = student.chinesescore + student.englishscore + student.mathscore;

            average = Math.Round(((student.chinesescore + student.englishscore + student.mathscore) / 3), 1, MidpointRounding.AwayFromZero).ToString("0.0");

            Dictionary<string, double> datascore = new Dictionary<string, double>();

            datascore.Add("國文", student.chinesescore);
            datascore.Add("英文", student.englishscore);
            datascore.Add("數學", student.mathscore);

            highestscore = datascore.FirstOrDefault(x => x.Value == datascore.Values.Max()).Key + datascore.FirstOrDefault(x => x.Value == datascore.Values.Max()).Value;
            lowestscore = datascore.FirstOrDefault(x => x.Value == datascore.Values.Min()).Key + datascore.FirstOrDefault(x => x.Value == datascore.Values.Min()).Value;
        }

    }

    public struct Person1
    {
        public string name;
        public double chinesescore;
        public double englishscore;
        public double mathscore;
    }
}

