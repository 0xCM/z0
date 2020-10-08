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
    /// Reifies a workflow event receiver that both logs received events and renders received events to the terminal
    /// </summary>
    public readonly struct WfTermLog : IWfEventSink, IMultiSink
    {
        public CorrelationToken Ct {get;}

        readonly IWfEventLog EventLog;

        public WfTermLog(IWfEventLog log, CorrelationToken ct)
        {
            Ct = ct;
            EventLog = log;
        }

        [MethodImpl(Inline)]
        public ref readonly E Deposit<E>(in E e)
            where E : IWfEvent
        {
            term.print(e.Format(), e.Flair);
            EventLog.Deposit(e);
            return ref e;
        }

        [MethodImpl(Inline)]
        public void Deposit(IWfEvent e)
        {
            term.print(e.Format(), e.Flair);
            EventLog.Deposit(e);
        }

        public void Deposit(IAppMsg e)
        {
            term.print(e);
            EventLog.Deposit(e);
        }

        public void Deposit(IAppEvent e)
        {
            term.print(e);
            EventLog.Deposit(e);
        }

        public void Deposit(string message, FlairKind? color = null)
        {
            term.print(message, color ?? FlairKind.Status);
        }

        public void Dispose()
        {
            term.print("Goodbye");
        }
    }
}