using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CriptoAndHashService
{
    public static class CriptoService
    {
        private static readonly byte[] Key = { 216, 2, 104, 104, 236, 129, 49, 109, 107, 190, 10, 86, 182, 189, 104, 34, 56, 153, 220, 236, 203, 189, 40, 161, 185, 2, 174, 4, 67, 230, 202, 220 };

        private static byte[] IV = { 118, 32, 251, 50, 86, 216, 96, 128, 19, 38, 58, 25, 120, 150, 228, 130 };

        public static string Criptografar(string plainText)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");

            byte[] encrypted;
            // Create an Rijndael object
            // with the specified key and IV.
            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return Convert.ToBase64String(encrypted).Replace("/", "-2F-").Replace("+", "-2B-").Replace("=", "-3D-");
        }

        public static string Descriptografar(string texto)
        {
            // Check arguments.
            if (texto == null || texto.Length <= 0)
                throw new ArgumentNullException("cipherText");


            byte[] cipherText = Convert.FromBase64String(texto.Replace("-2F-", "/").Replace("-2B-", "+").Replace("-3D-", "="));

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = "";

            // Create an Rijndael object
            // with the specified key and IV.
            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}
