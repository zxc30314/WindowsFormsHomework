﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsHomework.FieldDef;

namespace WindowsFormsHomework
{
    public partial class StudentsGrade : MyForm
    {
        public StudentsGrade()
        {
            InitializeComponent();
        }

        Person student;

        int number;
        double scoreall;
        string average;

        string highestscore, lowestscore;

        List<Dictionary<string, object>> list_data = new List<Dictionary<string, object>>();

        private void addButton_Click(object sender, EventArgs e)
        {
            student.name = nameTextBox.Text;
            bool chinesescoretrue = double.TryParse(chineseTextBox.Text, out student.chinesescore);
            bool englishscoretrue = double.TryParse(englishTextBox.Text, out student.englishscore);
            bool mathscoretrue = double.TryParse(mathTextBox.Text, out student.mathscore);

            if (chinesescoretrue && englishscoretrue && mathscoretrue && student.name != null)
            {
                countButton.Enabled = true;
                Compute();
                Adddata();
            }
            else MessageBox.Show("請輸入完整資訊", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void randomAddbutton_Click(object sender, EventArgs e)
        {
            randomAdd();
        }

        private void randomAdd()
        {
            countButton.Enabled = true;

            Random crandom = new Random(Guid.NewGuid().GetHashCode());

            number++;
            student.name = number.ToString();
            student.chinesescore = crandom.Next(0, 100);
            student.englishscore = crandom.Next(0, 100);
            student.mathscore = crandom.Next(0, 100);

            Compute();
            Adddata();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            randomAddbutton.Enabled = false;
            countButton.Enabled = false;
            randomAdd20Button.Enabled = false;

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

        private void resetButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            randomAddbutton.Enabled = true;
            randomAdd20Button.Enabled = true;
            countButton.Enabled = false;
            number = 0;
            list_data.Clear();
            scoreLabel.Text = null;
            eachscoreallLabel.Text = "總分";
            eachaverageLabel.Text = "平均";
            eachhightestLabel.Text = "最高分";
            eachlowestLabel.Text = "最低分";
        }

        private void Adddata()
        {
            FixWidthColTextHelper score =
                new FixWidthColTextHelper(Encoding.GetEncoding(950),//樣式
                new FieldDef("姓名", 16), new FieldDef("國文", 3, true),
                new FieldDef("英文", 7, true), new FieldDef("數學", 6, true),
                new FieldDef("總分", 7, true), new FieldDef("平均", 7, true),
                new FieldDef("最低", 8, true), new FieldDef("最高", 8, true));

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
                scoreLabel.Text += test + "\n";
                list_data.Add(data);
            }
        }

        private void randomAdd20Button_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                randomAdd();
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

    public struct Person
    {
        public string name;
        public double chinesescore;
        public double englishscore;
        public double mathscore;
    }

    public class FieldDef
    {
        /// <summary>
        /// 欄位名稱
        /// </summary>
        public string FieldName;
        /// <summary>
        /// 起啟位置
        /// </summary>
        public int StartPos = -1;
        /// <summary>
        /// 欄位長度
        /// </summary>
        public int Length;
        /// <summary>
        /// 填補字元(一般為空白或0)
        /// </summary>
        public char PaddingChar = ' ';
        /// <summary>
        /// 是否向右靠齊向左填補
        /// </summary>
        public bool IsRightAlign = false;

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="fldName">欄位名稱</param>
        /// <param name="len">欄位長度</param>
        /// <param name="paddingChar">長度不足填補字元，預設為空白</param>
        /// <param name="rightAlign">是否靠右對齊，預設為否</param>
        public FieldDef(string fldName, int len,
            bool rightAlign = false)
        {
            FieldName = fldName;
            Length = len;
            IsRightAlign = rightAlign;
        }


        public class FixWidthColTextHelper
        {
            List<FieldDef> fields = new List<FieldDef>();
            Encoding encoding;
            int lineLength = 0;
            public bool error;
            /// <summary>
            /// 建構式，傳入文件定義
            /// </summary>
            /// <param name="enc">文字編碼</param>
            /// <param name="def">欄位定義</param>
            public FixWidthColTextHelper(
                Encoding enc,
                params FieldDef[] def)
            {
                encoding = enc;
                int startPos = 0;
                foreach (FieldDef fd in def)
                {
                    fd.StartPos = startPos;
                    fields.Add(fd);
                    startPos += fd.Length; //???
                    lineLength += fd.Length;
                }
            }

            /// <summary>
            /// 傳入資料欄位，依欄位定義匯出成為字串
            /// </summary>
            /// <param name="data">以雜湊方式保存的欄位值</param>
            /// <returns>固定欄寬之資料字串</returns>
            public string DumpData(Dictionary<string, object> data)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var fd in fields)
                {
                    string val = data.ContainsKey(fd.FieldName) ? Convert.ToString(data[fd.FieldName]) : "";
                    //計算資料長度
                    byte[] buff = encoding.GetBytes(val);
                    int len = buff.Length;
                    //超過長度且不允許自動截斷時，丟出例外
                    if (len > fd.Length)
                    {
                        error = true;
                        MessageBox.Show($"欄位[{fd.FieldName}]內容過長!(長度={len} 限制={fd.Length})");
                    }
                    //決定左補或是右補
                    else if (len < fd.Length)
                    {
                        //因需配合Encoding算長度，不能直接用PaddingLeft()
                        string padding = new string(fd.PaddingChar, fd.Length - len);

                        if (fd.IsRightAlign) //靠右對齊時補左邊
                            val = padding + padding + val;
                        else //靠左對齊時補右邊
                            val += padding + padding;
                    }
                    sb.Append(val);
                }
                return sb.ToString();
            }
        }
    }
}
