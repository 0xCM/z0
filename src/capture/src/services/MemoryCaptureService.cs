//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class MemoryCaptureService 
    {        
        readonly byte[] ExtractBuffer;

        readonly byte[] ParseBuffer;

        readonly IMemoryExtractor Extractor;

        readonly IAsmFunctionDecoder Decoder;

        [MethodImpl(Inline)]
        public MemoryCaptureService(int? bufferlen = null)
        {
            ExtractBuffer = new byte[bufferlen ?? Extracts.DefaultBufferLength];
            ParseBuffer = new byte[bufferlen ?? Extracts.DefaultBufferLength];
            Extractor = MemoryExtractor.service(ExtractBuffer);
            Decoder = EncodingDecoder.Service;
        }

        public static void capture(MemoryAddress src, byte[] buffer)
        {
            var extract = Extracts.extract(src, buffer);
        }

        public static void parse(LocatedCode src, byte[] buffer)
        {
            if(ExtractParsers.parse(src, buffer, out var parsed) && parsed.IsNonEmpty)
            {
                var decoder = AsmFunctionDecoder.Default;
                var instructions = decoder.Decode(parsed); 
                var bits = new Z0.ParsedOperation(src.Address, src, parsed)               ;
            }
        }

        public Option<CapturedMemory> Capture(MemoryAddress src)        
            => from raw in Option.some(Extracts.extract(src, ParseBuffer.Clear()))
                from parsed in Parse(raw)
                where parsed.IsNonEmpty
                from instructions in Decoder.Decode(parsed)
                let bits = new Z0.ParsedOperation(src, raw, parsed)
                select new CapturedMemory(src, bits, instructions, string.Empty);

        [MethodImpl(Inline)]
        public Option<LocatedCode> Extract(MemoryAddress src)
            => Extractor.Extract(src);

        public Option<LocatedCode> Parse(LocatedCode src)
            => Extracts.parse(src, ParseBuffer.Clear());

        [MethodImpl(Inline)]
        public Option<AsmInstructionList> Decode(LocatedCode src)
            => Decoder.Decode(src);
    }
}