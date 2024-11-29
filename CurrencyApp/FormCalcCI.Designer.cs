namespace CurrencyApp
{
    partial class FormCalcCI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regularCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cumulativeCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCumulativeCI = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMonthlyDepositCCI = new System.Windows.Forms.Label();
            this.textBoxMonthlyDeposit = new System.Windows.Forms.TextBox();
            this.labelAmountCumulativeCI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmountCCI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAnnualRateCCI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAnnualRateCCI = new System.Windows.Forms.TextBox();
            this.buttonCCI = new System.Windows.Forms.Button();
            this.labelDurationCCI = new System.Windows.Forms.Label();
            this.textBoxDurationCCI = new System.Windows.Forms.TextBox();
            this.groupBoxRegularCI = new System.Windows.Forms.GroupBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelExDuration = new System.Windows.Forms.Label();
            this.textBoxAmountRCI = new System.Windows.Forms.TextBox();
            this.labelExAnnualRate = new System.Windows.Forms.Label();
            this.labelAnnualRate = new System.Windows.Forms.Label();
            this.labelExAmount = new System.Windows.Forms.Label();
            this.textBoxAnnualRateRCI = new System.Windows.Forms.TextBox();
            this.buttonClacRegularCI = new System.Windows.Forms.Button();
            this.labelYearsDuration = new System.Windows.Forms.Label();
            this.textBoxDurationRCI = new System.Windows.Forms.TextBox();
            this.tabControlCompoundInterest = new System.Windows.Forms.TabControl();
            this.tabPageRCI = new System.Windows.Forms.TabPage();
            this.tabPageCCI = new System.Windows.Forms.TabPage();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonExit2 = new System.Windows.Forms.Button();
            this.chartRCI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCCI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            this.groupBoxCumulativeCI.SuspendLayout();
            this.groupBoxRegularCI.SuspendLayout();
            this.tabControlCompoundInterest.SuspendLayout();
            this.tabPageRCI.SuspendLayout();
            this.tabPageCCI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCCI)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularCIToolStripMenuItem,
            this.cumulativeCIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regularCIToolStripMenuItem
            // 
            this.regularCIToolStripMenuItem.Name = "regularCIToolStripMenuItem";
            this.regularCIToolStripMenuItem.Size = new System.Drawing.Size(16, 20);
            // 
            // cumulativeCIToolStripMenuItem
            // 
            this.cumulativeCIToolStripMenuItem.Name = "cumulativeCIToolStripMenuItem";
            this.cumulativeCIToolStripMenuItem.Size = new System.Drawing.Size(16, 20);
            // 
            // groupBoxCumulativeCI
            // 
            this.groupBoxCumulativeCI.Controls.Add(this.buttonExit2);
            this.groupBoxCumulativeCI.Controls.Add(this.label7);
            this.groupBoxCumulativeCI.Controls.Add(this.labelMonthlyDepositCCI);
            this.groupBoxCumulativeCI.Controls.Add(this.textBoxMonthlyDeposit);
            this.groupBoxCumulativeCI.Controls.Add(this.labelAmountCumulativeCI);
            this.groupBoxCumulativeCI.Controls.Add(this.label2);
            this.groupBoxCumulativeCI.Controls.Add(this.textBoxAmountCCI);
            this.groupBoxCumulativeCI.Controls.Add(this.label3);
            this.groupBoxCumulativeCI.Controls.Add(this.labelAnnualRateCCI);
            this.groupBoxCumulativeCI.Controls.Add(this.label5);
            this.groupBoxCumulativeCI.Controls.Add(this.textBoxAnnualRateCCI);
            this.groupBoxCumulativeCI.Controls.Add(this.buttonCCI);
            this.groupBoxCumulativeCI.Controls.Add(this.labelDurationCCI);
            this.groupBoxCumulativeCI.Controls.Add(this.textBoxDurationCCI);
            this.groupBoxCumulativeCI.Location = new System.Drawing.Point(16, 6);
            this.groupBoxCumulativeCI.Name = "groupBoxCumulativeCI";
            this.groupBoxCumulativeCI.Size = new System.Drawing.Size(339, 387);
            this.groupBoxCumulativeCI.TabIndex = 12;
            this.groupBoxCumulativeCI.TabStop = false;
            this.groupBoxCumulativeCI.Text = "Cumulative Coumpound Interest";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "ex.: 123";
            // 
            // labelMonthlyDepositCCI
            // 
            this.labelMonthlyDepositCCI.AutoSize = true;
            this.labelMonthlyDepositCCI.Location = new System.Drawing.Point(6, 226);
            this.labelMonthlyDepositCCI.Name = "labelMonthlyDepositCCI";
            this.labelMonthlyDepositCCI.Size = new System.Drawing.Size(128, 20);
            this.labelMonthlyDepositCCI.TabIndex = 11;
            this.labelMonthlyDepositCCI.Text = "Monthly deposit::";
            // 
            // textBoxMonthlyDeposit
            // 
            this.textBoxMonthlyDeposit.Location = new System.Drawing.Point(143, 224);
            this.textBoxMonthlyDeposit.Name = "textBoxMonthlyDeposit";
            this.textBoxMonthlyDeposit.Size = new System.Drawing.Size(156, 26);
            this.textBoxMonthlyDeposit.TabIndex = 12;
            // 
            // labelAmountCumulativeCI
            // 
            this.labelAmountCumulativeCI.AutoSize = true;
            this.labelAmountCumulativeCI.Location = new System.Drawing.Point(35, 48);
            this.labelAmountCumulativeCI.Name = "labelAmountCumulativeCI";
            this.labelAmountCumulativeCI.Size = new System.Drawing.Size(69, 20);
            this.labelAmountCumulativeCI.TabIndex = 1;
            this.labelAmountCumulativeCI.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Number of months";
            // 
            // textBoxAmountCCI
            // 
            this.textBoxAmountCCI.Location = new System.Drawing.Point(144, 45);
            this.textBoxAmountCCI.Name = "textBoxAmountCCI";
            this.textBoxAmountCCI.Size = new System.Drawing.Size(156, 26);
            this.textBoxAmountCCI.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "ex.: 15";
            // 
            // labelAnnualRateCCI
            // 
            this.labelAnnualRateCCI.AutoSize = true;
            this.labelAnnualRateCCI.Location = new System.Drawing.Point(7, 107);
            this.labelAnnualRateCCI.Name = "labelAnnualRateCCI";
            this.labelAnnualRateCCI.Size = new System.Drawing.Size(102, 20);
            this.labelAnnualRateCCI.TabIndex = 3;
            this.labelAnnualRateCCI.Text = "Annual Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "ex.:123";
            // 
            // textBoxAnnualRateCCI
            // 
            this.textBoxAnnualRateCCI.Location = new System.Drawing.Point(143, 101);
            this.textBoxAnnualRateCCI.Name = "textBoxAnnualRateCCI";
            this.textBoxAnnualRateCCI.Size = new System.Drawing.Size(156, 26);
            this.textBoxAnnualRateCCI.TabIndex = 4;
            // 
            // buttonCCI
            // 
            this.buttonCCI.Location = new System.Drawing.Point(193, 303);
            this.buttonCCI.Name = "buttonCCI";
            this.buttonCCI.Size = new System.Drawing.Size(106, 44);
            this.buttonCCI.TabIndex = 7;
            this.buttonCCI.Text = "Calc CCI";
            this.buttonCCI.UseVisualStyleBackColor = true;
            this.buttonCCI.Click += new System.EventHandler(this.buttonCCI_Click);
            // 
            // labelDurationCCI
            // 
            this.labelDurationCCI.AutoSize = true;
            this.labelDurationCCI.Location = new System.Drawing.Point(35, 170);
            this.labelDurationCCI.Name = "labelDurationCCI";
            this.labelDurationCCI.Size = new System.Drawing.Size(74, 20);
            this.labelDurationCCI.TabIndex = 5;
            this.labelDurationCCI.Text = "Duration:";
            // 
            // textBoxDurationCCI
            // 
            this.textBoxDurationCCI.Location = new System.Drawing.Point(144, 164);
            this.textBoxDurationCCI.Name = "textBoxDurationCCI";
            this.textBoxDurationCCI.Size = new System.Drawing.Size(156, 26);
            this.textBoxDurationCCI.TabIndex = 6;
            // 
            // groupBoxRegularCI
            // 
            this.groupBoxRegularCI.Controls.Add(this.buttonExit);
            this.groupBoxRegularCI.Controls.Add(this.labelAmount);
            this.groupBoxRegularCI.Controls.Add(this.labelExDuration);
            this.groupBoxRegularCI.Controls.Add(this.textBoxAmountRCI);
            this.groupBoxRegularCI.Controls.Add(this.labelExAnnualRate);
            this.groupBoxRegularCI.Controls.Add(this.labelAnnualRate);
            this.groupBoxRegularCI.Controls.Add(this.labelExAmount);
            this.groupBoxRegularCI.Controls.Add(this.textBoxAnnualRateRCI);
            this.groupBoxRegularCI.Controls.Add(this.buttonClacRegularCI);
            this.groupBoxRegularCI.Controls.Add(this.labelYearsDuration);
            this.groupBoxRegularCI.Controls.Add(this.textBoxDurationRCI);
            this.groupBoxRegularCI.Location = new System.Drawing.Point(16, 6);
            this.groupBoxRegularCI.Name = "groupBoxRegularCI";
            this.groupBoxRegularCI.Size = new System.Drawing.Size(330, 378);
            this.groupBoxRegularCI.TabIndex = 11;
            this.groupBoxRegularCI.TabStop = false;
            this.groupBoxRegularCI.Text = "Regular Coumpound Interest";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(61, 51);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(69, 20);
            this.labelAmount.TabIndex = 1;
            this.labelAmount.Text = "Amount:";
            // 
            // labelExDuration
            // 
            this.labelExDuration.AutoSize = true;
            this.labelExDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExDuration.Location = new System.Drawing.Point(147, 196);
            this.labelExDuration.Name = "labelExDuration";
            this.labelExDuration.Size = new System.Drawing.Size(131, 18);
            this.labelExDuration.TabIndex = 10;
            this.labelExDuration.Text = "Number of months";
            // 
            // textBoxAmountRCI
            // 
            this.textBoxAmountRCI.Location = new System.Drawing.Point(144, 45);
            this.textBoxAmountRCI.Name = "textBoxAmountRCI";
            this.textBoxAmountRCI.Size = new System.Drawing.Size(156, 26);
            this.textBoxAmountRCI.TabIndex = 2;
            // 
            // labelExAnnualRate
            // 
            this.labelExAnnualRate.AutoSize = true;
            this.labelExAnnualRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExAnnualRate.Location = new System.Drawing.Point(146, 133);
            this.labelExAnnualRate.Name = "labelExAnnualRate";
            this.labelExAnnualRate.Size = new System.Drawing.Size(43, 15);
            this.labelExAnnualRate.TabIndex = 9;
            this.labelExAnnualRate.Text = "ex.: 15";
            // 
            // labelAnnualRate
            // 
            this.labelAnnualRate.AutoSize = true;
            this.labelAnnualRate.Location = new System.Drawing.Point(35, 107);
            this.labelAnnualRate.Name = "labelAnnualRate";
            this.labelAnnualRate.Size = new System.Drawing.Size(102, 20);
            this.labelAnnualRate.TabIndex = 3;
            this.labelAnnualRate.Text = "Annual Rate:";
            // 
            // labelExAmount
            // 
            this.labelExAmount.AutoSize = true;
            this.labelExAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExAmount.Location = new System.Drawing.Point(145, 75);
            this.labelExAmount.Name = "labelExAmount";
            this.labelExAmount.Size = new System.Drawing.Size(47, 15);
            this.labelExAmount.TabIndex = 8;
            this.labelExAmount.Text = "ex.:123";
            // 
            // textBoxAnnualRateRCI
            // 
            this.textBoxAnnualRateRCI.Location = new System.Drawing.Point(143, 101);
            this.textBoxAnnualRateRCI.Name = "textBoxAnnualRateRCI";
            this.textBoxAnnualRateRCI.Size = new System.Drawing.Size(156, 26);
            this.textBoxAnnualRateRCI.TabIndex = 4;
            // 
            // buttonClacRegularCI
            // 
            this.buttonClacRegularCI.Location = new System.Drawing.Point(194, 306);
            this.buttonClacRegularCI.Name = "buttonClacRegularCI";
            this.buttonClacRegularCI.Size = new System.Drawing.Size(106, 44);
            this.buttonClacRegularCI.TabIndex = 7;
            this.buttonClacRegularCI.Text = "Calc RCI";
            this.buttonClacRegularCI.UseVisualStyleBackColor = true;
            this.buttonClacRegularCI.Click += new System.EventHandler(this.buttonClacRegularCI_Click);
            // 
            // labelYearsDuration
            // 
            this.labelYearsDuration.AutoSize = true;
            this.labelYearsDuration.Location = new System.Drawing.Point(56, 167);
            this.labelYearsDuration.Name = "labelYearsDuration";
            this.labelYearsDuration.Size = new System.Drawing.Size(74, 20);
            this.labelYearsDuration.TabIndex = 5;
            this.labelYearsDuration.Text = "Duration:";
            // 
            // textBoxDurationRCI
            // 
            this.textBoxDurationRCI.Location = new System.Drawing.Point(144, 164);
            this.textBoxDurationRCI.Name = "textBoxDurationRCI";
            this.textBoxDurationRCI.Size = new System.Drawing.Size(156, 26);
            this.textBoxDurationRCI.TabIndex = 6;
            // 
            // tabControlCompoundInterest
            // 
            this.tabControlCompoundInterest.Controls.Add(this.tabPageRCI);
            this.tabControlCompoundInterest.Controls.Add(this.tabPageCCI);
            this.tabControlCompoundInterest.Location = new System.Drawing.Point(26, 23);
            this.tabControlCompoundInterest.Name = "tabControlCompoundInterest";
            this.tabControlCompoundInterest.SelectedIndex = 0;
            this.tabControlCompoundInterest.Size = new System.Drawing.Size(845, 432);
            this.tabControlCompoundInterest.TabIndex = 13;
            // 
            // tabPageRCI
            // 
            this.tabPageRCI.Controls.Add(this.chartRCI);
            this.tabPageRCI.Controls.Add(this.groupBoxRegularCI);
            this.tabPageRCI.Location = new System.Drawing.Point(4, 29);
            this.tabPageRCI.Name = "tabPageRCI";
            this.tabPageRCI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRCI.Size = new System.Drawing.Size(837, 399);
            this.tabPageRCI.TabIndex = 0;
            this.tabPageRCI.Text = "RCI";
            this.tabPageRCI.UseVisualStyleBackColor = true;
            // 
            // tabPageCCI
            // 
            this.tabPageCCI.Controls.Add(this.chartCCI);
            this.tabPageCCI.Controls.Add(this.groupBoxCumulativeCI);
            this.tabPageCCI.Location = new System.Drawing.Point(4, 29);
            this.tabPageCCI.Name = "tabPageCCI";
            this.tabPageCCI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCCI.Size = new System.Drawing.Size(837, 399);
            this.tabPageCCI.TabIndex = 1;
            this.tabPageCCI.Text = "CCI";
            this.tabPageCCI.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(39, 306);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 44);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonExit2
            // 
            this.buttonExit2.Location = new System.Drawing.Point(28, 303);
            this.buttonExit2.Name = "buttonExit2";
            this.buttonExit2.Size = new System.Drawing.Size(106, 44);
            this.buttonExit2.TabIndex = 14;
            this.buttonExit2.Text = "Exit";
            this.buttonExit2.UseVisualStyleBackColor = true;
            this.buttonExit2.Click += new System.EventHandler(this.buttonExit2_Click);
            // 
            // chartRCI
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRCI.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRCI.Legends.Add(legend3);
            this.chartRCI.Location = new System.Drawing.Point(352, 6);
            this.chartRCI.Name = "chartRCI";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRCI.Series.Add(series3);
            this.chartRCI.Size = new System.Drawing.Size(479, 387);
            this.chartRCI.TabIndex = 12;
            this.chartRCI.Text = "RCI";
            // 
            // chartCCI
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCCI.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCCI.Legends.Add(legend4);
            this.chartCCI.Location = new System.Drawing.Point(361, 6);
            this.chartCCI.Name = "chartCCI";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartCCI.Series.Add(series4);
            this.chartCCI.Size = new System.Drawing.Size(470, 387);
            this.chartCCI.TabIndex = 13;
            this.chartCCI.Text = "CCI";
            // 
            // FormCalcCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 473);
            this.Controls.Add(this.tabControlCompoundInterest);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormCalcCI";
            this.Text = "Compound Interest";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxCumulativeCI.ResumeLayout(false);
            this.groupBoxCumulativeCI.PerformLayout();
            this.groupBoxRegularCI.ResumeLayout(false);
            this.groupBoxRegularCI.PerformLayout();
            this.tabControlCompoundInterest.ResumeLayout(false);
            this.tabPageRCI.ResumeLayout(false);
            this.tabPageCCI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCCI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regularCIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cumulativeCIToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxCumulativeCI;
        private System.Windows.Forms.Label labelAmountCumulativeCI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmountCCI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAnnualRateCCI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAnnualRateCCI;
        private System.Windows.Forms.Button buttonCCI;
        private System.Windows.Forms.Label labelDurationCCI;
        private System.Windows.Forms.TextBox textBoxDurationCCI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMonthlyDepositCCI;
        private System.Windows.Forms.TextBox textBoxMonthlyDeposit;
        private System.Windows.Forms.GroupBox groupBoxRegularCI;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelExDuration;
        private System.Windows.Forms.TextBox textBoxAmountRCI;
        private System.Windows.Forms.Label labelExAnnualRate;
        private System.Windows.Forms.Label labelAnnualRate;
        private System.Windows.Forms.Label labelExAmount;
        private System.Windows.Forms.TextBox textBoxAnnualRateRCI;
        private System.Windows.Forms.Button buttonClacRegularCI;
        private System.Windows.Forms.Label labelYearsDuration;
        private System.Windows.Forms.TextBox textBoxDurationRCI;
        private System.Windows.Forms.TabControl tabControlCompoundInterest;
        private System.Windows.Forms.TabPage tabPageRCI;
        private System.Windows.Forms.TabPage tabPageCCI;
        private System.Windows.Forms.Button buttonExit2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRCI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCCI;
    }
}