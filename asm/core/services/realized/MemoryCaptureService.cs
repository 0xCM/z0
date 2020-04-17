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

        public Option<ApiMemoryCapture> Capture(MemoryAddress src)        
            => from raw in Extract(src)
                from parsed in Parse(raw)
                where parsed.IsNonEmpty
                from instructions in Decoder.DecodeInstructions(parsed)
                let bits = ParsedMemoryExtract.Define(src, raw, parsed)
                select ApiMemoryCapture.Define(src, bits, instructions, string.Empty);

        [MethodImpl(Inline)]
        public Option<Addressable> Extract(MemoryAddress src)
            => Extractor.Extract(src);

        public Option<Addressable> Parse(Addressable src)
            => from parsed in Context.MemoryExtractParser(ParseBuffer.Clear()).Parse(src)
                let encoded = Addressable.Define(src.Address, parsed)
                select encoded;

        [MethodImpl(Inline)]
        public Option<AsmInstructionList> Decode(Addressable src)
            => Decoder.DecodeInstructions(src);
    }
}