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

        static SshClient sshc;

        public static void InitializePi()
        {

            userName = Config.GetSshUser();
            sshHost = Config.GetSshHost();
            passwd = Config.GetSshPasswd();

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
        
        public static string GetPiModel()
        {
            SshCommand cmd = sshc.CreateCommand("cat /sys/firmware/devicetree/base/model");
            cmd.Execute();
            string model = cmd.Result;
                return model;
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

            if (arm.Length == 11)
            {
                arm = arm.Remove(4);
            }
            else if (arm.Length == 10)
            {
                arm = arm.Remove(5);
            }
            else
            {
                arm = "Error: " + arm.Length + ": Can't geht valid";
            }

            arm = arm + " Mhz";
            return arm;
        }
        
        public static string GetThrottled()
        {
            string hr = string.Empty;

            SshCommand cmd = sshc.CreateCommand("vcgencmd get_throttled");
            cmd.Execute();
            string hex = cmd.Result.Replace("throttled=", null);
            hex = hex.Replace("\n", null);

            switch (hex)
            {
                case "0x0":
                    hr = "OK";
                    break;
                case "0x1":
                    hr = "Under-voltage detcted";
                    break;
                case "0x2":
                    hr = "Arm frequency capped";
                    break;
                case "0x4":
                    hr = "Currently throttled";
                    break;
                case "0x8":
                    hr = "Soft temperature limit active";
                    break;
           
                default:
                    hr = "Can't get throttling informations";
                    break;
            }

            

            return hr;
        }

    }
}
