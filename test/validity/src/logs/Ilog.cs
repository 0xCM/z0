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

    enum LogWriteMode
    {
        Create,
        
        Overwrite,
        
        Append
    }


    /// <summary>
    /// Defines minimal contract for a log message sink
    /// </summary>
    interface ILogger : IAppMsgLog
    {
        /// <summary>
        /// Appends unstructured text content to the log
        /// </summary>
        /// <param name="text">The text to append</param>
        void Write(string text);

        FilePath Write<R>(IEnumerable<R> records, FolderName subdir, string basename, LogWriteMode mode, char delimiter, bool header, FileExtension ext)
            where R : IRecord;                
    }

    static class Log
    {        
        static LogPaths Paths 
            => LogPaths.The;
            
        public static ILogger Test => TestLog.TheOnly;

        public static ILogger Bench => BenchLog.TheOnly;

        public static ILogger App => AppLog.TheOnly;

        abstract class Logger<A> : ILogger
            where A : Logger<A>, new()
        {
            public static ILogger TheOnly = new A();
            
            public LogArea Area {get;}

            protected object locker = new object();
            
            protected Logger(LogArea Area)
            {
                this.Area = Area;
            }

            FilePath LogPath
                => Paths.Timestamped(Area,Area.ToString().ToLower());

            public void Write(AppMsg src)
            {
                lock(locker)
                    LogPath.AppendLine(src.ToString());
            }

            public void Write(IEnumerable<AppMsg> src)
            {
                lock(locker)
                    LogPath.Append(src.FormatLines());
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

            public void Write(string text)
            {
                lock(locker)
                    LogPath.Append(text);
            }

            [MethodImpl(Inline)]
            public void Notify(AppMsg msg)
                => Write(msg);


            [MethodImpl(Inline)]
            public void Notify(string msg, AppMsgKind? severity = null)
                => Write(AppMsg.NoCaller(msg,severity ?? AppMsgKind.Info));
        }

        sealed class AppLog : Logger<AppLog>
        {
            public AppLog()            
             : base(LogArea.App)
            {

            }
        }

        sealed class TestLog : Logger<TestLog>
        {
            public TestLog()            
             : base(LogArea.Test)
            {

            }
        }

        sealed class BenchLog : Logger<BenchLog>
        {
            public BenchLog()            
             : base(LogArea.Bench)
            {

            }
        }
    }
}