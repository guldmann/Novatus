using System;

namespace NovatusCommon.Models
{
    [Serializable]
    public class FileItem : IEquatable<FileItem>
    {
        public string FileName { get; set; }
        public string FileHash { get; set; }
        public string FilePathFromRoot { get; set; }
        public long FileSize { get; set; }

        public bool Equals(FileItem other)
        {
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(this, other)) return true;

            return FileName.Equals(other.FileName) &&
                   FilePathFromRoot.Equals(other.FilePathFromRoot) &&
                   FileHash.Equals(other.FileHash) &&
                   FileSize.Equals(other.FileSize);
        }
    }
}
