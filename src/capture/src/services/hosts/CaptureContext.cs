//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class CaptureContext : ICaptureContext
    {
        public CorrelationToken Ct {get;}

        public IAsmDecoder Decoder {get;}

        public IAsmFormatter Formatter {get;}

        public IWfCaptureBroker CaptureBroker {get;}

        public CaptureContext(IWfShell wf, IAsmDecoder decoder, IAsmFormatter formatter, IWfCaptureBroker broker)
        {
            Ct = wf.Ct;
            Decoder = decoder;
            Formatter = formatter;
            CaptureBroker = broker;
        }

        [MethodImpl(Inline)]
        public void Raise<E>(E e)
            where E : IAppEvent
                => CaptureBroker.Raise(e);
    }
}