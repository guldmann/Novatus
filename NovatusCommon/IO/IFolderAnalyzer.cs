using System;
using System.Collections.Generic;
using System.Text;
using NovatusCommon.Models;

namespace NovatusCommon.IO
{
    public interface IFolderAnalyzer
    {
        List<FileItem> Analyze(string path);
    }
}
