using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Set1UnitTest
{
    [TestClass]
    public class Challenge1
    {
        [TestMethod]
        public void Challenge1UnitTest()
        {
            CryptoUtility.Utility cryptoUtil = new CryptoUtility.Utility();
            string output = cryptoUtil.HexToBase64("49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d");
            Assert.AreEqual(output, "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t");
        }
    }
}
