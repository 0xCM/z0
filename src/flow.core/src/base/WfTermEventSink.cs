//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Reifies a workflow event receiver that emits received events to the terminal
    /// </summary>
    public readonly struct WfTermEventSink : IWfEventSink<WfTermEventSink>, IMultiSink
    {
        public static WfTermEventSink create(IWfEventLog log, CorrelationToken ct)
            => new WfTermEventSink(log, ct);

        readonly CorrelationToken Ct;    
        
        readonly IWfEventLog Log;
        
        internal WfTermEventSink(IWfEventLog log, CorrelationToken ct)
        {
            Ct = ct;
            Log = log;
        }
                
        [MethodImpl(Inline)]
        public ref readonly E Deposit<E>(in E e)
            where E : IWfEvent
        {
            term.print(e.Format(), e.Flair);            
            Log.Deposit(e);            
            return ref e;
        }

        [MethodImpl(Inline)]
        public void Deposit(IWfEvent e)
        {
            term.print(e.Format(), e.Flair);
            Log.Deposit(e);            
        }

        public void Deposit(IAppMsg e)
        {
            term.print(e);
        }
        
        public void Deposit(IAppEvent e)
        {
            term.print(e);
            Log.Deposit(e);            

        }

        public void Deposit(string message, MessageFlair? color = null)
        {
            term.print(message, color ?? MessageFlair.Green);
        }

        public void Dispose()
        {
            term.print(new WfStepRan<string>(nameof(WfTermEventSink), "Bye bye byte", Ct));                 
        }
    }
}