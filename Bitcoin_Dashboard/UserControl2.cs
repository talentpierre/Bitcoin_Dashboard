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

            List <string> mempoolTx = BitcoinToolbox.getMempoolTransactions();
            Console.WriteLine(mempoolTx[0]);

            List<TransactionOutput> deserialized = new List<TransactionOutput>();

            int outputAnzahl0 = 0;
            int outputAnzahl1 = 0;
            int outputAnzahl2 = 0;
            int outputAnzahl3to10 = 0;
            int outputAnzahlGroesser10 = 0;

            foreach (var item in mempoolTx)
            {
                var tx = NBitcoin.JsonConverters.Serializer.ToObject<TransactionOutput>(item, Network.TestNet);
                deserialized.Add(tx);

                switch (tx.Out.Count)
                {
                    case 0:
                        outputAnzahl0 += 1;
                        break;

                    case 1:
                        outputAnzahl1 += 1;
                        break;

                    case 2:
                        outputAnzahl2 += 1;
                        break;

                    case int n when (n <= 10 && n > 2):
                        outputAnzahl3to10 += 1;
                        break;

                    case int n when (n > 10):
                        outputAnzahlGroesser10 += 1;
                        break;

                    default:
                        break;
                }

            }

            labelOutput_0.Text = Convert.ToString(outputAnzahl0);
            labelOutput_1.Text = Convert.ToString(outputAnzahl1);
            labelOutput_2.Text = Convert.ToString(outputAnzahl2);
            labelOutput_3to10.Text = Convert.ToString(outputAnzahl3to10);
            labelOutput_Groesser10.Text = Convert.ToString(outputAnzahlGroesser10);

            label1.Text = deserialized[0].Out[0].Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
