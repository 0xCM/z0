//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using Z0.Asm;    
    
    using static Root;

    public readonly struct AsmFunctionDecoder : IAsmFunctionDecoder
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static AsmFunctionDecoder Create(IAsmContext context)
            => new AsmFunctionDecoder(context);
        
        [MethodImpl(Inline)]
        AsmFunctionDecoder(IAsmContext context)
        {
            this.Context = context;
        }

        public AsmFunction DecodeFunction(CapturedMember src, bool emitcil = true)
        {
            var list = Context.DecodeInstructions(src.Code, src.SourceMemory.Start);
            var block = Asm.AsmInstructionBlock.Define(src.Code, list, src.Outcome);
            var f = Context.FunctionBuilder().BuildFunction(src.SourceOp, block);
            return emitcil ? f.WithCil(Context.ClrIndex.FindCil(src.Method).ValueOrDefault()) : f;
        }

        public AsmFunction DecodeFunction(ParsedEncoding parsed)
        {
            var op = parsed.Operation;
            var code = AsmCode.Define(op.Id, parsed.AddressRange, parsed.ParsedData);
            var instructions = Context.DecodeInstructions(code, parsed.AddressRange.Start);
            return AsmFunction.Define(parsed, parsed.CaptureResult, instructions);
            //return AsmFunction.Define(op, code, parsed.CaptureResult, instructions);
        }

        // public AsmFunction DecodeFunction(OpDescriptor src, CaptureSummary summary)
        // {
        //     var code = AsmCode.Define(src.Id, summary.Range, summary.Bits.Trimmed);
        //     var instructions = Context.DecodeInstructions(code, summary.Range.Start);
        //     return AsmFunction.Define(src, code, summary.Outcome, instructions);
        // }
    }
}