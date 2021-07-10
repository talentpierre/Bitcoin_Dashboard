
namespace Bitcoin_Dashboard
{
    partial class UserControl2
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelOutput_Groesser10 = new System.Windows.Forms.Label();
            this.labelOutput_3to10 = new System.Windows.Forms.Label();
            this.labelOutput_2 = new System.Windows.Forms.Label();
            this.labelOutput_1 = new System.Windows.Forms.Label();
            this.labelOutput_0 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(113, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(113, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(288, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(357, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(424, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(502, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "3 - 10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(581, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "> 10";
            // 
            // labelOutput_Groesser10
            // 
            this.labelOutput_Groesser10.AutoSize = true;
            this.labelOutput_Groesser10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelOutput_Groesser10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOutput_Groesser10.Location = new System.Drawing.Point(581, 76);
            this.labelOutput_Groesser10.Name = "labelOutput_Groesser10";
            this.labelOutput_Groesser10.Size = new System.Drawing.Size(32, 16);
            this.labelOutput_Groesser10.TabIndex = 13;
            this.labelOutput_Groesser10.Text = "> 10";
            // 
            // labelOutput_3to10
            // 
            this.labelOutput_3to10.AutoSize = true;
            this.labelOutput_3to10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelOutput_3to10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOutput_3to10.Location = new System.Drawing.Point(502, 76);
            this.labelOutput_3to10.Name = "labelOutput_3to10";
            this.labelOutput_3to10.Size = new System.Drawing.Size(39, 16);
            this.labelOutput_3to10.TabIndex = 12;
            this.labelOutput_3to10.Text = "3 - 10";
            // 
            // labelOutput_2
            // 
            this.labelOutput_2.AutoSize = true;
            this.labelOutput_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelOutput_2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOutput_2.Location = new System.Drawing.Point(424, 76);
            this.labelOutput_2.Name = "labelOutput_2";
            this.labelOutput_2.Size = new System.Drawing.Size(15, 16);
            this.labelOutput_2.TabIndex = 11;
            this.labelOutput_2.Text = "2";
            // 
            // labelOutput_1
            // 
            this.labelOutput_1.AutoSize = true;
            this.labelOutput_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelOutput_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOutput_1.Location = new System.Drawing.Point(357, 76);
            this.labelOutput_1.Name = "labelOutput_1";
            this.labelOutput_1.Size = new System.Drawing.Size(15, 16);
            this.labelOutput_1.TabIndex = 10;
            this.labelOutput_1.Text = "1";
            // 
            // labelOutput_0
            // 
            this.labelOutput_0.AutoSize = true;
            this.labelOutput_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelOutput_0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOutput_0.Location = new System.Drawing.Point(288, 76);
            this.labelOutput_0.Name = "labelOutput_0";
            this.labelOutput_0.Size = new System.Drawing.Size(15, 16);
            this.labelOutput_0.TabIndex = 9;
            this.labelOutput_0.Text = "0";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 141);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Outputs";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Inputs";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(586, 209);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            title1.Name = "Title1";
            title1.Text = "Outputs and Inputs";
            this.chart1.Titles.Add(title1);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelOutput_Groesser10);
            this.Controls.Add(this.labelOutput_3to10);
            this.Controls.Add(this.labelOutput_2);
            this.Controls.Add(this.labelOutput_1);
            this.Controls.Add(this.labelOutput_0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(670, 378);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelOutput_Groesser10;
        private System.Windows.Forms.Label labelOutput_3to10;
        private System.Windows.Forms.Label labelOutput_2;
        private System.Windows.Forms.Label labelOutput_1;
        private System.Windows.Forms.Label labelOutput_0;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}
