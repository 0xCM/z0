//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    readonly struct AsmFunctionDecoder : IAsmFunctionDecoder
    {
        readonly C Context;

        struct C
        {
            public static C Create(IContext context, AsmFormatConfig format)
                => new C
                {
                    Decoder = context.AsmInstructionDecoder(format),
                    Builder =context.FunctionBuilder()
                };

            public IAsmInstructionDecoder Decoder;

            public IAsmFunctionBuilder Builder;
        }

        [MethodImpl(Inline)]
        public static AsmFunctionDecoder Create(IContext context, AsmFormatConfig format)
            => new AsmFunctionDecoder(context, format);
        
        [MethodImpl(Inline)]
        AsmFunctionDecoder(IContext context, AsmFormatConfig format)
        {
            Context = C.Create(context,format);
        }

        public Option<AsmFunction> Decode(ApiMemberCapture src)
            => DecodeCaptured(Context, src);

        public Option<AsmFunction> Decode(ParsedMember parsed)
            =>  from i in Context.Decoder.DecodeInstructions(ApiBits.Define(parsed.MemberUri.OpId, parsed.Content))
                select AsmFunction.Define(parsed, i);

        public Option<AsmFunction> Decode(ParsedExtract src)
            =>  from i in Context.Decoder.DecodeInstructions(ApiBits.Define(src.Id, src.ParsedContent))
                select AsmFunction.Define(src,i);

        static Option<AsmFunction> DecodeCaptured(C context, ApiMemberCapture src)
            => from i in context.Decoder.DecodeInstructions(src.Code)
                let block = Asm.AsmInstructionBlock.Define(src.Code, i, src.TermCode)
                select context.Builder.BuildFunction(src.Uri, src.OpSig.Format(), block);

    }
}