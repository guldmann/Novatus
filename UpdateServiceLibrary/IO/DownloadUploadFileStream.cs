using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UpdateServiceLibrary.IO
{
	//TODO test this 
	static class DownloadUploadFileStream
	{
		public static Stream GetFile(string fileName)
		{
			if (File.Exists(fileName))
			{
				Stream stream = File.OpenRead(fileName);
				return stream;
			}
			throw new FileNotFoundException("File don't exist", fileName);
		}

		//TODO test this 
		public static bool PutFile(string filename)
		{
			if (!File.Exists(filename))
			{
				Stream stream = File.OpenWrite(filename);
				return true;
			}
			return false; 
		}

	}
}
