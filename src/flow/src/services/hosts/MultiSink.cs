//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct MultiSink : IMultiSink
    {        
        readonly IAppEventSink Sink;

        [MethodImpl(Inline)]
        public void Deposit(IWfEvent e)
            => Sink.Deposit(e);

        [MethodImpl(Inline)]
        public void Deposit(IAppEvent e)
            => Sink.Deposit(e);

        [MethodImpl(Inline)]
        public MultiSink(IAppEventSink sink)        
        {
            Sink = sink;
            Sink.Deposit(new WorkerInitialized(nameof(MultiSink)));
        }
        
        public void Dispose()
        {
            Sink.Deposit(new WfStepFinished(nameof(MultiSink)));
        }
    }
}