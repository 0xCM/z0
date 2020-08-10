//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using Z0.Data;
    
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

        static TestLogPaths Paths 
            => TestLogPaths.The;

        internal TestLog()       
        {
            locker = new object();
        } 
        
        const LogArea Area = LogArea.Test;

        public FilePath Target
            => Paths.Timestamped(Area, Area.ToString().ToLower());

        static FilePath ComputePath(FolderName subdir, string basename, bool create, FileExtension ext)
            => create 
                ? (subdir.IsEmpty ? Paths.UniqueLogPath(Area,basename,ext) : Paths.UniqueLogPath(Area, subdir, basename,ext)) 
                : (subdir.IsEmpty ?  Paths.LogPath(Area, basename, ext) : Paths.LogPath(Area, subdir, basename, ext)) ;

        public FilePath Write(IEnumerable<R> src, FolderName subdir, string basename, LogWriteMode mode, char delimiter, bool header = true, FileExtension ext = null)
        {
            var records = src.ToArray();
            if(records.Length == 0)
                return FilePath.Empty;                

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

        void Emit(IReadOnlyList<R> records, char delimiter, bool header, FilePath dst)
        {                
            if(records.Count == 0)
                return;

            if(header)
                dst.AppendLine(Tabular.HeaderText<F>(delimiter));

            var formatter = Table.formatter<F>(delimiter);

            Root.iter(records, r => dst.AppendLine(r.DelimitedText(delimiter)));
        }

        public void Deposit(IAppMsg src)
        {
            lock(locker)
                Target.AppendLine(src.ToString());
        }
    }
}