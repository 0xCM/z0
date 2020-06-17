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

    public class CaptureWorkflowContext : ICaptureContext
    {
        public CaptureWorkflowContext(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory wf, 
            ICaptureBroker broker, ICaptureArchive archive)
        {
            this.ApiSet = context.ApiSet;
            this.Extractor = Capture.Services.HostExtractor();
            this.Parser = Extract.Services.ExtractParser();
            this.Decoder = decoder;
            this.Formatter = formatter;
            this.WriterFactory = wf;
            this.Broker = broker;
            this.Archive = archive;
            this.MsgSink = context;
        }

        public IApiSet ApiSet {get;}

        public IMemberExtractor Extractor {get;}

        public IExtractParser Parser {get;}

        public IAsmFunctionDecoder Decoder {get;}

        public IAsmFormatter Formatter {get;}

        public AsmWriterFactory WriterFactory {get;}

        public ICaptureBroker Broker {get;}

        public ICaptureArchive Archive {get;}

        public IAppMsgSink MsgSink {get;}

        int step;

        [MethodImpl(Inline)]
        public CorrelationToken Correlate()
            => CorrelationToken.From(increment(ref step));

        [MethodImpl(Inline)]
        public ref readonly E Raise<E>(in E e)
            where E : IAppEvent
                => ref Broker.Raise(e);
    }
}