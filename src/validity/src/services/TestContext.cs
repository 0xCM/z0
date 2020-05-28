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

    using static Seed;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public abstract class TestContext
    {
        protected IApiComposition Api => _Api.Value;

        static IApiComposition ComposeApi()
            => ApiComposition.Assemble(StatelessSeed.Fatory.PartIndexBuilder.Build());
        
        static Lazy<IApiComposition> _Api {get;}
            = Control.defer(ComposeApi);
    }
    
    public abstract class TestContext<U> : TestContext, ITestContext<U>
        where U : TestContext<U>
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

        void ISink<IAppMsg>.Deposit(IAppMsg msg)
            => Queue.Deposit(msg);

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

        protected IAppPaths Paths => Context.AppPaths;

        protected ITestCaseIdentity CaseIdentity => Context;

        protected BenchmarkRecord Benchmark(long opcount, Duration time, [Caller] string label = null)
            => Context.Benchmark(opcount, time, label);
        
        protected void ReportBenchmark(string name, long opcount, TimeSpan duration)
            => Context.ReportBenchmark(name,opcount, duration);

        protected void ReportBenchmark<W,T>(IFunc f, int ops, Duration time, W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => Context.ReportBenchmark<W,T>(f,ops,time);

        protected void CheckAction(Action f, string name)
            => Context.CheckAction(f,name);         
 
        protected string CaseName<C>(string root, C t = default)
            where C : unmanaged
                => Context.CaseName<C>(root);

        protected string CaseName(OpIdentity id)
            => Context.CaseName(id);

        protected OpIdentity SubjectId<T>(string label, T t = default)
            where T : unmanaged
                => Context.CaseOpId<T>(label);
                
        protected OpIdentity BaselineId<K>(string label,K t = default)
            where K : unmanaged
                => Context.BaselineId<K>(label);

        protected string CaseName<W,C>([Caller] string label = null, W w = default, C t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => Context.CaseName<W,C>(label, generic);

        protected string CaseName(IFunc f) 
            => Context.CaseName(f);

        protected void Notify(string msg, AppMsgKind? severity = null)
            => Queue.Notify(msg, severity);

        protected void Error(object msg, [Caller] string caller = null)
            => Queue.Error(msg, GetType(), caller); 

        protected void Trace(object msg, [Caller] string caller = null)
            => Queue.Trace(msg, GetType(), caller);
        
        protected void Trace(string title, object msg, AppMsgColor color, [Caller] string caller = null)
            => Queue.Trace(title, msg, color, GetType(), caller);

        protected void Trace(string title, string msg, [Caller] string caller = null)
            => Queue.Trace(title, msg, GetType(), caller);

        protected void Trace(IAppMsg msg)
            => Queue.Trace(msg);

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
        
        void IAppMsgSink.NotifyConsole(IAppMsg msg)            
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