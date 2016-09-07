using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace UpdateServiceLibrary.IO
{
	//How about token do we need it  ?  
	[ServiceContract]
	interface IUpdateFilesService
	{
		[OperationContract]
		Stream DownloadFileStream(string fileName, string token);
		
		[OperationContract]
		FileInfo GetFileInfo(string filename, string token);

		[OperationContract]
		Stream UploadFileStream(string fileName, string token);
	}
}
