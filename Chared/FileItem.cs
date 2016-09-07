using System;

namespace Chared
{
    [Serializable]
    public class FileItem : IEquatable<FileItem>
    {

        public string FileName { get; set; }
        public string SHAHash { get; set; }
        public string RootPath { get; set; }
		public long FileSize { get; set;  } 

        public bool Equals(FileItem other)
        {
	        if (Object.ReferenceEquals(other, null)) return false;
	        if (object.ReferenceEquals(this, other)) return true;
	        return FileName.Equals(other.FileName) &&
	               RootPath.Equals(other.RootPath) &&
	               SHAHash.Equals(other.SHAHash) &&
	               FileSize.Equals(other.FileSize); 
        }
    }
}
