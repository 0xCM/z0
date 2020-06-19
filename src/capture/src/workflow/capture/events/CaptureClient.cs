//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct CaptureClient : ICaptureClient
    {
        public ICaptureBroker Broker {get;}

        public IAppMsgSink Sink {get;}

        [MethodImpl(Inline)]
        public static ICaptureClient Create(ICaptureBroker broker, IAppMsgSink sink, bool connect = true)
            => new CaptureClient(broker, sink,connect);

        [MethodImpl(Inline)]
        public CaptureClient(ICaptureBroker broker, IAppMsgSink sink, bool connect)
        {
            Broker = broker;
            Sink = sink;
            if(connect)
                ((ICaptureClient)this).Connect();
        }
    }    
}