//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmServiceMessages;

    public readonly struct AsmFunctionBuilder : IAsmFunctionBuilder
    {
        [MethodImpl(Inline)]
        public static AsmFunctionBuilder Create(IAsmContext context)
            => new AsmFunctionBuilder(context);

        public IAsmContext Context {get;}
        
        [MethodImpl(Inline)]
        AsmFunctionBuilder(IAsmContext context)
        {
            this.Context = context;
        }

        public AsmFunction BuildFunction(MemberDescriptor op, AsmInstructionBlock src)
        {
            var info = new AsmInstructionInfo[src.InstructionCount];
            var offset = (ushort)0;

            for(var i=0; i<info.Length; i++)
            {
                var instruction = src[i];
                
                if(src.NativeCode.Length < offset + instruction.ByteLength)
                    throw AppException.Define(InstructionSizeMismatch(instruction.IP, offset, src.NativeCode.Length, instruction.ByteLength));                
            
                info[i] = instruction.SummarizeInstruction(src.NativeCode.Data, instruction.FormattedInstruction, offset, src.Origin.Start);
                offset += (ushort)instruction.ByteLength;
            }

            var blocklen = src.Decoded.Select(i => i.ByteLength).Sum();
            if(blocklen != src.NativeCode.Length)
                throw AppException.Define(InstructionBlockSizeMismatch(src.Origin, src.NativeCode.Length, blocklen));
        
            var parsed = ParsedOpExtract.Define(op, src.TermCode, src.NativeCode.Data);
            var instructions = AsmInstructionList.Create(src.Decoded, src.NativeCode.Data);
            //return AsmFunction.Define(parsed, src.Decoded);
            return AsmFunction.Define(parsed, instructions);
        }
    }


    static class ModelBuild
    {

    }
}