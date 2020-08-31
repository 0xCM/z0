//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public class CaptureContext : ICaptureContext
    {
        public CorrelationToken Ct {get;}

        public IAppContext ContextRoot {get;}

        public IAsmDecoder Decoder {get;}

        public IAsmFormatter Formatter {get;}

        public AsmTextWriterFactory WriterFactory {get;}

        public IWfCaptureBroker CaptureBroker {get;}

        public CaptureContext(IAppContext root, IAsmDecoder decoder, IAsmFormatter formatter, AsmTextWriterFactory wf,
            IWfCaptureBroker broker, CorrelationToken ct)
        {
            Ct = ct;
            ContextRoot = root;
            Decoder = decoder;
            Formatter = formatter;
            WriterFactory = wf;
            CaptureBroker = broker;
        }

        [MethodImpl(Inline)]
        public void Raise<E>(E e)
            where E : IAppEvent
                => CaptureBroker.Raise(e);
    }
}