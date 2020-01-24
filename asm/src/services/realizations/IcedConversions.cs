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

    using Specs = Z0.AsmSpecs;
    using Iced = Iced.Intel;

    public static class AsmSpecConversion
    {
        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.Code ToSpec(this Iced.Code src)
            => (Specs.Code)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.CodeSize ToSpec(this Iced.CodeSize src)
            => (Specs.CodeSize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.ConditionCode ToSpec(this Iced.ConditionCode src)
            => (Specs.ConditionCode)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.CpuidFeature ToSpec(this Iced.CpuidFeature src)
            => (Specs.CpuidFeature)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.EncodingKind ToSpec(this Iced.EncodingKind src)
            => (Specs.EncodingKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.FlowControl ToSpec(this Iced.FlowControl src)
            => (Specs.FlowControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.FormatterOutputTextKind ToSpec(this Iced.FormatterOutputTextKind src)
            => (Specs.FormatterOutputTextKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.MandatoryPrefix ToSpec(this Iced.MandatoryPrefix src)
            => (Specs.MandatoryPrefix)src;


        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.MemoryOperand ToSpec(this Iced.MemoryOperand src)
            => new Specs.MemoryOperand(src.Base.ToSpec(), src.Index.ToSpec(), src.Scale, src.Displacement, src.DisplSize, src.IsBroadcast, src.SegmentPrefix.ToSpec());

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.MemorySize ToSpec(this Iced.MemorySize src)
            => (Specs.MemorySize)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.Mnemonic ToSpec(this Iced.Mnemonic src)
            => (Specs.Mnemonic)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.OpCodeOperandKind ToSpec(this Iced.OpCodeOperandKind src)
            => (Specs.OpCodeOperandKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.OpCodeTableKind ToSpec(this Iced.OpCodeTableKind src)
            => (Specs.OpCodeTableKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.OpKind ToSpec(this Iced.OpKind src)
            => (Specs.OpKind)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.Register ToSpec(this Iced.Register src)
            => (Specs.Register)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.RflagsBits ToSpec(this Iced.RflagsBits src)
            => (Specs.RflagsBits)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.RoundingControl ToSpec(this Iced.RoundingControl src)
            => (Specs.RoundingControl)src;

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static Specs.TupleType ToSpec(this Iced.TupleType src)
            => (Specs.TupleType)src;

        public static AsmInstructionCode GetInstructionCode(this Iced.Instruction src)
        {
            var opcode =   Iced.EncoderCodeExtensions.ToOpCode(src.Code);
            return AsmInstructionCode.Define(opcode.ToInstructionString(), opcode.ToOpCodeString());
        }

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        public static Specs.OpCodeInfo ToSpec(this Iced.OpCodeInfo src)
            => new Specs.OpCodeInfo
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
        public static Specs.Instruction ToSpec(this Iced.Instruction src, string formatted)
            => new Specs.Instruction
            {
                FormattedInstruction = formatted,
                InstructionCode = src.GetInstructionCode(),
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
    }
}