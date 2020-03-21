//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Root;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public class TestContext<U> : ITestContext<U>
    {
        public ITestContext Context {get;}

        protected TestContext(ITestConfig config = null, IPolyrand random = null)
        {
            this.Random = random ?? Rng.WyHash64(Seed64.Seed00);
            this.Config = config ?? TestConfigDefaults.Default();
            this.Queue = AppMsgContext.Create();
            this.Context = this;
        }

        protected TestContext(IExternalTestContext external)
        {
            this.Random = external.Random;
            this.Config = TestConfigDefaults.Default();
            this.Queue = external;
            this.Context = this;
        }

        public virtual void Dispose()
            => OnDispose();

        protected virtual void OnDispose() { }

        public IPolyrand Random {get;}

        IAppMsgContext Queue {get;set;}

        public ITestConfig Config {get; private set;}

        Queue<TestCaseRecord> Outcomes {get;}
            = new Queue<TestCaseRecord>();

        Queue<BenchmarkRecord> Benchmarks {get;}
            = new Queue<BenchmarkRecord>();

        public void Configure(ITestConfig config)
            => Config = config;
                
        /// <summary>
        /// The number of elements to be selected from some sort of stream
        /// </summary>
        protected virtual int RepCount
            => Pow2.T06;
        
        /// <summary>
        /// The number times to repeat an action
        /// </summary>
        protected virtual int CycleCount
            => Pow2.T03;

        /// <summary>
        /// The number of times to repeat a cycle
        /// </summary>
        protected virtual int RoundCount
            => Pow2.T01;

        /// <summary>
        /// The number of operations performed in a benchmarking expercise
        /// </summary>
        protected virtual int OpCount
            => RoundCount*CycleCount;
        
        public virtual bool Enabled 
            => true;

        int ITestContext.RepCount 
            => RepCount;

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public string CaseName(IFunc f)
            => TestIdentity.testcase(GetType(),f);

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="id">Moniker that identifies the operation under test</param>
        public string CaseName(OpIdentity id)
            => TestIdentity.testcase(GetType(),id);

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        public string CaseName(string fullname)
            => TestIdentity.testcase(GetType(), fullname);

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="root">The root name</param>
        protected string CaseName<C>(string root, C t = default)
            where C : unmanaged
            => TestIdentity.testcase(GetType(),root, t);

        protected string CaseName<W,C>(string root, W w = default, C t = default, bool generic = true)
            where W : unmanaged, ITypeNat
            where C : unmanaged
                => NaturalIdentity.testcase(GetType(),root, w, t, generic);

        protected static OpIdentity SubjectId(string opname, NumericKind kind)
            => OpIdentity.numeric(opname,kind);

        protected static OpIdentity SubjectId<T>(string opname, T t = default)
            where T : unmanaged
                => OpIdentity.numeric(opname, NumericIdentity.kind<T>());

        protected static OpIdentity BaselineId<K>(string opname,K t = default)
            where K : unmanaged
                => OpIdentity.contracted<K>($"{opname}_baseline");

        protected virtual bool TraceEnabled
            => true;

        /// <summary>
        /// Submits a diagnostic message to the message queue without including caller information
        /// </summary>
        /// <param name="msg">The source message</param>
        protected void trace(object msg)
        {
            if(TraceEnabled)
                Notify(AppMsg.Info(msg));
        }

        protected void print(object msg, AppMsgKind? k = null)
            => NotifyConsole(AppMsg.NoCaller(msg, k));

        protected void colorize(object msg, AppMsgColor color)
            => NotifyConsole(msg, color);

        /// <summary>
        /// Submits a diagnostic message to the message queue without including caller information
        /// </summary>
        /// <param name="msg">The source message</param>
        protected void trace(object title, object msg)
        {
            if(TraceEnabled)
                Notify(AppMsg.Info($"{title} - {msg}"));
        }

        protected void trace(string title, string msg, int? tpad = null, AppMsgKind? severity = null)
        {
            if(TraceEnabled)
            {
                var titleFmt = tpad.Map(pad => title.PadRight(pad), () => title.PadRight(20));        
                Notify(AppMsg.NoCaller($"{titleFmt}: {msg}", severity ?? AppMsgKind.Babble));
            }
        }

        /// <summary>
        /// Submits a diagnostic message to the message queue
        /// </summary>
        /// <param name="msg">The source message</param>
        /// <param name="severity">The diagnostic severity level that, if specified, 
        /// replaces the exising source message severity prior to queue submission</param>
        protected void trace(AppMsg msg, AppMsgKind? severity = null)
        {
            if(TraceEnabled)
                Notify(msg.AsKind(severity ?? AppMsgKind.Babble));
        }

        /// <summary>
        /// Submits a diagnostic message to the message queue
        /// </summary>
        /// <param name="msg">The source message</param>
        /// <param name="severity">The diagnostic severity level that, if specified, replaces the exising source message severity prior to queue submission</param>
        protected void TraceCaller(object msg, AppMsgKind severity, [Caller] string caller = null)
        {
            if(TraceEnabled)
                Notify(AppMsg.NoCaller($"{GetType().DisplayName()}/{caller}: {msg}",severity));
        }

        /// <summary>
        /// Submits a diagnostic message to the message queue
        /// </summary>
        /// <param name="msg">The source message</param>
        protected void TraceCaller(object msg, [Caller] string caller = null)
        {
            if(TraceEnabled)
                Notify(AppMsg.Info($"{GetType().DisplayName()}/{caller}: {msg}"));
        }

        /// <summary>
        /// Submits a diagnostic message to the message queue
        /// </summary>
        /// <param name="msg">The source message</param>
        /// <param name="severity">The diagnostic severity level that, if specified, 
        /// replaces the exising source message severity prior to queue submission</param>
        protected void TraceCaller(string title, object msg, [Caller] string caller = null)
        {
            if(TraceEnabled)
                Notify(AppMsg.Info($"{GetType().DisplayName()}/{caller}/{title}: {msg}"));
        }

        /// <summary>
        /// Submits a diagnostic message to the queue related to performance/benchmarking
        /// </summary>
        /// <param name="msg">The message to submit</param>
        protected void TracePerf(string msg)
        {
            if(TraceEnabled)
                Notify(AppMsg.NoCaller($"{msg}", AppMsgKind.Benchmark));
        }

        public IEnumerable<TestCaseRecord> TakeOutcomes()
        {
            while(Outcomes.Any())
                yield return Outcomes.Dequeue();
        }

        public IEnumerable<BenchmarkRecord> TakeBenchmarks()
        {
            while(Benchmarks.Any())
                yield return Benchmarks.Dequeue();
        }

        public TestCaseRecord ReportOutcome(string casename, bool succeeded, TimeSpan duration)
        {
            var record = TestCaseRecord.Define(casename,succeeded,duration);
            Outcomes.Enqueue(record);
            return record;
        }

        public BenchmarkRecord ReportBenchmark(string name, long opcount, TimeSpan duration)
        {
            var record = BenchmarkRecord.Define(opcount, duration, name);
            Benchmarks.Enqueue(record);
            return record;
        }

        public void ReportBenchmark(BenchmarkRecord record)
            => Benchmarks.Enqueue(record);

        public IReadOnlyList<AppMsg> Flush()
            => Queue.Flush();

        public void Notify(string msg, AppMsgKind? severity = null)
            => Queue.Notify(msg, severity);
        
        public void Notify(AppMsg msg)
            => Queue.Notify(msg);

        public void NotifyConsole(AppMsg msg)
            => Queue.NotifyConsole(msg);

        public void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green)
            => NotifyConsole(AppMsg.Colorize(content, color));

        public IReadOnlyList<AppMsg> Flush(Exception e)
            => Queue.Flush(e);
            
        public void Flush(Exception e, IAppMsgLog target)
            => Queue.Flush(e, target);

        public void Flush(FilePath dst) 
            => Queue.Flush(dst);
            
        /// <summary>
        /// Allocates and optionally starts a system counter
        /// </summary>
        [MethodImpl(Inline)]   
        protected static SystemCounter counter(bool start = false) 
            => SystemCounter.Create(start);
    }

    public abstract class TestContext<H,C> : TestContext<H>
        where C : IAppContext
    {
        public new C Context {get;}

        protected TestContext(C context)
        {
            this.Context = context;
        }
    }

}