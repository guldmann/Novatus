using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace NovatusCommon
{
    public static class SHA256Hash
    {
        private static byte[] GetHash(this string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(this string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public static string GetHashFromFile(string fileName)
        {
            string result;
            using (StreamReader streamReader = new StreamReader(fileName, Encoding.UTF8))
            {
                result = streamReader.ReadToEnd();
            }
            return result.GetHashString();
        }
    }
}
