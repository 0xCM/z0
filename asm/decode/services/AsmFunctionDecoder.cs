//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Core;

    readonly struct AsmFunctionDecoder : IAsmFunctionDecoder
    {
        readonly IContext Context;

        readonly IAsmInstructionDecoder Decoder;

        [MethodImpl(Inline)]
        public static AsmFunctionDecoder Create(IContext context, AsmFormatConfig format)
            => new AsmFunctionDecoder(context, format);
        
        [MethodImpl(Inline)]
        AsmFunctionDecoder(IContext context, AsmFormatConfig format)
        {
            this.Context = context;
            this.Decoder = context.AsmInstructionDecoder(format);
        }

        public AsmFunction DecodeFunction(CapturedOp src)
        {
            var list = Decoder.DecodeInstructions(src.Code).Require();
            var block = Asm.AsmInstructionBlock.Define(src.Code, list, src.TermCode);
            return Context.FunctionBuilder().BuildFunction(src.Uri, src.OpSig, block);
        }

        public AsmFunction DecodeFunction(ParsedMemberCode parsed)
        {
            var code = AsmCode.Define(parsed.MemberUri.OpId, parsed.Content);
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