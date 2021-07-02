using System;
using System.Security.Cryptography;
using System.Text;

namespace Business
{
    public class PasswordHash
    {

        private string hash = "Password@2021$";

        public string Encrypt(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider
            {
                Key = md5.ComputeHash(Encoding.UTF8.GetBytes(hash)),
                Mode = CipherMode.ECB
            };

            ICryptoTransform transform = tripleDes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }

        public string Decrypt(string encrypted)
        {
            byte[] data = Convert.FromBase64String(encrypted);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider
            {
                Key = md5.ComputeHash(Encoding.UTF8.GetBytes(hash)),
                Mode = CipherMode.ECB
            };

            ICryptoTransform transform = tripleDes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Encoding.UTF8.GetString(result);
        }
    }
}
