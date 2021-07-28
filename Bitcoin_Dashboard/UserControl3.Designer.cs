
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBlockBericht = new System.Windows.Forms.Button();
            this.lblNumberOfTx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxBlockbericht = new System.Windows.Forms.TextBox();
            this.lblValueSent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBlockheight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_s1_c1 = new System.Windows.Forms.Label();
            this.lbl_s1_c2 = new System.Windows.Forms.Label();
            this.lbl_s1_c3 = new System.Windows.Forms.Label();
            this.lbl_s1_c4 = new System.Windows.Forms.Label();
            this.lbl_s1_c5 = new System.Windows.Forms.Label();
            this.lbl_s1_c6 = new System.Windows.Forms.Label();
            this.lbl_s1_c7 = new System.Windows.Forms.Label();
            this.lbl_s1_c8 = new System.Windows.Forms.Label();
            this.lbl_s1_c9 = new System.Windows.Forms.Label();
            this.lbl_s2_c1 = new System.Windows.Forms.Label();
            this.lbl_s2_c2 = new System.Windows.Forms.Label();
            this.lbl_s2_c3 = new System.Windows.Forms.Label();
            this.lbl_s2_c4 = new System.Windows.Forms.Label();
            this.lbl_s2_c5 = new System.Windows.Forms.Label();
            this.lbl_s2_c6 = new System.Windows.Forms.Label();
            this.lbl_s2_c7 = new System.Windows.Forms.Label();
            this.lbl_s2_c8 = new System.Windows.Forms.Label();
            this.lbl_s2_c9 = new System.Windows.Forms.Label();
            this.lbl_s3_c5 = new System.Windows.Forms.Label();
            this.lbl_s3_c3 = new System.Windows.Forms.Label();
            this.lbl_s3_c7 = new System.Windows.Forms.Label();
            this.lbl_s3_c8 = new System.Windows.Forms.Label();
            this.lbl_s3_c4 = new System.Windows.Forms.Label();
            this.lbl_s3_c9 = new System.Windows.Forms.Label();
            this.lbl_s3_c11 = new System.Windows.Forms.Label();
            this.lbl_s3_c10 = new System.Windows.Forms.Label();
            this.lbl_s3_c6 = new System.Windows.Forms.Label();
            this.lbl_s3_c2 = new System.Windows.Forms.Label();
            this.lbl_s3_c1 = new System.Windows.Forms.Label();
            this.lbl_s1_c10 = new System.Windows.Forms.Label();
            this.lbl_s1_c11 = new System.Windows.Forms.Label();
            this.lbl_s2_c10 = new System.Windows.Forms.Label();
            this.lbl_s2_c11 = new System.Windows.Forms.Label();
            this.lbl_s1_c12 = new System.Windows.Forms.Label();
            this.lbl_s1_c13 = new System.Windows.Forms.Label();
            this.lbl_s2_c12 = new System.Windows.Forms.Label();
            this.lbl_s2_c13 = new System.Windows.Forms.Label();
            this.lbl_s3_c12 = new System.Windows.Forms.Label();
            this.lbl_s3_c13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBlockBericht
            // 
            this.btnBlockBericht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlockBericht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockBericht.ForeColor = System.Drawing.Color.White;
            this.btnBlockBericht.Location = new System.Drawing.Point(500, 45);
            this.btnBlockBericht.Name = "btnBlockBericht";
            this.btnBlockBericht.Size = new System.Drawing.Size(105, 25);
            this.btnBlockBericht.TabIndex = 0;
            this.btnBlockBericht.Text = "Block report";
            this.btnBlockBericht.UseVisualStyleBackColor = true;
            this.btnBlockBericht.Click += new System.EventHandler(this.btnBlockBericht_Click);
            // 
            // lblNumberOfTx
            // 
            this.lblNumberOfTx.AutoSize = true;
            this.lblNumberOfTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTx.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfTx.Location = new System.Drawing.Point(47, 48);
            this.lblNumberOfTx.Name = "lblNumberOfTx";
            this.lblNumberOfTx.Size = new System.Drawing.Size(154, 16);
            this.lblNumberOfTx.TabIndex = 1;
            this.lblNumberOfTx.Text = "Number of Transactions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "__________";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(50, 110);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Outputs";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Inputs";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
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
            this.lblValueSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueSent.ForeColor = System.Drawing.Color.White;
            this.lblValueSent.Location = new System.Drawing.Point(47, 80);
            this.lblValueSent.Name = "lblValueSent";
            this.lblValueSent.Size = new System.Drawing.Size(74, 16);
            this.lblValueSent.TabIndex = 5;
            this.lblValueSent.Text = "Value sent:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "__________";
            // 
            // lblBlockheight
            // 
            this.lblBlockheight.AutoSize = true;
            this.lblBlockheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockheight.ForeColor = System.Drawing.Color.White;
            this.lblBlockheight.Location = new System.Drawing.Point(47, 16);
            this.lblBlockheight.Name = "lblBlockheight";
            this.lblBlockheight.Size = new System.Drawing.Size(126, 16);
            this.lblBlockheight.TabIndex = 7;
            this.lblBlockheight.Text = "Current Blockheight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "__________";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(350, 80);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(204, 16);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "____________________________";
            this.lblError.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 13;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.310066F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.55687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.55687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.55687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.55687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.55687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.55687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.55687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.55687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.55687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.55687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.559772F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.561472F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c13, 12, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c11, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c10, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c11, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c9, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c8, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c7, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c9, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c10, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c12, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s1_c13, 12, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c12, 11, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s2_c13, 12, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_s3_c12, 11, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 435);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(668, 102);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // lbl_s1_c1
            // 
            this.lbl_s1_c1.AutoSize = true;
            this.lbl_s1_c1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c1.Location = new System.Drawing.Point(4, 1);
            this.lbl_s1_c1.Name = "lbl_s1_c1";
            this.lbl_s1_c1.Size = new System.Drawing.Size(54, 32);
            this.lbl_s1_c1.TabIndex = 0;
            this.lbl_s1_c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s1_c2
            // 
            this.lbl_s1_c2.AutoSize = true;
            this.lbl_s1_c2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c2.Location = new System.Drawing.Point(65, 1);
            this.lbl_s1_c2.Name = "lbl_s1_c2";
            this.lbl_s1_c2.Size = new System.Drawing.Size(43, 32);
            this.lbl_s1_c2.TabIndex = 1;
            this.lbl_s1_c2.Text = "0";
            this.lbl_s1_c2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s1_c3
            // 
            this.lbl_s1_c3.AutoSize = true;
            this.lbl_s1_c3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c3.Location = new System.Drawing.Point(115, 1);
            this.lbl_s1_c3.Name = "lbl_s1_c3";
            this.lbl_s1_c3.Size = new System.Drawing.Size(43, 32);
            this.lbl_s1_c3.TabIndex = 2;
            this.lbl_s1_c3.Text = "1";
            this.lbl_s1_c3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s1_c4
            // 
            this.lbl_s1_c4.AutoSize = true;
            this.lbl_s1_c4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c4.Location = new System.Drawing.Point(165, 1);
            this.lbl_s1_c4.Name = "lbl_s1_c4";
            this.lbl_s1_c4.Size = new System.Drawing.Size(43, 32);
            this.lbl_s1_c4.TabIndex = 3;
            this.lbl_s1_c4.Text = "2";
            this.lbl_s1_c4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s1_c5
            // 
            this.lbl_s1_c5.AutoSize = true;
            this.lbl_s1_c5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c5.Location = new System.Drawing.Point(215, 1);
            this.lbl_s1_c5.Name = "lbl_s1_c5";
            this.lbl_s1_c5.Size = new System.Drawing.Size(43, 32);
            this.lbl_s1_c5.TabIndex = 4;
            this.lbl_s1_c5.Text = "3";
            this.lbl_s1_c5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s1_c6
            // 
            this.lbl_s1_c6.AutoSize = true;
            this.lbl_s1_c6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c6.Location = new System.Drawing.Point(265, 1);
            this.lbl_s1_c6.Name = "lbl_s1_c6";
            this.lbl_s1_c6.Size = new System.Drawing.Size(43, 32);
            this.lbl_s1_c6.TabIndex = 5;
            this.lbl_s1_c6.Text = "4";
            this.lbl_s1_c6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s1_c7
            // 
            this.lbl_s1_c7.AutoSize = true;
            this.lbl_s1_c7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c7.Location = new System.Drawing.Point(315, 1);
            this.lbl_s1_c7.Name = "lbl_s1_c7";
            this.lbl_s1_c7.Size = new System.Drawing.Size(43, 32);
            this.lbl_s1_c7.TabIndex = 6;
            this.lbl_s1_c7.Text = "5";
            this.lbl_s1_c7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_s1_c7.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbl_s1_c8
            // 
            this.lbl_s1_c8.AutoSize = true;
            this.lbl_s1_c8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c8.Location = new System.Drawing.Point(365, 1);
            this.lbl_s1_c8.Name = "lbl_s1_c8";
            this.lbl_s1_c8.Size = new System.Drawing.Size(43, 32);
            this.lbl_s1_c8.TabIndex = 7;
            this.lbl_s1_c8.Text = "6";
            this.lbl_s1_c8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s1_c9
            // 
            this.lbl_s1_c9.AutoSize = true;
            this.lbl_s1_c9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c9.Location = new System.Drawing.Point(415, 1);
            this.lbl_s1_c9.Name = "lbl_s1_c9";
            this.lbl_s1_c9.Size = new System.Drawing.Size(43, 32);
            this.lbl_s1_c9.TabIndex = 8;
            this.lbl_s1_c9.Text = "7";
            this.lbl_s1_c9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c1
            // 
            this.lbl_s2_c1.AutoSize = true;
            this.lbl_s2_c1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c1.Location = new System.Drawing.Point(4, 34);
            this.lbl_s2_c1.Name = "lbl_s2_c1";
            this.lbl_s2_c1.Size = new System.Drawing.Size(54, 32);
            this.lbl_s2_c1.TabIndex = 9;
            this.lbl_s2_c1.Text = "Inputs";
            this.lbl_s2_c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c2
            // 
            this.lbl_s2_c2.AutoSize = true;
            this.lbl_s2_c2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c2.Location = new System.Drawing.Point(65, 34);
            this.lbl_s2_c2.Name = "lbl_s2_c2";
            this.lbl_s2_c2.Size = new System.Drawing.Size(43, 32);
            this.lbl_s2_c2.TabIndex = 10;
            this.lbl_s2_c2.Text = "_____";
            this.lbl_s2_c2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c3
            // 
            this.lbl_s2_c3.AutoSize = true;
            this.lbl_s2_c3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c3.Location = new System.Drawing.Point(115, 34);
            this.lbl_s2_c3.Name = "lbl_s2_c3";
            this.lbl_s2_c3.Size = new System.Drawing.Size(43, 32);
            this.lbl_s2_c3.TabIndex = 11;
            this.lbl_s2_c3.Text = "_____";
            this.lbl_s2_c3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c4
            // 
            this.lbl_s2_c4.AutoSize = true;
            this.lbl_s2_c4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c4.Location = new System.Drawing.Point(165, 34);
            this.lbl_s2_c4.Name = "lbl_s2_c4";
            this.lbl_s2_c4.Size = new System.Drawing.Size(43, 32);
            this.lbl_s2_c4.TabIndex = 12;
            this.lbl_s2_c4.Text = "_____";
            this.lbl_s2_c4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c5
            // 
            this.lbl_s2_c5.AutoSize = true;
            this.lbl_s2_c5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c5.Location = new System.Drawing.Point(215, 34);
            this.lbl_s2_c5.Name = "lbl_s2_c5";
            this.lbl_s2_c5.Size = new System.Drawing.Size(43, 32);
            this.lbl_s2_c5.TabIndex = 13;
            this.lbl_s2_c5.Text = "_____";
            this.lbl_s2_c5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c6
            // 
            this.lbl_s2_c6.AutoSize = true;
            this.lbl_s2_c6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c6.Location = new System.Drawing.Point(265, 34);
            this.lbl_s2_c6.Name = "lbl_s2_c6";
            this.lbl_s2_c6.Size = new System.Drawing.Size(43, 32);
            this.lbl_s2_c6.TabIndex = 14;
            this.lbl_s2_c6.Text = "_____";
            this.lbl_s2_c6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c7
            // 
            this.lbl_s2_c7.AutoSize = true;
            this.lbl_s2_c7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c7.Location = new System.Drawing.Point(315, 34);
            this.lbl_s2_c7.Name = "lbl_s2_c7";
            this.lbl_s2_c7.Size = new System.Drawing.Size(43, 32);
            this.lbl_s2_c7.TabIndex = 15;
            this.lbl_s2_c7.Text = "_____";
            this.lbl_s2_c7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c8
            // 
            this.lbl_s2_c8.AutoSize = true;
            this.lbl_s2_c8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c8.Location = new System.Drawing.Point(365, 34);
            this.lbl_s2_c8.Name = "lbl_s2_c8";
            this.lbl_s2_c8.Size = new System.Drawing.Size(43, 32);
            this.lbl_s2_c8.TabIndex = 16;
            this.lbl_s2_c8.Text = "_____";
            this.lbl_s2_c8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c9
            // 
            this.lbl_s2_c9.AutoSize = true;
            this.lbl_s2_c9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c9.Location = new System.Drawing.Point(415, 34);
            this.lbl_s2_c9.Name = "lbl_s2_c9";
            this.lbl_s2_c9.Size = new System.Drawing.Size(43, 32);
            this.lbl_s2_c9.TabIndex = 17;
            this.lbl_s2_c9.Text = "_____";
            this.lbl_s2_c9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s3_c5
            // 
            this.lbl_s3_c5.AutoSize = true;
            this.lbl_s3_c5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c5.Location = new System.Drawing.Point(215, 67);
            this.lbl_s3_c5.Name = "lbl_s3_c5";
            this.lbl_s3_c5.Size = new System.Drawing.Size(43, 34);
            this.lbl_s3_c5.TabIndex = 18;
            this.lbl_s3_c5.Text = "_____";
            this.lbl_s3_c5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_s3_c5.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_s3_c3
            // 
            this.lbl_s3_c3.AutoSize = true;
            this.lbl_s3_c3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c3.Location = new System.Drawing.Point(115, 67);
            this.lbl_s3_c3.Name = "lbl_s3_c3";
            this.lbl_s3_c3.Size = new System.Drawing.Size(43, 34);
            this.lbl_s3_c3.TabIndex = 19;
            this.lbl_s3_c3.Text = "_____";
            this.lbl_s3_c3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s3_c7
            // 
            this.lbl_s3_c7.AutoSize = true;
            this.lbl_s3_c7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c7.Location = new System.Drawing.Point(315, 67);
            this.lbl_s3_c7.Name = "lbl_s3_c7";
            this.lbl_s3_c7.Size = new System.Drawing.Size(43, 34);
            this.lbl_s3_c7.TabIndex = 20;
            this.lbl_s3_c7.Text = "_____";
            this.lbl_s3_c7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s3_c8
            // 
            this.lbl_s3_c8.AutoSize = true;
            this.lbl_s3_c8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c8.Location = new System.Drawing.Point(365, 67);
            this.lbl_s3_c8.Name = "lbl_s3_c8";
            this.lbl_s3_c8.Size = new System.Drawing.Size(43, 34);
            this.lbl_s3_c8.TabIndex = 21;
            this.lbl_s3_c8.Text = "_____";
            this.lbl_s3_c8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s3_c4
            // 
            this.lbl_s3_c4.AutoSize = true;
            this.lbl_s3_c4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c4.Location = new System.Drawing.Point(165, 67);
            this.lbl_s3_c4.Name = "lbl_s3_c4";
            this.lbl_s3_c4.Size = new System.Drawing.Size(43, 34);
            this.lbl_s3_c4.TabIndex = 22;
            this.lbl_s3_c4.Text = "_____";
            this.lbl_s3_c4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s3_c9
            // 
            this.lbl_s3_c9.AutoSize = true;
            this.lbl_s3_c9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c9.Location = new System.Drawing.Point(415, 67);
            this.lbl_s3_c9.Name = "lbl_s3_c9";
            this.lbl_s3_c9.Size = new System.Drawing.Size(43, 34);
            this.lbl_s3_c9.TabIndex = 23;
            this.lbl_s3_c9.Text = "_____";
            this.lbl_s3_c9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s3_c11
            // 
            this.lbl_s3_c11.AutoSize = true;
            this.lbl_s3_c11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c11.Location = new System.Drawing.Point(515, 67);
            this.lbl_s3_c11.Name = "lbl_s3_c11";
            this.lbl_s3_c11.Size = new System.Drawing.Size(43, 34);
            this.lbl_s3_c11.TabIndex = 24;
            this.lbl_s3_c11.Text = "_____";
            this.lbl_s3_c11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s3_c10
            // 
            this.lbl_s3_c10.AutoSize = true;
            this.lbl_s3_c10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c10.Location = new System.Drawing.Point(465, 67);
            this.lbl_s3_c10.Name = "lbl_s3_c10";
            this.lbl_s3_c10.Size = new System.Drawing.Size(43, 34);
            this.lbl_s3_c10.TabIndex = 25;
            this.lbl_s3_c10.Text = "_____";
            this.lbl_s3_c10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s3_c6
            // 
            this.lbl_s3_c6.AutoSize = true;
            this.lbl_s3_c6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c6.Location = new System.Drawing.Point(265, 67);
            this.lbl_s3_c6.Name = "lbl_s3_c6";
            this.lbl_s3_c6.Size = new System.Drawing.Size(43, 34);
            this.lbl_s3_c6.TabIndex = 26;
            this.lbl_s3_c6.Text = "_____";
            this.lbl_s3_c6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s3_c2
            // 
            this.lbl_s3_c2.AutoSize = true;
            this.lbl_s3_c2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c2.Location = new System.Drawing.Point(65, 67);
            this.lbl_s3_c2.Name = "lbl_s3_c2";
            this.lbl_s3_c2.Size = new System.Drawing.Size(43, 34);
            this.lbl_s3_c2.TabIndex = 27;
            this.lbl_s3_c2.Text = "_____";
            this.lbl_s3_c2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s3_c1
            // 
            this.lbl_s3_c1.AutoSize = true;
            this.lbl_s3_c1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c1.Location = new System.Drawing.Point(4, 67);
            this.lbl_s3_c1.Name = "lbl_s3_c1";
            this.lbl_s3_c1.Size = new System.Drawing.Size(54, 34);
            this.lbl_s3_c1.TabIndex = 28;
            this.lbl_s3_c1.Text = "Outputs";
            this.lbl_s3_c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s1_c10
            // 
            this.lbl_s1_c10.AutoSize = true;
            this.lbl_s1_c10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c10.Location = new System.Drawing.Point(465, 1);
            this.lbl_s1_c10.Name = "lbl_s1_c10";
            this.lbl_s1_c10.Size = new System.Drawing.Size(43, 32);
            this.lbl_s1_c10.TabIndex = 29;
            this.lbl_s1_c10.Text = "8";
            this.lbl_s1_c10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s1_c11
            // 
            this.lbl_s1_c11.AutoSize = true;
            this.lbl_s1_c11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c11.Location = new System.Drawing.Point(515, 1);
            this.lbl_s1_c11.Name = "lbl_s1_c11";
            this.lbl_s1_c11.Size = new System.Drawing.Size(43, 32);
            this.lbl_s1_c11.TabIndex = 30;
            this.lbl_s1_c11.Text = "9";
            this.lbl_s1_c11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c10
            // 
            this.lbl_s2_c10.AutoSize = true;
            this.lbl_s2_c10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c10.Location = new System.Drawing.Point(465, 34);
            this.lbl_s2_c10.Name = "lbl_s2_c10";
            this.lbl_s2_c10.Size = new System.Drawing.Size(43, 32);
            this.lbl_s2_c10.TabIndex = 32;
            this.lbl_s2_c10.Text = "_____";
            this.lbl_s2_c10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c11
            // 
            this.lbl_s2_c11.AutoSize = true;
            this.lbl_s2_c11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c11.Location = new System.Drawing.Point(515, 34);
            this.lbl_s2_c11.Name = "lbl_s2_c11";
            this.lbl_s2_c11.Size = new System.Drawing.Size(43, 32);
            this.lbl_s2_c11.TabIndex = 33;
            this.lbl_s2_c11.Text = "_____";
            this.lbl_s2_c11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s1_c12
            // 
            this.lbl_s1_c12.AutoSize = true;
            this.lbl_s1_c12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c12.Location = new System.Drawing.Point(565, 1);
            this.lbl_s1_c12.Name = "lbl_s1_c12";
            this.lbl_s1_c12.Size = new System.Drawing.Size(43, 32);
            this.lbl_s1_c12.TabIndex = 34;
            this.lbl_s1_c12.Text = "10";
            this.lbl_s1_c12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s1_c13
            // 
            this.lbl_s1_c13.AutoSize = true;
            this.lbl_s1_c13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s1_c13.Location = new System.Drawing.Point(615, 1);
            this.lbl_s1_c13.Name = "lbl_s1_c13";
            this.lbl_s1_c13.Size = new System.Drawing.Size(49, 32);
            this.lbl_s1_c13.TabIndex = 35;
            this.lbl_s1_c13.Text = "> 10";
            this.lbl_s1_c13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c12
            // 
            this.lbl_s2_c12.AutoSize = true;
            this.lbl_s2_c12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c12.Location = new System.Drawing.Point(565, 34);
            this.lbl_s2_c12.Name = "lbl_s2_c12";
            this.lbl_s2_c12.Size = new System.Drawing.Size(43, 32);
            this.lbl_s2_c12.TabIndex = 36;
            this.lbl_s2_c12.Text = "_____";
            this.lbl_s2_c12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s2_c13
            // 
            this.lbl_s2_c13.AutoSize = true;
            this.lbl_s2_c13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s2_c13.Location = new System.Drawing.Point(615, 34);
            this.lbl_s2_c13.Name = "lbl_s2_c13";
            this.lbl_s2_c13.Size = new System.Drawing.Size(49, 32);
            this.lbl_s2_c13.TabIndex = 37;
            this.lbl_s2_c13.Text = "_____";
            this.lbl_s2_c13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s3_c12
            // 
            this.lbl_s3_c12.AutoSize = true;
            this.lbl_s3_c12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c12.Location = new System.Drawing.Point(565, 67);
            this.lbl_s3_c12.Name = "lbl_s3_c12";
            this.lbl_s3_c12.Size = new System.Drawing.Size(43, 34);
            this.lbl_s3_c12.TabIndex = 38;
            this.lbl_s3_c12.Text = "_____";
            this.lbl_s3_c12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s3_c13
            // 
            this.lbl_s3_c13.AutoSize = true;
            this.lbl_s3_c13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_s3_c13.Location = new System.Drawing.Point(615, 67);
            this.lbl_s3_c13.Name = "lbl_s3_c13";
            this.lbl_s3_c13.Size = new System.Drawing.Size(49, 34);
            this.lbl_s3_c13.TabIndex = 39;
            this.lbl_s3_c13.Text = "_____";
            this.lbl_s3_c13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblError);
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
            this.Size = new System.Drawing.Size(742, 558);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_s3_c6;
        private System.Windows.Forms.Label lbl_s3_c10;
        private System.Windows.Forms.Label lbl_s3_c11;
        private System.Windows.Forms.Label lbl_s3_c9;
        private System.Windows.Forms.Label lbl_s3_c4;
        private System.Windows.Forms.Label lbl_s3_c8;
        private System.Windows.Forms.Label lbl_s3_c7;
        private System.Windows.Forms.Label lbl_s3_c3;
        private System.Windows.Forms.Label lbl_s3_c5;
        private System.Windows.Forms.Label lbl_s2_c9;
        private System.Windows.Forms.Label lbl_s2_c8;
        private System.Windows.Forms.Label lbl_s2_c7;
        private System.Windows.Forms.Label lbl_s2_c6;
        private System.Windows.Forms.Label lbl_s2_c5;
        private System.Windows.Forms.Label lbl_s2_c4;
        private System.Windows.Forms.Label lbl_s2_c3;
        private System.Windows.Forms.Label lbl_s2_c2;
        private System.Windows.Forms.Label lbl_s2_c1;
        private System.Windows.Forms.Label lbl_s1_c9;
        private System.Windows.Forms.Label lbl_s1_c8;
        private System.Windows.Forms.Label lbl_s1_c7;
        private System.Windows.Forms.Label lbl_s1_c6;
        private System.Windows.Forms.Label lbl_s1_c5;
        private System.Windows.Forms.Label lbl_s1_c4;
        private System.Windows.Forms.Label lbl_s1_c3;
        private System.Windows.Forms.Label lbl_s1_c2;
        private System.Windows.Forms.Label lbl_s1_c1;
        private System.Windows.Forms.Label lbl_s2_c11;
        private System.Windows.Forms.Label lbl_s2_c10;
        private System.Windows.Forms.Label lbl_s1_c11;
        private System.Windows.Forms.Label lbl_s3_c1;
        private System.Windows.Forms.Label lbl_s3_c2;
        private System.Windows.Forms.Label lbl_s1_c10;
        private System.Windows.Forms.Label lbl_s3_c13;
        private System.Windows.Forms.Label lbl_s1_c12;
        private System.Windows.Forms.Label lbl_s1_c13;
        private System.Windows.Forms.Label lbl_s2_c12;
        private System.Windows.Forms.Label lbl_s2_c13;
        private System.Windows.Forms.Label lbl_s3_c12;
    }
}
