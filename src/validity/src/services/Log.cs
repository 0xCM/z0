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

    public enum LogArea
    {
        Test,

        Bench,

        App,

        Data,
    }

    class EnvConfig
    {
        public EnvConfig()
        {
        
        }

        FolderPath OutputFolder
            => FolderPath.Define(Settings.LogRoot);

        public FolderPath LogDir(LogArea target)        
            => OutputFolder + FolderName.Define(target.ToString().ToLower());

        public FolderPath LogDir(LogArea target, FolderName subdir)        
            => OutputFolder + (FolderName.Define(target.ToString().ToLower()) + subdir);
    }

    readonly struct TestLogPaths
    {
        public static TestLogPaths The => default;

        public FilePath LogPath(LogArea area, string basename, FileExtension ext = null)
            => Settings.LogDir(area) + FileName.Define($"{basename}.{ext ?? DefaultExtension}");

        public FilePath LogPath(LogArea area, FolderName subdir, string basename, FileExtension ext = null)
            => Settings.LogDir(area, subdir) + FileName.Define($"{basename}.{ext ?? DefaultExtension}");

        public FilePath Timestamped(LogArea area, string basename, FileExtension ext = null)
            => Settings.LogDir(area) + FileName.Define($"{basename}.{LogDate}.{ext ?? DefaultExtension}");

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

        static FilePath LogPath(LogArea area, string basename, FileExtension ext, long timestamp)
            => LogDir(area) + FileName.Define($"{basename}.{timestamp}.{ext ?? DefaultExtension}");

        static FilePath LogPath(LogArea area, FolderName subdir, string basename, FileExtension ext, long timestamp)
            => LogDir(area, subdir) + FileName.Define($"{basename}.{timestamp}.{ext ?? DefaultExtension}");
   
        static EnvConfig Settings
            => new EnvConfig();

        static long LogDate
            => Date.Today.ToDateKey();

        static FileExtension DefaultExtension
            => FileExtension.Define("log");

        static FolderPath LogDir(LogArea target)        
            => Settings.LogDir(target);

        static FolderPath LogDir(LogArea target, FolderName subject)        
            => Settings.LogDir(target, subject);
    }


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
                where R : ITabular
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
                where R : ITabular
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

    /// <summary>
    /// Defines a benchmark measure for an operator
    /// </summary>
    public readonly struct BenchmarkRecord : ITabular<BenchmarkRecord>, IComparable<BenchmarkRecord>, IComparable
    {
        public static BenchmarkRecord Empty => new BenchmarkRecord(0, Duration.Zero,string.Empty);

        [MethodImpl(Inline)]   
        public static BenchmarkRecord Capture(OpIdentity op, long opcount, in SystemCounter clock) 
            => new BenchmarkRecord(op, opcount, clock.Elapsed);

        [MethodImpl(Inline)]
        public static implicit operator BenchmarkRecord(in (OpIdentity op, long opcount, SystemCounter clock)  src)
            => Capture(src.op,src.opcount, src.clock);

        [MethodImpl(Inline)]
        public static implicit operator BenchmarkRecord((string opName, long opCount, SystemCounter clock) src)
            => Capture(Identify.Op(src.opName), src.opCount, src.clock);        

        [MethodImpl(Inline)]
        public static BenchmarkRecord Define(long count, Duration timing, string label)
            => new BenchmarkRecord(Identify.Op(label), count, timing);

        [MethodImpl(Inline)]
        BenchmarkRecord(OpIdentity id, long opcount, Duration elapsed)
        {
            this.OpId = id;
            this.OpCount = opcount;
            this.Timing = elapsed;
        }            

        [MethodImpl(Inline)]
        BenchmarkRecord(long count, Duration timing, string Label)
        {
            this.OpId = Identify.Op(Label ?? "?");
            this.OpCount = count;
            this.Timing = timing;
        }            

        /// <summary>
        /// The name of the measured operation
        /// </summary>
        public readonly OpIdentity OpId;

        /// <summary>
        /// Either the invocation count or the number of discrete operations performed
        /// </summary>
        public readonly long OpCount;

        /// <summary>
        /// The measured time
        /// </summary>
        public readonly Duration Timing;

        const int OpNamePad = 30;

        const int OpCountPad = 15;

        public string Format(int? labelPad = null)
            => $"{OpId}".PadRight(labelPad ?? OpNamePad) + $" | Ops = {OpCount} " + $"| Time = {Timing}";
        
        string ITabular.DelimitedText(char delimiter)
            => text.concat(
                $"{Formattable.format(OpId).PadRight(OpNamePad)}{delimiter}{Chars.Space}",  
                 OpCount.ToString("#,#").PadRight(OpCountPad),  $"{delimiter}{Chars.Space}",
                $"{Timing.Ms}");

        public IReadOnlyList<string> GetHeaders()
            => new string[]{nameof(OpId).PadRight(OpNamePad), 
                Chars.Space + nameof(OpCount).PadRight(OpCountPad), 
                Chars.Space + nameof(Timing),
                };

        public override string ToString()
            => Format();

        public int CompareTo(BenchmarkRecord other)
            => OpId.IdentityText.CompareTo(other.OpId.IdentityText);

        public int CompareTo(object obj)
            => obj is BenchmarkRecord r ? CompareTo(r) : -1;
    }    
}