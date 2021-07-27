using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitcoin_Dashboard
{
    public partial class FormCredenitals : Form
    {
        public FormCredenitals()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormCredenitals_Load(object sender, EventArgs e)
        { 
            this.BackColor = design.pageBackColor;
            this.Font = design.font;
            pnlTopPanel.BackColor = design.pnlBackColor;
            
            btnSaveConf.Font = design.font;
            btnSaveConf.BackColor = design.btnBackColor;
            btnSaveConf.ForeColor = design.btnForeColor;
            btnSaveConf.FlatStyle = design.btnFlatstyle;
            btnSaveConf.FlatAppearance.BorderSize = 0;

            btnClose.Font = design.font;
            btnClose.BackColor = design.btnBackColor;
            btnClose.ForeColor = design.btnForeColor;
            btnClose.FlatStyle = design.btnFlatstyle;
            btnClose.FlatAppearance.BorderSize = 0;

            ControlCollection ctn = (ControlCollection)this.Controls;
            
            foreach (Control obj in ctn)
            {
                obj.ForeColor = design.lblForeColor;
                obj.Font = design.font;
            }

            lblWelcomeConf.ForeColor = Color.Red;
            lblConfiguration.Font = design.fntTitle;

            tbxSshHost.BorderStyle = BorderStyle.None;
            tbxSshUser.BorderStyle = BorderStyle.None;
            tbxSshPasswd.BorderStyle = BorderStyle.None;
            tbxRpcHost.BorderStyle = BorderStyle.None;
            tbxRpcUser.BorderStyle = BorderStyle.None;
            tbxRpcPasswd.BorderStyle = BorderStyle.None;

            tbxSshHost.ForeColor = design.tbxLightForeColor;
            tbxSshUser.ForeColor = design.tbxLightForeColor;
            tbxSshPasswd.ForeColor = design.tbxLightForeColor;
            tbxRpcHost.ForeColor = design.tbxLightForeColor;
            tbxRpcUser.ForeColor = design.tbxLightForeColor;
            tbxRpcPasswd.ForeColor = design.tbxLightForeColor;

            lblWelcomeConf.Text = Config.WelcomeMsg;
            tbxSshHost.Text = Config.GetSshHost();
            tbxSshUser.Text = Config.GetSshUser();
            tbxSshPasswd.Text = Config.GetSshPasswd();
            tbxRpcHost.Text = Config.GetRpcHost();
            tbxRpcUser.Text = Config.GetRpcUser();
            tbxRpcPasswd.Text = Config.GetRpcPasswd();
        }

        private void btnSaveConf_Click(object sender, EventArgs e)
        {
            Config.SetConfig(tbxSshHost.Text, tbxSshUser.Text, tbxSshPasswd.Text, tbxRpcHost.Text, tbxRpcUser.Text, tbxRpcPasswd.Text);
            if (lblWelcomeConf.Text == "Please input your informations")
            {
                PiHardware.InitializePi();
                BitcoinToolbox.InitializeRPC();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
