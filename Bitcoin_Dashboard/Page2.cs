using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using NBitcoin;

namespace Bitcoin_Dashboard
{
    public partial class Page2 : UserControl
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JsonSerializerSettings jsonSettings = new JsonSerializerSettings();
            NBitcoin.JsonConverters.Serializer.RegisterFrontConverters(jsonSettings, Network.TestNet);

            Transactions deserialized = JsonConvert.DeserializeObject<Transactions>(BitcoinToolbox.getMempoolTransactions(), jsonSettings);
            Console.WriteLine(deserialized.Out[0].Value);

        }
    }
}
