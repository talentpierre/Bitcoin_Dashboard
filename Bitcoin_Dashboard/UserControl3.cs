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
    public partial class UserControl3 : UserControl
    {
        private int[] outputAnzahl = new int[5];
        private int[] inputAnzahl = new int[5];
        private long value;

        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 43, 60);
            chart1.BackColor = Color.FromArgb(76, 75, 105);
            btnBlockBericht.BackColor = Color.FromArgb(76, 75, 105);
            btnBlockBericht.ForeColor = Color.White;
            btnBlockBericht.FlatStyle = FlatStyle.Flat;
            btnBlockBericht.FlatAppearance.BorderSize = 0;

            fillArray(inputAnzahl);
            fillArray(outputAnzahl);

            
        }

        private void btnBlockBericht_Click(object sender, EventArgs e)
        {
            analyzeTransactions(Convert.ToInt32(textBoxBlockbericht.Text));
        }

        private void fillArray(int[] oiAnzahl)
        {
            for (int i = 0; i < 5; i++)
            {
                oiAnzahl[i] = 0;
            }
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

        public void analyzeTransactions(int height)
        {
            for (int i = 0; i < 5; i++)
            {
                outputAnzahl[i] = 0;
                inputAnzahl[i] = 0;
            }

            value = 0;

            List<Transaction> blockTxs = BitcoinToolbox.getBlockTransactions(height);
            label2.Text = Convert.ToString(blockTxs.Count);

            foreach (Transaction tx in blockTxs)
            {
                switch (tx.Outputs.Count)
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

                switch (tx.Inputs.Count)
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

                value += tx.Outputs.Transaction.TotalOut.Satoshi;
            }

            fillChart();
            label1.Text = Convert.ToString(value/(decimal)100000000);

        }

        private void UserControl3_VisibleChanged(object sender, EventArgs e)
        {
           
        }
    }
}
