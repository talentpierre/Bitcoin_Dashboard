using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitcoin_Dashboard
{
    public partial class Page2 : UserControl
    {
        private static bool connected = false;
        
        public Page2()
        {
            InitializeComponent();
        }

        private void Page2_Load(object sender, EventArgs e)
        {
            this.BackColor = design.pageBackColor;
            btnSSH.BackColor = design.btnBackColor;
            btnSSH.ForeColor = design.btnForeColor;
            btnSSH.FlatStyle = design.btnFlatstyle;
            btnSSH.FlatAppearance.BorderSize = 0;
            btnSSH.Font = design.font;
            ControlCollection ctn = this.Controls;
            foreach (Control obj in ctn)
            {
                obj.ForeColor = design.lblForeColor;
                obj.Font = design.font;
            }
        }

        private void btnSSH_Click(object sender, EventArgs e)
        {
            if (connected == false)
            {
                PiHardware.SshConnect();
                lblModel.Text = PiHardware.GetPiModel();
                lblTemp.Text = Convert.ToString(PiHardware.GetTemp());
                lblArmClock.Text = Convert.ToString(PiHardware.GetArmClock());
                lblSystemstate.Text = PiHardware.GetThrottled();
                connected = true;
                btnSSH.Text = "Disconnect";
            }
            else
            {
                PiHardware.SshDisconnect();
                lblModel.Text = "No Raspberry Pi connected";
                lblTemp.Text = "N/A";
                lblArmClock.Text = "N/A";
                lblSystemstate.Text = "N/A";
                connected = false;
                btnSSH.Text = "Connect";
            }
            


            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
