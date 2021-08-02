
namespace Bitcoin_Dashboard
{
    partial class FormCredenitals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCredenitals));
            this.lblHostSSH = new System.Windows.Forms.Label();
            this.lblUserSSH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHostRPC = new System.Windows.Forms.Label();
            this.lblUserRPC = new System.Windows.Forms.Label();
            this.lblPasswordRPC = new System.Windows.Forms.Label();
            this.tbxSshHost = new System.Windows.Forms.TextBox();
            this.tbxSshUser = new System.Windows.Forms.TextBox();
            this.tbxSshPasswd = new System.Windows.Forms.TextBox();
            this.tbxRpcHost = new System.Windows.Forms.TextBox();
            this.tbxRpcUser = new System.Windows.Forms.TextBox();
            this.tbxRpcPasswd = new System.Windows.Forms.TextBox();
            this.lblWelcomeConf = new System.Windows.Forms.Label();
            this.btnSaveConf = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.lblConfiguration = new System.Windows.Forms.Label();
            this.chxSsh = new System.Windows.Forms.CheckBox();
            this.pnlTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHostSSH
            // 
            resources.ApplyResources(this.lblHostSSH, "lblHostSSH");
            this.lblHostSSH.Name = "lblHostSSH";
            // 
            // lblUserSSH
            // 
            resources.ApplyResources(this.lblUserSSH, "lblUserSSH");
            this.lblUserSSH.Name = "lblUserSSH";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblHostRPC
            // 
            resources.ApplyResources(this.lblHostRPC, "lblHostRPC");
            this.lblHostRPC.Name = "lblHostRPC";
            // 
            // lblUserRPC
            // 
            resources.ApplyResources(this.lblUserRPC, "lblUserRPC");
            this.lblUserRPC.Name = "lblUserRPC";
            // 
            // lblPasswordRPC
            // 
            resources.ApplyResources(this.lblPasswordRPC, "lblPasswordRPC");
            this.lblPasswordRPC.Name = "lblPasswordRPC";
            // 
            // tbxSshHost
            // 
            resources.ApplyResources(this.tbxSshHost, "tbxSshHost");
            this.tbxSshHost.Name = "tbxSshHost";
            // 
            // tbxSshUser
            // 
            resources.ApplyResources(this.tbxSshUser, "tbxSshUser");
            this.tbxSshUser.Name = "tbxSshUser";
            // 
            // tbxSshPasswd
            // 
            resources.ApplyResources(this.tbxSshPasswd, "tbxSshPasswd");
            this.tbxSshPasswd.Name = "tbxSshPasswd";
            // 
            // tbxRpcHost
            // 
            resources.ApplyResources(this.tbxRpcHost, "tbxRpcHost");
            this.tbxRpcHost.Name = "tbxRpcHost";
            // 
            // tbxRpcUser
            // 
            resources.ApplyResources(this.tbxRpcUser, "tbxRpcUser");
            this.tbxRpcUser.Name = "tbxRpcUser";
            // 
            // tbxRpcPasswd
            // 
            resources.ApplyResources(this.tbxRpcPasswd, "tbxRpcPasswd");
            this.tbxRpcPasswd.Name = "tbxRpcPasswd";
            // 
            // lblWelcomeConf
            // 
            resources.ApplyResources(this.lblWelcomeConf, "lblWelcomeConf");
            this.lblWelcomeConf.Name = "lblWelcomeConf";
            // 
            // btnSaveConf
            // 
            resources.ApplyResources(this.btnSaveConf, "btnSaveConf");
            this.btnSaveConf.Name = "btnSaveConf";
            this.btnSaveConf.UseVisualStyleBackColor = true;
            this.btnSaveConf.Click += new System.EventHandler(this.btnSaveConf_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlTopPanel.Controls.Add(this.lblConfiguration);
            this.pnlTopPanel.Controls.Add(this.btnClose);
            this.pnlTopPanel.Controls.Add(this.lblWelcomeConf);
            this.pnlTopPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.pnlTopPanel, "pnlTopPanel");
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Tag = "";
            this.pnlTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelConfig_MouseDown);
            this.pnlTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelConfig_MouseMove);
            this.pnlTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelConfig_MouseUp);
            // 
            // lblConfiguration
            // 
            resources.ApplyResources(this.lblConfiguration, "lblConfiguration");
            this.lblConfiguration.Name = "lblConfiguration";
            this.lblConfiguration.Click += new System.EventHandler(this.label2_Click);
            // 
            // chxSsh
            // 
            resources.ApplyResources(this.chxSsh, "chxSsh");
            this.chxSsh.Checked = true;
            this.chxSsh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxSsh.Name = "chxSsh";
            this.chxSsh.UseVisualStyleBackColor = true;
            // 
            // FormCredenitals
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chxSsh);
            this.Controls.Add(this.btnSaveConf);
            this.Controls.Add(this.tbxRpcPasswd);
            this.Controls.Add(this.tbxRpcUser);
            this.Controls.Add(this.tbxRpcHost);
            this.Controls.Add(this.tbxSshPasswd);
            this.Controls.Add(this.tbxSshUser);
            this.Controls.Add(this.tbxSshHost);
            this.Controls.Add(this.lblPasswordRPC);
            this.Controls.Add(this.lblUserRPC);
            this.Controls.Add(this.lblHostRPC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserSSH);
            this.Controls.Add(this.lblHostSSH);
            this.Controls.Add(this.pnlTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCredenitals";
            this.Opacity = 0.98D;
            this.Load += new System.EventHandler(this.FormCredenitals_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCredenitals_MouseDown);
            this.pnlTopPanel.ResumeLayout(false);
            this.pnlTopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHostSSH;
        private System.Windows.Forms.Label lblUserSSH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHostRPC;
        private System.Windows.Forms.Label lblUserRPC;
        private System.Windows.Forms.Label lblPasswordRPC;
        private System.Windows.Forms.TextBox tbxSshHost;
        private System.Windows.Forms.TextBox tbxSshUser;
        private System.Windows.Forms.TextBox tbxSshPasswd;
        private System.Windows.Forms.TextBox tbxRpcHost;
        private System.Windows.Forms.TextBox tbxRpcUser;
        private System.Windows.Forms.TextBox tbxRpcPasswd;
        private System.Windows.Forms.Label lblWelcomeConf;
        private System.Windows.Forms.Button btnSaveConf;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.Label lblConfiguration;
        private System.Windows.Forms.CheckBox chxSsh;
    }
}