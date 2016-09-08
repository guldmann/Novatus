
NovatusDistributionClient
-------------------------

NovatusDistributionClient.dll is intended to be distributed and called from the application. 

to use NovatusDistributionClient.dll 

Add a reference to NovatusDistributionClient in youre project.
c# code to check for new Version
 
 NovatusDistributionClient novatusClient = new NovatusDistributionClient();
 bool newerVersion  = novatusClient.CheckForUpdate("applicationInfoFile.json"); 

 This will retun true if there is a new version on the server or false if current version is the newest.

 applicationInfoFile.json is a json file containing object of "VersionInfo" information of the current appliceation version.

 Calling novatusClient.CheckForUpdate  donwnloads a json file "Versionlist.json" with all versions of the application on the server. 
 Versionlist.json is saved in the application root. 
 
 Updating the application to a newer version we need to call UpdateClient.exe distributed with the application. 

Starting UpdateClient.exe. it takes 2 arguments 
1. Prompt user true/false  default is true, if true user will be given a choice to download new version or not this will show a GUI for the user false will silently download new version. 
2. Name of Versionlist file default to null and if null it will contact the server and download it 


UpdateClient.exe from C# code   

public void RunUpdateClient()
{
	ProcessStartInfo start = new ProcessStartInfo();
	start.WorkingDirectory = dir to UpdateClient.exe or null;
	start.Arguments = argumentOne argumentTwo;
	start.FileName = UpdateClient.exe;
	try
	{
		var proc = Process.Start(start);		
	}
	catch(Exception e)
	{
		//catch exceptions  
	}	
}


* To compare Application Version we use version.CompareTo this restrict version format to int32.int32.int32.int32 
 Exampel of apllication version numbers: 
 [1.0] [3] [1.0.1] [2.1.4.3]
 
 
  
   