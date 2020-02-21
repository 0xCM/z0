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
    public class EnvConfig
    {
        public static EnvConfig Get()
            => new EnvConfig();

        private EnvConfig()
        {
        
        }

        FolderPath OutputFolder
            =>  FolderPath.Define(Settings.LogRoot);

        // FolderPath OutputFolder
        //     =>  FolderPath.Define(@"J:\dev\projects\z0-logs");

        FolderPath DevRoot
            => FolderPath.Define(Settings.DevRoot);

        FolderPath ApiFolder
            => DevRoot + FolderName.Define("api");

        FolderPath DataFolder
            => OutputFolder + FolderName.Define("data");

        FolderPath TestFolder
            => OutputFolder + FolderName.Define("test");

        FolderPath ConfigFolder
            => DevRoot + FolderName.Define(".settings");

        public FilePath ConfigPath(FileName file)
            => ConfigFolder + file;
            
        public FilePath TestLogPath(FileName filename)
            => TestFolder + filename;

        public FolderPath DataDir(FolderName subfolder)
            => DataFolder + subfolder;

        public FolderPath ApiDir(FolderName subject)
            => ApiFolder + subject;

        public FolderPath ApiSrcDir()
            => ApiFolder + FolderName.Define("src");

        public FolderPath ApiSrcDir(FolderName subject)
            => ApiSrcDir() + subject;

        public FolderPath LogDir(LogArea target)        
            => OutputFolder + FolderName.Define(target.ToString().ToLower());

        public FolderPath LogDir(LogArea target, FolderName subdir)        
            => OutputFolder + (FolderName.Define(target.ToString().ToLower()) + subdir);
    }
}