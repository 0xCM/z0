//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static root;

    readonly struct AsmFunctionDecoder : IAsmFunctionDecoder
    {
        public IAsmContext Context {get;}

        readonly IAsmInstructionDecoder Decoder;

        [MethodImpl(Inline)]
        public static AsmFunctionDecoder Create(IAsmContext context)
            => new AsmFunctionDecoder(context);
        
        [MethodImpl(Inline)]
        AsmFunctionDecoder(IAsmContext context)
        {
            this.Context = context;
            this.Decoder = context.AsmInstructionDecoder();
        }

        // Option<CilFunction> GetCil(CapturedOp src)
        //     => from c in Context.ClrIndex.FindCil(src.Method.MetadataToken)
        //        select c.WithSig(src.Method.Signature());

        public AsmFunction DecodeFunction(CapturedOp src)
        {
            var list = Decoder.DecodeInstructions(src.Code).Require();
            var block = Asm.AsmInstructionBlock.Define(src.Code, list, src.TermCode);
            var f = Context.FunctionBuilder().BuildFunction(src.Operation, block);
            // if(emitcil)
            //     f = f.WithCil(GetCil(src).ValueOrDefault());
            return f;
        }

        public AsmFunction DecodeFunction(ParsedOpExtract parsed)
        {
            var op = parsed.Operation;
            var code = AsmCode.Define(op.Id, parsed.Content);
            var instructions = Decoder.DecodeInstructions(code).Require();
            return AsmFunction.Define(parsed, instructions);
        }

        public AsmFunction[] Decode(params ParsedExtract[] src)
        {
            var dst = new AsmFunction[src.Length];
            for(var i=0; i<src.Length; i++)
            {
                var parsed = src[i];
                var code = AsmCode.Define(parsed.Id, parsed.ParsedContent);
                var instructions = Decoder.DecodeInstructions(code).Require();
                dst[i] = AsmFunction.Define(parsed, instructions);
            }
            return dst;
        }
    }
}