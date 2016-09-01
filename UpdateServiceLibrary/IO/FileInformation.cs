using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateServiceLibrary.IO
{
    class FileInformation
    {
        public static long GetFileSize(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileInfo fInfo = new FileInfo(fileName);
                return fInfo.Length;
            }
            throw new FileNotFoundException("File don't exist", fileName);
        }

        public static FileInfo GetFileInfo(string fileName)
        {
            if (File.Exists(fileName))
            {
                return new FileInfo(fileName);

            }
            throw  new FileNotFoundException("File don't exist", fileName);
        }
    }
}
