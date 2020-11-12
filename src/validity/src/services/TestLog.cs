//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    public readonly struct TestLog
    {
        public static TestLog<TestCaseField, TestCaseRecord> Create()
            => new TestLog<TestCaseField, TestCaseRecord>();
    }

    public class TestLog<F,R> : IAppMsgContext
        where F : unmanaged, Enum
        where R : ITabular
    {
        object locker;

        static TestLogPathsLegacy Paths
            => TestLogPathsLegacy.The;

        internal TestLog()
        {
            locker = new object();
        }

        const LogArea Area = LogArea.Test;

        public FilePath Target
            => Paths.Timestamped(Area, Area.ToString().ToLower()).CreateParentIfMissing();

        static FilePath ComputePath(FolderName subdir, string basename, bool create, FileExtension ext)
            => create
                ? (subdir.IsEmpty ? Paths.UniqueLogPath(Area,basename, FS.ext(ext.Name)) : Paths.UniqueLogPath(Area, FS.folder(subdir.Name), basename, FS.ext(ext.Name)))
                : (subdir.IsEmpty ?  Paths.LogPath(Area, basename, FS.ext(ext.Name)) : Paths.LogPath(Area, FS.folder(subdir.Name), basename, FS.ext(ext.Name))) ;

        public FilePath Write(IEnumerable<R> src, FolderName subdir, string basename, LogWriteMode mode, char delimiter, bool header = true, FileExtension ext = null)
        {
            var records = src.ToArray();
            if(records.Length == 0)
                return FilePath.Empty;

            var path = ComputePath(subdir,basename, mode == LogWriteMode.Create, ext).CreateParentIfMissing();

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

        void Emit(IReadOnlyList<R> records, char delimiter, bool header, FilePath dst)
        {
            if(records.Count == 0)
                return;

            if(header)
                dst.AppendLine(Table.header53<F>(delimiter));

            var formatter = Table.formatter<F>(delimiter);

            z.iter(records, r => dst.AppendLine(r.DelimitedText(delimiter)));
        }

        public void Deposit(IAppMsg src)
        {
            lock(locker)
                Target.AppendLine(src.ToString());
        }
    }
}