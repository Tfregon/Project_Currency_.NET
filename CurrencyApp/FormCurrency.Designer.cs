namespace CurrencyApp
{
    partial class FormCurrency
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
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxCoins = new System.Windows.Forms.ListBox();
            this.btnLoadList = new System.Windows.Forms.Button();
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(236, 43);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(668, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxCoins
            // 
            this.listBoxCoins.FormattingEnabled = true;
            this.listBoxCoins.ItemHeight = 20;
            this.listBoxCoins.Location = new System.Drawing.Point(41, 106);
            this.listBoxCoins.Name = "listBoxCoins";
            this.listBoxCoins.Size = new System.Drawing.Size(121, 64);
            this.listBoxCoins.TabIndex = 5;
            // 
            // btnLoadList
            // 
            this.btnLoadList.Location = new System.Drawing.Point(30, 43);
            this.btnLoadList.Name = "btnLoadList";
            this.btnLoadList.Size = new System.Drawing.Size(145, 40);
            this.btnLoadList.TabIndex = 6;
            this.btnLoadList.Text = "LOAD LIST";
            this.btnLoadList.UseVisualStyleBackColor = true;
            this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click);
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Location = new System.Drawing.Point(30, 190);
            this.buttonShowInfo.Name = "buttonShowInfo";
            this.buttonShowInfo.Size = new System.Drawing.Size(145, 40);
            this.buttonShowInfo.TabIndex = 7;
            this.buttonShowInfo.Text = "SHOW";
            this.buttonShowInfo.UseVisualStyleBackColor = true;
            this.buttonShowInfo.Click += new System.EventHandler(this.buttonShowInfo_Click);
            // 
            // FormCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 357);
            this.Controls.Add(this.buttonShowInfo);
            this.Controls.Add(this.btnLoadList);
            this.Controls.Add(this.listBoxCoins);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Name = "FormCurrency";
            this.Text = "Currency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxCoins;
        private System.Windows.Forms.Button btnLoadList;
        private System.Windows.Forms.Button buttonShowInfo;
    }
}

