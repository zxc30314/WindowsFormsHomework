
namespace WindowsFormsHomework
{
    partial class Guess_Number
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
            this.guessnumberLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.showAnswerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guessnumberLabel
            // 
            this.guessnumberLabel.AutoSize = true;
            this.guessnumberLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guessnumberLabel.Location = new System.Drawing.Point(153, 33);
            this.guessnumberLabel.Name = "guessnumberLabel";
            this.guessnumberLabel.Size = new System.Drawing.Size(466, 27);
            this.guessnumberLabel.TabIndex = 0;
            this.guessnumberLabel.Text = "Please select a number between 1 to 100";
            // 
            // guessButton
            // 
            this.guessButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guessButton.Location = new System.Drawing.Point(158, 121);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(165, 42);
            this.guessButton.TabIndex = 19;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // showAnswerButton
            // 
            this.showAnswerButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showAnswerButton.Location = new System.Drawing.Point(432, 121);
            this.showAnswerButton.Name = "showAnswerButton";
            this.showAnswerButton.Size = new System.Drawing.Size(165, 42);
            this.showAnswerButton.TabIndex = 20;
            this.showAnswerButton.Text = "Show Answer";
            this.showAnswerButton.UseVisualStyleBackColor = true;
            this.showAnswerButton.Click += new System.EventHandler(this.showAnswerButton_Click);
            // 
            // Guess_Number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 202);
            this.Controls.Add(this.showAnswerButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessnumberLabel);
            this.Name = "Guess_Number";
            this.Text = "Guess_Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label guessnumberLabel;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button showAnswerButton;
    }
}