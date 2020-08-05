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

    using static Konst;

    /// <summary>
    /// Reifies a workflow event receiver that emits received events to the terminal
    /// </summary>
    public readonly struct TermEventSink : IMultiSink
    {
        const string Created  = "Created";

        const string Finished = "Finished";

        public static TermEventSink create(CorrelationToken? ct = null)
            => new TermEventSink(ct ?? CorrelationToken.create());
        
        readonly CorrelationToken Ct;    
        
        public TermEventSink(CorrelationToken ct)
        {
            Ct = ct;
        }
        
        [MethodImpl(Inline)]
        public void Deposit<E>(in E e)
            where E : IAppEvent
        {            
            term.print(e.Format(), e.Flair);            
        }

        public void Deposit(IAppMsg e)
        {
            term.print(e);
        }

        public void Deposit(IWfEvent e)
        {
            term.print(e);
        }

        public void Deposit(IAppEvent e)
        {
            term.print(e);
        }

        public void Deposit<T>(T content, CorrelationToken ct, AppMsgKind kind = AppMsgKind.Info,  [Caller]string caller = null, [File] string file = null, [Line] int? line = null)
        {            
            var msg = AppMsg.Define(content, kind, caller, file, line);
            term.print(msg);            
        }

        public void Dispose()
        {
            Deposit(Finished, Ct);
        }
    }
}