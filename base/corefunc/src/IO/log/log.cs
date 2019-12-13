//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        static DataPaths Paths 
            => DataPaths.The;
            
        public static void LogBenchmarks<R>(string name, R[] records, bool create = true, bool header = true, char delimiter = AsciSym.Pipe)
            where R : IRecord
        {
            if(records.Length == 0)
                return;
            
            Log.Get(LogTarget.Define(LogArea.Bench)).Log(records, name, delimiter, header, create,FileExtension.Define("csv"));
        }

        public static void LogTestResults<R>(string name, R[] records, bool create = true, bool header = true, char delimiter = AsciSym.Pipe)
            where R : IRecord
        {
            if(records.Length == 0)
                return;
            
            Log.Get(LogTarget.Define(LogArea.Test)).Log(records, name, delimiter, header, create,FileExtension.Define("csv"));
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
            
            protected object locker = new object();
            
            protected Logger(LogArea Area)
                => this.Area = Area;

            FilePath LogPath
                => Paths.LogPath(Area);

            public void Log(AppMsg src)
            {
                lock(locker)
                    LogPath.Append(src.ToString());
            }

            public void Log(IEnumerable<AppMsg> src)
            {
                lock(locker)
                    LogPath.Append(src.Select(x => x.ToString()));
            }

            void Emit<R>(IReadOnlyList<R> records, char delimiter, bool writeHeader, FilePath dst)
                where R : IRecord
            {                
                if(records.Count == 0)
                    return;

                if(writeHeader)
                    dst.Append(string.Join(delimiter, records[0].GetHeaders()));
                
                iter(records, r => dst.Append(r.DelimitedText(delimiter)));
            }

            public void Log<R>(IEnumerable<R> src, string topic, char delimiter, bool writeHeader = true, bool newFile = true, FileExtension ext = null)
                where R : IRecord
            {
                var records = src.ToArray();
                if(records.Length == 0)
                    return;                

                if(newFile)
                     Emit(records, delimiter, writeHeader, Paths.UniqueLogPath(Area,topic,ext));
                else
                    lock(locker)
                        Emit(records, delimiter, writeHeader, Paths.LogPath(Area,topic, ext));
            }

            public void Log<R>(IEnumerable<R> src, LogTarget target, char delimiter, bool writeHeader = true, bool newFile = true, FileExtension ext = null)
                where R : IRecord
            {
                var records = src.ToArray();
                if(records.Length == 0)
                    return;                

                if(newFile)
                     Emit(records, delimiter, writeHeader, Paths.UniqueLogPath(target,ext));
                else
                    lock(locker)
                        Emit(records, delimiter, writeHeader, Paths.LogPath(target));
            }

            public void Log(string text)
            {
                lock(locker)
                    LogPath.Append(text);
            }

            public LogArea Area {get;}
            
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