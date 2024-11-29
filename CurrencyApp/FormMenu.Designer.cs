namespace CurrencyApp
{
    partial class FormMenu
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonCurrecnyPair = new System.Windows.Forms.Button();
            this.buttonCaulcCI = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(267, 71);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(109, 20);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Currency App!";
            // 
            // buttonCurrecnyPair
            // 
            this.buttonCurrecnyPair.Location = new System.Drawing.Point(51, 237);
            this.buttonCurrecnyPair.Name = "buttonCurrecnyPair";
            this.buttonCurrecnyPair.Size = new System.Drawing.Size(151, 59);
            this.buttonCurrecnyPair.TabIndex = 1;
            this.buttonCurrecnyPair.Text = "Currency Pair";
            this.buttonCurrecnyPair.UseVisualStyleBackColor = true;
            this.buttonCurrecnyPair.Click += new System.EventHandler(this.buttonCurrecnyPair_Click);
            // 
            // buttonCaulcCI
            // 
            this.buttonCaulcCI.Location = new System.Drawing.Point(246, 237);
            this.buttonCaulcCI.Name = "buttonCaulcCI";
            this.buttonCaulcCI.Size = new System.Drawing.Size(151, 59);
            this.buttonCaulcCI.TabIndex = 2;
            this.buttonCaulcCI.Text = "Calc  CI";
            this.buttonCaulcCI.UseVisualStyleBackColor = true;
            this.buttonCaulcCI.Click += new System.EventHandler(this.buttonCaulcCI_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(438, 237);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(151, 59);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Wallet";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 338);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonCaulcCI);
            this.Controls.Add(this.buttonCurrecnyPair);
            this.Controls.Add(this.labelWelcome);
            this.Name = "FormMenu";
            this.Text = "Currency Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonCurrecnyPair;
        private System.Windows.Forms.Button buttonCaulcCI;
        private System.Windows.Forms.Button buttonLogin;
    }
}