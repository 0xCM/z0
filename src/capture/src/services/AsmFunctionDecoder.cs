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
        readonly IAsmInstructionDecoder Decoder;

        [MethodImpl(Inline)]
        public static AsmFunctionDecoder Create(IContext context, AsmFormatConfig format)
            => new AsmFunctionDecoder(context, format);
        
        [MethodImpl(Inline)]
        AsmFunctionDecoder(IContext context, AsmFormatConfig format)
        {
            Decoder = context.AsmInstructionDecoder(format);
        }

        static IAsmFunctionBuilder Builder => AsmFunctionBuilder.Default;

        public Option<AsmFunction> Decode(MemberCapture src)
            => DecodeCaptured(Decoder, src);

        public Option<AsmFunction> Decode(ParsedMember parsed)
            =>  from i in Decoder.DecodeInstructions(OperationBits.Define(parsed.MemberUri.OpId, parsed.Content))
                select AsmFunction.Define(parsed, i);

        public Option<AsmFunction> Decode(ParsedMemberExtract src)
            =>  from i in Decoder.DecodeInstructions(OperationBits.Define(src.Id, src.ParsedContent))
                select AsmFunction.Define(src,i);

        static Option<AsmFunction> DecodeCaptured(IAsmInstructionDecoder decoder, MemberCapture src)
            => from i in decoder.DecodeInstructions(src.Code)
                let block = Asm.AsmInstructionBlock.Define(src.Code, i, src.TermCode)
                select Builder.BuildFunction(src.Uri, src.OpSig.Format(), block);
    }
}