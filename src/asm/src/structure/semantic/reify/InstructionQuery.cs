//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static ModelErrors;

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
        public AsmOperandInfo[] Operands(Instruction src, MemoryAddress @base = default)
        {
            var args = new AsmOperandInfo[src.OpCount];
            for(byte j=0; j< src.OpCount; j++)
                args[j] = Operand(src, j, @base);
            return args;
        }

        [MethodImpl(Inline)]
        public AsmOperandInfo Operand(Instruction src, int index, MemoryAddress @base = default)
            => AsmOperandInfo.Define(index, 
                OperandKind(src,index),
                ImmInfo(src,index),
                AsmMemory.MemInfo(src,index),
                RegisterInfo(src,index),
                BranchInfo(src,index,@base));
 
        [MethodImpl(Inline)]
        public AsmInstructionSummary Summarize(Instruction src, ReadOnlySpan<byte> encoded, string content, ushort offset, ulong @base)
            => AsmInstructionSummary.Define(
                    (ushort)offset, 
                    content, 
                    src.InstructionCode,
                    Operands(src,@base), 
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

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src[i];                            
                dst[i] =   Summarize(instruction, src.EncodedBytes, instruction.FormattedInstruction, offset, src.EncodedBytes.AddressRange.Start);
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

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src.Instructions[i];
                
                if(src.Code.Length < offset + instruction.ByteLength)
                    throw AppException.Define(InstructionSizeMismatch(instruction.IP, offset, src.Code.Length, instruction.ByteLength));                
            
                dst[i] = Summarize(instruction, src.Code.Encoded, instruction.FormattedInstruction, offset, src.Code.Location.Start);
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }

        [MethodImpl(Inline)]
        public bool IsSegBase(OpKind src)
            => src == OpKind.MemorySegDI
            || src == OpKind.MemorySegEDI
            || src == OpKind.MemorySegESI
            || src == OpKind.MemorySegRDI
            || src == OpKind.MemorySegRSI
            || src == OpKind.MemorySegSI;
    }
}