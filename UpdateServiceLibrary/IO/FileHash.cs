using System;
using System.IO;
using System.Security.Cryptography;

namespace UpdateServiceLibrary.IO
{
    class FileHash
    {
        public string Sha1Hash(FileStream dirFile, long length)
        {
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            string ret = BitConverter.ToString(sha.ComputeHash(dirFile)).Replace("-", "").ToLower();
            dirFile.Close();
            return ret;
        }

        public string MD5Checsum(FileStream dirFile, long length)
        {
            var md5Sum = MD5.Create();
            string ret = BitConverter.ToString(md5Sum.ComputeHash(dirFile)).Replace("-", "").ToLower();
            dirFile.Close();
            return ret;
        }
    }
}
