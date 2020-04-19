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
            void Relay(IAppMsg msg)
                => Next(msg);

            this.Context = this;            
            this.Next += x => {};
            this.Queue = AppMsgExchange.Create();
            this.Queue.Next += Relay;
        }


        protected string caller([Caller] string caller = null)
            => caller;

        public virtual void Dispose()
            => OnDispose();

        protected virtual void OnDispose() 
        {

        }
                
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

        protected IAppPaths Paths => Context.AppPaths;
        
        protected void ReportBenchmark(string name, long opcount, TimeSpan duration)
            => Context.ReportBenchmark(name,opcount, duration);

        ITestCaseIdentity CaseIdentity => this;

        protected string CaseName<C>(string root, C t = default)
            where C : unmanaged
                => CaseIdentity.CaseName<C>(root);

        protected string CaseName(OpIdentity id)
            => CaseIdentity.CaseName(id);

        protected string CaseName<C>(OpIdentity id, C t = default)
            where C : unmanaged
                => CaseIdentity.CaseName<C>(id);

        protected OpIdentity SubjectId<T>(string label, T t = default)
            where T : unmanaged
                => CaseIdentity.CaseOpId<T>(label);
                
        protected OpIdentity BaselineId<K>(string label,K t = default)
            where K : unmanaged
                => CaseIdentity.BaselineId<K>(label);

        protected string CaseName<W,C>(string root, W w = default, C t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => CaseIdentity.CaseName<W,C>(root, generic: generic);

        protected string CaseName(ISFuncApi f) 
            => CaseIdentity.CaseName(f);

        protected void Notify(string msg, AppMsgKind? severity = null)
            => Queue.Notify(msg, severity);

        int CasePadding
            => Reports.width(TestCaseField.Case);

        IAppMsg TraceMsg(object title, object msg, string caller, AppMsgColor color = AppMsgColor.Magenta)
            => AppMsg.Colorize(string.Concat(string.Concat(caller, Chars.Space, title, Chars.Colon).PadRight(CasePadding), "| ", msg), color);

        IAppMsg TraceMsg(object msg, string caller, AppMsgColor color = AppMsgColor.Magenta)
            => AppMsg.Colorize(text.concat(text.concat(caller).PadRight(CasePadding), "| ", msg), color);

        ITracer Tracer => ITracer.Create(this,CasePadding);

        void trace(IAppMsg msg)
        {
            //Queue.NotifyConsole(msg);
            Tracer.trace(msg);
        }

        protected void error(object msg)
            => trace(AppMsg.Error(msg));

        protected void trace(object msg, [Caller] string caller = null)
            => trace(TraceMsg(msg, caller));
        
        protected void trace(string title, object msg, AppMsgColor color, [Caller] string caller = null)
            => trace(TraceMsg(title, msg, caller, color));

        protected void trace(string title, string msg, int? tpad = null, AppMsgKind? severity = null, [Caller] string caller = null)
            => trace(TraceMsg(title, msg, caller));        
    }
}