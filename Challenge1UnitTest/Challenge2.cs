using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge1UnitTest
{
    [TestClass]
    public class Challenge2
    {
        [TestMethod]
        public void UnequalLengthHex()
        {
            CryptoUtility.Xor xor = new CryptoUtility.Xor();

            try
            {
                string result = xor.EncryptEqualLengthHex("7F4", "65Ds");
                Assert.Fail("No Exeption Passed");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Arguments should have same length.", ex.Message);
            }

        }


        [TestMethod]
        public void IncorrectHex()
        {
            CryptoUtility.Xor xor = new CryptoUtility.Xor();

            try
            {
                string result = xor.EncryptEqualLengthHex("7HF", "S6F");
                Assert.Fail("No Exeption Passed");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Additional non-parsable characters are at the end of the string.", ex.Message);
            }

        }


        [TestMethod]
        public void TestResult()
        {
            CryptoUtility.Xor xor = new CryptoUtility.Xor();

            string result = xor.EncryptEqualLengthHex("1c0111001f010100061a024b53535009181c", "686974207468652062756c6c277320657965");
            Assert.AreEqual("746865206b696420646f6e277420706c6179", result);


        }
    }
}
