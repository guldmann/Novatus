using System;

namespace NovatusCommon.Models
{
    /// <summary>
    /// FileItem holds information of a file for application.
    /// a application have a collection of files, the files are listed in a content file as FileItems.
    ///
    /// FileInfo is used to compare items in 
    /// Content list for a new update vs local content files to know what
    /// files have changed and what files is new or to be deleted.   
    /// </summary>
    [Serializable]
    public class FileItem : IEquatable<FileItem>
    {
        /// <summary>
        /// Name of the file.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Hash of file to compare server file to local file. 
        /// </summary>
        public string FileHash { get; set; }

        /// <summary>
        /// Information on file location where is it on local application
        /// and where do the new file go based on local application root folder. 
        /// </summary>
        public string FilePathFromRoot { get; set; }

        public string RootDir { get; set; }

        /// <summary>
        /// the size of the file, could be useful for progressbar.
        /// </summary>
        public long FileSize { get; set; }


        /// <summary>
        /// Compare if files are equal.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
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
