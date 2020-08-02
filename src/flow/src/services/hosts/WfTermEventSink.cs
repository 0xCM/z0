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
    public readonly struct WfTermEventSink : IWfEventSink<WfTermEventSink>
    {
        public static WfTermEventSink create()
            => default;
                
        [MethodImpl(Inline)]
        public void Deposit<E>(in E e)
            where E : IWfEvent
        {
            term.print(e.Format(), e.Flair);            
        }

        [MethodImpl(Inline)]
        public void Deposit(IWfEvent e)
        {
            term.print(e.Format(), e.Flair);
        }

        public void Deposit(IAppMsg e)
        {
            term.print(e);
        }
        public void Deposit(IAppEvent e)
        {
            term.print(e);
        }

        public void Deposit(string message, AppMsgColor? color = null)
        {
            term.print(message, color ?? AppMsgColor.Green);
        }

        public void Dispose()
        {

        }
    }
}