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

    using Z0.Asm;

    using static zfunc;                

    using Iced = Iced.Intel;

    public static class AsmSpecConversion
    {
        public static AsmInstructionCode InstructionCode(this Iced.Instruction src)
        {
            var opcode = Iced.EncoderCodeExtensions.ToOpCode(src.Code);
            return AsmInstructionCode.Define(opcode.ToInstructionString(), opcode.ToOpCodeString());
        }

        public static InstructionInfo Info(this Iced.Instruction src)
            => src.GetInfo().ToSpec();

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        internal static OpCodeInfo ToSpec(this Iced.OpCodeInfo src)
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
                Code = src.Code.ToSpec(),
                Encoding = src.Encoding.ToSpec(),
                Fwait = src.Fwait,
                IsInstruction = src.IsInstruction,
                IsGroup = src.IsGroup,
                IsLIG = src.IsLIG,
                IsWIG = src.IsWIG,
                IsWIG32 = src.IsWIG32,
                GroupIndex = src.GroupIndex,
                L = src.L,
                MandatoryPrefix = src.MandatoryPrefix.ToSpec(),
                Mode16 = src.Mode16,
                Mode32 = src.Mode32,
                Mode64 = src.Mode64,
                OpCode = src.OpCode,
                OperandSize = src.OperandSize,
                OpCount = src.OpCount,
                Op0Kind = src.Op0Kind.ToSpec(),
                Op1Kind = src.Op1Kind.ToSpec(),
                Op2Kind = src.Op2Kind.ToSpec(),
                Op3Kind = src.Op3Kind.ToSpec(),
                Op4Kind = src.Op4Kind.ToSpec(),
                RequireNonZeroOpMaskRegister = src.RequireNonZeroOpMaskRegister,
                Table = src.Table.ToSpec(),
                TupleType = src.TupleType.ToSpec(),
                W = src.W,
            };

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        internal static Instruction ToSpec(this Iced.Instruction src, string formatted)
            => new Instruction
            {
                FormattedInstruction = formatted,
                ByteLength = src.ByteLength,
                ConditionCode = src.ConditionCode.ToSpec(),
                CodeSize = src.CodeSize.ToSpec(),
                Code = src.Code.ToSpec(),
                CpuidFeatures = src.CpuidFeatures.Map(x => x.ToSpec()),
                DeclareDataCount = src.DeclareDataCount,
                Encoding = src.Encoding.ToSpec(),
                FarBranch16 = src.FarBranch16,
                FarBranch32 = src.FarBranch32,
                FarBranchSelector = src.FarBranchSelector,
                FlowControl = src.FlowControl.ToSpec(),
                InstructionCode = src.InstructionCode(),
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
                MemorySize = src.MemorySize.ToSpec(),
                MemoryIndex = src.MemoryIndex.ToSpec(),
                MemoryIndexScale = src.MemoryIndexScale,
                MemoryDisplacement = src.MemoryDisplacement,
                MemoryAddress64 = src.MemoryAddress64,
                MemoryDisplSize = src.MemoryDisplSize,
                MemorySegment = src.MemorySegment.ToSpec(),
                MemoryBase = src.MemoryBase.ToSpec(),
                MergingMasking = src.MergingMasking,
                Mnemonic = src.Mnemonic.ToSpec(),
                NearBranch16 = src.NearBranch16,
                NearBranch32 = src.NearBranch32,
                NearBranch64 = src.NearBranch64,
                NearBranchTarget = src.NearBranchTarget,
                NextIP = src.NextIP,
                NextIP16 = src.NextIP16,
                NextIP32 = src.NextIP32,
                OpCode = src.OpCode.ToSpec(),
                OpCount = src.OpCount,
                OpMask = src.OpMask.ToSpec(),
                Op0Kind = src.Op0Kind.ToSpec(),
                Op1Kind = src.Op1Kind.ToSpec(),
                Op2Kind = src.Op2Kind.ToSpec(),
                Op3Kind = src.Op3Kind.ToSpec(),
                Op4Kind = src.Op4Kind.ToSpec(),
                Op0Register = src.Op0Register.ToSpec(),
                Op1Register = src.Op1Register.ToSpec(),
                Op2Register = src.Op2Register.ToSpec(),
                Op3Register = src.Op3Register.ToSpec(),
                Op4Register = src.Op4Register.ToSpec(),
                RflagsRead = src.RflagsRead.ToSpec(),
                RflagsWritten = src.RflagsWritten.ToSpec(),
                RflagsCleared = src.RflagsCleared.ToSpec(),
                RflagsSet = src.RflagsSet.ToSpec(),
                RflagsUndefined = src.RflagsUndefined.ToSpec(),
                RflagsModified = src.RflagsModified.ToSpec(),
                RoundingControl = src.RoundingControl.ToSpec(),
                SegmentPrefix = src.SegmentPrefix.ToSpec(),
                SuppressAllExceptions = src.SuppressAllExceptions,
                StackPointerIncrement = src.StackPointerIncrement,
                ZeroingMasking = src.ZeroingMasking,
           };             


        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static MemoryOperand ToSpec(this Iced.MemoryOperand src)
            => new MemoryOperand(src.Base.ToSpec(), src.Index.ToSpec(), src.Scale, src.Displacement, src.DisplSize, src.IsBroadcast, src.SegmentPrefix.ToSpec());


        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        public static UsedMemory ToSpec(this Iced.UsedMemory src)
            => new UsedMemory
            {
                Access = src.Access.ToSpec(),
                Base  = src.Base.ToSpec(),
                Displacement = src.Displacement,
                Index = src.Index.ToSpec(),
                MemorySize = src.MemorySize.ToSpec(),
                Scale = src.Scale,
                Segment = src.Segment.ToSpec(),
                Formatted = src.ToString()
            };

        static InstructionInfo ToSpec(this Iced.InstructionInfo src)
        {
            return new InstructionInfo
            {
                Encoding = src.Encoding.ToSpec(),
                FlowControl = src.FlowControl.ToSpec(),
                IsProtectedMode = src.IsProtectedMode,
                IsPrivileged = src.IsPrivileged,
                IsSaveRestoreInstruction = src.IsSaveRestoreInstruction,
                IsStackInstruction = src.IsStackInstruction,
                RflagsCleared = src.RflagsCleared.ToSpec(),
                RflagsRead = src.RflagsRead.ToSpec(),
                RflagsWritten = src.RflagsWritten.ToSpec(),
                RflagsModified = src.RflagsModified.ToSpec(),
                RflagsSet = src.RflagsSet.ToSpec(),
                RflagsUndefined = src.RflagsUndefined.ToSpec(),
                UsedMemory = src.GetUsedMemory().Select(x => x.ToSpec()).ToArray(),
                UsedRegisters = src.GetUsedRegisters().Select(x => x.ToSpec()).ToArray(),
                CpuidFeatures = src.CpuidFeatures.Select(x => x.ToSpec()).ToArray(),
                Access = array(
                    src.Op0Access.ToSpec(), 
                    src.Op0Access.ToSpec(), 
                    src.Op2Access.ToSpec(), 
                    src.Op3Access.ToSpec(), 
                    src.Op4Access.ToSpec()).Where(x => x != OpAccess.None).ToArray()

            };
        }
            
        [MethodImpl(Inline)]
        static UsedRegister ToSpec(this Iced.UsedRegister src)
            => new UsedRegister(src.Register.ToSpec(), src.Access.ToSpec());

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [MethodImpl(Inline)]
        static OpAccess ToSpec(this Iced.OpAccess src)
            => (OpAccess)src;

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
   }
}