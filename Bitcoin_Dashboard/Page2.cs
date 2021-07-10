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
            PiHardware.InitializePi();
        }

        private void Page2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 43, 60);
            
            
            
                //lblTemp.Text = Convert.ToString(PiHardware.GetTemp());
                //lblArmClock.Text = Convert.ToString(PiHardware.GetArmClock());
            
            
            
        }
    }
}
