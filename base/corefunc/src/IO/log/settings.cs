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

        public FilePath TestLogPath(FileName filename)
            => LogDir(LogArea.Test) + filename;

        public FolderPath LogDir(LogArea target)        
            => RootFolder + FolderName.Define(target.ToString().ToLower());

        public FolderPath LogDir(LogArea target, FolderName subdir)        
            => RootFolder + (FolderName.Define(target.ToString().ToLower()) + subdir);
    }
}