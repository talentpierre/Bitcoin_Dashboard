namespace Bitcoin_Dashboard
{
    partial class MainWindow
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnFees = new System.Windows.Forms.Button();
            this.btnBlocksuche = new System.Windows.Forms.Button();
            this.btnHardware = new System.Windows.Forms.Button();
            this.activeSidebarPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userControl21 = new Bitcoin_Dashboard.UserControl2();
            this.userControl31 = new Bitcoin_Dashboard.UserControl3();
            this.page21 = new Bitcoin_Dashboard.Page2();
            this.userControl11 = new Bitcoin_Dashboard.UserControl1();
            this.TopPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TopPanel.Controls.Add(this.button5);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(933, 68);
            this.TopPanel.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(877, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 1;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button5_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitcoin Node Explorer";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LeftPanel.Controls.Add(this.panel1);
            this.LeftPanel.Controls.Add(this.btnChange);
            this.LeftPanel.Controls.Add(this.btnFees);
            this.LeftPanel.Controls.Add(this.btnBlocksuche);
            this.LeftPanel.Controls.Add(this.btnHardware);
            this.LeftPanel.Controls.Add(this.activeSidebarPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 68);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(190, 558);
            this.LeftPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(200, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 470);
            this.panel1.TabIndex = 5;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(15, 195);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(170, 45);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "___Wechselkurs";
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnFees
            // 
            this.btnFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFees.Location = new System.Drawing.Point(15, 145);
            this.btnFees.Name = "btnFees";
            this.btnFees.Size = new System.Drawing.Size(170, 45);
            this.btnFees.TabIndex = 5;
            this.btnFees.Text = "___Fees";
            this.btnFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFees.UseVisualStyleBackColor = true;
            this.btnFees.Click += new System.EventHandler(this.btnFees_Click);
            // 
            // btnBlocksuche
            // 
            this.btnBlocksuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlocksuche.Location = new System.Drawing.Point(15, 95);
            this.btnBlocksuche.Name = "btnBlocksuche";
            this.btnBlocksuche.Size = new System.Drawing.Size(170, 45);
            this.btnBlocksuche.TabIndex = 4;
            this.btnBlocksuche.Text = "___Blocksuche";
            this.btnBlocksuche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlocksuche.UseVisualStyleBackColor = true;
            this.btnBlocksuche.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHardware
            // 
            this.btnHardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardware.Location = new System.Drawing.Point(15, 45);
            this.btnHardware.Name = "btnHardware";
            this.btnHardware.Size = new System.Drawing.Size(170, 45);
            this.btnHardware.TabIndex = 3;
            this.btnHardware.Text = "___Hardware Details";
            this.btnHardware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHardware.UseVisualStyleBackColor = true;
            this.btnHardware.Click += new System.EventHandler(this.button1_Click);
            // 
            // activeSidebarPanel
            // 
            this.activeSidebarPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.activeSidebarPanel.Location = new System.Drawing.Point(5, 50);
            this.activeSidebarPanel.Name = "activeSidebarPanel";
            this.activeSidebarPanel.Size = new System.Drawing.Size(5, 35);
            this.activeSidebarPanel.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(388, 184);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(483, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.userControl21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl21.Location = new System.Drawing.Point(191, 68);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(742, 558);
            this.userControl21.TabIndex = 7;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.OrangeRed;
            this.userControl31.Location = new System.Drawing.Point(191, 68);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(742, 558);
            this.userControl31.TabIndex = 6;
            // 
            // page21
            // 
            this.page21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.page21.Location = new System.Drawing.Point(191, 68);
            this.page21.Name = "page21";
            this.page21.Size = new System.Drawing.Size(742, 558);
            this.page21.TabIndex = 5;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.userControl11.Location = new System.Drawing.Point(191, 68);
            this.userControl11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(742, 558);
            this.userControl11.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(933, 626);
            this.ControlBox = false;
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.page21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnFees;
        private System.Windows.Forms.Button btnBlocksuche;
        private System.Windows.Forms.Button btnHardware;
        private System.Windows.Forms.Panel activeSidebarPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private UserControl1 userControl11;
        private Page2 page21;
        private UserControl3 userControl31;
        private UserControl2 userControl21;
    }
}

