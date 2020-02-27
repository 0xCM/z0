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

        Option<CilFunction> GetCil(CapturedMember src)
            => from c in Context.ClrIndex.FindCil(src.Method.MetadataToken)
               select c.WithSig(src.Method.Signature());

        public AsmFunction DecodeFunction(CapturedMember src, bool emitcil = true)
        {
            var list = Context.DecodeInstructions(src.Code);
            var block = Asm.AsmInstructionBlock.Define(src.Code, list, src.TermCode);
            var f = Context.FunctionBuilder().BuildFunction(src.Operation, block);
            if(emitcil)
                f = f.WithCil(GetCil(src).ValueOrDefault());
            return f;
        }

        public AsmFunction DecodeFunction(ParsedEncoding parsed)
        {
            var op = parsed.Operation;
            var code = AsmCode.Define(op.Id, parsed.ParsedData);
            var instructions = Context.DecodeInstructions(code);
            return AsmFunction.Define(parsed, instructions);
        }
    }
}