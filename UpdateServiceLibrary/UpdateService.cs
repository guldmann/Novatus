using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UpdateServiceLibrary.IO;

namespace UpdateServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class UpdateService : IUpdateCommunicationService, IUpdateFilesService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        #region UpdateFileService
        public Stream DownloadFileStream(string fileName, string token)
        {
            throw new NotImplementedException();
        }

        public Stream UploadFileStream(string fileName, string token)
        {
            throw new NotImplementedException();
        }

        public FileInfo GetFileInfo(string filename, string token)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
