//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public class CaptureContext : ICaptureContext
    { 
        public IApiSet ApiSet {get;}

        public IMemberExtractor Extractor {get;}

        public IExtractParser Parser {get;}

        public IAsmFunctionDecoder Decoder {get;}

        public IAsmFormatter Formatter {get;}

        public AsmWriterFactory WriterFactory {get;}

        public ICaptureBroker Broker {get;}

        public TCaptureArchive Archive {get;}

        public IAppMsgSink MsgSink {get;}

        int step;

        public CaptureContext(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory wf, 
            ICaptureBroker broker, TCaptureArchive archive)
        {
            ApiSet = context.Api;
            Extractor = Capture.Services.HostExtractor(Extracts.DefaultBufferLength);
            Parser = Extracts.Services.ExtractParser(Extracts.DefaultBufferLength);
            Decoder = decoder;
            Formatter = formatter;
            WriterFactory = wf;
            Broker = broker;
            Archive = archive;
            MsgSink = context;
        }

        [MethodImpl(Inline)]
        public CorrelationToken Correlate()
            => CorrelationToken.From(increment(ref step));

        [MethodImpl(Inline)]
        public ref readonly E Raise<E>(in E e)
            where E : IAppEvent
                => ref Broker.Raise(e);
    }
}