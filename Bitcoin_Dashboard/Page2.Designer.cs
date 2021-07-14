namespace Bitcoin_Dashboard
{
    partial class Page2
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
            this.btnSSH = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblArmClock = new System.Windows.Forms.Label();
            this.lblTemperatur = new System.Windows.Forms.Label();
            this.lblCpuTakt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSSH
            // 
            this.btnSSH.Location = new System.Drawing.Point(480, 42);
            this.btnSSH.Name = "btnSSH";
            this.btnSSH.Size = new System.Drawing.Size(75, 23);
            this.btnSSH.TabIndex = 0;
            this.btnSSH.Text = "Connect";
            this.btnSSH.UseVisualStyleBackColor = true;
            this.btnSSH.Click += new System.EventHandler(this.btnSSH_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(224, 67);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(32, 17);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "N/A";
            // 
            // lblArmClock
            // 
            this.lblArmClock.AutoSize = true;
            this.lblArmClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmClock.ForeColor = System.Drawing.Color.White;
            this.lblArmClock.Location = new System.Drawing.Point(227, 106);
            this.lblArmClock.Name = "lblArmClock";
            this.lblArmClock.Size = new System.Drawing.Size(31, 16);
            this.lblArmClock.TabIndex = 2;
            this.lblArmClock.Text = "N/A";
            // 
            // lblTemperatur
            // 
            this.lblTemperatur.AutoSize = true;
            this.lblTemperatur.Location = new System.Drawing.Point(47, 69);
            this.lblTemperatur.Name = "lblTemperatur";
            this.lblTemperatur.Size = new System.Drawing.Size(64, 13);
            this.lblTemperatur.TabIndex = 3;
            this.lblTemperatur.Text = "Temperatur:";
            this.lblTemperatur.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCpuTakt
            // 
            this.lblCpuTakt.AutoSize = true;
            this.lblCpuTakt.Location = new System.Drawing.Point(50, 108);
            this.lblCpuTakt.Name = "lblCpuTakt";
            this.lblCpuTakt.Size = new System.Drawing.Size(54, 13);
            this.lblCpuTakt.TabIndex = 4;
            this.lblCpuTakt.Text = "CPU-Takt";
            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblCpuTakt);
            this.Controls.Add(this.lblTemperatur);
            this.Controls.Add(this.lblArmClock);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnSSH);
            this.Name = "Page2";
            this.Size = new System.Drawing.Size(788, 506);
            this.Load += new System.EventHandler(this.Page2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSSH;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblArmClock;
        private System.Windows.Forms.Label lblTemperatur;
        private System.Windows.Forms.Label lblCpuTakt;
    }
}
