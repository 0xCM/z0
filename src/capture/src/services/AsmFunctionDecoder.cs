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
        internal AsmFunctionDecoder(in AsmFormatSpec format)
        {
            Decoder =  AsmWorkflows.Stateless.InstructionDecoder(format);
        }

        static IAsmFunctionBuilder Builder => AsmCore.Services.FunctionBuilder;

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