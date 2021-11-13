
namespace WindowsFormsHomework
{
    partial class Student_StructForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.mathLabel = new System.Windows.Forms.Label();
            this.englishLabel = new System.Windows.Forms.Label();
            this.chineseLabel = new System.Windows.Forms.Label();
            this.englishTextBox = new System.Windows.Forms.TextBox();
            this.mathTextBox = new System.Windows.Forms.TextBox();
            this.chineseTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.highestLabel = new System.Windows.Forms.Label();
            this.lowestLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.chineseScoreLabel = new System.Windows.Forms.Label();
            this.englishScoreLabel = new System.Windows.Forms.Label();
            this.mathScoreLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.keepButton = new System.Windows.Forms.Button();
            this.highestLowestButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(66, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "姓名：";
            // 
            // mathLabel
            // 
            this.mathLabel.AutoSize = true;
            this.mathLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mathLabel.Location = new System.Drawing.Point(66, 258);
            this.mathLabel.Name = "mathLabel";
            this.mathLabel.Size = new System.Drawing.Size(93, 27);
            this.mathLabel.TabIndex = 12;
            this.mathLabel.Text = "數學：";
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.englishLabel.Location = new System.Drawing.Point(66, 195);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(93, 27);
            this.englishLabel.TabIndex = 13;
            this.englishLabel.Text = "英文：";
            // 
            // chineseLabel
            // 
            this.chineseLabel.AutoSize = true;
            this.chineseLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chineseLabel.Location = new System.Drawing.Point(66, 134);
            this.chineseLabel.Name = "chineseLabel";
            this.chineseLabel.Size = new System.Drawing.Size(93, 27);
            this.chineseLabel.TabIndex = 14;
            this.chineseLabel.Text = "國語：";
            // 
            // englishTextBox
            // 
            this.englishTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.englishTextBox.Location = new System.Drawing.Point(165, 192);
            this.englishTextBox.Name = "englishTextBox";
            this.englishTextBox.Size = new System.Drawing.Size(175, 40);
            this.englishTextBox.TabIndex = 15;
            // 
            // mathTextBox
            // 
            this.mathTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mathTextBox.Location = new System.Drawing.Point(165, 255);
            this.mathTextBox.Name = "mathTextBox";
            this.mathTextBox.Size = new System.Drawing.Size(175, 40);
            this.mathTextBox.TabIndex = 16;
            // 
            // chineseTextBox
            // 
            this.chineseTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chineseTextBox.Location = new System.Drawing.Point(165, 131);
            this.chineseTextBox.Name = "chineseTextBox";
            this.chineseTextBox.Size = new System.Drawing.Size(175, 40);
            this.chineseTextBox.TabIndex = 17;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameTextBox.Location = new System.Drawing.Point(165, 73);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(175, 40);
            this.nameTextBox.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(455, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 337);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.highestLabel);
            this.flowLayoutPanel2.Controls.Add(this.lowestLabel);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 241);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(323, 96);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // highestLabel
            // 
            this.highestLabel.AutoSize = true;
            this.highestLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.highestLabel.Location = new System.Drawing.Point(3, 0);
            this.highestLabel.Name = "highestLabel";
            this.highestLabel.Padding = new System.Windows.Forms.Padding(3);
            this.highestLabel.Size = new System.Drawing.Size(142, 22);
            this.highestLabel.TabIndex = 20;
            this.highestLabel.Text = "最高科目成績為：";
            // 
            // lowestLabel
            // 
            this.lowestLabel.AutoSize = true;
            this.lowestLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lowestLabel.Location = new System.Drawing.Point(3, 22);
            this.lowestLabel.Name = "lowestLabel";
            this.lowestLabel.Padding = new System.Windows.Forms.Padding(3);
            this.lowestLabel.Size = new System.Drawing.Size(142, 22);
            this.lowestLabel.TabIndex = 21;
            this.lowestLabel.Text = "最低科目成績為：";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.nameLabel);
            this.flowLayoutPanel1.Controls.Add(this.chineseScoreLabel);
            this.flowLayoutPanel1.Controls.Add(this.englishScoreLabel);
            this.flowLayoutPanel1.Controls.Add(this.mathScoreLabel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(455, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(323, 196);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(3);
            this.nameLabel.Size = new System.Drawing.Size(62, 22);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "姓名：";
            // 
            // chineseScoreLabel
            // 
            this.chineseScoreLabel.AutoSize = true;
            this.chineseScoreLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chineseScoreLabel.Location = new System.Drawing.Point(3, 22);
            this.chineseScoreLabel.Name = "chineseScoreLabel";
            this.chineseScoreLabel.Padding = new System.Windows.Forms.Padding(3);
            this.chineseScoreLabel.Size = new System.Drawing.Size(62, 22);
            this.chineseScoreLabel.TabIndex = 20;
            this.chineseScoreLabel.Text = "國語：";
            // 
            // englishScoreLabel
            // 
            this.englishScoreLabel.AutoSize = true;
            this.englishScoreLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.englishScoreLabel.Location = new System.Drawing.Point(3, 44);
            this.englishScoreLabel.Name = "englishScoreLabel";
            this.englishScoreLabel.Padding = new System.Windows.Forms.Padding(3);
            this.englishScoreLabel.Size = new System.Drawing.Size(62, 22);
            this.englishScoreLabel.TabIndex = 20;
            this.englishScoreLabel.Text = "英文：";
            // 
            // mathScoreLabel
            // 
            this.mathScoreLabel.AutoSize = true;
            this.mathScoreLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mathScoreLabel.Location = new System.Drawing.Point(3, 66);
            this.mathScoreLabel.Name = "mathScoreLabel";
            this.mathScoreLabel.Padding = new System.Windows.Forms.Padding(3);
            this.mathScoreLabel.Size = new System.Drawing.Size(62, 22);
            this.mathScoreLabel.TabIndex = 20;
            this.mathScoreLabel.Text = "數學：";
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.displayButton.Location = new System.Drawing.Point(250, 334);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(187, 42);
            this.displayButton.TabIndex = 21;
            this.displayButton.Text = "顯示儲存內容";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // keepButton
            // 
            this.keepButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.keepButton.Location = new System.Drawing.Point(34, 334);
            this.keepButton.Name = "keepButton";
            this.keepButton.Size = new System.Drawing.Size(187, 42);
            this.keepButton.TabIndex = 23;
            this.keepButton.Text = "儲存";
            this.keepButton.UseVisualStyleBackColor = true;
            this.keepButton.Click += new System.EventHandler(this.keepButton_Click);
            // 
            // highestLowestButton
            // 
            this.highestLowestButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.highestLowestButton.Location = new System.Drawing.Point(507, 396);
            this.highestLowestButton.Name = "highestLowestButton";
            this.highestLowestButton.Size = new System.Drawing.Size(271, 42);
            this.highestLowestButton.TabIndex = 24;
            this.highestLowestButton.Text = "最高分/最低分科目";
            this.highestLowestButton.UseVisualStyleBackColor = true;
            this.highestLowestButton.Click += new System.EventHandler(this.highestLowestButton_Click);
            // 
            // Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highestLowestButton);
            this.Controls.Add(this.keepButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.chineseTextBox);
            this.Controls.Add(this.mathTextBox);
            this.Controls.Add(this.englishTextBox);
            this.Controls.Add(this.chineseLabel);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.mathLabel);
            this.Controls.Add(this.label1);
            this.Name = "Student_StructForm";
            this.Text = "Student_StructForm";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mathLabel;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Label chineseLabel;
        private System.Windows.Forms.TextBox englishTextBox;
        private System.Windows.Forms.TextBox mathTextBox;
        private System.Windows.Forms.TextBox chineseTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label highestLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label chineseScoreLabel;
        private System.Windows.Forms.Label englishScoreLabel;
        private System.Windows.Forms.Label mathScoreLabel;
        private System.Windows.Forms.Label lowestLabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button keepButton;
        private System.Windows.Forms.Button highestLowestButton;
    }
}