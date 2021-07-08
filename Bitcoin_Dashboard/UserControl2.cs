using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NBitcoin;


namespace Bitcoin_Dashboard
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            TransactionOutput deserialized = NBitcoin.JsonConverters.Serializer.ToObject<TransactionOutput>(BitcoinToolbox.getMempoolTransactions(), Network.TestNet);
            label1.Text = deserialized.Out[0].Value;
            //label2.Text = deserialized.In[0].PrevOut.Hash;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
