//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.IO;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public abstract class TestContext
    {
        public bool DiagnosticMode {get; private set;}

        public void SetMode(bool diagnostic)
        {
            DiagnosticMode = diagnostic;
        }

         protected IResolvedApi Api
            => _Api.Value;

        static IResolvedApi ComposeApi()
            => ApiQuery.assemble(ApiQuery.index());

        static Lazy<IResolvedApi> _Api {get;}
            = Root.defer(ComposeApi);
    }

    public abstract class TestContext<U> : TestContext, ITestContext<U>
        where U : TestContext<U>
    {
        public ITestContext Context {get;}

        public virtual IPolyrand Random {get;}
            = Polyrand.WyHash64(PolySeed64.Seed00);

        public event Action<IAppMsg> Next;

        protected readonly IAppMsgQueue Queue;

        Queue<TestCaseRecord> TestResults {get;}
            = new Queue<TestCaseRecord>();

        Queue<BenchmarkRecord> Benchmarks {get;}
            = new Queue<BenchmarkRecord>();

        protected TestContext()
        {
            void Relay(IAppMsg msg) => Next(msg);

            Context = this;
            Next += x => {};
            Queue = AppMsgExchange.Create();
            Queue.Next += Relay;
            OnDispose += () => {};
        }

        public void Dispose()
        {
            OnDispose();
        }

        protected event Action OnDispose;

        void ISink<IAppMsg>.Deposit(IAppMsg msg)
            => Queue.Deposit(msg);

        void IAppMsgSink.NotifyConsole(IAppMsg msg)
            => Queue.NotifyConsole(msg);

        public IEnumerable<TestCaseRecord> TakeOutcomes()
        {
            while(TestResults.Any())
                yield return TestResults.Dequeue();
        }

        public IEnumerable<BenchmarkRecord> TakeBenchmarks()
        {
            while(Benchmarks.Any())
                yield return Benchmarks.Dequeue();
        }

        public void Deposit(TestCaseRecord result)
            => TestResults.Enqueue(result);

        public void Deposit(BenchmarkRecord record)
            => Benchmarks.Enqueue(record);

        public IReadOnlyList<IAppMsg> Dequeue()
            => Queue.Dequeue();

        public IReadOnlyList<IAppMsg> Flush(Exception e)
            => Queue.Flush(e);

        public void Flush(Exception e, IAppMsgSink target)
            => Queue.Flush(e, target);

        public void Emit(FilePath dst)
            => Queue.Emit(dst);

        /// <summary>
        /// The number of elements to be selected from some sort of stream
        /// </summary>
        protected virtual int RepCount
            => Context.RepCount;

        /// <summary>
        /// The number times to repeat an action
        /// </summary>
        protected virtual int CycleCount
            => Context.CycleCount;

        /// <summary>
        /// The number of times to repeat a cycle
        /// </summary>
        protected virtual int RoundCount
            => Context.RoundCount;

        /// <summary>
        /// The number of operations performed in a benchmarking expercise
        /// </summary>
        protected virtual int OpCount
            => RoundCount*CycleCount;

        public virtual bool Enabled
            => true;

        protected virtual bool TraceDetailEnabled
            => false;

        protected TChecks Claim
            => Checks.Checker;

        protected TCheckInvariant ClaimInvariant
            => Claim;

        protected TCheckPrimal ClaimPrimal
            => Claim;

        protected TCheckPrimalSeq ClaimPrimalSeq
            => Claim;

        protected TCheckNumeric ClaimNumeric
            => CheckNumeric.Checker;

        protected TCheckEquatable ClaimEquatable
            => CheckEquatable.Checker;

        protected IShellPaths AppPaths
            => Context.AppPaths;

        protected PartId TestedPart
        {
            [MethodImpl(Inline)]
            get => (PartId)((ulong)Assembly.GetEntryAssembly().Id() & 0xFFFFul);
        }

        FolderPath TestRoot
        {
             [MethodImpl(Inline)]
             get => Context.AppPaths.TestDataRoot + FolderName.Define(TestedPart.Format());
        }

        protected FolderPath UnitDataDir
        {
             [MethodImpl(Inline)]
             get => TestRoot + FolderName.Define(GetType().Name);
        }

        protected string caller([Caller] string caller = null)
            => caller;


        protected TTestCaseIdentity CaseIdentityService
            => Context;

        protected OpIdentity CaseOpId<T>(string label, T t = default)
            where T : unmanaged
                => Context.CaseOpId<T>(label);

        protected OpIdentity BaselineId<K>(string label,K t = default)
            where K : unmanaged
                => Context.BaselineId<K>(label);

        protected string CaseName<C>(string root, C t = default)
            where C : unmanaged
                => Context.CaseName<C>(root);

        protected string CaseName(OpIdentity id)
            => Context.CaseName(id);

        protected string CaseName<W,C>([Caller] string label = null, W w = default, C t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => Context.CaseName<W,C>(label, generic);

        protected string CaseName(IFunc f)
            => Context.CaseName(f);

        [MethodImpl(Inline)]
        protected FilePath UnitPath(FileName name)
            => UnitDataDir + name;

        protected StreamWriter UnitWriter(FileName filename)
            => UnitPath(filename).Writer();

        [MethodImpl(Inline)]
        protected FilePath CasePath(FileExtension ext, [CallerMemberName] string caller = null)
            => UnitPath(FileName.Define(caller,  ext));

        [MethodImpl(Inline)]
        protected FilePath CasePath(string CaseName, FileExtension ext = null)
            => UnitPath(FileName.Define(CaseName, ext ?? FileExtensions.Csv));

        protected StreamWriter CaseWriter(FileExtension ext, [Caller] string caller = null)
            => CasePath(caller, ext).Writer();

        protected StreamWriter CaseWriter(string CaseName, FileExtension ext = null)
            => CasePath(CaseName, ext).Writer();

        protected BenchmarkRecord Benchmark(long opcount, Duration time, [Caller] string label = null)
            => Context.Benchmark(opcount, time, label);

        protected BenchmarkRecord ReportBenchmark(string name, long opcount, TimeSpan duration)
            => Context.ReportBenchmark(name,opcount, duration);

        protected BenchmarkRecord ReportBenchmark<W,T>(IFunc f, int ops, Duration time, W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => Context.ReportBenchmark<W,T>(f,ops,time);

        protected void CheckAction(Action f, string name)
            => Context.CheckAction(f,name);

        protected void Notify(string msg, MessageKind? severity = null)
            => Queue.Notify(msg, severity);

        protected void Trace(object msg, [Caller] string caller = null)
            => Queue.Trace(msg, GetType(), caller);

        protected void Trace(string title, object msg, MessageFlair color, [Caller] string caller = null)
            => Queue.Trace(title, msg, color, GetType(), caller);

        protected void Trace(string title, string msg, [Caller] string caller = null)
            => Queue.Trace(title, msg, GetType(), caller);

        protected void Trace(IAppMsg msg)
            => Queue.Trace(msg);

        protected void Trace(ITextual msg)
            => Notify(msg.Format());

        /// <summary>
        /// Allocates and optionally starts a system counter
        /// </summary>
        [MethodImpl(Inline)]
        public SystemCounter counter(bool start = false)
            => SystemCounters.counter(start);

        /// <summary>
        /// Creates a new stopwatch and optionally start it
        /// </summary>
        /// <param name="start">Whether to start the new stopwatch</param>
        [MethodImpl(Inline)]
        public Stopwatch stopwatch(bool start = true)
            => start ? Stopwatch.StartNew() : new Stopwatch();

        /// <summary>
        /// Captures a stopwatch duration
        /// </summary>
        /// <param name="sw">A running/stopped stopwatch</param>
        [MethodImpl(Inline)]
        public Duration snapshot(Stopwatch sw)
            => Duration.Define(sw.ElapsedTicks);
    }
}