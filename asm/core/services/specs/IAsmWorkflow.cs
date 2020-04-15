//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IAsmWorkflow : IService
    {
        IAppMsgSink Sink {get;}

        void Report(IAppEvent e, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(e.Format(), color);        
    }

    public interface IAsmWorkflow<R> :  IAsmWorkflow
        where R : IWorkflowRelay
    {
        R Relay {get;}            


        [MethodImpl(Inline)]
        ref readonly E Raise<E>(in E e)
            where E : IAppEvent
                => ref Relay.Raise(e);
    }

    public interface IAsmWorkflow<W,R> : IAsmWorkflow<R>
        where W : IAsmWorkflow<W,R>
        where R : IWorkflowRelay
    {

    }
}