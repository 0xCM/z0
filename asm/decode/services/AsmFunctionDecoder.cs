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

        Option<CilFunction> GetCil(CapturedOp src)
            => from c in Context.ClrIndex.FindCil(src.Method.MetadataToken)
               select c.WithSig(src.Method.Signature());

        public AsmFunction DecodeFunction(CapturedOp src, bool emitcil = true)
        {
            var list = Context.DecodeInstructions(src.Code);
            var block = Asm.AsmInstructionBlock.Define(src.Code, list.Require(), src.TermCode);
            var f = Context.FunctionBuilder().BuildFunction(src.Operation, block);
            if(emitcil)
                f = f.WithCil(GetCil(src).ValueOrDefault());
            return f;
        }

        public AsmFunction DecodeFunction(ParsedOpExtract parsed)
        {
            var op = parsed.Operation;
            var code = AsmCode.Define(op.Id, parsed.Content);
            var instructions = Context.DecodeInstructions(code).Require();
            return AsmFunction.Define(parsed, instructions);
        }
    }
}