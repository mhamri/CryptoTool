using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoUtility;
using System.Globalization;
using System.IO;

namespace Set1
{
    class Program
    {
        static void Main(string[] args)
        {

            Utility u = new Utility();
            //string bin= u.HexToBinary("20070b54180a541d13181a00541c06540a0c0606065a98540caa262430000c04260c102cb435fcaab2abacbf32b2aeb934b9a0a8a425b6a9809cbcb7a8bb2e34eaa7a83580aa8625b8a7aebc2cbb9e9d329cbcaf3493a080a625aab9329cbcaf34b1aab6aab33431b0a8bebfb6ad3634b0af849d329cb225faabacbab4af3a9332aaa0a9a6b3b80a0a");
            string[] arr = new string[] { "X", "Y", "Z"};
            var jj = CombinationsWithRepition(arr, 5);
            jj = from j in jj
                 select "ZY" + j;

            StreamWriter f = new StreamWriter("xored.txt");
            
            Xor x = new Xor();
            string c = string.Empty;
            foreach (var item in jj)
            {
                if (string.IsNullOrEmpty(c))
                {
                    c = item.Substring(0, 1);
                }
                else if (c != item.Substring(0, 1))
                {
                    f.WriteLine();
                    c = item.Substring(0, 1);

                }

                string xored = x.EncryptOrDecrypt("20070b54 180a 541d 1318 1a00 541c 0654", item);
                string output=string.Format("{0}: {1}", item, xored);
                Console.WriteLine(output);

                f.WriteLine(output);
            }

            f.Close();

            Console.ReadLine();
        }


        static IEnumerable<String> CombinationsWithRepition(IEnumerable<string> input, int length)
        {
            if (length <= 0)
                yield return "";
            else
            {
                foreach (var i in input)
                    foreach (var c in CombinationsWithRepition(input, length - 1))
                        yield return i.ToString() + c;
            }
        }
    }
}
