
namespace WindowsFormsHomework
{
    partial class Hello
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
            this.SayHiButton = new System.Windows.Forms.Button();
            this.SayHelloButton = new System.Windows.Forms.Button();
            this.constellationTextBox = new System.Windows.Forms.TextBox();
            this.constellationLabel = new System.Windows.Forms.Label();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.englishNameTextBox = new System.Windows.Forms.TextBox();
            this.englishNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SayHiButton
            // 
            this.SayHiButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SayHiButton.Location = new System.Drawing.Point(286, 327);
            this.SayHiButton.Name = "SayHiButton";
            this.SayHiButton.Size = new System.Drawing.Size(165, 42);
            this.SayHiButton.TabIndex = 19;
            this.SayHiButton.Text = "Say Hi!";
            this.SayHiButton.UseVisualStyleBackColor = true;
            this.SayHiButton.Click += new System.EventHandler(this.SayHiButton_Click);
            // 
            // SayHelloButton
            // 
            this.SayHelloButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SayHelloButton.Location = new System.Drawing.Point(78, 327);
            this.SayHelloButton.Name = "SayHelloButton";
            this.SayHelloButton.Size = new System.Drawing.Size(165, 42);
            this.SayHelloButton.TabIndex = 18;
            this.SayHelloButton.Text = "Say Hello!";
            this.SayHelloButton.UseVisualStyleBackColor = true;
            this.SayHelloButton.Click += new System.EventHandler(this.SayHelloButton_Click);
            // 
            // constellationTextBox
            // 
            this.constellationTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.constellationTextBox.Location = new System.Drawing.Point(249, 241);
            this.constellationTextBox.Name = "constellationTextBox";
            this.constellationTextBox.Size = new System.Drawing.Size(175, 40);
            this.constellationTextBox.TabIndex = 17;
            // 
            // constellationLabel
            // 
            this.constellationLabel.AutoSize = true;
            this.constellationLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.constellationLabel.Location = new System.Drawing.Point(78, 254);
            this.constellationLabel.Name = "constellationLabel";
            this.constellationLabel.Size = new System.Drawing.Size(93, 27);
            this.constellationLabel.TabIndex = 16;
            this.constellationLabel.Text = "星座：";
            // 
            // sexTextBox
            // 
            this.sexTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sexTextBox.Location = new System.Drawing.Point(249, 182);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(175, 40);
            this.sexTextBox.TabIndex = 15;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sexLabel.Location = new System.Drawing.Point(78, 195);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(93, 27);
            this.sexLabel.TabIndex = 14;
            this.sexLabel.Text = "性別：";
            // 
            // englishNameTextBox
            // 
            this.englishNameTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.englishNameTextBox.Location = new System.Drawing.Point(249, 123);
            this.englishNameTextBox.Name = "englishNameTextBox";
            this.englishNameTextBox.Size = new System.Drawing.Size(175, 40);
            this.englishNameTextBox.TabIndex = 13;
            // 
            // englishNameLabel
            // 
            this.englishNameLabel.AutoSize = true;
            this.englishNameLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.englishNameLabel.Location = new System.Drawing.Point(78, 136);
            this.englishNameLabel.Name = "englishNameLabel";
            this.englishNameLabel.Size = new System.Drawing.Size(165, 27);
            this.englishNameLabel.TabIndex = 12;
            this.englishNameLabel.Text = "English Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameTextBox.Location = new System.Drawing.Point(249, 68);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(175, 40);
            this.nameTextBox.TabIndex = 11;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameLabel.Location = new System.Drawing.Point(78, 71);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(93, 27);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "姓名：";
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SayHiButton);
            this.Controls.Add(this.SayHelloButton);
            this.Controls.Add(this.constellationTextBox);
            this.Controls.Add(this.constellationLabel);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.englishNameTextBox);
            this.Controls.Add(this.englishNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "Hello";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SayHiButton;
        private System.Windows.Forms.Button SayHelloButton;
        private System.Windows.Forms.TextBox constellationTextBox;
        private System.Windows.Forms.Label constellationLabel;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.TextBox englishNameTextBox;
        private System.Windows.Forms.Label englishNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}