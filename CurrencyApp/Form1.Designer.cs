namespace CurrencyApp
{
    partial class Form1
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
            this.buttonBTCBRL = new System.Windows.Forms.Button();
            this.buttonEURBRL = new System.Windows.Forms.Button();
            this.buttonUSDBRL = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBTCBRL
            // 
            this.buttonBTCBRL.Location = new System.Drawing.Point(53, 78);
            this.buttonBTCBRL.Name = "buttonBTCBRL";
            this.buttonBTCBRL.Size = new System.Drawing.Size(103, 40);
            this.buttonBTCBRL.TabIndex = 0;
            this.buttonBTCBRL.Text = "BTC/BRL";
            this.buttonBTCBRL.UseVisualStyleBackColor = true;
            this.buttonBTCBRL.Click += new System.EventHandler(this.buttonBTCBRL_Click);
            // 
            // buttonEURBRL
            // 
            this.buttonEURBRL.Location = new System.Drawing.Point(53, 151);
            this.buttonEURBRL.Name = "buttonEURBRL";
            this.buttonEURBRL.Size = new System.Drawing.Size(103, 40);
            this.buttonEURBRL.TabIndex = 1;
            this.buttonEURBRL.Text = "EUR/BRL";
            this.buttonEURBRL.UseVisualStyleBackColor = true;
            this.buttonEURBRL.Click += new System.EventHandler(this.buttonEURBRL_Click);
            // 
            // buttonUSDBRL
            // 
            this.buttonUSDBRL.Location = new System.Drawing.Point(53, 225);
            this.buttonUSDBRL.Name = "buttonUSDBRL";
            this.buttonUSDBRL.Size = new System.Drawing.Size(103, 40);
            this.buttonUSDBRL.TabIndex = 2;
            this.buttonUSDBRL.Text = "USD/BRL";
            this.buttonUSDBRL.UseVisualStyleBackColor = true;
            this.buttonUSDBRL.Click += new System.EventHandler(this.buttonUSDBRL_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(258, 78);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(560, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonUSDBRL);
            this.Controls.Add(this.buttonEURBRL);
            this.Controls.Add(this.buttonBTCBRL);
            this.Name = "Form1";
            this.Text = "Currency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBTCBRL;
        private System.Windows.Forms.Button buttonEURBRL;
        private System.Windows.Forms.Button buttonUSDBRL;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
    }
}

