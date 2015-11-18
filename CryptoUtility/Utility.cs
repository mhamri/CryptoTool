using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoUtility
{
    public class Utility
    {
        public string HexToBase64(string hex)
        {
            byte[] data = HexToByteArray(hex);
            string base64 = Convert.ToBase64String(data);
            return base64;
        }

        public string ByteToBase64(byte[] byt)
        {
            return Convert.ToBase64String(byt);
        }

        public byte[] HexToByteArray(string hex)
        {
            hex = hex.Replace("-", "").Replace(" ","");

            byte[] resultantArray = new byte[hex.Length / 2];
            for (int i = 0; i < resultantArray.Length; i++)
            {
                resultantArray[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return resultantArray;

        }

        public string HexToBinary(string hex)
        {
            byte[] hexB = HexToByteArray(hex);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hexB.Length; i++)
            {
                sb.Append(Convert.ToString(hexB[i],2).PadLeft(8,'0'));
            }

            return sb.ToString();
        }
    }
}
