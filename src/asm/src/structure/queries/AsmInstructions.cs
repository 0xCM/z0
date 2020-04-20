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

    public class AsmInstruction
    {
        /// <summary>
        /// Extracts operand information from an instruction
        /// </summary>
        /// <param name="src">The source instruction</param>
        public static AsmOperandInfo[] operands(Instruction src, ulong baseaddress)
        {
            var args = new AsmOperandInfo[src.OpCount];
            for(byte j=0; j< src.OpCount; j++)
                args[j] = operand(src, j, baseaddress);
            return args;
        }

        public static AsmOperandInfo operand(Instruction src, int index, ulong baseaddress)
            => AsmOperandInfo.Define(index, 
                kind(src,index),
                AsmImm.describe(src,index),
                AsmMemory.describe(src,index),
                AsmRegister.describe(src,index),
                AsmBranch.describe(src,index,baseaddress)
                );
 
 		/// <summary>
		/// Gets an operand's kind if it exists (see <see cref="OpCount"/>)
		/// </summary>
		/// <param name="operand">Operand number, 0-4</param>
		public static OpKind kind(Instruction src, int operand) {
			switch (operand) {
			case 0: return src.Op0Kind;
			case 1: return src.Op1Kind;
			case 2: return src.Op2Kind;
			case 3: return src.Op3Kind;
			case 4: return src.Op4Kind;
			default:
				throw new ArgumentException($"The operand index {operand} is out of range");
			}
		}

       public static AsmInstructionInfo describe(Instruction src, ReadOnlySpan<byte> encoded, string content, ushort offset, ulong baseaddress)
            => AsmInstructionInfo.Define((ushort)offset, 
                content, 
                src.InstructionCode,
                operands(src,baseaddress),
                encoded.Slice(offset, src.ByteLength).ToArray());

        /// <summary>
        /// Describes the instructions that comprise an instruction list
        /// </summary>
        /// <param name="src">The source instruction list</param>
        public static AsmInstructionInfo[] describe(AsmInstructionList src)
        {
            var dst = new AsmInstructionInfo[src.Length];
            var offset = (ushort)0;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src[i];                            
                dst[i] =   describe(instruction, src.EncodedBytes, instruction.FormattedInstruction, offset, src.EncodedBytes.AddressRange.Start);
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }

        /// <summary>
        /// Describes the instructions that comprise a function
        /// </summary>
        /// <param name="src">The source function</param>
        public static AsmInstructionInfo[] describe(AsmFunction src)
        {
            var dst = new AsmInstructionInfo[src.InstructionCount];
            var offset = (ushort)0;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src.Instructions[i];
                
                if(src.Code.Length < offset + instruction.ByteLength)
                    throw AppException.Define(InstructionSizeMismatch(instruction.IP, offset, src.Code.Length, instruction.ByteLength));                
            
                dst[i] = describe(instruction, src.Code.Encoded, instruction.FormattedInstruction, offset, src.Code.Location.Start);
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }
    }
}