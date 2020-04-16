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

    using static ModelErrors;
 
	partial class ModelQueries
    {
       public static AsmInstructionInfo SummarizeInstruction(this Instruction src, ReadOnlySpan<byte> encoded, string content, ushort offset, ulong baseaddress)
            => AsmInstructionInfo.Define((ushort)offset, 
                content, 
                src.InstructionCode,
                src.SummarizeOperands(baseaddress),
                encoded.Slice(offset, src.ByteLength).ToArray());


        /// <summary>
        /// Describes the instructions that comprise an instruction list
        /// </summary>
        /// <param name="src">The source instruction list</param>
        public static AsmInstructionInfo[] DescribeInstructions(this AsmInstructionList src)
        {
            var dst = new AsmInstructionInfo[src.Length];
            var offset = (ushort)0;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src[i];                            
                dst[i] = instruction.SummarizeInstruction(src.EncodedBytes, instruction.FormattedInstruction, offset, src.EncodedBytes.AddressRange.Start);
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }

        /// <summary>
        /// Describes the instructions that comprise a function
        /// </summary>
        /// <param name="src">The source function</param>
        public static AsmInstructionInfo[] DescribeInstructions(this AsmFunction src)
        {
            var dst = new AsmInstructionInfo[src.InstructionCount];
            var offset = (ushort)0;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src.Instructions[i];
                
                if(src.Code.Length < offset + instruction.ByteLength)
                    throw AppException.Define(InstructionSizeMismatch(instruction.IP, offset, src.Code.Length, instruction.ByteLength));                
            
                dst[i] = instruction.SummarizeInstruction(src.Code.Data, instruction.FormattedInstruction, offset, src.Code.Location.Start);
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }
    }
}