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
        private int[] outputAnzahl = new int[5];
        private int[] inputAnzahl = new int[5];


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

        private void fillArray(int[] oiAnzahl)
        {
            for (int i = 0; i < 5; i++)
            {
                oiAnzahl[i] = 0;
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(44, 43, 60);
            chart1.BackColor = Color.FromArgb(44, 43, 60);

            fillArray(inputAnzahl);
            fillArray(outputAnzahl);
            timer1.Start();

        }

        private void fillChart()
        {

            chart1.Series["Outputs"].Points.Clear();
            chart1.Series["Outputs"].Points.AddXY("0", outputAnzahl[0]);
            chart1.Series["Outputs"].Points.AddXY("1", outputAnzahl[1]);
            chart1.Series["Outputs"].Points.AddXY("2", outputAnzahl[2]);
            chart1.Series["Outputs"].Points.AddXY("3 - 10", outputAnzahl[3]);
            chart1.Series["Outputs"].Points.AddXY("10 - ...", outputAnzahl[4]);


            chart1.Series["Inputs"].Points.Clear();
            chart1.Series["Inputs"].Points.AddXY("0", inputAnzahl[0]);
            chart1.Series["Inputs"].Points.AddXY("1", inputAnzahl[1]);
            chart1.Series["Inputs"].Points.AddXY("2", inputAnzahl[2]);
            chart1.Series["Inputs"].Points.AddXY("3 - 10", inputAnzahl[3]);
            chart1.Series["Inputs"].Points.AddXY("10 - ...", inputAnzahl[4]);

        }

        public void analyzeTransactions()
        {
            for (int i = 0; i < 5; i++)
            {
                outputAnzahl[i] = 0;
                inputAnzahl[i] = 0;
            }

            List<string> mempoolTx = BitcoinToolbox.getMempoolTransactions();
            label1.Text = Convert.ToString(mempoolTx.Count);

            List<TransactionOutput> deserialized = new List<TransactionOutput>();

            foreach (string tx_json in mempoolTx)
            {
                TransactionOutput tx = NBitcoin.JsonConverters.Serializer.ToObject<TransactionOutput>(tx_json, Network.TestNet);
                deserialized.Add(tx);

                switch (tx.Out.Count)
                {
                    case 0:
                        outputAnzahl[0] += 1;
                        break;

                    case 1:
                        outputAnzahl[1] += 1;
                        break;

                    case 2:
                        outputAnzahl[2] += 1;
                        break;

                    case int n when (n <= 10 && n > 2):
                        outputAnzahl[3] += 1;
                        break;

                    case int n when (n > 10):
                        outputAnzahl[4] += 1;
                        break;

                    default:
                        break;
                }

                switch (tx.In.Count)
                {
                    case 0:
                        inputAnzahl[0] += 1;
                        break;

                    case 1:
                        inputAnzahl[1] += 1;
                        break;

                    case 2:
                        inputAnzahl[2] += 1;
                        break;

                    case int n when (n <= 10 && n > 2):
                        inputAnzahl[3] += 1;
                        break;

                    case int n when (n > 10):
                        inputAnzahl[4] += 1;
                        break;

                    default:
                        break;
                }
                Console.WriteLine(tx_json);

            }

            fillChart();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            analyzeTransactions();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
