using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NBitcoin;
using NBitcoin.RPC;



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
            //label_blockhash.Text = BitcoinToolbox.getBlockInfo("hash", Convert.ToInt32(textBox1.Text));
            //label_weight.Text = BitcoinToolbox.getBlockInfo("weight", Convert.ToInt32(textBox1.Text));
            //label_coinbaseheight.Text = BitcoinToolbox.getBlockInfo("height", Convert.ToInt32(textBox1.Text));
            //label_merkleroot.Text = BitcoinToolbox.getBlockInfo("root", Convert.ToInt32(textBox1.Text));

            BlockchainInfo chaininfo = BitcoinToolbox.getBlockchainInformation();
            Block bestBlock = BitcoinToolbox.getBestBlock();

            lbl_chain.Text = Convert.ToString(chaininfo.Chain);
            lbl_sizeOnDisk.Text = Convert.ToString(Math.Round((double)chaininfo.SizeOnDisk / (1024 * 1024 * 1024),2)) + " GiB";
            lbl_initialBlockdownload.Text = Convert.ToString(chaininfo.InitialBlockDownload);
            lbl_verificationProgress.Text = Convert.ToString(chaininfo.VerificationProgress);

            lbl_blocksize.Text = Convert.ToString(bestBlock.GetSerializedSize()) + " Bytes";
            lbl_blocktime.Text = Convert.ToString(bestBlock.Header.BlockTime.UtcDateTime);
            lbl_nrTx.Text = Convert.ToString(bestBlock.Transactions.Count);
            lbl_blockHeight.Text = Convert.ToString(bestBlock.GetCoinbaseHeight()); 

            progressBar1.BackColor = Color.FromArgb(76, 75, 105);
            progressBar1.ForeColor = Color.PaleGreen;
            progressBar1.Value = Convert.ToInt32(chaininfo.VerificationProgress * 1000000);
            //progressBar1.Value = Convert.ToInt32(0.5 * 1000000);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 43, 60);

            button2.BackColor = Color.FromArgb(76, 75, 105);
            button2.ForeColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
        }
    }
}
