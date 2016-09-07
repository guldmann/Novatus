using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Chared.Network
{
	public class HttpConnector
	{
		/// <summary>
		/// Takes a VersionInifo and get a Versionlist from server
		/// </summary>
		/// <param name="localVersion"></param>
		/// <returns></returns>
		public VersionList GetVersionList(VersionInfo localVersion)
		{
			string versionList; 
			try
			{
				WebClient wc = new WebClient();
				versionList = Path.Combine(localVersion.TempDir + "Versionlist.json"); 
				wc.DownloadFile(localVersion.ServerList[0].Url, versionList);
				wc.Dispose();
			}
			catch (Exception ex)
			{
				return null; 
			}
			string jsonText = File.ReadAllText(versionList);
			return JsonConvert.DeserializeObject<VersionList>(jsonText);
		}
	}
}
