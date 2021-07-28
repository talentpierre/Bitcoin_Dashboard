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
        private int[] outputAnzahl = new int[12];
        private int[] inputAnzahl = new int[12];
        private long value;

        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            this.BackColor = design.pageBackColor;
            chart1.BackColor = design.chartBackColor;
            btnBlockBericht.BackColor = design.btnBackColor;
            btnBlockBericht.ForeColor = design.btnForeColor;
            btnBlockBericht.FlatStyle = design.btnFlatstyle;
            btnBlockBericht.FlatAppearance.BorderSize = 0;

            ControlCollection ctn = this.Controls;
            foreach (Control obj in ctn)
            {
                obj.ForeColor = design.lblForeColor;
                obj.Font = design.font;
            }
            textBoxBlockbericht.ForeColor = Color.Black;

            fillArray(inputAnzahl);
            fillArray(outputAnzahl);

            
        }

        private void btnBlockBericht_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                analyzeTransactions(Convert.ToInt32(textBoxBlockbericht.Text));
            }
            catch
            {
                lblError.Text = "Wrong Value (To high, to low, wrong format?)";
                lblError.Visible = true;
            }
            
            label3.Text = Convert.ToString(BitcoinToolbox.getBestBlockHeight());
        }

        private void fillArray(int[] oiAnzahl)
        {
            for (int i = 0; i < 12; i++)
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
            chart1.Series["Outputs"].Points.AddXY("3", outputAnzahl[3]);
            chart1.Series["Outputs"].Points.AddXY("4", outputAnzahl[4]);
            chart1.Series["Outputs"].Points.AddXY("5", outputAnzahl[5]);
            chart1.Series["Outputs"].Points.AddXY("6", outputAnzahl[6]);
            chart1.Series["Outputs"].Points.AddXY("7", outputAnzahl[7]);
            chart1.Series["Outputs"].Points.AddXY("8", outputAnzahl[8]);
            chart1.Series["Outputs"].Points.AddXY("9", outputAnzahl[9]);
            chart1.Series["Outputs"].Points.AddXY("10", outputAnzahl[10]);
            chart1.Series["Outputs"].Points.AddXY("> 10", outputAnzahl[11]);


            chart1.Series["Inputs"].Points.Clear();
            chart1.Series["Inputs"].Points.AddXY("0", inputAnzahl[0]);
            chart1.Series["Inputs"].Points.AddXY("1", inputAnzahl[1]);
            chart1.Series["Inputs"].Points.AddXY("2", inputAnzahl[2]);
            chart1.Series["Inputs"].Points.AddXY("3", inputAnzahl[3]);
            chart1.Series["Inputs"].Points.AddXY("4", inputAnzahl[4]);
            chart1.Series["Inputs"].Points.AddXY("5", inputAnzahl[5]);
            chart1.Series["Inputs"].Points.AddXY("6", inputAnzahl[6]);
            chart1.Series["Inputs"].Points.AddXY("7", inputAnzahl[7]);
            chart1.Series["Inputs"].Points.AddXY("8", inputAnzahl[8]);
            chart1.Series["Inputs"].Points.AddXY("9", inputAnzahl[9]);
            chart1.Series["Inputs"].Points.AddXY("10", inputAnzahl[10]);
            chart1.Series["Inputs"].Points.AddXY("> 10", inputAnzahl[11]);

            fillTable();

        }

        private void fillTable()
        {
            lbl_s3_c2.Text = Convert.ToString(outputAnzahl[0]);
            lbl_s3_c3.Text = Convert.ToString(outputAnzahl[1]);
            lbl_s3_c4.Text = Convert.ToString(outputAnzahl[2]);
            lbl_s3_c5.Text = Convert.ToString(outputAnzahl[3]);
            lbl_s3_c6.Text = Convert.ToString(outputAnzahl[4]);
            lbl_s3_c7.Text = Convert.ToString(outputAnzahl[5]);
            lbl_s3_c8.Text = Convert.ToString(outputAnzahl[6]);
            lbl_s3_c9.Text = Convert.ToString(outputAnzahl[7]);
            lbl_s3_c10.Text = Convert.ToString(outputAnzahl[8]);
            lbl_s3_c11.Text = Convert.ToString(outputAnzahl[9]);
            lbl_s3_c12.Text = Convert.ToString(outputAnzahl[10]);
            lbl_s3_c13.Text = Convert.ToString(outputAnzahl[11]);

            lbl_s2_c2.Text = Convert.ToString(inputAnzahl[0]);
            lbl_s2_c3.Text = Convert.ToString(inputAnzahl[1]);
            lbl_s2_c4.Text = Convert.ToString(inputAnzahl[2]);
            lbl_s2_c5.Text = Convert.ToString(inputAnzahl[3]);
            lbl_s2_c6.Text = Convert.ToString(inputAnzahl[4]);
            lbl_s2_c7.Text = Convert.ToString(inputAnzahl[5]);
            lbl_s2_c8.Text = Convert.ToString(inputAnzahl[6]);
            lbl_s2_c9.Text = Convert.ToString(inputAnzahl[7]);
            lbl_s2_c10.Text = Convert.ToString(inputAnzahl[8]);
            lbl_s2_c11.Text = Convert.ToString(inputAnzahl[9]);
            lbl_s2_c12.Text = Convert.ToString(inputAnzahl[10]);
            lbl_s2_c13.Text = Convert.ToString(inputAnzahl[11]);
        }

        public void analyzeTransactions(int height)
        {
            fillArray(outputAnzahl);
            fillArray(inputAnzahl);

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

                    case 3:
                        outputAnzahl[3] += 1;
                        break;

                    case 4:
                        outputAnzahl[4] += 1;
                        break;

                    case 5:
                        outputAnzahl[5] += 1;
                        break;

                    case 6:
                        outputAnzahl[6] += 1;
                        break;

                    case 7:
                        outputAnzahl[7] += 1;
                        break;

                    case 8:
                        outputAnzahl[8] += 1;
                        break;

                    case 9:
                        outputAnzahl[9] += 1;
                        break;

                    case 10:
                        outputAnzahl[10] += 1;
                        break;

                    case int n when (n > 10):
                        outputAnzahl[11] += 1;
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

                    case 3:
                        inputAnzahl[3] += 1;
                        break;

                    case 4:
                        inputAnzahl[4] += 1;
                        break;

                    case 5:
                        inputAnzahl[5] += 1;
                        break;

                    case 6:
                        inputAnzahl[6] += 1;
                        break;

                    case 7:
                        inputAnzahl[7] += 1;
                        break;

                    case 8:
                        inputAnzahl[8] += 1;
                        break;

                    case 9:
                        inputAnzahl[9] += 1;
                        break;

                    case 10:
                        inputAnzahl[10] += 1;
                        break;

                    case int n when (n > 10):
                        inputAnzahl[11] += 1;
                        break;

                    default:
                        break;
                }

                value += tx.Outputs.Transaction.TotalOut.Satoshi;
            }

            fillChart();
            label1.Text = Convert.ToString(value/(decimal)100000000) + " Bitcoin";

        }

        private void UserControl3_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
