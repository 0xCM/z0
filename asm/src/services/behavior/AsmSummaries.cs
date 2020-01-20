//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

	using Iced.Intel;
    
    using AsmOpKind = Iced.Intel.OpKind;
    
    using static Iced.Intel.OpKind;
    using static zfunc;
    
    static class AsmSummaries
    {   
        /// <summary>
        /// Extracts operand information from an instruction
        /// </summary>
        /// <param name="src">The source instruction</param>
        public static AsmOperandInfo[] SummarizeOperands(this Instruction src)
        {
            var args = new AsmOperandInfo[src.OpCount];
            for(byte j=0; j< src.OpCount; j++)
                args[j] = src.OperandInfo(j);
            return args;
        }

        public static AsmOperandInfo OperandInfo(this Instruction src, int index)
            => AsmOperandInfo.Define(index, 
                src.GetOpKind(index).ToString(),
                src.ImmediateInfo(index).ValueOrDefault(), 
                src.MemoryInfo(index).ValueOrDefault(), 
                src.RegisterInfo(index).ValueOrDefault(), 
                src.BranchInfo(index).ValueOrDefault()
                );

        public static AsmInstructionInfo SummarizeInstruction(this Instruction src, AsmCode code, string asm, ushort offset)
        {            
            Span<byte> data = code.Encoded;
            if(data.Length < offset + src.ByteLength)
                throw new ArgumentException($"ip = {src.IP.FormatHex()}, datalen = {data.Length}, offset = {offset}, bytelen = {src.ByteLength}");

            var encoded = data.Slice(offset, src.ByteLength).ToArray();        
            var operands = src.SummarizeOperands();
            var mnemonic = src.Mnemonic.ToString().ToUpper();
            var opcode = src.Code.ToOpCode();
            return AsmInstructionInfo.Define((ushort)offset, asm, opcode.ToInstructionString(), opcode.ToOpCodeString(), operands, encoded);
        }

        /// <summary>
        /// Extracts register information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        public static Option<AsmRegisterInfo> RegisterInfo(this Instruction src, int index)
            => src.GetOpKind(index).IsRegister() ? new AsmRegisterInfo(src.GetOpRegister(index).ToString()) : default;

        public static Option<AsmBranchInfo> BranchInfo(this Instruction src, int index)
        {
            var kind = src.GetOpKind(index);
            if(kind.IsBranch())
            {
                switch(kind)
                {
                    case AsmOpKind.NearBranch16:
                        return AsmBranchInfo.Define(16, src.NearBranch16, true);
                    case AsmOpKind.NearBranch32:
                        return AsmBranchInfo.Define(32, src.NearBranch32, true);
                    case AsmOpKind.NearBranch64:
                        return AsmBranchInfo.Define(64, src.NearBranch64, true);
                    case AsmOpKind.FarBranch16:
                        return AsmBranchInfo.Define(16, src.FarBranch16, false);
                    case AsmOpKind.FarBranch32:
                        return AsmBranchInfo.Define(32, src.FarBranch32, false);
                }
            }

            return default;
        }

        /// <summary>
        /// Extracts immediate information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        public static Option<ImmInfo> ImmediateInfo(this Instruction src, int index)
        {
            var kind = src.GetOpKind(index);
            int size = kind.ImmediateSize();
            if(kind.IsImmediate() && size != 0)
            {
                var signed = kind.IsSignExtendedImmediate();
                var imm = src.GetImmediate(index);
                switch(size)
                {
                    case Pow2.T03:
                        return ImmInfo.Define(size, imm);
                    case Pow2.T04:
                        if(signed)
                            return ImmInfo.Define(size, (long)imm);
                        else 
                            return ImmInfo.Define(size, imm);
                    case Pow2.T05:
                        if(signed)
                            return ImmInfo.Define(size, (long)imm);
                        else 
                            return ImmInfo.Define(size, imm);
                    case Pow2.T06:
                        if(signed)
                            return ImmInfo.Define(size, (long)imm);
                        else 
                            return ImmInfo.Define(size, imm);
                }
            }

            return default;
        }

        /// <summary>
        /// Determines the size of a classified immediate operand, if applicable; otherwise, returns 0
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static int ImmediateSize(this AsmOpKind src)
        {
            if(src == Immediate8 || src == Immediate8_2nd)
                return 8;
            else if(src == Immediate16 || src == Immediate8to16)
                return 16;
            else if(src == Immediate32 || src == Immediate8to32)
                return 32;
            else if(src == Immediate64 || src == Immediate8to64 || src == Immediate32to64)
                return 64;
            else
                return 0;
        }
        
        static bool IsSpecified(this Register r)
            => r != Iced.Intel.Register.None;

        static string Format(this MemorySize src)
            => src switch {
                MemorySize.Int8 => "8i",
                MemorySize.Int16 => "16i",
                MemorySize.Int32 => "32i",
                MemorySize.Int64 => "64i",
                MemorySize.UInt8 => "8u",
                MemorySize.UInt16 => "16u",
                MemorySize.UInt32 => "32u",
                MemorySize.UInt64 => "64u",
                _   => src.ToString()
            };

        /// <summary>
        /// Extracts memory information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        public static Option<AsmMemInfo> MemoryInfo(this Instruction src, int index)
        {            
            var kind = src.GetOpKind(index);
            
            if(kind.IsMemory())
            {
                var info = new AsmMemInfo();
                info.Size = src.MemorySize.Format();

                if(kind.IsDirectMemory())
                {
                    info.BaseRegister = src.MemoryBase.ToString();
                    info.Displacement = src.MemoryDisplacement;
                    info.DisplacementSize = src.MemoryDisplSize;
                    info.IndexScale = src.MemoryIndexScale;
                }

                if(kind.IsDirectMemory() || kind.IsBaseSegment())
                {
                    if(src.SegmentPrefix.IsSpecified())
                        info.SegmentPrefix = src.SegmentPrefix.ToString();
                    
                    info.SegmentRegister = src.MemorySegment.ToString();
                }

                if(kind.IsMem64())
                    info.Address = src.MemoryAddress64;                

                return info;
            }

            return default;
        }
    }
}
