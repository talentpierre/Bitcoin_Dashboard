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
        //private static bool connected = false;
        public Page2()
        {
            InitializeComponent();
            PiHardware.InitializePi();
        }

        private void Page2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 43, 60);
            
        }

        private void btnCnctSSH_Click(object sender, EventArgs e)
        {
            PiHardware.SshConnect();
            //connected = true;
            lblTemp.Text = Convert.ToString(PiHardware.GetTemp());
            lblArmClock.Text = Convert.ToString(PiHardware.GetArmClock());
            timer1.Interval = 2*1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblTemp.Text = Convert.ToString(PiHardware.GetTemp());
            lblArmClock.Text = Convert.ToString(PiHardware.GetArmClock());

        }
    }
}
