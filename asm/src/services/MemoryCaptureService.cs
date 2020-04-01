//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    class MemoryCaptureService : IMemoryCapture
    {
        public IAsmContext Context {get;}

        readonly byte[] ExtractBuffer;

        readonly IMemoryExtractor Extractor;

        readonly byte[] ParseBuffer;

        readonly IAsmFormatter Formatter;

        readonly IAsmInstructionDecoder Decoder;

        [MethodImpl(Inline)]
        public static IMemoryCapture Create(IAsmContext context)
            => new MemoryCaptureService(context);

        [MethodImpl(Inline)]
        MemoryCaptureService(IAsmContext context)
        {
            this.Context = context;
            this.ExtractBuffer = new byte[context.DefaultBufferLength];
            this.ParseBuffer = new byte[context.DefaultBufferLength];
            this.Extractor = context.MemoryExtractor(ExtractBuffer);
            this.Decoder = context.AsmInstructionDecoder();
            this.Formatter = context.AsmFormatter(context.AsmFormat.WithSectionDelimiter());
        }
        
        public Option<CapturedMemory> Capture(MemoryAddress src)        
            => from raw in Extract(src)
                from parsed in Parse(raw)
                from instructions in Decode(parsed)
                let bits = ParsedMemoryExtract.Define(src, raw, parsed)
                select CapturedMemory.Define(src, bits, instructions, string.Empty);

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