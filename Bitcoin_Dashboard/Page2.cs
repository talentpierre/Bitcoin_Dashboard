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
        public Page2()
        {
            InitializeComponent();
        }

        private void Page2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 43, 60);
            btnSSH.BackColor = Color.FromArgb(76, 75, 105);
            btnSSH.ForeColor = Color.White;
            btnSSH.FlatStyle = FlatStyle.Flat;
            btnSSH.FlatAppearance.BorderSize = 0;
        }

        private void btnSSH_Click(object sender, EventArgs e)
        {
            PiHardware.SshConnect();


            label1.Text = Convert.ToString(PiHardware.GetTemp());
            label2.Text = Convert.ToString(PiHardware.GetArmClock());
        }
    }
}
