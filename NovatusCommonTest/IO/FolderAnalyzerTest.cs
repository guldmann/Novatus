using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using NovatusCommon.IO;

namespace NovatusCommonTest.IO
{
    public class FolderAnalyzerTest : TestBase
    {


        [Fact]
        public void When_folder_is_analyzed()
        {
            FolderAnalyzer analyzer = new FolderAnalyzer();
            CreateFiles();

            var temp = analyzer.Analyze("TestFolders");

            var test = "temo";
        }

    }
}
