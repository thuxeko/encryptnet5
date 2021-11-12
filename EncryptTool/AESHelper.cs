using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptTool
{
    public static class AESHelper
    {
        private const string aesDefaultKey = "YOUR DEFAULT PASSPHRASE";
        public static string Encrypt(string data, string key = null)
        {
            if (string.IsNullOrEmpty(key))
            {
                key = aesDefaultKey;
            }

            try
            {
                var aesCryptoProvider = new AesCryptoServiceProvider();
                var sha256hasher = new SHA256Managed();

                aesCryptoProvider.KeySize = 256;
                aesCryptoProvider.BlockSize = 128;
                aesCryptoProvider.Padding = PaddingMode.PKCS7;
                aesCryptoProvider.Mode = CipherMode.ECB; //CBC, CFB
                aesCryptoProvider.Key = sha256hasher.ComputeHash(Encoding.UTF8.GetBytes(key));
                byte[] byteData = Encoding.UTF8.GetBytes(data.Trim());

                return Convert.ToBase64String(aesCryptoProvider.CreateEncryptor().TransformFinalBlock(byteData, 0, byteData.Length));
            }
            catch
            {
                return null;
            }
        }

        public static string Decrypt(string data, string key = null)
        {
            if (string.IsNullOrEmpty(key))
            {
                key = aesDefaultKey;
            }

            try
            {
                var aesCryptoProvider = new AesCryptoServiceProvider();
                var sha256hasher = new SHA256Managed();

                aesCryptoProvider.KeySize = 256;
                aesCryptoProvider.BlockSize = 128;
                aesCryptoProvider.Padding = PaddingMode.PKCS7;
                aesCryptoProvider.Mode = CipherMode.ECB; //CBC, CFB
                aesCryptoProvider.Key = sha256hasher.ComputeHash(Encoding.UTF8.GetBytes(key));

                byte[] byteData = Convert.FromBase64String(data.Trim());

                return Encoding.UTF8.GetString(aesCryptoProvider.CreateDecryptor().TransformFinalBlock(byteData, 0, byteData.Length));
            }
            catch
            {
                return null;
            }
        }
    }
}
