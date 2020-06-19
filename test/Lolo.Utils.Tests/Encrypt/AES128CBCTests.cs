using Xunit;
using Lolo.Utils.Encrypt;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lolo.Utils.Encrypt.Tests
{
    public class AES128CBCTests
    {
        [Fact()]
        public void Base64EncryptTest()
        {
            //Arrange
            string iv = Convert.ToBase64String(Encoding.Default.GetBytes("1234567812345678"));
            string key = Convert.ToBase64String(Encoding.Default.GetBytes("8765432187654321"));
            string str = "hello world";

            //ACT
            var encrypt = AES128CBC.Base64Encrypt(str, key, iv);

            //Assert 
            Assert.True(AES128CBC.Base64Decrypt(encrypt, key, iv) == str, encrypt);
        }

        [Fact()]
        public void Base64DecryptTest()
        {
            //Arrange
            string iv = Convert.ToBase64String(Encoding.Default.GetBytes("1234567812345678"));
            string key = Convert.ToBase64String(Encoding.Default.GetBytes("8765432187654321"));
            string str = "HxivQmmD+hhS5WodniAWSg==";//hello world

            //ACT
            var encrypt = AES128CBC.Base64Decrypt(str, key, iv);

            //Assert 
            Assert.True(encrypt == "hello world", encrypt);
        }

        [Fact()]
        public void EncryptTest()
        {
            //Arrange
            string iv = "1234567812345678";
            string key = "8765432187654321";
            string str = "hello world";

            //ACT
            var encrypt = AES128CBC.Encrypt(str, key, iv);

            //Assert 
            Assert.True(AES128CBC.Decrypt(encrypt, key, iv) == str, encrypt);
        }

        [Fact()]
        public void DecryptTest()
        {
            //Arrange
            string iv = "1234567812345678";
            string key = "8765432187654321";
            string str = "HxivQmmD+hhS5WodniAWSg==";//hello world

            //ACT
            var encrypt = AES128CBC.Decrypt(str, key, iv);

            //Assert 
            Assert.True(encrypt == "hello world", encrypt);
        }
    }
}