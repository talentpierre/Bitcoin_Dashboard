using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using System.IO;
using System.Threading;

namespace Bitcoin_Dashboard
{
    class PiHardware
    {

        private static string userName;
        private static string passwd;
        private static string sshHost;

        static SshClient sshc = new SshClient(sshHost, userName, passwd);

        public static void InitializePi()
        {
            if (Directory.Exists("credentials/ssh/") == false)
            {
                Directory.CreateDirectory("credentials/ssh/");
            }
            if (File.Exists("credentials/ssh/sshUser.txt") == false)
            {
                File.Create("credentials/ssh/sshUser.txt");
            }
            if (File.Exists("credentials/ssh/sshHost.txt") == false)
            {
                File.Create("credentials/ssh/sshHost.txt");
            }
            if (File.Exists("credentials/ssh/sshPasswd.txt") == false)
            {
                File.Create("credentials/ssh/sshPasswd.txt");
            }

            Thread.Sleep(1200);

            userName = File.ReadAllText("credentials/ssh/sshUser.txt");
            sshHost = File.ReadAllText("credentials/ssh/sshHost.txt");
            passwd = File.ReadAllText("credentials/ssh/sshPasswd.txt");

            Thread.Sleep(450);
            sshc = new SshClient(sshHost, userName, passwd);
        }
        
        public static string GetTemp()
        {
            sshc = new SshClient(sshHost, userName, passwd);
            sshc.Connect();
            SshCommand cmd = sshc.CreateCommand("vcgencmd measure_temp");
            cmd.Execute();
            string temp = "cmd.Result";
            return temp;
        }
        
        public static string GetThrottled()
        {
            return null;
        }

    }
}
