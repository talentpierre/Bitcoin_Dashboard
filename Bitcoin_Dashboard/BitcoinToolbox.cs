using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;

using NBitcoin;
using NBitcoin.RPC;



namespace Bitcoin_Dashboard
{
    public class BitcoinToolbox
    {
       
        public static Network network = Network.TestNet;
        public static string rpcHost;
        public static string rpcCredentials;
        static RPCClient rpcclient;


        public static void InitializeRPC()
        {


            rpcHost = Config.GetRpcHost();
            rpcCredentials = Config.GetRpcCredentials();
            

            rpcclient = new RPCClient(rpcCredentials, rpcHost, network);

        }

        public static string getBlockInfo(string info, int height)
        {
            uint256 blockhash = rpcclient.GetBlockHash(height);
            NBitcoin.Block newBlock = rpcclient.GetBlock(blockhash);

            string result = "";

            switch (info)
            {
                case "hash":
                    result = Convert.ToString(newBlock.GetHash());
                    break;

                case "weight":
                    result = Convert.ToString(newBlock.GetWeight());
                    break;

                case "height":
                    result = Convert.ToString(newBlock.GetCoinbaseHeight());
                    break;

                case "root":
                    result = Convert.ToString(newBlock.GetMerkleRoot());
                    break;

                default:
                    break;
            }

            return result;
        }

        public static List<Transaction> getBlockTransactions(int height)
        {
            uint256 blockhash = rpcclient.GetBlockHash(height);
            NBitcoin.Block newBlock = rpcclient.GetBlock(blockhash);

            List<Transaction> txsBlock = newBlock.Transactions;
  
            return txsBlock;
        }


        public static List<Transaction> getMempoolTransactions()
        {
            NBitcoin.uint256[] mempooldump = rpcclient.GetRawMempool();
            Console.WriteLine(mempooldump.Length);

            List<NBitcoin.Transaction> txsMempool = new List<Transaction>();

            foreach (uint256 i in mempooldump)
            {
                Console.WriteLine(i);
                txsMempool.Add(rpcclient.GetRawTransaction(i));

            }

            return txsMempool;

        }

        public static int getBestBlockHeight()
        {
            int height = rpcclient.GetBlockCount();
            return height;
        }

        public static BlockchainInfo getBlockchainInformation()
        {
            return rpcclient.GetBlockchainInfo();
        }

        public static Block getBestBlock()
        {
            uint256 bestBlockHash =  rpcclient.GetBestBlockHash();
            return rpcclient.GetBlock(bestBlockHash);
        }

        
    }

    
}
