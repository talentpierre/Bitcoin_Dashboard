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
        public static Network network = Network.TestNet;
        public static readonly string rpcHost = "192.168.193.10:18332";
        public static readonly string rpcCredentials = "pida:DxJ29FSOx75Z1foEc";

        //https://www.codeproject.com/articles/11114/move-window-form-without-titlebar-in-c


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                 int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        


        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 43, 60);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            TopPanel.BackColor = Color.FromArgb(76, 75, 105);
            LeftPanel.BackColor = Color.FromArgb(50, 49, 65);
            
            btnHardware.BackColor = Color.FromArgb(50, 49, 65);
            btnHardware.ForeColor = Color.White;
            btnHardware.FlatStyle = FlatStyle.Flat;
            btnHardware.FlatAppearance.BorderSize = 0;

            btnBlocksuche.BackColor = Color.FromArgb(50, 49, 65);
            btnBlocksuche.ForeColor = Color.White;
            btnBlocksuche.FlatStyle = FlatStyle.Flat;
            btnBlocksuche.FlatAppearance.BorderSize = 0;

            btnFees.BackColor = Color.FromArgb(50, 49, 65);
            btnFees.ForeColor = Color.White;
            btnFees.FlatStyle = FlatStyle.Flat;
            btnFees.FlatAppearance.BorderSize = 0;

            btnChange.BackColor = Color.FromArgb(50, 49, 65);
            btnChange.ForeColor = Color.White;
            btnChange.FlatStyle = FlatStyle.Flat;
            btnChange.FlatAppearance.BorderSize = 0;

            button5.BackColor = Color.FromArgb(76, 75, 105);
            button5.ForeColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            
            BitcoinToolbox.InitializeRPC();
            
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
//                this.Opacity = 0.5;
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                
            }
        }


        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
 //               MainWindow.ActiveForm.Opacity = 1;
            }
        }

        private void activeSidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            //PiHardware.SshDisconnect();
            this.Close();
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
            activeSidebarPanel.Location = new Point(5, btnFees.Location.Y + 5);
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

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
