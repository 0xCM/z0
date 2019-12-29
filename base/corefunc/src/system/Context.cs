//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
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
        /// The context random source
        /// </summary>
        public virtual IPolyrand Random {get;}

        protected virtual bool TraceEnabled {get;}
            = true;


        List<AppMsg> MsgQueue {get;} 
            = new List<AppMsg>();


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