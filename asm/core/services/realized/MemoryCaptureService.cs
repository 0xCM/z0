//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    class MemoryCaptureService : IMemoryCapture
    {
        readonly IContext Context;

        readonly byte[] ExtractBuffer;

        readonly byte[] ParseBuffer;

        readonly IMemoryExtractor Extractor;

        readonly IAsmInstructionDecoder Decoder;

        [MethodImpl(Inline)]
        public static IMemoryCapture Create(IContext context, IAsmInstructionDecoder decoder, int bufferlen)
            => new MemoryCaptureService(context, decoder, bufferlen);

        [MethodImpl(Inline)]
        MemoryCaptureService(IContext context, IAsmInstructionDecoder decoder, int bufferlen)
        {
            this.Context = context;
            this.ExtractBuffer = new byte[bufferlen];
            this.ParseBuffer = new byte[bufferlen];
            this.Extractor = context.MemoryExtractor(ExtractBuffer);
            this.Decoder = decoder;
        }

        public Option<ParsedMemoryCapture> Capture(MemoryAddress src)        
            => from raw in Extract(src)
                from parsed in Parse(raw)
                from instructions in Decode(parsed)
                let bits = ParsedMemoryExtract.Define(src, raw, parsed)
                select ParsedMemoryCapture.Define(src, bits, instructions, string.Empty);

        [MethodImpl(Inline)]
        public Option<MemoryExtract> Extract(MemoryAddress src)
            => Extractor.Extract(src);

        public Option<MemoryExtract> Parse(MemoryExtract src)
            => from parsed in Context.MemoryExtractParser(ParseBuffer.Clear()).Parse(src)
                let encoded = MemoryExtract.Define(src.Address, parsed)
                select encoded;

        [MethodImpl(Inline)]
        public Option<AsmInstructionList> Decode(MemoryExtract src)
            => Decoder.DecodeInstructions(src);
    }
}