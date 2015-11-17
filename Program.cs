using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CryptoTool
{
    class Program
    {
        static void Main(string[] args)
        {

            Utility u = new Utility();
            string v= u.StringToBase64("49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d");
            if (v== "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t")
            {
                Console.WriteLine("true");
            }

           Console.ReadLine();

        }
    }
}
