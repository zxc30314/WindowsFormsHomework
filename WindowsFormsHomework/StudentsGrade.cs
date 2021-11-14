using System;
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

        List<Dictionary<string, object>> dict = new List<Dictionary<string, object>>();

        private void addButton_Click(object sender, EventArgs e)
        {
            student.name = nameTextBox.Text;
            int.TryParse(chineseTextBox.Text, out student.chinesescore);
            int.TryParse(englishTextBox.Text, out student.englishscore);
            int.TryParse(mathTextBox.Text, out student.mathscore);

            Add();
        }

        private void randomAddbutton_Click(object sender, EventArgs e)
        {
            Random crandom = new Random();

            number++;
            student.name = number.ToString();
            student.chinesescore = crandom.Next(0, 100);
            student.englishscore = crandom.Next(0, 100);
            student.mathscore = crandom.Next(0, 100);

            Add();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            object chinesescore;
            object englishscore;
            object mathscore;

            double chinesescoreall = 0;
            double englishscoreall = 0;
            double mathscoreall = 0;

            double chineseaverage;
            double englishaverage;
            double mathaverage;

            int highestchinesescore = 0;
            int highestenglishscore = 0;
            int highestmathaverage = 0;

            foreach (Dictionary<string, object> eachscore in dict)
            {
                eachscore.TryGetValue("國文", out chinesescore);
                eachscore.TryGetValue("英文", out englishscore);
                eachscore.TryGetValue("數學", out mathscore);
                chinesescoreall += Convert.ToDouble(chinesescore);
                englishscoreall += Convert.ToDouble(englishscore);
                mathscoreall += Convert.ToDouble(mathscore);
            }

            chineseaverage = Math.Round(chinesescoreall / dict.Count, 1, MidpointRounding.AwayFromZero);
            englishaverage = Math.Round(englishscoreall / dict.Count, 1, MidpointRounding.AwayFromZero);
            mathaverage = Math.Round(mathscoreall / dict.Count, 1, MidpointRounding.AwayFromZero);

            string maxkey = dict.FirstOrDefault(x => x.Values == dict.Values.Max()).Key;

            scoreall.Text += $"{chinesescoreall,29}{englishscoreall,13}{mathscoreall,13}";
            average.Text += $"{chineseaverage.ToString("0.0"),29}{englishaverage.ToString("0.0"),13}{mathaverage.ToString("0.0"),13}";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            dict.Clear();
            label11.Text = null;
            scoreall.Text = "總分";
            average.Text = "平均";
        }

        private void Add()
        {
            FixWidthColTextHelper score =
                new FixWidthColTextHelper(Encoding.GetEncoding(950),
                new FieldDef("姓名", 17), new FieldDef("國文", 3, true),
                new FieldDef("英文", 8, true), new FieldDef("數學", 8, true));

            Dictionary<string, object> data = new Dictionary<string, object>();

            data.Add("姓名", student.name);
            data.Add("國文", student.chinesescore);
            data.Add("英文", student.englishscore);
            data.Add("數學", student.mathscore);
            string test = score.DumpData(data);
            if (!score.error)
            {
                label11.Text += test + "\n";
            }

            dict.Add(data);
        }
    }

    public struct Person
    {
        public string name;
        public int chinesescore;
        public int englishscore;
        public int mathscore;
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
