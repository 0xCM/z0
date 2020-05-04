//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AsmErrors;

    partial struct AsmQuery
    {
        public InstructionInfo Details(Instruction src)
        {
            return new InstructionInfo
            {
                Encoding = src.Encoding,
                FlowControl = src.FlowControl,
                IsProtectedMode = src.IsProtectedMode,
                IsPrivileged = src.IsPrivileged,
                IsSaveRestoreInstruction = src.IsSaveRestoreInstruction,
                IsStackInstruction = src.IsStackInstruction,
                RflagsCleared = src.RflagsCleared,
                RflagsRead = src.RflagsRead,
                RflagsWritten = src.RflagsWritten,
                RflagsModified = src.RflagsModified,
                RflagsSet = src.RflagsSet,
                RflagsUndefined = src.RflagsUndefined,
                UsedMemory =  src.UsedMemory(),
                UsedRegisters = src.UsedRegisters(),
                CpuidFeatures = src.CpuidFeatures,
                Access = src.Access(),
            };
        }

        [MethodImpl(Inline)]
        public AsmOperandInfo[] Operands(MemoryAddress @base, Instruction src)
        {
            var args = new AsmOperandInfo[src.OpCount];
            for(byte j=0; j< src.OpCount; j++)
                args[j] = Operand(@base, src, j);
            return args;
        }

        [MethodImpl(Inline)]
        public AsmOperandInfo Operand(MemoryAddress @base, Instruction src, int index)
            => AsmOperandInfo.Define(index, 
                OperandKind(src,index),
                DescribeImm(src,index),
                MemInfo(src,index),
                OperandRegister(src,index),
                BranchInfo(@base, src,index));
 
        [MethodImpl(Inline)]
        public AsmInstructionSummary Summarize(MemoryAddress @base, Instruction src, ReadOnlySpan<byte> encoded, string content, ushort offset)
            => AsmInstructionSummary.Define(
                    @base,
                    (ushort)offset, 
                    content, 
                    src.InstructionCode,
                    Operands(@base, src), 
                    encoded.Slice(offset, src.ByteLength).ToArray()
                    );

		public OpKind OperandKind(Instruction src, int operand) 
        {
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

        /// <summary>
        /// Describes the instructions that comprise an instruction list
        /// </summary>
        /// <param name="src">The source instruction list</param>
        public AsmInstructionSummary[] Summarize(AsmInstructionList src)
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
        public AsmInstructionSummary[] Summarize(AsmFunction src)
        {
            var dst = new AsmInstructionSummary[src.InstructionCount];
            var offset = (ushort)0;
            var @base = src.BaseAddress;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src.Inxs[i];
                
                if(src.Code.Length < offset + instruction.ByteLength)
                    throw AppException.Define(InstructionSizeMismatch(instruction.IP, offset, src.Code.Length, instruction.ByteLength));                
            
                dst[i] = Summarize(@base, instruction, src.Code.Encoded, instruction.FormattedInstruction, offset);
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }
    }
}