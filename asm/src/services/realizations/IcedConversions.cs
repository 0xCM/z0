//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;                

    using AsmSpecs;

    using Iced = Iced.Intel;


    public static class AsmSpecConversion
    {
        public static AsmInstructionCode InstructionCode(this Iced.Instruction src)
        {
            var opcode = Iced.EncoderCodeExtensions.ToOpCode(src.Code);
            return AsmInstructionCode.Define(opcode.ToInstructionString(), opcode.ToOpCodeString());
        }

        static AsmInstructionInfo InstructionSummary(this Iced.Instruction src, ReadOnlySpan<byte> encoded, string content, ushort offset, ulong baseaddress)
            => AsmInstructionInfo.Define((ushort)offset, content, 
                    src.InstructionCode(), 
                    src.SummarizeOperands(baseaddress), 
                    encoded.Slice(offset, src.ByteLength).ToArray());

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        internal static OpCodeInfo ToSpec(this Iced.OpCodeInfo src)
            => new OpCodeInfo
            {
                CanSuppressAllExceptions = src.CanSuppressAllExceptions,
                RequireNonZeroOpMaskRegister = src.RequireNonZeroOpMaskRegister,
                CanUseZeroingMasking = src.CanUseZeroingMasking,
                CanUseLockPrefix = src.CanUseLockPrefix,
                CanUseXacquirePrefix = src.CanUseXacquirePrefix,
                CanUseXreleasePrefix = src.CanUseXreleasePrefix,
                CanUseRepPrefix = src.CanUseRepPrefix,
                CanUseRepnePrefix = src.CanUseRepnePrefix,
                CanUseBndPrefix = src.CanUseBndPrefix,
                CanUseHintTakenPrefix = src.CanUseHintTakenPrefix,
                CanUseNotrackPrefix = src.CanUseNotrackPrefix,
                Table = src.Table.ToSpec(),
                MandatoryPrefix = src.MandatoryPrefix.ToSpec(),
                OpCode = src.OpCode,
                IsGroup = src.IsGroup,
                GroupIndex = src.GroupIndex,
                OpCount = src.OpCount,
                Op0Kind = src.Op0Kind.ToSpec(),
                Op1Kind = src.Op1Kind.ToSpec(),
                Op2Kind = src.Op2Kind.ToSpec(),
                CanUseOpMaskRegister = src.CanUseOpMaskRegister,
                Op3Kind = src.Op3Kind.ToSpec(),
                Op4Kind = src.Op4Kind.ToSpec(),
                CanBroadcast = src.CanBroadcast,
                Code = src.Code.ToSpec(),
                Encoding = src.Encoding.ToSpec(),
                IsInstruction = src.IsInstruction,
                Mode16 = src.Mode16,
                Mode32 = src.Mode32,
                CanUseRoundingControl = src.CanUseRoundingControl,
                Fwait = src.Fwait,
                Mode64 = src.Mode64,
                AddressSize = src.AddressSize,
                L = src.L,
                W = src.W,
                IsLIG = src.IsLIG,
                IsWIG = src.IsWIG,
                IsWIG32 = src.IsWIG32,
                TupleType = src.TupleType.ToSpec(),
                OperandSize = src.OperandSize
            };

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        internal static Instruction ToSpec(this Iced.Instruction src, string formatted)
            => new Instruction
            {
                FormattedInstruction = formatted,
                InstructionCode = src.InstructionCode(),
                ConditionCode = src.ConditionCode.ToSpec(),
                IsBroadcast = src.IsBroadcast,
                MemorySize = src.MemorySize.ToSpec(),
                MemoryIndexScale = src.MemoryIndexScale,
                MemoryDisplacement = src.MemoryDisplacement,
                Immediate8 = src.Immediate8,
                Immediate8_2nd = src.Immediate8_2nd,
                Immediate16 = src.Immediate16,
                Immediate32 = src.Immediate32,
                Immediate64 = src.Immediate64,
                Immediate8to16 = src.Immediate8to16,
                Immediate8to32 = src.Immediate8to32,
                Immediate8to64 = src.Immediate8to64,
                Immediate32to64 = src.Immediate32to64,
                MemoryAddress64 = src.MemoryAddress64,
                NearBranch16 = src.NearBranch16,
                NearBranch32 = src.NearBranch32,
                NearBranch64 = src.NearBranch64,
                NearBranchTarget = src.NearBranchTarget,
                FarBranch16 = src.FarBranch16,
                FarBranch32 = src.FarBranch32,
                FarBranchSelector = src.FarBranchSelector,
                MemoryDisplSize = src.MemoryDisplSize,
                MemorySegment = src.MemorySegment.ToSpec(),
                SegmentPrefix = src.SegmentPrefix.ToSpec(),
                Op4Kind = src.Op4Kind.ToSpec(),
                IP32 = src.IP32,
                IP = src.IP,
                NextIP16 = src.NextIP16,
                NextIP32 = src.NextIP32,
                NextIP = src.NextIP,
                CodeSize = src.CodeSize.ToSpec(),
                Code = src.Code.ToSpec(),
                Mnemonic = src.Mnemonic.ToSpec(),
                MemoryBase = src.MemoryBase.ToSpec(),
                OpCount = src.OpCount,
                HasXacquirePrefix = src.HasXacquirePrefix,
                HasXreleasePrefix = src.HasXreleasePrefix,
                HasRepPrefix = src.HasRepPrefix,
                HasRepePrefix = src.HasRepePrefix,
                HasRepnePrefix = src.HasRepnePrefix,
                HasLockPrefix = src.HasLockPrefix,
                Op0Kind = src.Op0Kind.ToSpec(),
                Op1Kind = src.Op1Kind.ToSpec(),
                Op2Kind = src.Op2Kind.ToSpec(),
                Op3Kind = src.Op3Kind.ToSpec(),
                ByteLength = src.ByteLength,
                MemoryIndex = src.MemoryIndex.ToSpec(),
                Op0Register = src.Op0Register.ToSpec(),
                Op1Register = src.Op1Register.ToSpec(),
                IsStackInstruction = src.IsStackInstruction,
                IsSaveRestoreInstruction = src.IsSaveRestoreInstruction,
                RflagsRead = src.RflagsRead.ToSpec(),
                RflagsWritten = src.RflagsWritten.ToSpec(),
                RflagsCleared = src.RflagsCleared.ToSpec(),
                RflagsSet = src.RflagsSet.ToSpec(),
                RflagsUndefined = src.RflagsUndefined.ToSpec(),
                RflagsModified = src.RflagsModified.ToSpec(),
                IsPrivileged = src.IsPrivileged,
                IsJccShortOrNear = src.IsJccShortOrNear,
                IsJccShort = src.IsJccShort,
                IsJmpShort = src.IsJmpShort,
                IsJmpNear = src.IsJmpNear,
                IsJmpShortOrNear = src.IsJmpShortOrNear,
                IsJmpFar = src.IsJmpFar,
                IsCallNear = src.IsCallNear,
                IsCallFar = src.IsCallFar,
                IsJmpNearIndirect = src.IsJmpNearIndirect,
                IsJmpFarIndirect = src.IsJmpFarIndirect,
                IsCallNearIndirect = src.IsCallNearIndirect,
                IsJccNear = src.IsJccNear,
                IP16 = src.IP16,
                Op2Register = src.Op2Register.ToSpec(),
                Op3Register = src.Op3Register.ToSpec(),
                Op4Register = src.Op4Register.ToSpec(),
                OpMask = src.OpMask.ToSpec(),
                HasOpMask = src.HasOpMask,
                ZeroingMasking = src.ZeroingMasking,
                MergingMasking = src.MergingMasking,
                RoundingControl = src.RoundingControl.ToSpec(),
                DeclareDataCount = src.DeclareDataCount,
                IsVsib = src.IsVsib,
                IsProtectedMode = src.IsProtectedMode,
                IsVsib32 = src.IsVsib32,
                SuppressAllExceptions = src.SuppressAllExceptions,
                IsIPRelativeMemoryOperand = src.IsIPRelativeMemoryOperand,
                IPRelativeMemoryAddress = src.IPRelativeMemoryAddress,
                OpCode = src.OpCode.ToSpec(),
                StackPointerIncrement = src.StackPointerIncrement,
                Encoding = src.Encoding.ToSpec(),
                CpuidFeatures = src.CpuidFeatures.Map(x => x.ToSpec()),
                FlowControl = src.FlowControl.ToSpec(),
                IsVsib64 = src.IsVsib64,
                IsCallFarIndirect = src.IsCallFarIndirect,    
           };             
 
        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        static bool IsNearBranch(this Iced.OpKind src)        
            => src == Iced.OpKind.NearBranch16
            || src == Iced.OpKind.NearBranch32
            || src == Iced.OpKind.NearBranch64;

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        static bool IsFarBranch(this Iced.OpKind src)        
            => src == Iced.OpKind.FarBranch16
            || src == Iced.OpKind.FarBranch32;

        /// <summary>
        /// Determines whether a classified operand is associated with a branching instruction
        /// </summary>
        /// <param name="src">The operand classification</param>
        static bool IsBranch(this Iced.OpKind src)
            => src.IsFarBranch() || src.IsNearBranch();

        /// <summary>
        /// Determines whether the classified operand is an 8-bit immediate
        /// used by the enter, extrq, or insertq instructions
        /// Accessed via the instruction attribute Immediate8_2nd
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsSpecialImmediate8(this Iced.OpKind src)
            => src == Iced.OpKind.Immediate8_2nd;
        
        /// <summary>
        /// Determines whether the classified operand a sign-extended immediate which may include:
        /// An 8-bit value sign extended to 16 bits, accessed via the Immediate8to16 instruction attribute
        /// An 8-bit value sign extended to 32 bits, accessed via Immediate8to32 instruction attribute
        /// An 8-bit value sign extended to 64 bits, accessed via the Immediate8to64 instruction attribute
        /// A 32-bit value sign extended to 64 bits, accessed via the Immediate32to64 instruction attribute
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsSignExtendedImmediate(this Iced.OpKind src)
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
        static bool IsDirectImmediate(this Iced.OpKind src)
            => src == Iced.OpKind.Immediate8
            || src == Iced.OpKind.Immediate16
            || src == Iced.OpKind.Immediate32
            || src == Iced.OpKind.Immediate64
            ;

        /// <summary>
        /// Determines whether the classified operand is an immediate of some sort
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsImmediate(this Iced.OpKind src)
            => src.IsSignExtendedImmediate() || src.IsDirectImmediate() || src.IsSpecialImmediate8();

        /// <summary>
        /// Determines whether the classified operand is a segment of the form 
        /// seg:[di], seg:[edi], seg:[esi], seg:[rdi], seg:[rsi], seg:[si]
        /// Relevant instruction attributes include: MemorySize, MemorySegment, SegmentPrefix 
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsBaseSegment(this Iced.OpKind src)
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
        static bool IsEsSegment(this Iced.OpKind src)            
            => src == Iced.OpKind.MemoryESDI
            || src == Iced.OpKind.MemoryESEDI
            || src == Iced.OpKind.MemoryESRDI;

        /// <summary>
        /// Determines whether the classified operand is a 64-bit memory offset. 
        /// Relevant instruction attributes include:
        /// MemoryAddress64, MemorySegment, SegmentPrefix, MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsMem64(this Iced.OpKind src)
            =>  src == Iced.OpKind.Memory64;

        /// <summary>
        /// Determines whether the classified operand is direct memory.
        /// Relevant instruction attributes include: 
        /// MemoryDisplSize, MemorySize, MemoryIndexScale, MemoryDisplacement, MemoryBase, 
        /// MemoryIndex, MemorySegment, SegmentPrefix
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsDirectMemory(this Iced.OpKind src)
            => src == Iced.OpKind.Memory;         
        
        /// <summary>
        /// Determines whether the classified operand is some sort of memory
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static bool IsMemory(this Iced.OpKind src)            
            => src.IsDirectMemory() || src.IsMem64() || src.IsEsSegment() || src.IsBaseSegment();

        /// <summary>
        /// Determines whether the classified operand is a register
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsRegister(this Iced.OpKind src)
            => src == Iced.OpKind.Register;  

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static Code ToSpec(this Iced.Code src)
            => (Code)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static CodeSize ToSpec(this Iced.CodeSize src)
            => (CodeSize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static ConditionCode ToSpec(this Iced.ConditionCode src)
            => (ConditionCode)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static CpuidFeature ToSpec(this Iced.CpuidFeature src)
            => (CpuidFeature)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static EncodingKind ToSpec(this Iced.EncodingKind src)
            => (EncodingKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static FlowControl ToSpec(this Iced.FlowControl src)
            => (FlowControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static FormatterOutputTextKind ToSpec(this Iced.FormatterOutputTextKind src)
            => (FormatterOutputTextKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static MandatoryPrefix ToSpec(this Iced.MandatoryPrefix src)
            => (MandatoryPrefix)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static MemoryOperand ToSpec(this Iced.MemoryOperand src)
            => new MemoryOperand(src.Base.ToSpec(), src.Index.ToSpec(), src.Scale, src.Displacement, src.DisplSize, src.IsBroadcast, src.SegmentPrefix.ToSpec());

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static MemorySize ToSpec(this Iced.MemorySize src)
            => (MemorySize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static Mnemonic ToSpec(this Iced.Mnemonic src)
            => (Mnemonic)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static OpCodeOperandKind ToSpec(this Iced.OpCodeOperandKind src)
            => (OpCodeOperandKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static OpCodeTableKind ToSpec(this Iced.OpCodeTableKind src)
            => (OpCodeTableKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static OpKind ToSpec(this Iced.OpKind src)
            => (OpKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static Register ToSpec(this Iced.Register src)
            => (Register)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static RflagsBits ToSpec(this Iced.RflagsBits src)
            => (RflagsBits)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static RoundingControl ToSpec(this Iced.RoundingControl src)
            => (RoundingControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static TupleType ToSpec(this Iced.TupleType src)
            => (TupleType)src;

        /// <summary>
        /// Extracts operand information from an instruction
        /// </summary>
        /// <param name="src">The source instruction</param>
        static AsmSpecs.AsmOperandInfo[] SummarizeOperands(this Iced.Instruction src, ulong baseaddress)
        {
            var args = new AsmSpecs.AsmOperandInfo[src.OpCount];
            for(byte j=0; j< src.OpCount; j++)
                args[j] = src.OperandInfo(j,baseaddress);
            return args;
        }

        /// <summary>
        /// Extracts immediate information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        static Option<ImmInfo> ImmediateInfo(this Iced.Instruction src, int index)
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

        static string Format(this Iced.MemorySize src)
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
        static Option<AsmMemInfo> MemoryInfo(this Iced.Instruction src, int index)
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
        /// Determines the size of a classified immediate operand, if applicable; otherwise, returns 0
        /// </summary>
        /// <param name="src">The operand classifier</param>
        static int ImmediateSize(this Iced.OpKind src)
        {
            if(src == Iced.OpKind.Immediate8 || src == Iced.OpKind.Immediate8_2nd)
                return 8;
            else if(src == Iced.OpKind.Immediate16 || src == Iced.OpKind.Immediate8to16)
                return 16;
            else if(src == Iced.OpKind.Immediate32 || src == Iced.OpKind.Immediate8to32)
                return 32;
            else if(src == Iced.OpKind.Immediate64 || src == Iced.OpKind.Immediate8to64 || src == Iced.OpKind.Immediate32to64)
                return 64;
            else
                return 0;
        }

        static bool IsSpecified(this Iced.Register r)
            => r != Iced.Register.None;

        /// <summary>
        /// Extracts register information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        static Option<AsmRegisterInfo> RegisterInfo(this Iced.Instruction src, int index)
            => src.GetOpKind(index).IsRegister() ? new AsmRegisterInfo(src.GetOpRegister(index).ToString()) : default;

        static AsmSpecs.AsmOperandInfo OperandInfo(this Iced.Instruction src, int index, ulong baseaddress)
            => AsmSpecs.AsmOperandInfo.Define(index, 
                src.GetOpKind(index).ToSpec(),
                src.ImmediateInfo(index).ValueOrDefault(), 
                src.MemoryInfo(index).ValueOrDefault(), 
                src.RegisterInfo(index).ValueOrDefault(), 
                src.BranchInfo(index,baseaddress).ValueOrDefault()
                );

        static Option<AsmBranchInfo> BranchInfo(this Iced.Instruction src, int index, ulong baseaddress)
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
   }
}