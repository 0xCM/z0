//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class MemoryCaptureService : IMemoryCapture
    {
        [MethodImpl(Inline)]
        public static IMemoryCapture Create(IAsmFunctionDecoder decoder, int? bufferlen = null)
            => new MemoryCaptureService(decoder, bufferlen ?? Pow2.T14);
        
        readonly byte[] ExtractBuffer;

        readonly byte[] ParseBuffer;

        readonly IMemoryExtractor Extractor;

        readonly IAsmFunctionDecoder Decoder;

        [MethodImpl(Inline)]
        static ILocatedCodeParser ExtractParser(byte[] buffer) 
            => Z0.Extract.Services.LocatedParser(buffer);

        [MethodImpl(Inline)]
        static IMemoryExtractor MemoryExtractor(byte[] buffer) 
            => Z0.Asm.Capture.Services.MemoryExtractor(buffer);

        [MethodImpl(Inline)]
        internal MemoryCaptureService(IAsmFunctionDecoder decoder, int bufferlen)
        {
            this.ExtractBuffer = new byte[bufferlen];
            this.ParseBuffer = new byte[bufferlen];
            this.Extractor = MemoryExtractor(ExtractBuffer);
            this.Decoder = decoder;
        }

        public Option<CapturedMemory> Capture(MemoryAddress src)        
            => from raw in Extract(src)
                from parsed in Parse(raw)
                where parsed.IsNonEmpty
                from instructions in Decoder.Decode(parsed)
                let bits = ParsedCode.Define(src, raw, parsed)
                select CapturedMemory.Define(src, bits, instructions, string.Empty);

        [MethodImpl(Inline)]
        public Option<LocatedCode> Extract(MemoryAddress src)
            => Extractor.Extract(src);

        public Option<LocatedCode> Parse(LocatedCode src)
            => from parsed in  ExtractParser(ParseBuffer.Clear()).Parse(src)
               let encoded = LocatedCode.Define(src.Address, parsed)
               select encoded;

        [MethodImpl(Inline)]
        public Option<AsmInstructionList> Decode(LocatedCode src)
            => Decoder.Decode(src);
    }
}