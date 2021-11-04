using System;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class Hello : Form, IPanel
    {
        private string constellation;
        private string englishName;
        private readonly string line = ",\n";

        private string name;
        private string sexName;

        public Hello()
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

        private void SayHelloButton_Click(object sender, EventArgs e)
        {
            Keep();

            MessageBox.Show("Hello, 我是" + name + line + "英文名字是" + englishName + line + "性別是" + sexName + line + "星座是" + constellation + line +
                            "很高興認識你。");
        }

        private void SayHiButton_Click(object sender, EventArgs e)
        {
            Keep();

            MessageBox.Show("Hi, 我是" + name + line + "英文名字是" + englishName + line + "性別是" + sexName + line + "星座是" + constellation + line +
                            "很高興認識你。");
        }

        private void Keep()
        {
            name = nameTextBox.Text;
            englishName = englishNameTextBox.Text;
            sexName = sexTextBox.Text;
            constellation = constellationTextBox.Text;
        }
    }
}