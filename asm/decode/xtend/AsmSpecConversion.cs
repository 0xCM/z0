//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Core;

    using Iced = Iced.Intel;

    static class AsmSpecConversion
    {
        public static AsmInstructionCode ToInstructionCode(this Iced.Instruction src)
        {
            var opcode = Iced.EncoderCodeExtensions.ToOpCode(src.Code);
            return AsmInstructionCode.Define(opcode.ToInstructionString(), opcode.ToOpCodeString());
        }

        public static InstructionInfo ToInstructionInfo(this Iced.Instruction src)
            => src.GetInfo().ToInstructionInfo();

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        public static OpCodeInfo ToOpCodeInfo(this Iced.OpCodeInfo src)
            => new OpCodeInfo
            {
                AddressSize = src.AddressSize,
                CanBroadcast = src.CanBroadcast,
                CanSuppressAllExceptions = src.CanSuppressAllExceptions,
                CanUseBndPrefix = src.CanUseBndPrefix,
                CanUseHintTakenPrefix = src.CanUseHintTakenPrefix,
                CanUseNotrackPrefix = src.CanUseNotrackPrefix,
                CanUseOpMaskRegister = src.CanUseOpMaskRegister,
                CanUseZeroingMasking = src.CanUseZeroingMasking,
                CanUseLockPrefix = src.CanUseLockPrefix,
                CanUseXacquirePrefix = src.CanUseXacquirePrefix,
                CanUseXreleasePrefix = src.CanUseXreleasePrefix,
                CanUseRepPrefix = src.CanUseRepPrefix,
                CanUseRepnePrefix = src.CanUseRepnePrefix,
                CanUseRoundingControl = src.CanUseRoundingControl,
                Code = src.Code.ToLiteralCode(),
                Encoding = src.Encoding.ToEncodingKind(),
                Fwait = src.Fwait,
                IsInstruction = src.IsInstruction,
                IsGroup = src.IsGroup,
                IsLIG = src.IsLIG,
                IsWIG = src.IsWIG,
                IsWIG32 = src.IsWIG32,
                GroupIndex = src.GroupIndex,
                L = src.L,
                MandatoryPrefix = src.MandatoryPrefix.ToMandatoryPrefix(),
                Mode16 = src.Mode16,
                Mode32 = src.Mode32,
                Mode64 = src.Mode64,
                OpCode = src.OpCode,
                OperandSize = src.OperandSize,
                OpCount = src.OpCount,
                Op0Kind = src.Op0Kind.ToOpCodeOperandKind(),
                Op1Kind = src.Op1Kind.ToOpCodeOperandKind(),
                Op2Kind = src.Op2Kind.ToOpCodeOperandKind(),
                Op3Kind = src.Op3Kind.ToOpCodeOperandKind(),
                Op4Kind = src.Op4Kind.ToOpCodeOperandKind(),
                RequireNonZeroOpMaskRegister = src.RequireNonZeroOpMaskRegister,
                Table = src.Table.ToOpCodeTableKind(),
                TupleType = src.TupleType.ToTupleType(),
                W = src.W,
            };

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        public static Instruction ToInstruction(this Iced.Instruction src, string formatted)
            => new Instruction
            {
                FormattedInstruction = formatted,
                ByteLength = src.ByteLength,
                ConditionCode = src.ConditionCode.ToConditionCode(),
                CodeSize = src.CodeSize.ToCodeSize(),
                Code = src.Code.ToLiteralCode(),
                CpuidFeatures = src.CpuidFeatures.Map(x => x.ToCpuid()),
                DeclareDataCount = src.DeclareDataCount,
                Encoding = src.Encoding.ToEncodingKind(),
                FarBranch16 = src.FarBranch16,
                FarBranch32 = src.FarBranch32,
                FarBranchSelector = src.FarBranchSelector,
                FlowControl = src.FlowControl.ToFlowControl(),
                InstructionCode = src.ToInstructionCode(),
                IP = src.IP,
                IP16 = src.IP16,
                IP32 = src.IP32,
                IPRelativeMemoryAddress = src.IPRelativeMemoryAddress,
                IsBroadcast = src.IsBroadcast,
                IsCallFar = src.IsCallFar,
                IsCallFarIndirect = src.IsCallFarIndirect,    
                IsCallNear = src.IsCallNear,
                IsCallNearIndirect = src.IsCallNearIndirect,
                IsIPRelativeMemoryOperand = src.IsIPRelativeMemoryOperand,
                IsJccShortOrNear = src.IsJccShortOrNear,
                IsJccShort = src.IsJccShort,
                IsJmpShort = src.IsJmpShort,
                IsJmpNear = src.IsJmpNear,
                IsJmpShortOrNear = src.IsJmpShortOrNear,
                IsJmpFar = src.IsJmpFar,
                IsJmpNearIndirect = src.IsJmpNearIndirect,
                IsJmpFarIndirect = src.IsJmpFarIndirect,
                IsJccNear = src.IsJccNear,
                IsPrivileged = src.IsPrivileged,
                IsProtectedMode = src.IsProtectedMode,
                IsStackInstruction = src.IsStackInstruction,
                IsSaveRestoreInstruction = src.IsSaveRestoreInstruction,
                IsVsib64 = src.IsVsib64,
                IsVsib = src.IsVsib,
                IsVsib32 = src.IsVsib32,
                Immediate8 = src.Immediate8,
                Immediate8_2nd = src.Immediate8_2nd,
                Immediate16 = src.Immediate16,
                Immediate32 = src.Immediate32,
                Immediate64 = src.Immediate64,
                Immediate8to16 = src.Immediate8to16,
                Immediate8to32 = src.Immediate8to32,
                Immediate8to64 = src.Immediate8to64,
                Immediate32to64 = src.Immediate32to64,
                HasLockPrefix = src.HasLockPrefix,
                HasOpMask = src.HasOpMask,
                HasRepPrefix = src.HasRepPrefix,
                HasRepePrefix = src.HasRepePrefix,
                HasRepnePrefix = src.HasRepnePrefix,
                HasXacquirePrefix = src.HasXacquirePrefix,
                HasXreleasePrefix = src.HasXreleasePrefix,
                MemorySize = src.MemorySize.ToMemorySize(),
                MemoryIndex = src.MemoryIndex.ToRegister(),
                MemoryIndexScale = src.MemoryIndexScale,
                MemoryDisplacement = src.MemoryDisplacement,
                MemoryAddress64 = src.MemoryAddress64,
                MemoryDisplSize = src.MemoryDisplSize,
                MemorySegment = src.MemorySegment.ToRegister(),
                MemoryBase = src.MemoryBase.ToRegister(),
                MergingMasking = src.MergingMasking,
                Mnemonic = src.Mnemonic.ToMnemonic(),
                NearBranch16 = src.NearBranch16,
                NearBranch32 = src.NearBranch32,
                NearBranch64 = src.NearBranch64,
                NearBranchTarget = src.NearBranchTarget,
                NextIP = src.NextIP,
                NextIP16 = src.NextIP16,
                NextIP32 = src.NextIP32,
                OpCode = src.OpCode.ToOpCodeInfo(),
                OpCount = src.OpCount,
                OpMask = src.OpMask.ToRegister(),
                Op0Kind = src.Op0Kind.ToAsmOpKind(),
                Op1Kind = src.Op1Kind.ToAsmOpKind(),
                Op2Kind = src.Op2Kind.ToAsmOpKind(),
                Op3Kind = src.Op3Kind.ToAsmOpKind(),
                Op4Kind = src.Op4Kind.ToAsmOpKind(),
                Op0Register = src.Op0Register.ToRegister(),
                Op1Register = src.Op1Register.ToRegister(),
                Op2Register = src.Op2Register.ToRegister(),
                Op3Register = src.Op3Register.ToRegister(),
                Op4Register = src.Op4Register.ToRegister(),
                RflagsRead = src.RflagsRead.ToRFlags(),
                RflagsWritten = src.RflagsWritten.ToRFlags(),
                RflagsCleared = src.RflagsCleared.ToRFlags(),
                RflagsSet = src.RflagsSet.ToRFlags(),
                RflagsUndefined = src.RflagsUndefined.ToRFlags(),
                RflagsModified = src.RflagsModified.ToRFlags(),
                RoundingControl = src.RoundingControl.ToRoundingControl(),
                SegmentPrefix = src.SegmentPrefix.ToRegister(),
                SuppressAllExceptions = src.SuppressAllExceptions,
                StackPointerIncrement = src.StackPointerIncrement,
                ZeroingMasking = src.ZeroingMasking,
           };             


        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static MemoryOperand ToMemoryOperand(this Iced.MemoryOperand src)
            => new MemoryOperand(src.Base.ToRegister(), src.Index.ToRegister(), src.Scale, src.Displacement, src.DisplSize, src.IsBroadcast, src.SegmentPrefix.ToRegister());

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static UsedMemory ToUsedMemory(this Iced.UsedMemory src)
            => new UsedMemory
            {
                Access = src.Access.ToOpAccess(),
                Base  = src.Base.ToRegister(),
                Displacement = src.Displacement,
                Index = src.Index.ToRegister(),
                MemorySize = src.MemorySize.ToMemorySize(),
                Scale = src.Scale,
                Segment = src.Segment.ToRegister(),
                Formatted = src.ToString()
            };

        public static InstructionInfo ToInstructionInfo(this Iced.InstructionInfo src)
        {
            return new InstructionInfo
            {
                Encoding = src.Encoding.ToEncodingKind(),
                FlowControl = src.FlowControl.ToFlowControl(),
                IsProtectedMode = src.IsProtectedMode,
                IsPrivileged = src.IsPrivileged,
                IsSaveRestoreInstruction = src.IsSaveRestoreInstruction,
                IsStackInstruction = src.IsStackInstruction,
                RflagsCleared = src.RflagsCleared.ToRFlags(),
                RflagsRead = src.RflagsRead.ToRFlags(),
                RflagsWritten = src.RflagsWritten.ToRFlags(),
                RflagsModified = src.RflagsModified.ToRFlags(),
                RflagsSet = src.RflagsSet.ToRFlags(),
                RflagsUndefined = src.RflagsUndefined.ToRFlags(),
                UsedMemory = src.GetUsedMemory().Select(x => x.ToUsedMemory()).ToArray(),
                UsedRegisters = src.GetUsedRegisters().Select(x => x.ToUsedRegister()).ToArray(),
                CpuidFeatures = src.CpuidFeatures.Select(x => x.ToCpuid()).ToArray(),
                Access = array(
                    src.Op0Access.ToOpAccess(), 
                    src.Op0Access.ToOpAccess(), 
                    src.Op2Access.ToOpAccess(), 
                    src.Op3Access.ToOpAccess(), 
                    src.Op4Access.ToOpAccess()).Where(x => x != OpAccess.None).ToArray()

            };
        }
            
        [MethodImpl(Inline)]
        public static UsedRegister ToUsedRegister(this Iced.UsedRegister src)
            => new UsedRegister(src.Register.ToRegister(), src.Access.ToOpAccess());

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static OpAccess ToOpAccess(this Iced.OpAccess src)
            => (OpAccess)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Code ToLiteralCode(this Iced.Code src)
            => (Code)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static CodeSize ToCodeSize(this Iced.CodeSize src)
            => (CodeSize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static ConditionCode ToConditionCode(this Iced.ConditionCode src)
            => (ConditionCode)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static CpuidFeature ToCpuid(this Iced.CpuidFeature src)
            => (CpuidFeature)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static EncodingKind ToEncodingKind(this Iced.EncodingKind src)
            => (EncodingKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static FlowControl ToFlowControl(this Iced.FlowControl src)
            => (FlowControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static MandatoryPrefix ToMandatoryPrefix(this Iced.MandatoryPrefix src)
            => (MandatoryPrefix)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static MemorySize ToMemorySize(this Iced.MemorySize src)
            => (MemorySize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Mnemonic ToMnemonic(this Iced.Mnemonic src)
            => (Mnemonic)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static OpCodeOperandKind ToOpCodeOperandKind(this Iced.OpCodeOperandKind src)
            => (OpCodeOperandKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static OpCodeTableKind ToOpCodeTableKind(this Iced.OpCodeTableKind src)
            => (OpCodeTableKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static OpKind ToAsmOpKind(this Iced.OpKind src)
            => (OpKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Register ToRegister(this Iced.Register src)
            => (Register)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static RflagsBits ToRFlags(this Iced.RflagsBits src)
            => (RflagsBits)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static RoundingControl ToRoundingControl(this Iced.RoundingControl src)
            => (RoundingControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static TupleType ToTupleType(this Iced.TupleType src)
            => (TupleType)src;
   }
}