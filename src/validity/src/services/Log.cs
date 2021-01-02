//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum LogArea
    {
        Test,

        Bench,

        App,

    }

    class EnvConfig
    {
        public EnvConfig()
        {

        }

        FS.FolderPath OutputFolder
            => EnvVars.Common.LogRoot;

        public FS.FolderPath LogDir(LogArea target)
            => OutputFolder + FS.folder(target.ToString().ToLower());

        public FS.FolderPath LogDir(LogArea target, FS.FolderName subdir)
            => OutputFolder + (FS.folder(target.ToString().ToLower()) + subdir);
    }

    readonly struct TestLogPathsLegacy
    {
        public static TestLogPathsLegacy The => default;

        public FS.FilePath LogPath(LogArea area, string basename, FS.FileExt? ext = null)
            => Settings.LogDir(area) + FS.file(basename, ext ?? FileExtensions.Log);

        public FS.FilePath LogPath(LogArea area, FS.FolderName subdir, string basename, FS.FileExt? ext = null)
            => Settings.LogDir(area, subdir) + FS.file(basename, ext ?? FileExtensions.Log);

        public FS.FilePath Timestamped(LogArea area, string basename, FS.FileExt? ext = null)
            => Settings.LogDir(area) + FS.file($"{basename}.{LogDate}", ext ?? FileExtensions.Log);

        public FS.FilePath UniqueLogPath(LogArea area, string basename, FS.FileExt? ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = Time.now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, basename, ext ?? FileExtensions.Log, elapsed);
        }

        public FS.FilePath UniqueLogPath(LogArea area, FS.FolderName subdir, string basename, FS.FileExt? ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = Time.now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, subdir, basename, ext ?? FileExtensions.Log, elapsed);
        }

        static FS.FilePath LogPath(LogArea area, string basename, FS.FileExt ext, long timestamp)
            => LogDir(area) + FS.file($"{basename}.{timestamp}", ext);

        static FS.FilePath LogPath(LogArea area, FS.FolderName subdir, string basename, FS.FileExt ext, long timestamp)
            => LogDir(area, subdir) + FS.file($"{basename}.{timestamp}.{ext}", ext);

        static EnvConfig Settings
            => new EnvConfig();

        static long LogDate
            => Date.Today.ToDateKey();

        static FS.FolderPath LogDir(LogArea target)
            => Settings.LogDir(target);

        static FS.FolderPath LogDir(LogArea target, FS.FolderName subject)
            => Settings.LogDir(target, subject);
    }
}