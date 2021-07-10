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
            this.components = new System.ComponentModel.Container();
            this.Temperatur = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.Taktrate = new System.Windows.Forms.Label();
            this.lblArmClock = new System.Windows.Forms.Label();
            this.btnCnctSSH = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Temperatur
            // 
            this.Temperatur.AutoSize = true;
            this.Temperatur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Temperatur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Temperatur.Location = new System.Drawing.Point(25, 60);
            this.Temperatur.Name = "Temperatur";
            this.Temperatur.Size = new System.Drawing.Size(81, 16);
            this.Temperatur.TabIndex = 0;
            this.Temperatur.Text = "Temperatur:";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTemp.Location = new System.Drawing.Point(124, 60);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(31, 16);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "N/A";
            // 
            // Taktrate
            // 
            this.Taktrate.AutoSize = true;
            this.Taktrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Taktrate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Taktrate.Location = new System.Drawing.Point(25, 102);
            this.Taktrate.Name = "Taktrate";
            this.Taktrate.Size = new System.Drawing.Size(93, 16);
            this.Taktrate.TabIndex = 2;
            this.Taktrate.Text = "CPU-Taktrate:";
            // 
            // lblArmClock
            // 
            this.lblArmClock.AutoSize = true;
            this.lblArmClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblArmClock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblArmClock.Location = new System.Drawing.Point(124, 102);
            this.lblArmClock.Name = "lblArmClock";
            this.lblArmClock.Size = new System.Drawing.Size(31, 16);
            this.lblArmClock.TabIndex = 3;
            this.lblArmClock.Text = "N/A";
            // 
            // btnCnctSSH
            // 
            this.btnCnctSSH.Location = new System.Drawing.Point(537, 57);
            this.btnCnctSSH.Name = "btnCnctSSH";
            this.btnCnctSSH.Size = new System.Drawing.Size(75, 23);
            this.btnCnctSSH.TabIndex = 4;
            this.btnCnctSSH.Text = "Connect SSH";
            this.btnCnctSSH.UseVisualStyleBackColor = true;
            this.btnCnctSSH.Click += new System.EventHandler(this.btnCnctSSH_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnCnctSSH);
            this.Controls.Add(this.lblArmClock);
            this.Controls.Add(this.Taktrate);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.Temperatur);
            this.Name = "Page2";
            this.Size = new System.Drawing.Size(742, 558);
            this.Load += new System.EventHandler(this.Page2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Temperatur;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label Taktrate;
        private System.Windows.Forms.Label lblArmClock;
        private System.Windows.Forms.Button btnCnctSSH;
        private System.Windows.Forms.Timer timer1;
    }
}
