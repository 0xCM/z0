//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    using static zfunc;


    public readonly struct DataPaths
    {

        public static DataPaths The => default;
    
        static LogSettings Settings
            => LogSettings.Get();

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
        /// <param name="subfolder">The area subfolder</param>
        /// <param name="file">The filename</param>
        public FilePath TargetPath(LogArea area, FolderName subfolder, FileName file)
            => AreaFolder(LogTarget.Define(area), subfolder).CreateIfMissing() + file;

        public FolderPath LogDir(LogArea target)        
            => Settings.LogDir(target);

        public FolderPath LogDir(LogArea target, FolderName subdir)        
            => Settings.LogDir(target, subdir);

        public FilePath TestLogPath(FileName filename)
            => LogDir(LogArea.Test) + filename;

        public FilePath TestLogPath(FolderName subfolder, FileName filename)
            => LogDir(LogArea.Test, subfolder) + filename;

        public FilePath LogPath(LogArea area, FileExtension ext = null, long? timestamp = null)
            => LogDir(area) + FileName.Define($"{area}.{timestamp ?? LogDate}.{ext ?? DefaultExtension}");

        public FilePath LogPath(LogArea area, FolderName subdir, FileExtension ext = null, long? timestamp = null)
            => LogDir(area, subdir) + FileName.Define($"{area}.{timestamp ?? LogDate}.{ext ?? DefaultExtension}");

        public FilePath LogPath(LogArea area, string topic, FileExtension ext = null, long? timestamp = null)
            => LogDir(area) + FileName.Define($"{area}.{topic}.{timestamp ?? LogDate}.{ext ?? DefaultExtension}");

        public FilePath LogPath(LogArea area, FolderName subdir, string topic, FileExtension ext = null, long? timestamp = null)
            => LogDir(area, subdir) + FileName.Define($"{area}.{topic}.{timestamp ?? LogDate}.{ext ?? DefaultExtension}");

        public FilePath LogPath(ILogTarget target, FileExtension ext = null, long? timestamp = null)
            => LogDir(target.Area) + FileName.Define($"{target.Area}.{target.Name}.{timestamp ?? LogDate}.{ext ?? DefaultExtension}");

        public FilePath LogPath(ILogTarget target, FolderName subdir,  FileExtension ext = null, long? timestamp = null)
            => LogDir(target.Area, subdir) + FileName.Define($"{target.Area}.{target.Name}.{timestamp ?? LogDate}.{ext ?? DefaultExtension}");

        public FilePath UniqueLogPath(LogArea area, string topic,  FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, topic, ext, elapsed);
        }

        public FilePath UniqueLogPath(LogArea area, FolderName subdir, string topic,  FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, subdir, topic, ext, elapsed);
        }

        public FilePath UniqueLogPath(LogArea area, FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, ext, elapsed);
        }

        public FilePath UniqueLogPath(LogArea area, FolderName subdir, FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, subdir, ext, elapsed);
        }

        public FilePath UniqueLogPath(ILogTarget target, FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(target, ext, elapsed);
        }

        public FilePath UniqueLogPath(ILogTarget target, FolderName subdir, FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(target, subdir, ext, elapsed);
        }
    }
}