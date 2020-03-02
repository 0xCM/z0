//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    using static Root;

    class AsmMemoryCapture : IAsmMemoryCapture
    {
        public IAsmContext Context {get;}

        readonly byte[] ExtractBuffer;

        readonly IAsmMemoryExtractor Extractor;

        readonly byte[] ParseBuffer;

        readonly IAsmFunctionFormatter Formatter;

        readonly IAsmInstructionDecoder Decoder;

        [MethodImpl(Inline)]
        public static IAsmMemoryCapture Create(IAsmContext context)
            => new AsmMemoryCapture(context);

        [MethodImpl(Inline)]
        AsmMemoryCapture(IAsmContext context)
        {
            this.Context = context;
            this.ExtractBuffer = new byte[context.DefaultBufferLength];
            this.ParseBuffer = new byte[context.DefaultBufferLength];
            this.Extractor = context.MemoryExtractor(ExtractBuffer);
            this.Decoder = context.InstructionDecoder();
            this.Formatter = context.AsmFormatter(context.AsmFormat.WithSectionDelimiter());
        }
        
        public Option<AsmMemoryExtract> Capture(MemoryAddress src)        
            => from raw in Extract(src)
                from parsed in Parse(raw)
                from instructions in Decode(parsed)
                let bits = AsmCaptureBits.Define(src, raw, parsed)
                select AsmMemoryExtract.Define(src, bits, instructions, string.Empty);

        [MethodImpl(Inline)]
        Option<EncodedData> Extract(MemoryAddress src)
            => Extractor.Extract(src);

        Option<EncodedData> Parse(EncodedData src)
            => from parsed in Context.EncodingParser(ParseBuffer.Clear()).Parse(src)
                let encoded = EncodedData.Define(src.BaseAddress, parsed)
                select encoded;

        [MethodImpl(Inline)]
        Option<AsmInstructionList> Decode(EncodedData src)
            => Decoder.DecodeInstructions(src);

    }
}