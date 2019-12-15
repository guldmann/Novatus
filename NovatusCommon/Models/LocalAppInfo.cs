namespace NovatusCommon.Models
{
    public class LocalAppInfo
    {
        /// <summary>
        /// Name of Application.
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// Application version.
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// Root folder / path for application.
        /// </summary>
        public string AppRoot { get; set; }

        /// <summary>
        /// Local application json file with information on all application files
        /// for current version.
        /// </summary>
        public string ContentFile { get; set; }

        /// <summary>
        /// Path to local path where temp files is supposed to be stored. 
        /// </summary>
        public string TempDir { get; set; }

        /// <summary>
        /// Information of server to get new application versions from.
        /// </summary>
        public UpdateServer UpdateServer { get; set; }
    }
}
