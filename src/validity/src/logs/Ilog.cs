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

    using static Seed;

    static class Log
    {        
        static TestLogPaths Paths 
            => TestLogPaths.The;

        public static ITestLogger TestLog => TestLogger.TheOnly;

        public static IAppMsgSink TestMsgTarget => TestLogger.TheOnly;

        public static ITestLogger BenchLog => BenchLogger.TheOnly;

        class TestLogger<A> : ITestLogger, IAppMsgContext
            where A : TestLogger<A>, new()
        {
            public static A TheOnly = new A();
            
            public LogArea Area {get;}

            protected object locker = new object();
            
            protected TestLogger(LogArea Area)
            {
                this.Area = Area;
            }

            FilePath LogPath
                => Paths.Timestamped(Area,Area.ToString().ToLower());

            public void Write(IAppMsg src)
            {
                lock(locker)
                    LogPath.AppendLine(src.ToString());
            }

            public void Write(IEnumerable<IAppMsg> src)
            {
                lock(locker)
                    LogPath.Append(Formattable.items(src));
            }

            void Emit<R>(IReadOnlyList<R> records, char delimiter, bool header, FilePath dst)
                where R : IRecord
            {                
                if(records.Count == 0)
                    return;

                if(header)
                    dst.AppendLine(string.Join(delimiter, records[0].HeaderNames));
                
                Control.iter(records, r => dst.AppendLine(r.DelimitedText(delimiter)));
            }

            FilePath ComputePath(FolderName subdir, string basename, bool create, FileExtension ext)
                => create 
                    ? (subdir.IsEmpty ? Paths.UniqueLogPath(Area,basename,ext) : Paths.UniqueLogPath(Area, subdir, basename,ext)) 
                    : (subdir.IsEmpty ?  Paths.LogPath(Area, basename, ext) : Paths.LogPath(Area, subdir, basename, ext)) ;

            public FilePath Write<R>(IEnumerable<R> src, FolderName subdir, string basename, LogWriteMode mode, char delimiter, bool header = true, FileExtension ext = null)
                where R : IRecord
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

            [MethodImpl(Inline)]
            public void Deposit(IAppMsg src)
            {
                lock(locker)
                    LogPath.AppendLine(src.ToString());
            }

            [MethodImpl(Inline)]
            public void Notify(string msg, AppMsgKind? severity = null)
                => Deposit(AppMsg.NoCaller(msg,severity ?? AppMsgKind.Info));
        }

        sealed class AppLogger : TestLogger<AppLogger>
        {
            public AppLogger()            
             : base(LogArea.App)
            {

            }
        }

        sealed class TestLogger : TestLogger<TestLogger>
        {
            public TestLogger()            
             : base(LogArea.Test)
            {

            }
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