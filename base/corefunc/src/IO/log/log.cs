//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public static class Log
    {
        static LogPaths Paths 
            => LogPaths.The;
            
        public static void WriteAsmInfo(string data, FolderName subfolder, Moniker m)            
            => Paths.AsmDetailPath(subfolder, m).Overwrite(data);
        
        public static string ReadAsmInfo(FolderName subfolder, Moniker m)            
            => Paths.AsmDetailPath(subfolder, m).ReadText();

        public static FilePath LogBenchmarks<R>(string basename, R[] records, LogWriteMode mode = LogWriteMode.Create, bool header = true, char delimiter = AsciSym.Pipe)
            where R : IRecord
        {
            if(records.Length == 0)
                return FilePath.Empty;
                        
            return Log.Get(LogTarget.Define(LogArea.Bench)).Write(records,FolderName.Empty, basename, mode, delimiter, header, FileExtension.Define("csv"));
        }

        public static FilePath LogTestResults<R>(string basename, R[] records, LogWriteMode mode, bool header = true, char delimiter = AsciSym.Pipe)
            where R : IRecord
                => LogTestResults(FolderName.Empty, basename, records, mode, header, delimiter);

        public static FilePath LogTestResults<R>(FolderName subdir, string basename,  R[] records, LogWriteMode mode, bool header = true, char delimiter = AsciSym.Pipe)
            where R : IRecord
        {
            if(records.Length == 0)
                return FilePath.Empty;
            
            return Log.Get(LogTarget.Define(LogArea.Test)).Write(records, subdir, basename, mode, delimiter, header, FileExtension.Define("csv"));
        }

        public static ILogger Get(ILogTarget dst)
            => dst.Area switch{
                LogArea.App => AppLog.TheOnly,
                LogArea.Bench => BenchLog.TheOnly,
                LogArea.Test => TestLog.TheOnly,
                _ => throw new ArgumentException()
            };

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
                    LogPath.Append(src.ToString());
            }

            public void Write(IEnumerable<AppMsg> src)
            {
                lock(locker)
                    LogPath.Append(src.Select(x => x.ToString()));
            }

            void Emit<R>(IReadOnlyList<R> records, char delimiter, bool header, FilePath dst)
                where R : IRecord
            {                
                if(records.Count == 0)
                    return;

                if(header)
                    dst.Append(string.Join(delimiter, records[0].GetHeaders()));
                
                iter(records, r => dst.Append(r.DelimitedText(delimiter)));
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
                    path.DeleteIfExists();
                    Emit(records, delimiter, header, path);
                }
                return path;
            }

            public void Write(string text)
            {
                lock(locker)
                    LogPath.Append(text);
            }            
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