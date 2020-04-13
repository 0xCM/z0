//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    
    using static Seed;

    public partial class TestContext<U> : ITestContext
    {
        public ITestContext Context {get;}

        public IPolyrand Random {get;}

        public event Action<AppMsg> Next;

        protected IAppMsgExchange Queue {get; private set;}

        Queue<TestCaseRecord> Outcomes {get;}
            = new Queue<TestCaseRecord>();

        Queue<BenchmarkRecord> Benchmarks {get;}
            = new Queue<BenchmarkRecord>();


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

        public void ReportOutcome(string casename, bool succeeded, TimeSpan duration)
        {
            var record = TestCaseRecord.Define(casename,succeeded,duration);
            Outcomes.Enqueue(record);
        }

        public void ReportBenchmark(string name, long opcount, TimeSpan duration)
        {
            var record = BenchmarkRecord.Define(opcount, duration, name);
            Benchmarks.Enqueue(record);
        }

        public void ReportBenchmark(BenchmarkRecord record)
            => Benchmarks.Enqueue(record);

        protected TestContext(IPolyrand random = null)
        {
            this.Context = this;            
            this.Random = random ?? Polyrand.WyHash64(PolySeed64.Seed00);
            this.Next += BlackHole;
            this.Queue = AppMessages.exchange();
            this.Queue.Next += Relay;
        }

        /// <summary>
        /// Allocates and optionally starts a system counter
        /// </summary>
        [MethodImpl(Inline)]   
        protected static SystemCounter counter(bool start = false) 
            => SystemCounter.Create(start);

        public Type HostType => typeof(U);

        public virtual void Dispose()
            => OnDispose();

        protected virtual void OnDispose() { }

        void BlackHole(AppMsg msg) {}
                
        void Relay(AppMsg msg)
            => Next(msg);

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

        public IReadOnlyList<AppMsg> Dequeue()
            => Queue.Dequeue();

        public void Notify(string msg, AppMsgKind? severity = null)
            => Queue.Notify(msg, severity);
        
        public void Notify(AppMsg msg)
            => Queue.Notify(msg);

        public void NotifyConsole(AppMsg msg)            
            => Queue.NotifyConsole(msg, msg.Color);

        public void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green)
            => NotifyConsole(AppMsg.Colorize(content, color));

        public IReadOnlyList<AppMsg> Flush(Exception e)
            => Queue.Flush(e);
            
        public void Flush(Exception e, IAppMsgLog target)
            => Queue.Flush(e, target);

        public void Emit(FilePath dst) 
            => Queue.Emit(dst);        

        /// <summary>
        /// Creates a new stopwatch and optionally start it
        /// </summary>
        /// <param name="start">Whether to start the new stopwatch</param>
        [MethodImpl(Inline)]   
        protected static Stopwatch stopwatch(bool start = true) 
            => start ? Stopwatch.StartNew() : new Stopwatch();

        /// <summary>
        /// Captures a stopwatch duration
        /// </summary>
        /// <param name="sw">A running/stopped stopwatch</param>
        [MethodImpl(Inline)]   
        protected static Duration snapshot(Stopwatch sw)     
            => Duration.Define(sw.ElapsedTicks);        

        /// <summary>
        /// Captures a duration and the number of operations executed within the period
        /// </summary>
        /// <param name="time">The running time</param>
        /// <param name="opcount">The operation count</param>
        /// <param name="label">The label associated with the measure, if specified</param>
        protected static BenchmarkRecord optime(long opcount, Duration time, [CallerMemberName] string label = null)
            => BenchmarkRecord.Define(opcount, time, label);

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        protected void CheckAction(Action f, OpIdentity name, SystemCounter count = default)
        {
            var succeeded = true;
            
            count.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                term.errlabel(e, name.Identifier);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(CaseName(name), succeeded,count);
            }
        }

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        protected void CheckAction(Action f, string name, SystemCounter count = default)
        {
            var succeeded = true;
            
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
                ReportOutcome(name,succeeded,count);
            }
        }
    }
}