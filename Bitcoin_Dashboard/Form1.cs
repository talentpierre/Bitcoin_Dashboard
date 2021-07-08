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
            
            button1.BackColor = Color.FromArgb(50, 49, 65);
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button2.BackColor = Color.FromArgb(50, 49, 65);
            button2.ForeColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            button3.BackColor = Color.FromArgb(50, 49, 65);
            button3.ForeColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;

            button4.BackColor = Color.FromArgb(50, 49, 65);
            button4.ForeColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;

            button5.BackColor = Color.FromArgb(76, 75, 105);
            button5.ForeColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            
            BitcoinToolbox.InitializeRPC();
            
            page21.Hide();
            
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
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            activeSidebarPanel.Location = new Point(5, button2.Location.Y + 5);

            page21.Show();
            userControl11.Hide();
         

            
        }

        private void page11_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activeSidebarPanel.Location = new Point(5, button1.Location.Y + 5);

            userControl11.Show();
            page21.Hide();
        }

        private void page21_Load(object sender, EventArgs e)
        {

        }
    }
}
