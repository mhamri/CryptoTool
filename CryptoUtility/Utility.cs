using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoUtility
{
    public class Utility
    {
        public string StringToBase64(string str)
        {
            byte[] data = StringToHex(str);
            string base64 = Convert.ToBase64String(data);
            return base64;
        }

        public string HexToBase64(byte[] hex)
        {
            return Convert.ToBase64String(hex);
        }

        public byte[] StringToHex(string str)
        {
            str = str.Replace("-", "");

            byte[] resultantArray = new byte[str.Length / 2];
            for (int i = 0; i < resultantArray.Length; i++)
            {
                resultantArray[i] = Convert.ToByte(str.Substring(i * 2, 2), 16);
            }
            return resultantArray;

        }
    }
}
