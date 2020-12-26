//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Part;

    /// <summary>
    /// Reifies a workflow event receiver that emits received events to the terminal
    /// </summary>
    public readonly struct TermEventSink : IMultiSink
    {
        readonly CorrelationToken Ct;

        [MethodImpl(Inline)]
        internal TermEventSink(CorrelationToken ct)
            => Ct = ct;

        [MethodImpl(Inline)]
        public void Deposit<E>(in E e)
            where E : IAppEvent
                => term.print(e.Format(), e.Flair);

        [MethodImpl(Inline)]
        public void Deposit(IAppMsg e)
            => term.print(e);

        [MethodImpl(Inline)]
        public void Deposit(IWfEvent e)
            => term.print(e);

        [MethodImpl(Inline)]
        public void Deposit(IAppEvent e)
            => term.print(e);

        [MethodImpl(Inline)]
        public void Deposit<T>(T content, CorrelationToken ct, LogLevel kind = LogLevel.Status, [Caller]string caller = null, [File] string file = null, [Line] int? line = null)
            => term.print(AppMsg.called(content, kind, caller, file, line));

        public void Dispose()
            => Deposit("Finished", Ct);
    }
}