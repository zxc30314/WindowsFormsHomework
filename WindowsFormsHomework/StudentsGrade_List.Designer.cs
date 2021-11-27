
namespace WindowsFormsHomework
{
    partial class StudentsGrade_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchchineseButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eachlowestLabel = new System.Windows.Forms.Label();
            this.eachhightestLabel = new System.Windows.Forms.Label();
            this.eachaverageLabel = new System.Windows.Forms.Label();
            this.eachscoreallLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mathTextBox = new System.Windows.Forms.TextBox();
            this.englishTextBox = new System.Windows.Forms.TextBox();
            this.chineseTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.minChineseTextBox = new System.Windows.Forms.TextBox();
            this.maxChineseTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchchineseButton
            // 
            this.searchchineseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchchineseButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchchineseButton.Location = new System.Drawing.Point(18, 405);
            this.searchchineseButton.Name = "searchchineseButton";
            this.searchchineseButton.Size = new System.Drawing.Size(212, 33);
            this.searchchineseButton.TabIndex = 50;
            this.searchchineseButton.Text = "SEARCH";
            this.searchchineseButton.UseVisualStyleBackColor = true;
            this.searchchineseButton.Click += new System.EventHandler(this.searchchineseButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resetButton.Location = new System.Drawing.Point(18, 285);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(212, 33);
            this.resetButton.TabIndex = 49;
            this.resetButton.Text = "清除所有資料";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Enabled = false;
            this.removeButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.removeButton.Location = new System.Drawing.Point(18, 246);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(212, 33);
            this.removeButton.TabIndex = 48;
            this.removeButton.Text = "移除資料";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.insertButton.Location = new System.Drawing.Point(18, 207);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(212, 33);
            this.insertButton.TabIndex = 47;
            this.insertButton.Text = "插入儲存資料";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.eachlowestLabel);
            this.panel2.Controls.Add(this.eachhightestLabel);
            this.panel2.Controls.Add(this.eachaverageLabel);
            this.panel2.Controls.Add(this.eachscoreallLabel);
            this.panel2.Location = new System.Drawing.Point(236, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 96);
            this.panel2.TabIndex = 46;
            // 
            // eachlowestLabel
            // 
            this.eachlowestLabel.AutoSize = true;
            this.eachlowestLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eachlowestLabel.Location = new System.Drawing.Point(3, 66);
            this.eachlowestLabel.Name = "eachlowestLabel";
            this.eachlowestLabel.Padding = new System.Windows.Forms.Padding(3);
            this.eachlowestLabel.Size = new System.Drawing.Size(62, 22);
            this.eachlowestLabel.TabIndex = 29;
            this.eachlowestLabel.Text = "最低分";
            // 
            // eachhightestLabel
            // 
            this.eachhightestLabel.AutoSize = true;
            this.eachhightestLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eachhightestLabel.Location = new System.Drawing.Point(3, 44);
            this.eachhightestLabel.Name = "eachhightestLabel";
            this.eachhightestLabel.Padding = new System.Windows.Forms.Padding(3);
            this.eachhightestLabel.Size = new System.Drawing.Size(62, 22);
            this.eachhightestLabel.TabIndex = 28;
            this.eachhightestLabel.Text = "最高分";
            // 
            // eachaverageLabel
            // 
            this.eachaverageLabel.AutoSize = true;
            this.eachaverageLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eachaverageLabel.Location = new System.Drawing.Point(3, 22);
            this.eachaverageLabel.Name = "eachaverageLabel";
            this.eachaverageLabel.Padding = new System.Windows.Forms.Padding(3);
            this.eachaverageLabel.Size = new System.Drawing.Size(46, 22);
            this.eachaverageLabel.TabIndex = 27;
            this.eachaverageLabel.Text = "平均";
            // 
            // eachscoreallLabel
            // 
            this.eachscoreallLabel.AutoSize = true;
            this.eachscoreallLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eachscoreallLabel.Location = new System.Drawing.Point(3, 0);
            this.eachscoreallLabel.Name = "eachscoreallLabel";
            this.eachscoreallLabel.Padding = new System.Windows.Forms.Padding(3);
            this.eachscoreallLabel.Size = new System.Drawing.Size(46, 22);
            this.eachscoreallLabel.TabIndex = 26;
            this.eachscoreallLabel.Text = "總分";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Location = new System.Drawing.Point(18, 168);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(212, 33);
            this.addButton.TabIndex = 45;
            this.addButton.Text = "加入學生資料";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.scoreLabel);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(236, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 260);
            this.panel1.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(400, -2);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(46, 22);
            this.label12.TabIndex = 33;
            this.label12.Text = "最低";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scoreLabel.Location = new System.Drawing.Point(3, 35);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Padding = new System.Windows.Forms.Padding(3);
            this.scoreLabel.Size = new System.Drawing.Size(6, 22);
            this.scoreLabel.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(462, -2);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3);
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "最高";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(335, -2);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3);
            this.label9.Size = new System.Drawing.Size(46, 22);
            this.label9.TabIndex = 30;
            this.label9.Text = "平均";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(283, -2);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3);
            this.label8.Size = new System.Drawing.Size(46, 22);
            this.label8.TabIndex = 29;
            this.label8.Text = "總分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(127, -2);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(46, 22);
            this.label7.TabIndex = 28;
            this.label7.Text = "國文";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(179, -2);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "英文";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(231, -2);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "數學";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "姓名";
            // 
            // mathTextBox
            // 
            this.mathTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mathTextBox.Location = new System.Drawing.Point(101, 135);
            this.mathTextBox.Name = "mathTextBox";
            this.mathTextBox.Size = new System.Drawing.Size(84, 27);
            this.mathTextBox.TabIndex = 43;
            // 
            // englishTextBox
            // 
            this.englishTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.englishTextBox.Location = new System.Drawing.Point(101, 99);
            this.englishTextBox.Name = "englishTextBox";
            this.englishTextBox.Size = new System.Drawing.Size(84, 27);
            this.englishTextBox.TabIndex = 42;
            // 
            // chineseTextBox
            // 
            this.chineseTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chineseTextBox.Location = new System.Drawing.Point(101, 62);
            this.chineseTextBox.Name = "chineseTextBox";
            this.chineseTextBox.Size = new System.Drawing.Size(84, 27);
            this.chineseTextBox.TabIndex = 41;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameTextBox.Location = new System.Drawing.Point(101, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(84, 27);
            this.nameTextBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(33, 138);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "數學：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "英文：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "國文：";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameLabel.Location = new System.Drawing.Point(33, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(3);
            this.nameLabel.Size = new System.Drawing.Size(62, 22);
            this.nameLabel.TabIndex = 36;
            this.nameLabel.Text = "姓名：";
            // 
            // countButton
            // 
            this.countButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countButton.Enabled = false;
            this.countButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countButton.Location = new System.Drawing.Point(570, 405);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(212, 33);
            this.countButton.TabIndex = 51;
            this.countButton.Text = "各科統計";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // minChineseTextBox
            // 
            this.minChineseTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.minChineseTextBox.Location = new System.Drawing.Point(11, 354);
            this.minChineseTextBox.Name = "minChineseTextBox";
            this.minChineseTextBox.Size = new System.Drawing.Size(84, 27);
            this.minChineseTextBox.TabIndex = 52;
            // 
            // maxChineseTextBox
            // 
            this.maxChineseTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.maxChineseTextBox.Location = new System.Drawing.Point(146, 354);
            this.maxChineseTextBox.Name = "maxChineseTextBox";
            this.maxChineseTextBox.Size = new System.Drawing.Size(84, 27);
            this.maxChineseTextBox.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(55, 321);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(142, 22);
            this.label11.TabIndex = 54;
            this.label11.Text = "搜尋國文成績範圍";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(110, 354);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(3);
            this.label13.Size = new System.Drawing.Size(19, 22);
            this.label13.TabIndex = 55;
            this.label13.Text = "-";
            // 
            // StudentsGarde_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maxChineseTextBox);
            this.Controls.Add(this.minChineseTextBox);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.searchchineseButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mathTextBox);
            this.Controls.Add(this.englishTextBox);
            this.Controls.Add(this.chineseTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Name = "StudentsGarde_List";
            this.Text = "StudentsGarde_List";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchchineseButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label eachlowestLabel;
        private System.Windows.Forms.Label eachhightestLabel;
        private System.Windows.Forms.Label eachaverageLabel;
        private System.Windows.Forms.Label eachscoreallLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mathTextBox;
        private System.Windows.Forms.TextBox englishTextBox;
        private System.Windows.Forms.TextBox chineseTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox minChineseTextBox;
        private System.Windows.Forms.TextBox maxChineseTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}