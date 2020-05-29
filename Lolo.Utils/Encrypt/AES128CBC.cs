using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Lolo.Utils.Encrypt
{
    public static class AES128CBC
    {

        /// <summary>
        /// AES加密 -base64(微信小程序可用)
        /// </summary>
        /// <param name="encryptStr"></param>
        /// <param name="key"></param>
        /// <param name="ivStr"></param>
        /// <returns></returns>
        public static string Base64Encrypt(string encryptStr, string key, string ivStr)
        {
            byte[] iv = Convert.FromBase64String(ivStr);
            byte[] keyArray = Convert.FromBase64String(key);

            string base64string = Convert.ToBase64String(Encoding.Default.GetBytes(encryptStr));
            byte[] toEncryptArray = Convert.FromBase64String(base64string);
            RijndaelManaged rDel = new RijndaelManaged
            {
                Key = keyArray,
                IV = iv,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// AES解密-base64(微信小程序信息可用)
        /// </summary>
        /// <param name="decryptStr"></param>
        /// <param name="key"></param>
        /// <param name="ivStr"></param>
        /// <returns></returns>
        public static string Base64Decrypt(string decryptStr, string key, string ivStr)
        {
            byte[] keyArray = Convert.FromBase64String(key);
            byte[] iv = Convert.FromBase64String(ivStr);
            byte[] toEncryptArray = Convert.FromBase64String(decryptStr);
            RijndaelManaged rDel = new RijndaelManaged
            {
                Key = keyArray,
                IV = iv,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="encryptStr"></param>
        /// <param name="key"></param>
        /// <param name="ivStr"></param>
        /// <returns></returns>
        public static string Encrypt(string encryptStr, string key, string ivStr)
        {
            byte[] iv = Encoding.UTF8.GetBytes(ivStr);
            byte[] keyArray = Encoding.UTF8.GetBytes(key);

            byte[] toEncryptArray = Encoding.UTF8.GetBytes(encryptStr);
            RijndaelManaged rDel = new RijndaelManaged
            {
                Key = keyArray,
                IV = iv,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="decryptStr"></param>
        /// <param name="key"></param>
        /// <param name="ivStr"></param>
        /// <returns></returns>
        public static string Decrypt(string decryptStr, string key, string ivStr)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(key);
            byte[] iv = Encoding.UTF8.GetBytes(ivStr);
            byte[] toEncryptArray = Convert.FromBase64String(decryptStr);
            RijndaelManaged rDel = new RijndaelManaged
            {
                Key = keyArray,
                IV = iv,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}
