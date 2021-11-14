
namespace WindowsFormsHomework
{
    partial class HomePage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.loanButton = new System.Windows.Forms.Button();
            this.helloButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.studentsGradeButton = new System.Windows.Forms.Button();
            this.student_StructFormButton = new System.Windows.Forms.Button();
            this.posButton = new System.Windows.Forms.Button();
            this.bubblePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bubblePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // loanButton
            // 
            this.loanButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loanButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loanButton.Location = new System.Drawing.Point(24, 53);
            this.loanButton.Name = "loanButton";
            this.loanButton.Size = new System.Drawing.Size(212, 23);
            this.loanButton.TabIndex = 1;
            this.loanButton.Text = "Loan";
            this.loanButton.UseVisualStyleBackColor = true;
            this.loanButton.Click += new System.EventHandler(this.loanButton_Click);
            // 
            // helloButton
            // 
            this.helloButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helloButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.helloButton.Location = new System.Drawing.Point(24, 24);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(212, 23);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "Hello";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 114);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackgroundImage = global::WindowsFormsHomework.Properties.Resources.pngtree_chinese_style_antiquity_ink_background_picture_image_953480;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.studentsGradeButton);
            this.splitContainer1.Panel1.Controls.Add(this.student_StructFormButton);
            this.splitContainer1.Panel1.Controls.Add(this.posButton);
            this.splitContainer1.Panel1.Controls.Add(this.helloButton);
            this.splitContainer1.Panel1.Controls.Add(this.loanButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackgroundImage = global::WindowsFormsHomework.Properties.Resources._8db293dd3ca2ca61f5df28cdfe87235e;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Size = new System.Drawing.Size(800, 336);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 25;
            // 
            // studentsGradeButton
            // 
            this.studentsGradeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsGradeButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.studentsGradeButton.Location = new System.Drawing.Point(24, 140);
            this.studentsGradeButton.Name = "studentsGradeButton";
            this.studentsGradeButton.Size = new System.Drawing.Size(212, 23);
            this.studentsGradeButton.TabIndex = 4;
            this.studentsGradeButton.Text = "StudentsGrade";
            this.studentsGradeButton.UseVisualStyleBackColor = true;
            this.studentsGradeButton.Click += new System.EventHandler(this.studentsGradeButton_Click);
            // 
            // student_StructFormButton
            // 
            this.student_StructFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.student_StructFormButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.student_StructFormButton.Location = new System.Drawing.Point(24, 111);
            this.student_StructFormButton.Name = "student_StructFormButton";
            this.student_StructFormButton.Size = new System.Drawing.Size(212, 23);
            this.student_StructFormButton.TabIndex = 3;
            this.student_StructFormButton.Text = "Student_StructForm";
            this.student_StructFormButton.UseVisualStyleBackColor = true;
            this.student_StructFormButton.Click += new System.EventHandler(this.student_StructFormButton_Click);
            // 
            // posButton
            // 
            this.posButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.posButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.posButton.Location = new System.Drawing.Point(24, 82);
            this.posButton.Name = "posButton";
            this.posButton.Size = new System.Drawing.Size(212, 23);
            this.posButton.TabIndex = 2;
            this.posButton.Text = "Pos";
            this.posButton.UseVisualStyleBackColor = true;
            this.posButton.Click += new System.EventHandler(this.posButton_Click);
            // 
            // bubblePicture
            // 
            this.bubblePicture.BackgroundImage = global::WindowsFormsHomework.Properties.Resources.pngtree_literary_light_blue_bubble_banner_background_bluebubble_image_83250;
            this.bubblePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bubblePicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.bubblePicture.Location = new System.Drawing.Point(0, 0);
            this.bubblePicture.Name = "bubblePicture";
            this.bubblePicture.Size = new System.Drawing.Size(800, 114);
            this.bubblePicture.TabIndex = 24;
            this.bubblePicture.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bubblePicture);
            this.IsMdiContainer = true;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bubblePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loanButton;
        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox bubblePicture;
        private System.Windows.Forms.Button posButton;
        private System.Windows.Forms.Button student_StructFormButton;
        private System.Windows.Forms.Button studentsGradeButton;
    }
}

