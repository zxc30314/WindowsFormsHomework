
namespace WindowsFormsHomework
{
    partial class Loan
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
            this.downpaymentTextBox = new System.Windows.Forms.TextBox();
            this.downpaymentLabel = new System.Windows.Forms.Label();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.InterestLabel = new System.Windows.Forms.Label();
            this.limitTextBox = new System.Windows.Forms.TextBox();
            this.limitLabel = new System.Windows.Forms.Label();
            this.loanTextBox = new System.Windows.Forms.TextBox();
            this.loanLabel = new System.Windows.Forms.Label();
            this.TotalButton = new System.Windows.Forms.Button();
            this.monthlyPayButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downpaymentTextBox
            // 
            this.downpaymentTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.downpaymentTextBox.Location = new System.Drawing.Point(272, 251);
            this.downpaymentTextBox.Name = "downpaymentTextBox";
            this.downpaymentTextBox.Size = new System.Drawing.Size(175, 40);
            this.downpaymentTextBox.TabIndex = 25;
            // 
            // downpaymentLabel
            // 
            this.downpaymentLabel.AutoSize = true;
            this.downpaymentLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.downpaymentLabel.Location = new System.Drawing.Point(101, 254);
            this.downpaymentLabel.Name = "downpaymentLabel";
            this.downpaymentLabel.Size = new System.Drawing.Size(93, 27);
            this.downpaymentLabel.TabIndex = 24;
            this.downpaymentLabel.Text = "頭期款";
            // 
            // interestTextBox
            // 
            this.interestTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.interestTextBox.Location = new System.Drawing.Point(272, 192);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(175, 40);
            this.interestTextBox.TabIndex = 23;
            // 
            // InterestLabel
            // 
            this.InterestLabel.AutoSize = true;
            this.InterestLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InterestLabel.Location = new System.Drawing.Point(101, 195);
            this.InterestLabel.Name = "InterestLabel";
            this.InterestLabel.Size = new System.Drawing.Size(130, 27);
            this.InterestLabel.TabIndex = 22;
            this.InterestLabel.Text = "年利率(%)";
            // 
            // limitTextBox
            // 
            this.limitTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.limitTextBox.Location = new System.Drawing.Point(272, 133);
            this.limitTextBox.Name = "limitTextBox";
            this.limitTextBox.Size = new System.Drawing.Size(175, 40);
            this.limitTextBox.TabIndex = 21;
            // 
            // limitLabel
            // 
            this.limitLabel.AutoSize = true;
            this.limitLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.limitLabel.Location = new System.Drawing.Point(101, 136);
            this.limitLabel.Name = "limitLabel";
            this.limitLabel.Size = new System.Drawing.Size(109, 27);
            this.limitLabel.TabIndex = 20;
            this.limitLabel.Text = "期限(年)";
            // 
            // loanTextBox
            // 
            this.loanTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loanTextBox.Location = new System.Drawing.Point(272, 71);
            this.loanTextBox.Name = "loanTextBox";
            this.loanTextBox.Size = new System.Drawing.Size(175, 40);
            this.loanTextBox.TabIndex = 19;
            // 
            // loanLabel
            // 
            this.loanLabel.AutoSize = true;
            this.loanLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loanLabel.Location = new System.Drawing.Point(101, 74);
            this.loanLabel.Name = "loanLabel";
            this.loanLabel.Size = new System.Drawing.Size(120, 27);
            this.loanLabel.TabIndex = 18;
            this.loanLabel.Text = "貸款金額";
            // 
            // TotalButton
            // 
            this.TotalButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalButton.Location = new System.Drawing.Point(303, 342);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(165, 42);
            this.TotalButton.TabIndex = 27;
            this.TotalButton.Text = "總付款";
            this.TotalButton.UseVisualStyleBackColor = true;
            this.TotalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // monthlyPayButton
            // 
            this.monthlyPayButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthlyPayButton.Location = new System.Drawing.Point(106, 342);
            this.monthlyPayButton.Name = "monthlyPayButton";
            this.monthlyPayButton.Size = new System.Drawing.Size(165, 42);
            this.monthlyPayButton.TabIndex = 26;
            this.monthlyPayButton.Text = "PMT(月付)";
            this.monthlyPayButton.UseVisualStyleBackColor = true;
            this.monthlyPayButton.Click += new System.EventHandler(this.monthlyPayButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reportButton.Location = new System.Drawing.Point(563, 342);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(165, 42);
            this.reportButton.TabIndex = 28;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.TotalButton);
            this.Controls.Add(this.monthlyPayButton);
            this.Controls.Add(this.downpaymentTextBox);
            this.Controls.Add(this.downpaymentLabel);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.InterestLabel);
            this.Controls.Add(this.limitTextBox);
            this.Controls.Add(this.limitLabel);
            this.Controls.Add(this.loanTextBox);
            this.Controls.Add(this.loanLabel);
            this.Name = "Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox downpaymentTextBox;
        private System.Windows.Forms.Label downpaymentLabel;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.Label InterestLabel;
        private System.Windows.Forms.TextBox limitTextBox;
        private System.Windows.Forms.Label limitLabel;
        private System.Windows.Forms.TextBox loanTextBox;
        private System.Windows.Forms.Label loanLabel;
        private System.Windows.Forms.Button TotalButton;
        private System.Windows.Forms.Button monthlyPayButton;
        private System.Windows.Forms.Button reportButton;
    }
}