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
    public readonly struct WfTermLog : IWfEventSink
    {
        public string Source {get;}

        [MethodImpl(Inline)]
        public WfTermLog(string source)
        {
            Source = source ?? EmptyString;
            term.print(PartMsg.SourceLoggerCreated.Format(Source ?? EmptyString));
        }

        [MethodImpl(Inline)]
        public void Deposit(IWfEvent e)
        {
            if(e != null)
                term.print(e.Format(), e.Flair);
            else
                term.error("A null message was deposited");
        }

        public void Dispose()
            => term.print(PartMsg.SourceLoggerDisposed.Format(Source ?? EmptyString));
    }
}