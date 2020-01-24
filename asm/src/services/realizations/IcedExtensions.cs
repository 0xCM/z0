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
        
    using Iced = Iced.Intel;
    using Iced.Intel;
    using static Iced.Intel.OpKind;
    
    using static zfunc;
    
    static class IcedAsmOpTests
    {        
        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        public static bool IsNearBranch(this Iced.OpKind src)        
            => src == Iced.OpKind.NearBranch16
            || src == Iced.OpKind.NearBranch32
            || src == Iced.OpKind.NearBranch64;

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        public static bool IsFarBranch(this Iced.OpKind src)        
            => src == Iced.OpKind.FarBranch16
            || src == Iced.OpKind.FarBranch32;

        /// <summary>
        /// Determines whether a classified operand is associated with a branching instruction
        /// </summary>
        /// <param name="src">The operand classification</param>
        public static bool IsBranch(this Iced.OpKind src)
            => src.IsFarBranch() || src.IsNearBranch();

        /// <summary>
        /// Determines whether the classified operand is an 8-bit immediate
        /// used by the enter, extrq, or insertq instructions
        /// Accessed via the instruction attribute Immediate8_2nd
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsSpecialImmediate8(this Iced.OpKind src)
            => src == Iced.OpKind.Immediate8_2nd;
        
        /// <summary>
        /// Determines whether the classified operand a sign-extended immediate which may include:
        /// An 8-bit value sign extended to 16 bits, accessed via the Immediate8to16 instruction attribute
        /// An 8-bit value sign extended to 32 bits, accessed via Immediate8to32 instruction attribute
        /// An 8-bit value sign extended to 64 bits, accessed via the Immediate8to64 instruction attribute
        /// A 32-bit value sign extended to 64 bits, accessed via the Immediate32to64 instruction attribute
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsSignExtendedImmediate(this Iced.OpKind src)
            => src == Iced.OpKind.Immediate8to16  
            || src == Iced.OpKind.Immediate8to32  
            || src == Iced.OpKind.Immediate8to64  
            || src == Iced.OpKind.Immediate32to64 
             ;

        /// <summary>
        /// Determines whether the classified operand is an 8-bit, 16-bit, 32-bit or 64-bit constant
        /// which are accessed respectively through the Immediate8, Immediate16, Immediate32, and Immediate64
        /// instruction attributes
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsDirectImmediate(this Iced.OpKind src)
            => src == Iced.OpKind.Immediate8
            || src == Iced.OpKind.Immediate16
            || src == Iced.OpKind.Immediate32
            || src == Iced.OpKind.Immediate64
            ;

        /// <summary>
        /// Determines whether the classified operand is an immediate of some sort
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsImmediate(this Iced.OpKind src)
            => src.IsSignExtendedImmediate() || src.IsDirectImmediate() || src.IsSpecialImmediate8();

        /// <summary>
        /// Determines whether the classified operand is a segment of the form 
        /// seg:[di], seg:[edi], seg:[esi], seg:[rdi], seg:[rsi], seg:[si]
        /// Relevant instruction attributes include: MemorySize, MemorySegment, SegmentPrefix 
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsBaseSegment(this Iced.OpKind src)
            => src == Iced.OpKind.MemorySegDI
            || src == Iced.OpKind.MemorySegEDI
            || src == Iced.OpKind.MemorySegESI
            || src == Iced.OpKind.MemorySegRDI
            || src == Iced.OpKind.MemorySegRSI
            || src == Iced.OpKind.MemorySegSI
            ;

        /// <summary>
        /// Determines whether the classified operand is an ES ("extra") memory segment.
        /// Possible choices include es:[di], es:[edi], es:[rdi]
        /// Relevant instruction attributes inlude: MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsEsSegment(this Iced.OpKind src)            
            => src == Iced.OpKind.MemoryESDI
            || src == Iced.OpKind.MemoryESEDI
            || src == Iced.OpKind.MemoryESRDI;

        /// <summary>
        /// Determines whether the classified operand is a 64-bit memory offset. 
        /// Relevant instruction attributes include:
        /// MemoryAddress64, MemorySegment, SegmentPrefix, MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsMem64(this Iced.OpKind src)
            =>  src == Iced.OpKind.Memory64;

        /// <summary>
        /// Determines whether the classified operand is direct memory.
        /// Relevant instruction attributes include: 
        /// MemoryDisplSize, MemorySize, MemoryIndexScale, MemoryDisplacement, MemoryBase, 
        /// MemoryIndex, MemorySegment, SegmentPrefix
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsDirectMemory(this Iced.OpKind src)
            => src == Iced.OpKind.Memory;         
        
        /// <summary>
        /// Determines whether the classified operand is some sort of memory
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsMemory(this Iced.OpKind src)            
            => src.IsDirectMemory() || src.IsMem64() || src.IsEsSegment() || src.IsBaseSegment();

        /// <summary>
        /// Determines whether the classified operand is a register
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsRegister(this Iced.OpKind src)
            => src == Iced.OpKind.Register;  

        /// <summary>
        /// Determines the size of a classified immediate operand, if applicable; otherwise, returns 0
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static int ImmediateSize(this Iced.OpKind src)
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

        public static bool IsSpecified(this Iced.Register r)
            => r != Iced.Register.None;

        /// <summary>
        /// Extracts register information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        public static Option<AsmRegisterInfo> RegisterInfo(this Instruction src, int index)
            => src.GetOpKind(index).IsRegister() ? new AsmRegisterInfo(src.GetOpRegister(index).ToString()) : default;

        public static AsmInstructionCode InstructionCode(this Instruction src)
        {
            var opcode = src.Code.ToOpCode();
            return AsmInstructionCode.Define(opcode.ToInstructionString(), opcode.ToOpCodeString());
        }

        public static Option<AsmBranchInfo> BranchInfo(this Instruction src, int index, ulong baseaddress)
        {
            var kind = src.GetOpKind(index);
            if(kind.IsBranch())
            {
                switch(kind)
                {
                    case Iced.OpKind.NearBranch16:
                        return AsmBranchInfo.Define(16, src.NearBranch16, true, baseaddress);
                    case Iced.OpKind.NearBranch32:
                        return AsmBranchInfo.Define(32, src.NearBranch32, true, baseaddress);
                    case Iced.OpKind.NearBranch64:
                        return AsmBranchInfo.Define(64, src.NearBranch64, true, baseaddress);
                    case Iced.OpKind.FarBranch16:
                        return AsmBranchInfo.Define(16, src.FarBranch16, false, baseaddress);
                    case Iced.OpKind.FarBranch32:
                        return AsmBranchInfo.Define(32, src.FarBranch32, false, baseaddress);
                }
            }

            return default;
        }

        public static string Format(this Iced.MemorySize src)
            => src switch {
                Iced.MemorySize.Int8 => "8i",
                Iced.MemorySize.Int16 => "16i",
                Iced.MemorySize.Int32 => "32i",
                Iced.MemorySize.Int64 => "64i",
                Iced.MemorySize.UInt8 => "8u",
                Iced.MemorySize.UInt16 => "16u",
                Iced.MemorySize.UInt32 => "32u",
                Iced.MemorySize.UInt64 => "64u",
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
                info.Size = Format(src.MemorySize);

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

        /// <summary>
        /// Extracts immediate information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        public static Option<ImmInfo> ImmediateInfo(this Instruction src, int index)
        {
            var kind = src.GetOpKind(index);
            if(!kind.IsImmediate())
                return default;

            int size = kind.ImmediateSize();
            if(size == 0)
                return default;

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
                default:
                    return default;
            }
        }

        public static AsmInstructionInfo SummarizeInstruction(this Instruction src, ReadOnlySpan<byte> encoded, string content, ushort offset, ulong baseaddress)
            => AsmInstructionInfo.Define((ushort)offset, content, 
                    src.InstructionCode(), 
                    src.SummarizeOperands(baseaddress), 
                    encoded.Slice(offset, src.ByteLength).ToArray());

        /// <summary>
        /// Extracts operand information from an instruction
        /// </summary>
        /// <param name="src">The source instruction</param>
        public static AsmOperandInfo[] SummarizeOperands(this Instruction src, ulong baseaddress)
        {
            var args = new AsmOperandInfo[src.OpCount];
            for(byte j=0; j< src.OpCount; j++)
                args[j] = src.OperandInfo(j,baseaddress);
            return args;
        }


        public static AsmOperandInfo OperandInfo(this Instruction src, int index, ulong baseaddress)
            => AsmOperandInfo.Define(index, 
                src.GetOpKind(index).ToSpec(),
                src.ImmediateInfo(index).ValueOrDefault(), 
                src.MemoryInfo(index).ValueOrDefault(), 
                src.RegisterInfo(index).ValueOrDefault(), 
                src.BranchInfo(index,baseaddress).ValueOrDefault()
                );

    }
}