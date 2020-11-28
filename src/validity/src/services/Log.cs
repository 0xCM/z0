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
            => Settings.LogDir(area) + FS.file(basename, ext ?? ArchiveFileKinds.Log);

        public FS.FilePath LogPath(LogArea area, FS.FolderName subdir, string basename, FS.FileExt? ext = null)
            => Settings.LogDir(area, subdir) + FS.file(basename, ext ?? ArchiveFileKinds.Log);

        public FS.FilePath Timestamped(LogArea area, string basename, FS.FileExt? ext = null)
            => Settings.LogDir(area) + FS.file($"{basename}.{LogDate}", ext ?? ArchiveFileKinds.Log);

        public FS.FilePath UniqueLogPath(LogArea area, string basename, FS.FileExt? ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = Time.now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, basename, ext ?? ArchiveFileKinds.Log, elapsed);
        }

        public FS.FilePath UniqueLogPath(LogArea area, FS.FolderName subdir, string basename, FS.FileExt? ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = Time.now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, subdir, basename, ext ?? ArchiveFileKinds.Log, elapsed);
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

    static class Log
    {
        static TestLogPathsLegacy Paths
            => TestLogPathsLegacy.The;

        public static ITestLogger BenchLog
            => BenchLogger.TheOnly;

        class TestLogger<A> : ITestLogger, IAppMsgContext
            where A : TestLogger<A>, new()
        {
            public static A TheOnly = new A();

            public LogArea Area {get;}

            protected object locker = new object();

            protected TestLogger(LogArea area)
            {
                Area = area;
            }

            FS.FilePath LogPath
                => Paths.Timestamped(Area, Area.ToString().ToLower());

            void Emit<R>(IReadOnlyList<R> records, char delimiter, bool header, FS.FilePath dst)
                where R : ITabular
            {
                if(records.Count == 0)
                    return;

                dst.CreateParentIfMissing();
                if(header)
                    dst.AppendLine(string.Join(delimiter, records[0].HeaderNames));

                z.iter(records, r => dst.AppendLine(r.DelimitedText(delimiter)));
            }

            FS.FilePath ComputePath(FS.FolderName subdir, string basename, bool create, FS.FileExt ext)
                => create
                    ? (subdir.IsEmpty ? Paths.UniqueLogPath(Area,basename,ext)
                                      : Paths.UniqueLogPath(Area, subdir, basename,ext))
                    : (subdir.IsEmpty ?  Paths.LogPath(Area, basename, ext)
                                      : Paths.LogPath(Area, subdir, basename, ext));

            public FS.FilePath Write<R>(IEnumerable<R> src, FS.FolderName subdir, string basename, LogWriteMode mode, char delimiter, bool header = true, FS.FileExt ext = default)
                where R : ITabular
            {
                var records = src.ToArray();
                if(records.Length == 0)
                    return FS.FilePath.Empty;

                ext = ext.IsEmpty ? ArchiveFileKinds.Log : ext;

                var path = ComputePath(subdir,basename, mode == LogWriteMode.Create, ext);

                if(mode == LogWriteMode.Create)
                     Emit(records, delimiter, header, path);
                else if(mode == LogWriteMode.Append)
                    lock(locker)
                        Emit(records, delimiter, header, path);
                else
                {
                    path.Delete();
                    Emit(records, delimiter, header, path);
                }
                return path;
            }

            [MethodImpl(Inline)]
            public void Deposit(IAppMsg src)
            {
                lock(locker)
                    LogPath.AppendLine(src.ToString());
            }

            [MethodImpl(Inline)]
            public void Notify(string msg, LogLevel? severity = null)
                => Deposit(AppMsg.define(msg,severity ?? LogLevel.Info));
        }

        sealed class BenchLogger : TestLogger<BenchLogger>
        {
            public BenchLogger()
             : base(LogArea.Bench)
            {

            }
        }
    }
}