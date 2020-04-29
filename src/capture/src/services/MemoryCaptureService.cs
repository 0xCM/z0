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
        readonly byte[] ExtractBuffer;

        readonly byte[] ParseBuffer;

        readonly IMemoryExtractor Extractor;

        readonly IAsmFunctionDecoder Decoder;

        [MethodImpl(Inline)]
        static ILocatedParser ExtractParser(byte[] buffer) 
            =>  Z0.Extract.Services.LocatedParser(buffer);

        [MethodImpl(Inline)]
        static IMemoryExtractor MemoryExtractor(byte[] buffer) 
            => AsmWorkflows.Stateless.MemoryExtractor(buffer);

        [MethodImpl(Inline)]
        internal MemoryCaptureService(IAsmFunctionDecoder decoder, int bufferlen)
        {
            this.ExtractBuffer = new byte[bufferlen];
            this.ParseBuffer = new byte[bufferlen];
            this.Extractor = MemoryExtractor(ExtractBuffer);
            this.Decoder = decoder;
        }

        public Option<MemoryCapture> Capture(MemoryAddress src)        
            => from raw in Extract(src)
                from parsed in Parse(raw)
                where parsed.IsNonEmpty
                from instructions in Decoder.DecodeInstructions(parsed)
                let bits = ParsedMemoryExtract.Define(src, raw, parsed)
                select MemoryCapture.Define(src, bits, instructions, string.Empty);

        [MethodImpl(Inline)]
        public Option<LocatedCode> Extract(MemoryAddress src)
            => Extractor.Extract(src);

        public Option<LocatedCode> Parse(LocatedCode src)
            => from parsed in  ExtractParser(ParseBuffer.Clear()).Parse(src)
               let encoded = LocatedCode.Define(src.Address, parsed)
               select encoded;

        [MethodImpl(Inline)]
        public Option<AsmInstructionList> Decode(LocatedCode src)
            => Decoder.DecodeInstructions(src);
    }
}