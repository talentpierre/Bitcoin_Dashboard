using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using NBitcoin;
using NBitcoin.RPC;

namespace Bitcoin_Dashboard
{
    public partial class MainWindow : Form
    {
        private bool dragging = false;
        private Point startpoint = new Point(0, 0);

        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 43, 60);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            TopPanel.BackColor = design.pnlBackColor;
            LeftPanel.BackColor = Color.FromArgb(50, 49, 65);

            lblNodeTitle.Font = design.fntTitle;
            lblNodeTitle.ForeColor = design.lblForeColor;

            btnHardware.BackColor = design.form1BtnBackColor;
            btnHardware.ForeColor = design.btnForeColor;
            btnHardware.FlatStyle = design.btnFlatstyle;
            btnHardware.FlatAppearance.BorderSize = 0;

            btnBlocksuche.BackColor = design.form1BtnBackColor;
            btnBlocksuche.ForeColor = design.btnForeColor;
            btnBlocksuche.FlatStyle = design.btnFlatstyle;
            btnBlocksuche.FlatAppearance.BorderSize = 0;

            btnMempool.BackColor = design.form1BtnBackColor;
            btnMempool.ForeColor = design.btnForeColor;
            btnMempool.FlatStyle = design.btnFlatstyle;
            btnMempool.FlatAppearance.BorderSize = 0;

            btnChange.BackColor = design.form1BtnBackColor;
            btnChange.ForeColor = design.btnForeColor;
            btnChange.FlatStyle = design.btnFlatstyle;
            btnChange.FlatAppearance.BorderSize = 0;

            button5.BackColor = Color.FromArgb(76, 75, 105);
            button5.ForeColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;

            btnConfig.Font = design.font;
            btnConfig.BackColor = design.btnBackColor;
            btnConfig.ForeColor = design.btnForeColor;
            btnConfig.FlatStyle = design.btnFlatstyle;
            btnConfig.FlatAppearance.BorderSize = 0;

            Config.InitConfig();            

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();

            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }


        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void activeSidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activeSidebarPanel.Location = new Point(5, btnBlocksuche.Location.Y + 5);

            userControl11.Show();
            page21.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void page11_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activeSidebarPanel.Location = new Point(5, btnHardware.Location.Y + 5);
            page21.Show();
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            activeSidebarPanel.Location = new Point(5, btnMempool.Location.Y + 5);
            userControl21.Show();
            userControl11.Hide();
            page21.Hide();
            userControl31.Hide();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            activeSidebarPanel.Location = new Point(5, btnChange.Location.Y + 5);
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            page21.Hide();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormCredenitals formcreds = new FormCredenitals();
            formcreds.Show();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }
    }
}
