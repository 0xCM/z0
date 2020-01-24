//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    
    using static zfunc;

    using static AsmServiceMessages;

    class AsmFunctionBuilder : IAsmFunctionBuilder
    {
        public static IAsmFunctionBuilder Create()
            => new AsmFunctionBuilder();

        private AsmFunctionBuilder()
        {
            
        }

        public AsmSpecs.AsmFunction BuildFunction(AsmSpecs.AsmInstructionBlock src)
        {
            var dst = new AsmInstructionInfo[src.InstructionCount];
            var offset = (ushort)0;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src[i];
                
                if(src.NativeCode.Length < offset + instruction.ByteLength)
                    throw error(InstructionSizeMismatch(instruction.IP, offset, src.NativeCode.Length, instruction.ByteLength));                
            
                dst[i] = instruction.SummarizeInstruction(src.NativeCode.Encoded, instruction.FormattedInstruction, offset, src.Origin.Start);
                offset += (ushort)instruction.ByteLength;
            }

            var blocklen = src.Decoded.Select(i => i.ByteLength).Sum();
            if(blocklen != src.NativeCode.Length)
                throw error(InstructionBlockSizeMismatch(src.Origin, src.NativeCode.Length, blocklen));

            return AsmSpecs.AsmFunction.Define(src.Origin, src.NativeCode, src.TermCode, src.Decoded);

        }

        public AsmFunction BuildFunction(InstructionBlock src)
        {
            var format = src.FormatInstructions(AsmFormatConfig.Default.Invert());            
            var dst = new AsmInstructionInfo[src.InstructionCount];
            var offset = (ushort)0;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src[i];
                if(src.NativeCode.Length < offset + instruction.ByteLength)
                    throw error(InstructionSizeMismatch(instruction.IP, offset, src.NativeCode.Length, instruction.ByteLength));                
            
                dst[i] = instruction.SummarizeInstruction(src.NativeCode.Encoded, format[i], offset, src.Origin.Start);
                offset += (ushort)instruction.ByteLength;
            }

            var blocklen = src.Decoded.Select(i => i.ByteLength).Sum();
            if(blocklen != src.NativeCode.Length)
                throw error(InstructionBlockSizeMismatch(src.Origin, src.NativeCode.Length, blocklen));

            return AsmFunction.Define(src.Origin, src.NativeCode, src.TermCode, dst);
        }
    }
}