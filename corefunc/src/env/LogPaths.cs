//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;


    public readonly struct LogPaths
    {
        public static LogPaths The => default;
    
        static EnvConfig Settings
            => EnvConfig.Get();

        long LogDate
            => Date.Today.ToDateKey();

        FileExtension DefaultExtension
            => FileExtension.Define("log");

        /// <summary>
        /// Gets the log folder for a specific area
        /// </summary>
        /// <param name="target">The area target</param>
        public FolderPath AreaFolder(ILogTarget target)
            =>  Settings.LogDir(target.Area);

        /// <summary>
        /// Gets the log folder for a specific area and subfolder
        /// </summary>
        /// <param name="target">The area target</param>
        /// <param name="subfolder">The target subfolder</param>
        public FolderPath AreaFolder(ILogTarget target, FolderName subfolder)
            => Settings.LogDir(target.Area, subfolder);

        /// <summary>
        /// Creates a fully-qualified log file path
        /// </summary>
        /// <param name="area">The area</param>
        /// <param name="file">The filename</param>
        public FilePath TargetPath(LogArea area, FileName file)
            => AreaFolder(LogTarget.Define(area)).CreateIfMissing() + file;

        /// <summary>
        /// Creates a fully-qualified log file path
        /// </summary>
        /// <param name="area">The area</param>
        /// <param name="subject">The area subfolder</param>
        /// <param name="file">The filename</param>
        public FilePath TargetPath(LogArea area, FolderName subject, FileName file)
            => AreaFolder(LogTarget.Define(area), subject).CreateIfMissing() + file;

        public FolderPath LogDir(LogArea target)        
            => Settings.LogDir(target);

        public FolderPath LogDir(LogArea target, FolderName subject)        
            => Settings.LogDir(target, subject);

        public FolderPath DataDir(FolderName subject)
            => Settings.DataDir(subject);

        public FilePath DataPath(FolderName subject, FileName file)
            => Settings.DataDir(subject) + file;

        public FilePath ConfigPath(string name, FileExtension ext = null)
            => Settings.ConfigPath(FileName.Define(name, ext ?? FileExtension.Define("json")));

        public FilePath LogPath(LogArea area, string basename, FileExtension ext = null)
            => LogDir(area) + FileName.Define($"{basename}.{ext ?? DefaultExtension}");

        public FilePath LogPath(LogArea area, FolderName subdir, string basename, FileExtension ext = null)
            => LogDir(area, subdir) + FileName.Define($"{basename}.{ext ?? DefaultExtension}");

        public FilePath Timestamped(LogArea area, string basename, FileExtension ext = null)
            => LogDir(area) + FileName.Define($"{basename}.{LogDate}.{ext ?? DefaultExtension}");

        FilePath LogPath(LogArea area, string basename, FileExtension ext, long timestamp)
            => LogDir(area) + FileName.Define($"{basename}.{timestamp}.{ext ?? DefaultExtension}");

        FilePath LogPath(LogArea area, FolderName subdir, string basename, FileExtension ext, long timestamp)
            => LogDir(area, subdir) + FileName.Define($"{basename}.{timestamp}.{ext ?? DefaultExtension}");

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
    }
}