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
    public partial class UserControl1 : UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_blockhash.Text = BitcoinToolbox.getBlockInfo("hash", Convert.ToInt32(textBox1.Text));
            label_weight.Text = BitcoinToolbox.getBlockInfo("weight", Convert.ToInt32(textBox1.Text));
            label_coinbaseheight.Text = BitcoinToolbox.getBlockInfo("height", Convert.ToInt32(textBox1.Text));
            label_merkleroot.Text = BitcoinToolbox.getBlockInfo("root", Convert.ToInt32(textBox1.Text));
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 43, 60);
        }
    }
}
