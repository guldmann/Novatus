using NovatusCommon.Models;
using System.Collections.Generic;
using System.IO;

namespace NovatusCommon.IO
{
    public class FolderAnalyzer : IFolderAnalyzer
    {
        private readonly List<string> _fileFilter;
        private readonly List<string> _folderFilter;
        private List<FileItem> _fileItems;
        private string _stripPath;
        private string _rootFolder;

        public FolderAnalyzer(List<string> fileFilter = null, List<string> folderFilter = null)
        {
            // TODO: Add Ilogger

            _fileFilter = fileFilter ?? new List<string>();
            _folderFilter = folderFilter ?? new List<string>();
            _fileItems = new List<FileItem>();
        }

        public List<FileItem> Analyze(string path)
        {
            // strip full path
            int lastIndex = path.LastIndexOf('\\');
            _stripPath = path;

            //_stripPath = path.Substring(0, lastIndex + 1);
            _rootFolder = path.Substring(lastIndex + 1);
            //_rootFolder = path.Replace(_stripPath, "");

            if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                FindAllFiles(path);
            }

            return _fileItems;
        }

        private void ProcessFile(string file)
        {
            var fileInfo = new FileInfo(file);
            if (fileInfo.Directory == null) return;

            string fromRoot = fileInfo.Directory.ToString().Replace(_stripPath, "");
            var fileItem = new FileItem
            {
                RootDir = _rootFolder,
                FilePathFromRoot = fromRoot,

                FileName = fileInfo.Name,
                FileHash = SHA256Hash.GetHashFromFile(fileInfo.FullName),
                FileSize = fileInfo.Length
            };
            _fileItems.Add(fileItem);
        }

        private void FindAllFiles(string path)
        {
            //TODO File and folder filter in here

            foreach (string file in Directory.GetFiles(path))
            {
                ProcessFile(file);
            }

            foreach (string subDir in Directory.GetDirectories(path))
            {
                try
                {
                    FindAllFiles(subDir);
                }
                catch
                {
                    // swallow, log, whatever
                }
            }
        }
    }
}