
namespace WindowsFormsHomework
{
    partial class Pos
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
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.wineButton = new System.Windows.Forms.Button();
            this.whisyButton = new System.Windows.Forms.Button();
            this.tequilaButton = new System.Windows.Forms.Button();
            this.beerButton = new System.Windows.Forms.Button();
            this.listGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.totalPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.payMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.creditButton = new System.Windows.Forms.Button();
            this.cashButton = new System.Windows.Forms.Button();
            this.menuGroupBox.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.totalPriceGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.payMethodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.wineButton);
            this.menuGroupBox.Controls.Add(this.whisyButton);
            this.menuGroupBox.Controls.Add(this.tequilaButton);
            this.menuGroupBox.Controls.Add(this.beerButton);
            this.menuGroupBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuGroupBox.Location = new System.Drawing.Point(35, 48);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(236, 355);
            this.menuGroupBox.TabIndex = 0;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "菜單 Menu";
            // 
            // wineButton
            // 
            this.wineButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wineButton.Location = new System.Drawing.Point(25, 73);
            this.wineButton.Name = "wineButton";
            this.wineButton.Size = new System.Drawing.Size(75, 102);
            this.wineButton.TabIndex = 3;
            this.wineButton.Text = "紅酒\r\nWine\r\nNT320";
            this.wineButton.UseVisualStyleBackColor = true;
            this.wineButton.Click += new System.EventHandler(this.wineButton_Click);
            // 
            // whisyButton
            // 
            this.whisyButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.whisyButton.Location = new System.Drawing.Point(25, 203);
            this.whisyButton.Name = "whisyButton";
            this.whisyButton.Size = new System.Drawing.Size(75, 102);
            this.whisyButton.TabIndex = 2;
            this.whisyButton.Text = "威士忌\r\nWhisy\r\nNT350";
            this.whisyButton.UseVisualStyleBackColor = true;
            this.whisyButton.Click += new System.EventHandler(this.whisyButton_Click);
            // 
            // tequilaButton
            // 
            this.tequilaButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tequilaButton.Location = new System.Drawing.Point(131, 73);
            this.tequilaButton.Name = "tequilaButton";
            this.tequilaButton.Size = new System.Drawing.Size(75, 102);
            this.tequilaButton.TabIndex = 1;
            this.tequilaButton.Text = "龍舌蘭\r\nTequila\r\nNT180";
            this.tequilaButton.UseVisualStyleBackColor = true;
            this.tequilaButton.Click += new System.EventHandler(this.tequilaButton_Click);
            // 
            // beerButton
            // 
            this.beerButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.beerButton.Location = new System.Drawing.Point(131, 203);
            this.beerButton.Name = "beerButton";
            this.beerButton.Size = new System.Drawing.Size(75, 102);
            this.beerButton.TabIndex = 0;
            this.beerButton.Text = "啤酒\r\nBeer\r\nNT120";
            this.beerButton.UseVisualStyleBackColor = true;
            this.beerButton.Click += new System.EventHandler(this.beerButton_Click);
            // 
            // listGroupBox
            // 
            this.listGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.listGroupBox.Controls.Add(this.clearButton);
            this.listGroupBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listGroupBox.Location = new System.Drawing.Point(590, 48);
            this.listGroupBox.Name = "listGroupBox";
            this.listGroupBox.Size = new System.Drawing.Size(200, 355);
            this.listGroupBox.TabIndex = 2;
            this.listGroupBox.TabStop = false;
            this.listGroupBox.Text = "購物清單 List";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.listLabel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 266);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listLabel.Location = new System.Drawing.Point(123, 0);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(72, 16);
            this.listLabel.TabIndex = 0;
            this.listLabel.Text = "尚未點餐";
            this.listLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(118, 314);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 35);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "清除清單";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // totalPriceGroupBox
            // 
            this.totalPriceGroupBox.Controls.Add(this.panel2);
            this.totalPriceGroupBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalPriceGroupBox.Location = new System.Drawing.Point(294, 63);
            this.totalPriceGroupBox.Name = "totalPriceGroupBox";
            this.totalPriceGroupBox.Size = new System.Drawing.Size(273, 100);
            this.totalPriceGroupBox.TabIndex = 3;
            this.totalPriceGroupBox.TabStop = false;
            this.totalPriceGroupBox.Text = "總金額 Total Price";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.totalPriceLabel);
            this.panel2.Location = new System.Drawing.Point(6, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 39);
            this.panel2.TabIndex = 0;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalPriceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalPriceLabel.Location = new System.Drawing.Point(189, 12);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(72, 27);
            this.totalPriceLabel.TabIndex = 1;
            this.totalPriceLabel.Text = "NT$0";
            // 
            // payMethodGroupBox
            // 
            this.payMethodGroupBox.Controls.Add(this.label1);
            this.payMethodGroupBox.Controls.Add(this.creditButton);
            this.payMethodGroupBox.Controls.Add(this.cashButton);
            this.payMethodGroupBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.payMethodGroupBox.Location = new System.Drawing.Point(294, 194);
            this.payMethodGroupBox.Name = "payMethodGroupBox";
            this.payMethodGroupBox.Size = new System.Drawing.Size(273, 109);
            this.payMethodGroupBox.TabIndex = 4;
            this.payMethodGroupBox.TabStop = false;
            this.payMethodGroupBox.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(160, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "信用卡享九折";
            // 
            // creditButton
            // 
            this.creditButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.creditButton.Location = new System.Drawing.Point(160, 39);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(80, 35);
            this.creditButton.TabIndex = 1;
            this.creditButton.Text = "信用卡";
            this.creditButton.UseVisualStyleBackColor = true;
            this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
            // 
            // cashButton
            // 
            this.cashButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cashButton.Location = new System.Drawing.Point(42, 39);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(80, 35);
            this.cashButton.TabIndex = 0;
            this.cashButton.Text = "現金";
            this.cashButton.UseVisualStyleBackColor = true;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.payMethodGroupBox);
            this.Controls.Add(this.totalPriceGroupBox);
            this.Controls.Add(this.listGroupBox);
            this.Controls.Add(this.menuGroupBox);
            this.Name = "Pos";
            this.Text = "Pos";
            this.menuGroupBox.ResumeLayout(false);
            this.listGroupBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.totalPriceGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.payMethodGroupBox.ResumeLayout(false);
            this.payMethodGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.Button beerButton;
        private System.Windows.Forms.GroupBox listGroupBox;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.GroupBox totalPriceGroupBox;
        private System.Windows.Forms.Button wineButton;
        private System.Windows.Forms.Button whisyButton;
        private System.Windows.Forms.Button tequilaButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.GroupBox payMethodGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}