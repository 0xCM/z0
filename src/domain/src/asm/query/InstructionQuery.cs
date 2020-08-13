//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AsmErrors;

    partial struct AsmQuery
    {
        [Op]
		public static OpKind kind(Instruction src, int operand) 
        {
			switch (operand) {
			case 0: return src.Op0Kind;
			case 1: return src.Op1Kind;
			case 2: return src.Op2Kind;
			case 3: return src.Op3Kind;
			case 4: return src.Op4Kind;
			default:
				return 0;
			}
		}    

        [MethodImpl(Inline), Op]
        public AsmOperandInfo operand(MemoryAddress @base, Instruction src, int index)
            => new AsmOperandInfo(index, asm.kind(src,index), ImmInfo(src,index),
                MemInfo(src,index), RegisterInfo(src,index), asm.branch(@base, src,index));

        [MethodImpl(Inline), Op]
        public AsmOperandInfo[] operands(MemoryAddress @base, Instruction src)
        {
            var args = new AsmOperandInfo[src.OpCount];
            for(byte j=0; j< src.OpCount; j++)
                args[j] = operand(@base, src, j);
            return args;
        }

        [MethodImpl(Inline), Op]
        public AsmInstructionSummary summarize(MemoryAddress @base, Instruction src, ReadOnlySpan<byte> encoded, string content, ushort offset)
            => new AsmInstructionSummary(@base, (ushort)offset,  content,  src.InstructionCode,
                    operands(@base, src),  encoded.Slice(offset, src.ByteLength).ToArray());

        /// <summary>
        /// Describes the instructions that comprise an instruction list
        /// </summary>
        /// <param name="src">The source instruction list</param>
        [Op]
        public AsmInstructionSummary[] summarize(AsmInstructionList src)
        {
            var dst = new AsmInstructionSummary[src.Length];
            var offset = (ushort)0;
            var @base = src.Encoded.Address;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src[i];                            
                dst[i] =   Summarize(@base, instruction, src.Encoded, instruction.FormattedInstruction, offset );
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }

        /// <summary>
        /// Describes the instructions that comprise a function
        /// </summary>
        /// <param name="src">The source function</param>
        [Op]
        public AsmInstructionSummary[] summarize(in AsmFunction src)
        {
            var dst = new AsmInstructionSummary[src.InstructionCount];
            var offset = (ushort)0;
            var @base = src.BaseAddress;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src.Instructions[i];
                
                if(src.Code.Length < offset + instruction.ByteLength)
                    throw AppException.Define(InstructionSizeMismatch(instruction.IP, offset, src.Code.Length, instruction.ByteLength));                
            
                dst[i] = Summarize(@base, instruction, src.Code.Encoded, instruction.FormattedInstruction, offset);
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }

        public InstructionInfo Details(Instruction src)
            => asm.details(src);

        public AsmOperandInfo[] Operands(MemoryAddress @base, Instruction src)
            => operands(@base,src);

        public AsmOperandInfo Operand(MemoryAddress @base, Instruction src, int index)
            => operand(@base,src,index);
 
        public AsmInstructionSummary Summarize(MemoryAddress @base, Instruction src, ReadOnlySpan<byte> encoded, string content, ushort offset)
            => summarize(@base,src,encoded,content,offset);

		public OpKind OperandKind(Instruction src, int operand) 
            => asm.kind(src,operand);

        /// <summary>
        /// Describes the instructions that comprise an instruction list
        /// </summary>
        /// <param name="src">The source instruction list</param>
        public AsmInstructionSummary[] Summarize(AsmInstructionList src)
            => summarize(src);

        /// <summary>
        /// Describes the instructions that comprise a function
        /// </summary>
        /// <param name="src">The source function</param>
        public AsmInstructionSummary[] Summarize(AsmFunction src)
            => summarize(src);
    }
}