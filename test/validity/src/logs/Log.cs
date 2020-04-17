//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum LogArea
    {
        Test,

        Bench,

        App,

        Data,
    }

    class EnvConfig
    {
        public EnvConfig()
        {
        
        }

        FolderPath OutputFolder
            => FolderPath.Define(Settings.LogRoot);

        FolderPath DataFolder
            => OutputFolder + FolderName.Define("data");

        public FolderPath DataDir(FolderName subfolder)
            => DataFolder + subfolder;

        public FolderPath LogDir(LogArea target)        
            => OutputFolder + FolderName.Define(target.ToString().ToLower());

        public FolderPath LogDir(LogArea target, FolderName subdir)        
            => OutputFolder + (FolderName.Define(target.ToString().ToLower()) + subdir);
    }

    readonly struct TestLogPaths
    {
        public static TestLogPaths The => default;

        public FilePath DataPath(FolderName subject, FileName file)
            => Settings.DataDir(subject) + file;

        public FilePath LogPath(LogArea area, string basename, FileExtension ext = null)
            => Settings.LogDir(area) + FileName.Define($"{basename}.{ext ?? DefaultExtension}");

        public FilePath LogPath(LogArea area, FolderName subdir, string basename, FileExtension ext = null)
            => Settings.LogDir(area, subdir) + FileName.Define($"{basename}.{ext ?? DefaultExtension}");

        public FilePath Timestamped(LogArea area, string basename, FileExtension ext = null)
            => Settings.LogDir(area) + FileName.Define($"{basename}.{LogDate}.{ext ?? DefaultExtension}");

        public FilePath UniqueLogPath(LogArea area, string basename, FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = time.now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, basename, ext, elapsed);
        }

        public FilePath UniqueLogPath(LogArea area, FolderName subdir, string basename, FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = time.now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, subdir, basename, ext, elapsed);
        }

        static FilePath LogPath(LogArea area, string basename, FileExtension ext, long timestamp)
            => LogDir(area) + FileName.Define($"{basename}.{timestamp}.{ext ?? DefaultExtension}");

        static FilePath LogPath(LogArea area, FolderName subdir, string basename, FileExtension ext, long timestamp)
            => LogDir(area, subdir) + FileName.Define($"{basename}.{timestamp}.{ext ?? DefaultExtension}");
   
        static EnvConfig Settings
            => new EnvConfig();

        static long LogDate
            => Date.Today.ToDateKey();

        static FileExtension DefaultExtension
            => FileExtension.Define("log");

        static FolderPath LogDir(LogArea target)        
            => Settings.LogDir(target);

        static FolderPath LogDir(LogArea target, FolderName subject)        
            => Settings.LogDir(target, subject);
    }
}