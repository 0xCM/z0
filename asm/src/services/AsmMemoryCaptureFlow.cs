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

    class AsmMemoryCaptureFlow : IAsmMemoryCaptureFlow
    {
        public IAsmContext Context {get;}

        readonly byte[] ExtractBuffer;

        readonly IAsmMemoryExtractor Extractor;

        readonly byte[] ParseBuffer;

        readonly IAsmInstructionDecoder Decoder;

        public MemoryAddress[] Addresses {get;}

        [MethodImpl(Inline)]
        public static IAsmMemoryCaptureFlow Create(IAsmContext context, IEnumerable<MemoryAddress> selected)
            => new AsmMemoryCaptureFlow(context,selected);

        [MethodImpl(Inline)]
        AsmMemoryCaptureFlow(IAsmContext context, IEnumerable<MemoryAddress> selected)
        {
            this.Context = context;
            this.ExtractBuffer = new byte[context.DefaultBufferLength];
            this.ParseBuffer = new byte[context.DefaultBufferLength];
            this.Addresses = selected.OrderBy(x => x.Location).ToArray();
            this.Extractor = context.MemoryExtractor(ExtractBuffer);
            this.Decoder = context.InstructionDecoder();
        }
        
        public IEnumerable<AsmMemoryExtract> Execute()
        {            
            foreach(var address in Addresses)
            {
                Context.PostMessage($"{address} - Executing memory capture workflow");
                
                var capture = RunCaptureFlow(address);
                if(capture)
                {
                    Context.PostMessage($"{address} - Executed memory capture workflow successfully");
                    yield return capture.Value;
                }
                else
                {
                    term.error($"{address} - Memory capture workflow failed");
                }                                
            }
        }
        
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

        Option<AsmMemoryExtract> RunCaptureFlow(MemoryAddress src)        
            => from raw in Extract(src)
                from parsed in Parse(raw)
                from instructions in Decode(parsed)
                let bits = AsmCaptureBits.Define(src, raw, parsed)
                select AsmMemoryExtract.Define(src,bits,instructions);
    }
}