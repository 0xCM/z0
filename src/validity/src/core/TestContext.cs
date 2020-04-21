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
    
    using static Seed;
    

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public class TestContext<U> : ITestContext, IConsoleNotifier, IAppMsgContext  
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

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="id">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        public void CheckAction(Action f, OpIdentity id)
        {
            var succeeded = true;
            var count = counter();
            
            count.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                term.errlabel(e, id.Identifier);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(CaseName(id), succeeded,count);
            }
        }

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        public void CheckAction(Action f, string name)
        {
            var succeeded = true;
            var count = counter();
            
            count.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                term.errlabel(e, name);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(name,succeeded,count);
            }
        }
 
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

        public void Deposit(TestCaseRecord result)
            => TestResults.Enqueue(result);

        public void Deposit(BenchmarkRecord record)
            => Benchmarks.Enqueue(record);

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

        public IReadOnlyList<IAppMsg> Dequeue()
            => Queue.Dequeue();

        public IReadOnlyList<IAppMsg> Flush(Exception e)
            => Queue.Flush(e);
            
        public void Flush(Exception e, IAppMsgSink target)
            => Queue.Flush(e, target);

        public void Emit(FilePath dst) 
            => Queue.Emit(dst);        
        
        public void Deposit(IAppMsg msg)
            => Queue.Deposit(msg);

        public void NotifyConsole(IAppMsg msg)            
            => Queue.NotifyConsole(msg);

        public void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green)
            => Queue.NotifyConsole(AppMsg.Colorize(content, color));            


        /// <summary>
        /// Allocates and optionally starts a system counter
        /// </summary>
        [MethodImpl(Inline)]   
        public SystemCounter counter(bool start = false) 
            => SystemCounter.Create(start);

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

        public void Measure<T>(UnaryOp<T> f, UnaryOp<T> cf, string opname)
            where T :unmanaged
        {
            const int SampleSize = 256;
            var last = default(T);
            var clock = counter();
            
            void run_f()
            {
                var src = Random.Span<T>(SampleSize);
                byte j = 0;
                var oc = 0;

                clock.Start();
                for(var cycle = 0; cycle < CycleCount; cycle++)
                for(int rep=0; rep < RepCount; rep++, j++, oc++)
                {
                    ref readonly var x = ref refs.skip(src,j);
                    last = f(x);
                }
                clock.Stop();

                Context.ReportBenchmark(SubjectId<T>(opname),oc,clock);

            }

            void run_cf()
            {
                var src = Random.Span<T>(SampleSize);
                byte j = 0;
                var oc = 0;

                clock.Start();
                for(var cycle = 0; cycle < CycleCount; cycle++)
                for(int rep=0; rep < RepCount; rep++, j++, oc++)
                {
                    ref readonly var x = ref refs.skip(src,j);
                    last = cf(x);
                }            
                clock.Stop();

                Context.ReportBenchmark(BaselineId<T>(opname),oc,clock);            
            }

            run_cf();            
            
            clock.Reset();
            
            run_f();
        }

        public void Measure<T>(BinaryOp<T> cf, BinaryOp<T> f, string opname)
            where T :unmanaged
        {
            const int SampleSize = 256;
            var last = default(T);
            var clock = counter();
            void run_f()
            {
                var lhs = Random.Span<T>(SampleSize);
                var rhs = Random.Span<T>(SampleSize);
                byte j = 0;
                var oc = 0;

                clock.Start();
                for(var cycle = 0; cycle < CycleCount; cycle++)
                for(int rep=0; rep < RepCount; rep++, j++, oc++)
                {
                    ref readonly var x = ref refs.skip(lhs,j);
                    ref readonly var y = ref refs.skip(rhs,j);                
                    last = f(x,y);
                }
                clock.Stop();

                Context.ReportBenchmark(SubjectId<T>(opname),oc,clock);
            }

            void run_cf()
            {
                var lhs = Random.Span<T>(SampleSize);
                var rhs = Random.Span<T>(SampleSize);
                byte j = 0;
                var oc = 0;

                clock.Start();
                for(var cycle = 0; cycle < CycleCount; cycle++)
                for(int rep=0; rep < RepCount; rep++, j++, oc++)
                {
                    ref readonly var x = ref refs.skip(lhs,j);
                    ref readonly var y = ref refs.skip(rhs,j);                
                    last = cf(x,y);
                }            
                clock.Stop();

                Context.ReportBenchmark(BaselineId<T>(opname),oc,clock);            
            }

            run_cf();            
            
            clock.Reset();
            
            run_f();
        } 
    }
}