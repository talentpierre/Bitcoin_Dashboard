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
        private int outputAnzahl0 = 0;
        private int outputAnzahl1 = 0;
        private int outputAnzahl2 = 0;
        private int outputAnzahl3to10 = 0;
        private int outputAnzahlGroesser10 = 0;

        private int inputAnzahl0 = 0;
        private int inputAnzahl1 = 0;
        private int inputAnzahl2 = 0;
        private int inputAnzahl3to10 = 0;
        private int inputAnzahlGroesser10 = 0;

        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            analyzeTransactions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            
        }

        private void fillChart()
        {
            chart1.Series["Outputs"].Points.AddXY("0", outputAnzahl0);
            chart1.Series["Outputs"].Points.AddXY("1", outputAnzahl1);
            chart1.Series["Outputs"].Points.AddXY("2", outputAnzahl2);
            chart1.Series["Outputs"].Points.AddXY("3 - 10", outputAnzahl3to10);
            chart1.Series["Outputs"].Points.AddXY("10 - ...", outputAnzahlGroesser10);
            

            chart1.Series["Inputs"].Points.AddXY("0", inputAnzahl0);
            chart1.Series["Inputs"].Points.AddXY("1", inputAnzahl1);
            chart1.Series["Inputs"].Points.AddXY("2", inputAnzahl2);
            chart1.Series["Inputs"].Points.AddXY("3 - 10", inputAnzahl3to10);
            chart1.Series["Inputs"].Points.AddXY("10 - ...", inputAnzahlGroesser10);

        }

        public void analyzeTransactions()
        {
            List<string> mempoolTx = BitcoinToolbox.getMempoolTransactions();
            Console.WriteLine(mempoolTx[0]);

            List<TransactionOutput> deserialized = new List<TransactionOutput>();

            foreach (string tx_json in mempoolTx)
            {
                TransactionOutput tx = NBitcoin.JsonConverters.Serializer.ToObject<TransactionOutput>(tx_json, Network.TestNet);
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

                switch (tx.In.Count)
                {
                    case 0:
                        inputAnzahl0 += 1;
                        break;

                    case 1:
                        inputAnzahl1 += 1;
                        break;

                    case 2:
                        inputAnzahl2 += 1;
                        break;

                    case int n when (n <= 10 && n > 2):
                        inputAnzahl3to10 += 1;
                        break;

                    case int n when (n > 10):
                        inputAnzahlGroesser10 += 1;
                        break;

                    default:
                        break;
                }
                Console.WriteLine(tx_json);

            }

            labelOutput_0.Text = Convert.ToString(outputAnzahl0);
            labelOutput_1.Text = Convert.ToString(outputAnzahl1);
            labelOutput_2.Text = Convert.ToString(outputAnzahl2);
            labelOutput_3to10.Text = Convert.ToString(outputAnzahl3to10);
            labelOutput_Groesser10.Text = Convert.ToString(outputAnzahlGroesser10);

            label1.Text = deserialized[0].Out[0].Value;

            fillChart();
        }
    }
}
