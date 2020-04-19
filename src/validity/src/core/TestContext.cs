//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static Seed;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public partial class TestContext<U> : ITestContext, IConsoleNotifier, IAppMsgContext  
    {
        public ITestContext Context {get;}

        public virtual IPolyrand Random {get;}
            =  Polyrand.WyHash64(PolySeed64.Seed00);

        public event Action<IAppMsg> Next;

        protected readonly IAppMsgQueue Queue;

        Queue<TestCaseRecord> TestResults {get;}
            = new Queue<TestCaseRecord>();

        Queue<BenchmarkRecord> Benchmarks {get;}
            = new Queue<BenchmarkRecord>();

        protected TestContext()
        {
            this.Context = this;            
            this.Next += BlackHole;
            this.Queue = AppMsgExchange.Create();
            this.Queue.Next += Relay;
        }

        public virtual void Dispose()
            => OnDispose();

        protected virtual void OnDispose() 
        {

        }

        void BlackHole(IAppMsg msg) {}
                
        void Relay(IAppMsg msg)
            => Next(msg);

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

        /// <summary>
        /// Captures a duration and the number of operations executed within the period
        /// </summary>
        /// <param name="time">The running time</param>
        /// <param name="opcount">The operation count</param>
        /// <param name="label">The label associated with the measure, if specified</param>
        protected static BenchmarkRecord measured(long opcount, Duration time, [Caller] string label = null)
            => BenchmarkRecord.Define(opcount, time, label);

        protected void ReportBenchmark(string name, long opcount, TimeSpan duration)
            => Context.ReportBenchmark(name,opcount, duration);

        protected string CaseName<C>(string root, C t = default)
            where C : unmanaged
                => Context.CaseName<C>(root);

        protected string CaseName(OpIdentity id)
            => Context.CaseName(id);

        protected string CaseName<C>(OpIdentity id, C t = default)
            where C : unmanaged
                => Context.CaseName<C>(id);

        protected static OpIdentity SubjectId<T>(string opname, T t = default)
            where T : unmanaged
                => TestCaseIdentity.SubjectId<T>(opname);
                
        protected static OpIdentity BaselineId<K>(string opname,K t = default)
            where K : unmanaged
                => TestCaseIdentity.SFuncBaseline<K>(opname);

        protected string CaseName<W,C>(string root, W w = default, C t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => Context.CaseName<W,C>(root, generic: generic);

        protected string CaseName(ISFuncApi f) 
            => Context.CaseName(f);

        protected void Notify(string msg, AppMsgKind? severity = null)
            => Queue.Notify(msg, severity);

        void trace(IAppMsg msg)
        {
            Queue.NotifyConsole(msg);
        }

        int CasePadding
            => Reports.width(TestCaseField.Case);

        IAppMsg TraceMsg(object title, object msg, string caller, AppMsgColor color = AppMsgColor.Magenta)
            => AppMsg.Colorize(string.Concat(string.Concat(caller, Chars.Space, title, Chars.Colon).PadRight(CasePadding), "| ", msg), color);

        IAppMsg TraceMsg(object msg, string caller, AppMsgColor color = AppMsgColor.Magenta)
            => AppMsg.Colorize(text.concat(text.concat(caller).PadRight(CasePadding), "| ", msg), color);

        protected void error(object msg)
            => trace(AppMsg.Error(msg));

        public void trace(object msg, [Caller] string caller = null)
            => trace(TraceMsg(msg, caller));

        public void trace(string title, object msg, AppMsgColor color, [Caller] string caller = null)
            => trace(TraceMsg(title, msg, caller, color));

        public void trace(string title, string msg, int? tpad = null, AppMsgKind? severity = null, [Caller] string caller = null)
            => trace(TraceMsg(title, msg, caller));        
    }
}