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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonCurrecnyPair = new System.Windows.Forms.Button();
            this.buttonCaulcCI = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCurrecnyPair
            // 
            this.buttonCurrecnyPair.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCurrecnyPair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCurrecnyPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCurrecnyPair.Location = new System.Drawing.Point(29, 421);
            this.buttonCurrecnyPair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCurrecnyPair.Name = "buttonCurrecnyPair";
            this.buttonCurrecnyPair.Size = new System.Drawing.Size(213, 45);
            this.buttonCurrecnyPair.TabIndex = 1;
            this.buttonCurrecnyPair.Text = "Currency Pair";
            this.buttonCurrecnyPair.UseVisualStyleBackColor = false;
            this.buttonCurrecnyPair.Click += new System.EventHandler(this.buttonCurrecnyPair_Click);
            // 
            // buttonCaulcCI
            // 
            this.buttonCaulcCI.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCaulcCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCaulcCI.Location = new System.Drawing.Point(29, 472);
            this.buttonCaulcCI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCaulcCI.Name = "buttonCaulcCI";
            this.buttonCaulcCI.Size = new System.Drawing.Size(213, 45);
            this.buttonCaulcCI.TabIndex = 2;
            this.buttonCaulcCI.Text = "Calculate CI";
            this.buttonCaulcCI.UseVisualStyleBackColor = false;
            this.buttonCaulcCI.Click += new System.EventHandler(this.buttonCaulcCI_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(29, 523);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(213, 45);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Wallet";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonCaulcCI);
            this.Controls.Add(this.buttonCurrecnyPair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Application";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCurrecnyPair;
        private System.Windows.Forms.Button buttonCaulcCI;
        private System.Windows.Forms.Button buttonLogin;
    }
}