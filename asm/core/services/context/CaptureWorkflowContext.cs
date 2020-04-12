//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public class CaptureWorkflowContext : IContext
    {
        public CaptureWorkflowContext(IAsmContext context, IApiSet api, IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory wf, 
            IHostExtractor extractor, IExtractParser parser,  IHostCaptureWorkflowRelay broker)
        {
            this.RootContext = context;
            this.ApiSet = api;
            this.Extractor = extractor;
            this.Parser = parser;
            this.Decoder = decoder;
            this.Formatter = formatter;
            this.WriterFactory = wf;
            this.Broker = broker;
        }

        public IContext RootContext {get;}

        public IApiSet ApiSet {get;}

        public IHostExtractor Extractor {get;}

        public IExtractParser Parser {get;}

        public IAsmFunctionDecoder Decoder {get;}

        public IAsmFormatter Formatter {get;}

        public AsmWriterFactory WriterFactory {get;}

        public IHostCaptureWorkflowRelay Broker {get;}

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