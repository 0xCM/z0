//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Linq.Expressions;
    
    using static zfunc;


    public abstract class Context : IContext
    {        
        protected Context(IPolyrand rng)
        {
            this.Random = rng;            
        }

        /// <summary>
        /// The timings accrued by performance collection operations
        /// </summary>
        public IEnumerable<OpTime> Benchmarks
            => OpTimes;

        /// <summary>
        /// The context random source
        /// </summary>
        public virtual IPolyrand Random {get;}

        protected virtual bool TraceEnabled {get;}
            = true;

        protected virtual bool BenchEnabled
            => true;

        /// <summary>
        /// Collects operation timings
        /// </summary>
        ConcurrentBag<OpTime> OpTimes {get;}
            = new ConcurrentBag<OpTime>();

        List<AppMsg> MsgQueue {get;} 
            = new List<AppMsg>();

        ConcurrentQueue<AppMsg> _MsgQueue {get;} 
            = new ConcurrentQueue<AppMsg>();


        ConcurrentQueue<TestCaseResult> TestResults {get;}
            = new ConcurrentQueue<TestCaseResult>();


        protected void Enqueue(IEnumerable<TestCaseResult> results)
            => TestResults.Enqueue(results);

        protected OpTime[] DequeueTimings()
        {
            var timings = OpTimes.OrderBy(x => x.OpName).ToArray();
            OpTimes.Clear();
            return timings;
        }

        protected TestCaseResult[] DequeueResults()
        {
            var results = TestResults.OrderBy(x => x.Operation).ToArray();
            TestResults.Clear();
            return results;
        }

        public IReadOnlyList<AppMsg> DequeueMessages(params AppMsg[] addenda)
        {
            Notify(addenda);
            var messages = MsgQueue.ToArray();
            MsgQueue.Clear();
            return messages;
        }

        /// <summary>
        /// Enqueues an application message
        /// </summary>
        /// <param name="msg">The timings to enqueue</param>
        protected void Notify(AppMsg msg)
            => MsgQueue.Add(msg);

        /// <summary>
        /// Enqueues application messages
        /// </summary>
        /// <param name="msg">The messages to enqueue</param>
        protected void Notify(params AppMsg[] messages)
            => MsgQueue.AddRange(messages);

        protected void NotifyError(Exception e)
        {
            var msg = AppMsg.Define($"{e}", SeverityLevel.Error);
            (this as IContext).EmitMessages(msg);
        }

        /// <summary>
        /// Enqueues operation timing
        /// </summary>
        /// <param name="timing">The timing to enqueue</param>
        protected void Mark(OpTime timing)
            => OpTimes.Add(timing);

        /// <summary>
        /// Enqueues operation timings
        /// </summary>
        /// <param name="timings">The timings to enqueue</param>
        protected void Mark(params OpTime[] timings)
            => OpTimes.AddRange(timings);

        /// <summary>
        /// Enqueues operation timings
        /// </summary>
        /// <param name="timings">The timings to enqueue</param>
        protected void Mark(IEnumerable<OpTime> timings)
            => OpTimes.AddRange(timings);

        protected void HiLite(string msg, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => Notify(AppMsg.Define(msg, SeverityLevel.HiliteCL, caller, file, line));

        protected void Trace(string msg, SeverityLevel? severity = null)
        {
            if(TraceEnabled)
                Notify(AppMsg.Define($"{msg}", severity ?? SeverityLevel.Babble));
        }

        protected void Trace(string title, string msg, int? tpad = null, SeverityLevel? severity = null)
        {
            var titleFmt = tpad.Map(pad => title.PadRight(pad), () => title.PadRight(20));        
            if(TraceEnabled)
                Notify(AppMsg.Define($"{titleFmt}: {msg}", severity ?? SeverityLevel.Babble));
        }

        protected void Trace<T>(NamedValue<T> nv, int? npad = null, SeverityLevel? severity = null)
            => Trace(nv.Name, $"{nv.Value}", npad, severity);

        /// <summary>
        /// Submits a diagnostic messages to the queue predicated on an expression evaluation
        /// </summary>
        /// <param name="fx">The expression to evaluate</param>
        /// <param name="severity">The diagnostic severity level</param>
        /// <typeparam name="T"></typeparam>
        protected void Trace<T>(Expression<Func<T>> fx, SeverityLevel? severity = null)
        {
            Trace(fx.Evaluate(), null, severity);
        }

        /// <summary>
        /// Submits a diagnostic message to the message queue
        /// </summary>
        /// <param name="msg">The source message</param>
        /// <param name="severity">The diagnostic severity level that, if specified, 
        /// replaces the exising source message severity prior to queue submission</param>
        protected void Trace(AppMsg msg, SeverityLevel? severity = null)
        {
            if(TraceEnabled)
                Notify(msg.WithLevel(severity ?? SeverityLevel.Babble));
        }

        /// <summary>
        /// Submits a diagnostic message to the queue related to performance/benchmarking
        /// </summary>
        /// <param name="msg">The message to submit</param>
        protected void TracePerf(string msg)
        {
            if(TraceEnabled)
                Notify(AppMsg.Define($"{msg}", SeverityLevel.Benchmark));
        }

        /// <summary>
        /// Collects operation pair timing
        /// </summary>
        /// <param name="time">The time to collect</param>
        /// <param name="labelPad">For tracing, the width of the timing label</param>
        protected void Collect(OpTimePair time, int? labelPad = null)
        {
            Mark(time.Left,time.Right);

            if(TraceEnabled)
                TracePerf(time.Format(labelPad));
        }

        /// <summary>
        /// Collects operation timing
        /// </summary>
        /// <param name="time">The time to collect</param>
        /// <param name="labelPad">For tracing, the width of the timing label</param>
        protected void Collect(OpTime time, int? labelPad = null)
        {
            Mark(time);

            if(TraceEnabled)
                TracePerf(time.Format(labelPad));
        }

        /// <summary>
        /// Collects function evaluation timing
        /// </summary>
        /// <param name="f">The function to evaluate</param>
        /// <param name="label">The measurement label</param>
        /// <param name="labelPad">For tracing, the width of the measurement label</param>
        public void Measure(Func<int> f, [CallerMemberName] string label = null, int? labelPad = null)
        {
            var sw = stopwatch();
            var ops = f();
            var time = OpTime.Define(ops, snapshot(sw), label);
            Mark(time);

            if(TraceEnabled)
                TracePerf(time.Format(labelPad));
        }
    }

    public abstract class Context<T> : Context
    {                
        protected Context(IPolyrand randomizer)
            : base(randomizer)            
        {

        }

    }   

    public abstract class AppContext<T> : Context<T>
        where T : AppContext<T>, new()
    {
        protected AppContext(IPolyrand rng)
            : base(rng)
        {

        }

        public abstract void Run();

        public static void RunApp()
            => new T().Run();

    }

}