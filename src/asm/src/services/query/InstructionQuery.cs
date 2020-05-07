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
        [Op]
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

        [MethodImpl(Inline), Op]
        public AsmOperandInfo[] Operands(MemoryAddress @base, Instruction src)
        {
            var args = new AsmOperandInfo[src.OpCount];
            for(byte j=0; j< src.OpCount; j++)
                args[j] = Operand(@base, src, j);
            return args;
        }

        [MethodImpl(Inline), Op]
        public AsmOperandInfo Operand(MemoryAddress @base, Instruction src, int index)
            => AsmOperandInfo.Define(index, 
                OperandKind(src,index),
                ImmInfo(src,index),
                MemInfo(src,index),
                RegisterInfo(src,index),
                BranchInfo(@base, src,index));
 
        [MethodImpl(Inline), Op]
        public AsmInstructionSummary Summarize(MemoryAddress @base, Instruction src, ReadOnlySpan<byte> encoded, string content, ushort offset)
            => AsmInstructionSummary.Define(
                    @base,
                    (ushort)offset, 
                    content, 
                    src.InstructionCode,
                    Operands(@base, src), 
                    encoded.Slice(offset, src.ByteLength).ToArray()
                    );

        [Op]
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


        [Op]
		public OpKind OperandKind<T>(T src, int operand) 
            where T : IAsmInxs
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

        public OpKind[] OperandKinds<T>(T src)
            where T : IAsmInxs
        {
            var count = src.OpCount;
            var dst = new OpKind[src.OpCount];
            for(var i=0; i<count; i++)
                dst[i] = OperandKind(src,i);
            return dst;
        }

        /// <summary>
        /// Describes the instructions that comprise an instruction list
        /// </summary>
        /// <param name="src">The source instruction list</param>
        [Op]
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
        [Op]
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