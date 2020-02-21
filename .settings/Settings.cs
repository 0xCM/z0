namespace Z0
{
    using System;

    public class Settings
    {
        public static string DevRoot
            => @"J:\dev\projects\z0";

        public static string ConfigRoot
            => $@"{DevRoot}\.config";

        public static string LogRoot
            => @"J:\dev\projects\z0-logs"; 
            
        /// <summary>
        /// Gets the source directory for a specified project
        /// </summary>
        /// <param name="ProjectFolder">The folder in which the project resides</param>
        public static string ProjectRoot(string ProjectFolder)
            => $@"{DevRoot}\{ProjectFolder}";
    }

}