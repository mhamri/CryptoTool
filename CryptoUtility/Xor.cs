using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoUtility
{
    public class Xor
    {
        public string EncryptEqualLengthHex(string firstStringHex, string secondStringHex )
        {
            if (firstStringHex.Length!= secondStringHex.Length)
            {
                throw new Exception("Arguments should have same length.");
            }


            Utility cryptoUtil = new Utility();
            byte[] firstHexByte = cryptoUtil.HexToByteArray(firstStringHex);
            byte[] secondHexByte = cryptoUtil.HexToByteArray(secondStringHex);
            byte[] xored = new byte[firstHexByte.Length];
            for (int i = 0; i < firstHexByte.Length; i++)
            {
                xored[i] = Convert.ToByte(firstHexByte[i] ^ secondHexByte[i]);
            }
            return BitConverter.ToString(xored).Replace("-", "").ToLower();
        }

        public string EncryptOrDecrypt(string text, string key)
        {
            var result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
                result.Append((char)((uint)text[c] ^ (uint)key[c % key.Length]));

            return result.ToString();
        }
    }

    
}
