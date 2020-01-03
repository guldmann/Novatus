using NovatusCommon.Models;
using System;
using System.IO;
using System.Text.Json;

namespace NovotusClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // start by reading application json
            // then do a lookup to server to see if current version is latest
            // if not latest do ask user to download
            // if user say download do download
            // Add and show progresss of download
            // do a backup of replaced files to give ability to go back
            // restart application and apply new files
            //

            //Look for updates

            // download update

            // ??

            if (args != null)
            {
                Console.WriteLine("Missing arguments!");
            }
            if (args[0] != null && args[0] == "update")
            {
                var updateServer = parseUpdateServerSettings();
                switch (updateServer.ComType)
                {
                    //case ComType.HTTP:
                    //    //DO http call here
                    //break;
                    //case ComType.API:
                    //    //Do Api call here
                    //break;
                    //case ComType.FTP:
                    //    //Do Ftp call herer
                    //break;
                    //case ComType.Network:
                    //    //Do network call here
                    //break;
                }
            }

            if (args[0] != null && args[0] == "download")
            {
                // Do download here and go on do the rest
            }
        }

        private static UpdateServer parseUpdateServerSettings()
        {
            if (File.Exists("UpdateServer.json"))
            {
                return JsonSerializer.Deserialize<UpdateServer>(File.ReadAllText("UpdateServer.json"));
            }
            else
            {
                throw new FileNotFoundException("File is missing reinstall to fix this", "UpdateServer.json");
            }
        }
    }
}