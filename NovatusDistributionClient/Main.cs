using System.IO;
using System.Net.Http;
using Chared;
using Chared.Network;
using Newtonsoft.Json;

namespace NovatusDistributionClient
{
    public class Main
    {
        public bool CheckForUpdate(string applicationInfoFile)
        {
            if (File.Exists(applicationInfoFile))
            {
                var updateInfo = ReadFile(applicationInfoFile);
				GetUpdateInfo(updateInfo);
            }
            return false; 
        }

        private VersionInfo ReadFile(string applicationInfoFile)
        {
            string jsonText = File.ReadAllText(applicationInfoFile);
            return JsonConvert.DeserializeObject<VersionInfo>(jsonText);
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="updateInfo"></param>
        private void GetUpdateInfo(VersionInfo updateInfo)
        {
			HttpConnector httpConnector = new HttpConnector();

			var versionList = httpConnector.GetVersionList(updateInfo);
			foreach (var version in versionList.List)
			{
				
			}
			/*
			 * static class Program
{
    static void Main()
    {
        string v1 = "1.23.56.1487";
        string v2 = "1.24.55.487";

        var version1 = new Version(v1);
        var version2 = new Version(v2);

        var result = version1.CompareTo(version2);
        if (result > 0)
            Console.WriteLine("version1 is greater");
        else if (result < 0)
            Console.WriteLine("version2 is greater");
        else
            Console.WriteLine("versions are equal");
        return;

    }
}
			 
			 */

			//TODO read all version in list when version is same as local download nextversion in the list 
			// then do this un till the end of the list 
		}
	}
}
