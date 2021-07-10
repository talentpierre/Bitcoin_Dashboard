using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Bitcoin_Dashboard
{
    class PiHardware
    {

        private static string userName;
        private static string passwd;
        private static string sshHost;
        private static bool exist = true;

        static SshClient sshc;

        public static void InitializePi()
        {
            if (Directory.Exists("credentials/ssh/") == false)
            {
                Directory.CreateDirectory("credentials/ssh/");
                exist = false;
            }
            if (File.Exists("credentials/ssh/sshUser.txt") == false)
            {
                File.Create("credentials/ssh/sshUser.txt");
                exist = false;
            }
            if (File.Exists("credentials/ssh/sshHost.txt") == false)
            {
                File.Create("credentials/ssh/sshHost.txt");
                exist = false;
            }
            if (File.Exists("credentials/ssh/sshPasswd.txt") == false)
            {
                File.Create("credentials/ssh/sshPasswd.txt");
                exist = false;
            }

            if (exist == false)
            {
                MessageBox.Show("Bitte gib deine SSH Daten im credentials Ordner ein");
               Thread.Sleep(1200);
                Application.Exit();
                Environment.Exit(0);
            }

            Thread.Sleep(1200);

            userName = File.ReadAllText("credentials/ssh/sshUser.txt");
            sshHost = File.ReadAllText("credentials/ssh/sshHost.txt");
            passwd = File.ReadAllText("credentials/ssh/sshPasswd.txt");

            if (userName == null || passwd == null || sshHost == null)
            {
                MessageBox.Show("Bitte gib deine SSH Daten im credentials Ordner ein");
                Thread.Sleep(1200);
                Application.Exit();
                Environment.Exit(0);
            }


        }

        public static void SshConnect()
        {
            sshc = new SshClient(sshHost, userName, passwd);
            sshc.Connect();
        }

        public static void SshDisconnect()
        {
            sshc.Disconnect();
        }
        
        public static string GetTemp()
        {

            //ShellStream stream = sshc.CreateShellStream("vcTemp", 80, 1, 800, 600, 1024);
            SshCommand cmd = sshc.CreateCommand("vcgencmd measure_temp");
            cmd.Execute();
            string temp = cmd.Result;
            temp = temp.Replace("temp=", null);
            return temp;
            //test
        }

        public static string GetArmClock()
        {
            
            SshCommand cmd = sshc.CreateCommand("vcgencmd measure_clock arm");
            cmd.Execute();
            string arm = cmd.Result;
            arm = arm.Replace("frequency(48)=", null);
            arm = arm.Remove(4);
            arm = arm + " Mhz";
            return arm;
        }
        
        public static string GetThrottled()
        {
            return null;
        }

    }
}
