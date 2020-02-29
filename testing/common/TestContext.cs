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

    public abstract class TestContext<U> : ITestContext<U>
        where U : TestContext<U>
    {
        protected TestContext(ITestConfig config = null, IPolyrand random = null)
        {
            this.Random = random ?? Rng.WyHash64(Seed64.Seed00);
            this.Config = config ?? TestConfigDefaults.Default();
            this.Queue = MsgContext.Create();
        }

        public IPolyrand Random {get;}

        readonly IMsgContext Queue;

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
            => Identity.testcase(GetType(),f);

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="id">Moniker that identifies the operation under test</param>
        public string CaseName(OpIdentity id)
            => Identity.testcase(GetType(),id);

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        public string CaseName(string fullname)
            => Identity.testcase(GetType(), fullname);

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="root">The root name</param>
        protected string CaseName<C>(string root, C t = default)
            where C : unmanaged
            => Identity.testcase(GetType(),root, t);

        protected string CaseName<W,C>(string root, W w = default, C t = default, bool generic = true)
            where W : unmanaged, ITypeNat
            where C : unmanaged
                => Identity.testcase(GetType(),root, w, t, generic);

        protected static OpIdentity SubjectId(string opname, NumericKind kind)
            => OpId.numeric(opname,kind);

        protected static OpIdentity SubjectId<T>(string opname, T t = default)
            where T : unmanaged
                => OpId.numeric(opname, Numeric.kind<T>());

        protected static OpIdentity BaselineId<K>(string opname,K t = default)
            where K : unmanaged
                => Identity.contracted<K>($"{opname}_baseline");

        protected virtual bool TraceEnabled
            => true;

        /// <summary>
        /// Submits a diagnostic message to the message queue without including caller information
        /// </summary>
        /// <param name="msg">The source message</param>
        protected void Trace(object msg)
        {
            if(TraceEnabled)
                PostMessage(AppMsg.Info(msg));
        }

        /// <summary>
        /// Submits a diagnostic message to the message queue without including caller information
        /// </summary>
        /// <param name="msg">The source message</param>
        protected void Trace(object title, object msg)
        {
            if(TraceEnabled)
                PostMessage(AppMsg.Info($"{title} - {msg}"));
        }

        protected void Trace(string title, string msg, int? tpad = null, AppMsgKind? severity = null)
        {
            if(TraceEnabled)
            {
                var titleFmt = tpad.Map<int, string>(pad => title.PadRight(pad), () => title.PadRight(20));        
                PostMessage(AppMsg.NoCaller($"{titleFmt}: {msg}", severity ?? AppMsgKind.Babble));
            }
        }

        /// <summary>
        /// Submits a diagnostic message to the message queue
        /// </summary>
        /// <param name="msg">The source message</param>
        /// <param name="severity">The diagnostic severity level that, if specified, 
        /// replaces the exising source message severity prior to queue submission</param>
        protected void Trace(AppMsg msg, AppMsgKind? severity = null)
        {
            if(TraceEnabled)
                PostMessage(msg.AsKind(severity ?? AppMsgKind.Babble));
        }

        /// <summary>
        /// Submits a diagnostic message to the message queue
        /// </summary>
        /// <param name="msg">The source message</param>
        /// <param name="severity">The diagnostic severity level that, if specified, replaces the exising source message severity prior to queue submission</param>
        protected void TraceCaller(object msg, AppMsgKind severity, [Caller] string caller = null)
        {
            if(TraceEnabled)
                PostMessage(AppMsg.NoCaller($"{GetType().DisplayName()}/{caller}: {msg}",severity));
        }

        /// <summary>
        /// Submits a diagnostic message to the message queue
        /// </summary>
        /// <param name="msg">The source message</param>
        protected void TraceCaller(object msg, [Caller] string caller = null)
        {
            if(TraceEnabled)
                PostMessage(AppMsg.Info($"{GetType().DisplayName()}/{caller}: {msg}"));
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
                PostMessage(AppMsg.Info($"{GetType().DisplayName()}/{caller}/{title}: {msg}"));
        }

        /// <summary>
        /// Submits a diagnostic message to the queue related to performance/benchmarking
        /// </summary>
        /// <param name="msg">The message to submit</param>
        protected void TracePerf(string msg)
        {
            if(TraceEnabled)
                PostMessage(AppMsg.NoCaller($"{msg}", AppMsgKind.Benchmark));
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

        public IReadOnlyList<AppMsg> DequeueMessages()
            => Queue.DequeueMessages();

        public void PostMessage(AppMsg msg)
            => Queue.PostMessage(msg);

        public void PostMessage(string msg, AppMsgKind? severity = null)
            => Queue.PostMessage(msg, severity);

        public void FlushMessages(Exception e, IAppMsgLog target)
            => Queue.FlushMessages(e, target);

        /// <summary>
        /// Allocates and optionally starts a system counter
        /// </summary>
        [MethodImpl(Inline)]   
        protected static SystemCounter counter(bool start = false) 
            => SystemCounter.Create(start);
    }
}