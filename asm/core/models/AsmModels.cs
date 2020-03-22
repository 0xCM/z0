//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    
    using static Root;    
    using static OpKind;
    using static AsmServiceMessages;

    using W = FixedWidth;
    using NI = NumericIndicator;
    
    public static partial class AsmModels
    {        
        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        public static bool IsNearBranch(this OpKind src)        
            => src == OpKind.NearBranch16
            || src == OpKind.NearBranch32
            || src == OpKind.NearBranch64;

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        public static bool IsFarBranch(this OpKind src)        
            => src == OpKind.FarBranch16
            || src == OpKind.FarBranch32;

        /// <summary>
        /// Determines whether a classified operand is associated with a branching instruction
        /// </summary>
        /// <param name="src">The operand classification</param>
        public static bool IsBranch(this OpKind src)
            => src.IsFarBranch() || src.IsNearBranch();

        /// <summary>
        /// Determines whether the classified operand is an 8-bit immediate
        /// used by the enter, extrq, or insertq instructions
        /// Accessed via the instruction attribute Immediate8_2nd
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsSpecialImmediate8(this OpKind src)
            => src == OpKind.Immediate8_2nd;
        
        /// <summary>
        /// Determines whether the classified operand a sign-extended immediate which may include:
        /// An 8-bit value sign extended to 16 bits, accessed via the Immediate8to16 instruction attribute
        /// An 8-bit value sign extended to 32 bits, accessed via Immediate8to32 instruction attribute
        /// An 8-bit value sign extended to 64 bits, accessed via the Immediate8to64 instruction attribute
        /// A 32-bit value sign extended to 64 bits, accessed via the Immediate32to64 instruction attribute
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsSignExtendedImmediate(this OpKind src)
            => src == OpKind.Immediate8to16  
            || src == OpKind.Immediate8to32  
            || src == OpKind.Immediate8to64  
            || src == OpKind.Immediate32to64 
             ;

        /// <summary>
        /// Determines whether the classified operand is an 8-bit, 16-bit, 32-bit or 64-bit constant
        /// which are accessed respectively through the Immediate8, Immediate16, Immediate32, and Immediate64
        /// instruction attributes
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsDirectImmediate(this OpKind src)
            => src == OpKind.Immediate8
            || src == OpKind.Immediate16
            || src == OpKind.Immediate32
            || src == OpKind.Immediate64
            ;

        /// <summary>
        /// Determines whether the classified operand is an immediate of some sort
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsImmediate(this OpKind src)
            => src.IsSignExtendedImmediate() || src.IsDirectImmediate() || src.IsSpecialImmediate8();

        /// <summary>
        /// Determines whether the classified operand is a segment of the form 
        /// seg:[di], seg:[edi], seg:[esi], seg:[rdi], seg:[rsi], seg:[si]
        /// Relevant instruction attributes include: MemorySize, MemorySegment, SegmentPrefix 
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsBaseSegment(this OpKind src)
            => src == OpKind.MemorySegDI
            || src == OpKind.MemorySegEDI
            || src == OpKind.MemorySegESI
            || src == OpKind.MemorySegRDI
            || src == OpKind.MemorySegRSI
            || src == OpKind.MemorySegSI
            ;

        /// <summary>
        /// Determines whether the classified operand is an ES ("extra") memory segment.
        /// Possible choices include es:[di], es:[edi], es:[rdi]
        /// Relevant instruction attributes inlude: MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsEsSegment(this OpKind src)            
            => src == OpKind.MemoryESDI
            || src == OpKind.MemoryESEDI
            || src == OpKind.MemoryESRDI;

        /// <summary>
        /// Determines whether the classified operand is a 64-bit memory offset. 
        /// Relevant instruction attributes include:
        /// MemoryAddress64, MemorySegment, SegmentPrefix, MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsMem64(this OpKind src)
            =>  src == OpKind.Memory64;

        /// <summary>
        /// Determines whether the classified operand is direct memory.
        /// Relevant instruction attributes include: 
        /// MemoryDisplSize, MemorySize, MemoryIndexScale, MemoryDisplacement, MemoryBase, 
        /// MemoryIndex, MemorySegment, SegmentPrefix
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsDirectMemory(this OpKind src)
            => src == OpKind.Memory;         
        
        /// <summary>
        /// Determines whether the classified operand is some sort of memory
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsMemory(this OpKind src)            
            => src.IsDirectMemory() || src.IsMem64() || src.IsEsSegment() || src.IsBaseSegment();

        /// <summary>
        /// Determines whether the classified operand is a register
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsRegister(this OpKind src)
            => src == OpKind.Register;  

        public static bool IsSpecified(this Register r)
            => r != Asm.Register.None;

        /// <summary>
        /// Determines the size of a classified immediate operand, if applicable; otherwise, returns 0
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static int ImmediateSize(this OpKind src)
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

        public static string Format(this MemorySize src)
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
                var info = AsmMemInfo.Init(src.MemorySize, src.MemorySize.Format());
                info.Size = src.MemorySize;
                info.SizeFormat = src.MemorySize.Format();

                if(kind.IsDirectMemory())
                {
                    info.BaseRegister = src.MemoryBase;
                    info.Displacement = src.MemoryDisplacement;
                    info.DisplacementSize = src.MemoryDisplSize;
                    info.IndexScale = src.MemoryIndexScale;
                }

                if(kind.IsDirectMemory() || kind.IsBaseSegment())
                {
                    if(src.SegmentPrefix.IsSpecified())
                        info.SegmentPrefix = src.SegmentPrefix;
                    
                    info.SegmentRegister = src.MemorySegment;
                }

                if(kind.IsMem64())
                    info.Address = src.MemoryAddress64;                

                return info;
            }

            return none<AsmMemInfo>();
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
                return none<ImmInfo>();

            int size = kind.ImmediateSize();
            if(size == 0)
                return none<ImmInfo>();

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
                    return none<ImmInfo>();
            }
        }

        public static Option<AsmBranchInfo> BranchInfo(this Instruction src, int index, ulong baseaddress)
        {
            var kind = src.GetOpKind(index);
            if(kind.IsBranch())
            {
                switch(kind)
                {
                    case NearBranch16:
                        return AsmBranchInfo.Define(baseaddress, src.NearBranch16, 16, true);
                    case NearBranch32:
                        return AsmBranchInfo.Define(baseaddress, src.NearBranch32, 32, true);
                    case NearBranch64:
                        return AsmBranchInfo.Define(baseaddress, src.NearBranch64, 64, true);
                    case FarBranch16:
                        return AsmBranchInfo.Define(baseaddress, src.FarBranch16, 16,  false);
                    case FarBranch32:
                        return AsmBranchInfo.Define(baseaddress, src.FarBranch32, 32, false);
                }
            }

            return none<AsmBranchInfo>();
        }

        /// <summary>
        /// Extracts register information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        public static Option<AsmRegisterInfo> RegisterInfo(this Instruction src, int index)
            => src.GetOpKind(index).IsRegister() 
            ? new AsmRegisterInfo(src.GetOpRegister(index)) 
            : none<AsmRegisterInfo>();

        public static AsmInstructionInfo SummarizeInstruction(this Instruction src, ReadOnlySpan<byte> encoded, string content, ushort offset, ulong baseaddress)
            => AsmInstructionInfo.Define((ushort)offset, 
                content, 
                src.InstructionCode,
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
                src.GetOpKind(index),
                src.ImmediateInfo(index),
                src.MemoryInfo(index),
                src.RegisterInfo(index),
                src.BranchInfo(index,baseaddress)
                );

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
            
                dst[i] = instruction.SummarizeInstruction(src.Code.Data, instruction.FormattedInstruction, offset, src.Code.AddressRange.Start);
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }
      
        static readonly AsmFormatConfig DefaultConfig = AsmFormatConfig.New;

        public static SegmentedIdentity AsSegmentedIdentity(this MemorySize src, TypeIndicator ti)
            => src switch {
                    MemorySize.Packed128_Int8 => (ti, W.W128, W.W8, NI.Signed),
                    MemorySize.Packed128_UInt8 => (ti, W.W128, W.W8, NI.Unsigned),
                    MemorySize.Packed128_Int16 => (ti, W.W128, W.W16, NI.Signed),
                    MemorySize.Packed128_UInt16 => (ti,W.W128, W.W16, NI.Unsigned),
                    MemorySize.Packed128_Int32 => (ti, W.W128, W.W32, NI.Signed),
                    MemorySize.Packed128_UInt32 => (ti, W.W128, W.W32, NI.Unsigned),
                    MemorySize.Packed128_Int64 => (ti, W.W128, W.W64, NI.Signed),
                    MemorySize.Packed128_UInt64 => (ti, W.W128, W.W64, NI.Unsigned),
                    MemorySize.Packed128_Float32 => (ti, W.W128, W.W32, NI.Float),
                    MemorySize.Packed128_Float64 => (ti, W.W128, W.W64, NI.Float),
                    MemorySize.Packed256_Int8 => (ti, W.W256, W.W8, NI.Signed),
                    MemorySize.Packed256_UInt8 => (ti, W.W256, W.W8, NI.Unsigned),
                    MemorySize.Packed256_Int16 => (ti, W.W256, W.W16, NI.Signed),
                    MemorySize.Packed256_UInt16 => (ti, W.W256, W.W16, NI.Unsigned),
                    MemorySize.Packed256_Int32 => (ti, W.W256, W.W32, NI.Signed),
                    MemorySize.Packed256_UInt32 => (ti, W.W256, W.W32, NI.Unsigned),
                    MemorySize.Packed256_Int64 => (ti, W.W256, W.W64, NI.Signed),
                    MemorySize.Packed256_UInt64 => (ti, W.W256, W.W64, NI.Unsigned),
                    MemorySize.Packed256_Float32 => (ti, W.W256, W.W32, NI.Float),
                    MemorySize.Packed256_Float64 => (ti, W.W256, W.W64, NI.Float),
                    _ => SegmentedIdentity.Empty
            };
    }
}