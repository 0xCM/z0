//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static zfunc;

    /// <summary>
    /// Hack
    /// </summary>
    public class LogSettings
    {
        public static LogSettings Get()
            => new LogSettings();

        private LogSettings()
        {

        }
        
        public FolderPath RootFolder
            => FolderPath.Define(@"J:\dev\projects\z0-logs");
            
        public FolderPath RootDataFolder
            => RootFolder + FolderName.Define("data");

        public FolderPath RootTestFolder
            => RootFolder + FolderName.Define("test");

        public FolderPath RootAppFolder
            => RootFolder + FolderName.Define("app");

        public FolderPath RootBenchFolder
            => RootFolder + FolderName.Define("bench");

        public FilePath TestLogPath(FileName filename)
            => RootTestFolder + filename;

        public FolderPath DataDir(FolderName subfolder)
            => RootDataFolder + subfolder;

        public FolderPath LogDir(LogArea target)        
            => RootFolder + FolderName.Define(target.ToString().ToLower());

        public FolderPath LogDir(LogArea target, FolderName subdir)        
            => RootFolder + (FolderName.Define(target.ToString().ToLower()) + subdir);
    }
}