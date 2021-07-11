
namespace Bitcoin_Dashboard
{
    partial class UserControl3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBlockBericht = new System.Windows.Forms.Button();
            this.lblNumberOfTx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxBlockbericht = new System.Windows.Forms.TextBox();
            this.lblValueSent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBlockheight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBlockBericht
            // 
            this.btnBlockBericht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlockBericht.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockBericht.ForeColor = System.Drawing.Color.White;
            this.btnBlockBericht.Location = new System.Drawing.Point(500, 45);
            this.btnBlockBericht.Name = "btnBlockBericht";
            this.btnBlockBericht.Size = new System.Drawing.Size(105, 25);
            this.btnBlockBericht.TabIndex = 0;
            this.btnBlockBericht.Text = "Block Bericht";
            this.btnBlockBericht.UseVisualStyleBackColor = true;
            this.btnBlockBericht.Click += new System.EventHandler(this.btnBlockBericht_Click);
            // 
            // lblNumberOfTx
            // 
            this.lblNumberOfTx.AutoSize = true;
            this.lblNumberOfTx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTx.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfTx.Location = new System.Drawing.Point(47, 48);
            this.lblNumberOfTx.Name = "lblNumberOfTx";
            this.lblNumberOfTx.Size = new System.Drawing.Size(163, 17);
            this.lblNumberOfTx.TabIndex = 1;
            this.lblNumberOfTx.Text = "Number of Transactions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "__________";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(50, 110);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Outputs";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Inputs";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(550, 310);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // textBoxBlockbericht
            // 
            this.textBoxBlockbericht.Location = new System.Drawing.Point(354, 48);
            this.textBoxBlockbericht.Name = "textBoxBlockbericht";
            this.textBoxBlockbericht.Size = new System.Drawing.Size(140, 20);
            this.textBoxBlockbericht.TabIndex = 4;
            // 
            // lblValueSent
            // 
            this.lblValueSent.AutoSize = true;
            this.lblValueSent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueSent.ForeColor = System.Drawing.Color.White;
            this.lblValueSent.Location = new System.Drawing.Point(47, 80);
            this.lblValueSent.Name = "lblValueSent";
            this.lblValueSent.Size = new System.Drawing.Size(79, 17);
            this.lblValueSent.TabIndex = 5;
            this.lblValueSent.Text = "Value sent:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "__________";
            // 
            // lblBlockheight
            // 
            this.lblBlockheight.AutoSize = true;
            this.lblBlockheight.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockheight.ForeColor = System.Drawing.Color.White;
            this.lblBlockheight.Location = new System.Drawing.Point(47, 16);
            this.lblBlockheight.Name = "lblBlockheight";
            this.lblBlockheight.Size = new System.Drawing.Size(139, 17);
            this.lblBlockheight.TabIndex = 7;
            this.lblBlockheight.Text = "Current Blockheight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "__________";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBlockheight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValueSent);
            this.Controls.Add(this.textBoxBlockbericht);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfTx);
            this.Controls.Add(this.btnBlockBericht);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(670, 439);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlockBericht;
        private System.Windows.Forms.Label lblNumberOfTx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxBlockbericht;
        private System.Windows.Forms.Label lblValueSent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBlockheight;
        private System.Windows.Forms.Label label3;
    }
}
