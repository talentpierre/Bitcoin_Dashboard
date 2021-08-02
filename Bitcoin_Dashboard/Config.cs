using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Bitcoin_Dashboard
{
    class Config
    {
        static string configPath = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\NodeExplorer";
        static string configFile = @"\credentials.conf";
        static string conf = configPath + configFile;


        //ssh
        public static bool sshState = true;
        public static string sshHost = string.Empty;
        public static string sshUser = string.Empty;
        public static string sshPasswd = string.Empty;

        //rpc
        public static string rpcCredentials = string.Empty;
        public static string rpcUser = string.Empty;
        public static string rpcPasswd = string.Empty;
        public static string rpcHost = string.Empty;

        public static string WelcomeMsg = string.Empty;

        static StreamReader cfgReader;
        

        public static void InitConfig()
        {
            if (Directory.Exists(configPath) == false)
            {
                Directory.CreateDirectory(configPath);
            }

            if (File.Exists(conf) == false || File.ReadAllText(conf) == null)
            {
                StreamWriter cfgCreate = new StreamWriter(conf);
                cfgCreate.WriteLine("[SSH]");
                cfgCreate.WriteLine("SSH Host=");
                cfgCreate.WriteLine("SSH User=");
                cfgCreate.WriteLine("SSH Password=");
                cfgCreate.WriteLine("");
                cfgCreate.WriteLine("[RPC]");
                cfgCreate.WriteLine("RPC Host=");
                cfgCreate.WriteLine("RPC User=");
                cfgCreate.WriteLine("RPC Password=");
                cfgCreate.WriteLine("");
                cfgCreate.WriteLine("[Comments]");
                cfgCreate.Close();

                Bitcoin_Dashboard.FormCredenitals formCredentials = new Bitcoin_Dashboard.FormCredenitals();
                WelcomeMsg = "Please input your informations";
                formCredentials.Show();
            }
            else if (GetSshEnabled() == true)
            {
                if (GetSshHost() == "" || GetSshPasswd() == "" || GetSshUser() == "" || GetRpcHost() == "" || GetRpcUser() == "" || GetRpcPasswd() == "")
                {
                    Bitcoin_Dashboard.FormCredenitals formCredentials = new Bitcoin_Dashboard.FormCredenitals();
                    WelcomeMsg = "Please input your informations";
                    formCredentials.Show();

                }
                else
                {
                    PiHardware.InitializePi();
                    BitcoinToolbox.InitializeRPC();
                }
            }
            else if (GetSshEnabled() == false)
            {
                if (GetRpcHost() == "" || GetRpcUser() == "" || GetRpcPasswd() == "")
                {
                    Bitcoin_Dashboard.FormCredenitals formCredentials = new Bitcoin_Dashboard.FormCredenitals();
                    WelcomeMsg = "Please input your informations";
                    formCredentials.Show();

                }
                else
                {
                    PiHardware.InitializePi();
                    BitcoinToolbox.InitializeRPC();
                }
            }
            
        }

        public static bool GetSshEnabled()
        {
            cfgReader = new StreamReader(conf);

            while (!cfgReader.EndOfStream)
            {
                string arg = cfgReader.ReadLine().ToString();
                if (arg.Contains("[SSH]"))
                {

                    sshState = true;
                }
                else if (arg.Contains("[!SSH]"))
                {
                    sshState = false;
                }
            }
            cfgReader.Close();
            return sshState;
        }
        
        public static string GetSshHost()
        {
            cfgReader = new StreamReader(conf);

            while(!cfgReader.EndOfStream)
            {
                string arg = cfgReader.ReadLine().ToString();
                if (arg.Contains("SSH Host="))
                {

                    sshHost = arg.Replace("SSH Host=", null);
                }
            }
            cfgReader.Close();
            return sshHost;

        }


        public static string GetSshUser()
        {
            cfgReader = new StreamReader(conf);

            while (!cfgReader.EndOfStream)
            {
                string arg = cfgReader.ReadLine().ToString();
                if (arg.Contains("SSH User="))
                {

                    sshUser = arg.Replace("SSH User=", null);
                }
            }
            cfgReader.Close();
            return sshUser;

        }


        public static string GetSshPasswd()
        {
            cfgReader = new StreamReader(conf);

            while (!cfgReader.EndOfStream)
            {
                string arg = cfgReader.ReadLine().ToString();
                if (arg.Contains("SSH Password="))
                {

                    sshPasswd = arg.Replace("SSH Password=", null);
                }
            }
            cfgReader.Close();
            return sshPasswd;

        }


        public static string GetRpcHost()
        {
            cfgReader = new StreamReader(conf);

            while (!cfgReader.EndOfStream)
            {
                string arg = cfgReader.ReadLine().ToString();
                if (arg.Contains("RPC Host="))
                {

                    rpcHost = arg.Replace("RPC Host=", null);
                }
            }
            cfgReader.Close();
            return rpcHost;

        }


        public static string GetRpcUser()
        {
            cfgReader = new StreamReader(conf);

            while (!cfgReader.EndOfStream)
            {
                string arg = cfgReader.ReadLine().ToString();
                if (arg.Contains("RPC User="))
                {

                    rpcUser = arg.Replace("RPC User=", null);
                }
            }
            cfgReader.Close();
            return rpcUser;

        }


        public static string GetRpcPasswd()
        {
            cfgReader = new StreamReader(conf);

            while (!cfgReader.EndOfStream)
            {
                string arg = cfgReader.ReadLine().ToString();
                if (arg.Contains("RPC Password="))
                {

                    rpcPasswd = arg.Replace("RPC Password=", null);
                }
            }
            cfgReader.Close();
            return rpcPasswd;

        }


        public static string GetRpcCredentials()
        {
            rpcCredentials = GetRpcUser() + ":" + GetRpcPasswd();
            return rpcCredentials;
        }

        public static void SetConfig(bool ssh, string sshHost, string sshUser, string sshPassword, string rpcHost, string rpcUser, string rpcPassword)
        {
            StreamWriter cfgCreate = new StreamWriter(conf);
            if (ssh == false)
            {
                cfgCreate.WriteLine("[!SSH]");
            }
            else if (ssh == true)
            {
                cfgCreate.WriteLine("[SSH]");
            }
            cfgCreate.WriteLine("SSH Host=" + sshHost);
            cfgCreate.WriteLine("SSH User=" + sshUser);
            cfgCreate.WriteLine("SSH Password=" + sshPassword);
            cfgCreate.WriteLine("");
            cfgCreate.WriteLine("[RPC]");
            cfgCreate.WriteLine("RPC Host=" + rpcHost);
            cfgCreate.WriteLine("RPC User=" + rpcUser);
            cfgCreate.WriteLine("RPC Password=" + rpcPassword);
            cfgCreate.WriteLine("");
            cfgCreate.WriteLine("[Comments]");
            cfgCreate.Close();
        }
    }
}
