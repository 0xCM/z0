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
        
        public IAsmContext Asm {get;}
        
        public IApiSet ApiSet {get;}

        public IExtractionParser Parser {get;}

        public IAsmFunctionDecoder Decoder {get;}

        public IAsmFormatter Formatter {get;}

        public AsmWriterFactory WriterFactory {get;}

        public IWfCaptureBroker CaptureBroker {get;}

        public IPartCaptureArchive Archive {get;}

        public IAppMsgSink MsgSink {get;}

        public CaptureContext(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory wf, 
            IWfCaptureBroker broker, IPartCaptureArchive archive, CorrelationToken ct)
        {
            Asm = context;
            Ct = ct;
            ApiSet = context.ContextRoot;
            Parser = Extractors.Services.ExtractParser(Extractors.DefaultBufferLength);
            Decoder = decoder;
            Formatter = formatter;
            WriterFactory = wf;
            CaptureBroker = broker;
            Archive = archive;
            MsgSink = context;
        }

        [MethodImpl(Inline)]
        public void Raise<E>(E e)
            where E : IAppEvent
                => CaptureBroker.Raise(e);
    }
}