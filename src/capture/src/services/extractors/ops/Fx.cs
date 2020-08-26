//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Iced.Intel;

    using static Konst;

    using Iced = Iced.Intel;

    partial class IceExtractors
    {
       /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        public static Instruction Fx(Iced.Instruction src, string formatted)
        {
            var info = src.GetInfo();
            return new Instruction
            {
                UsedMemory = UsedMemoryDefer(info),
                UsedRegisters = UsedRegistersDefer(info),
                Access = OpAccessDefer(info),
                FlowInfo = FlowInfoDefer(src.Code),
                InstructionCode = FxCode(src),
                ByteLength = src.ByteLength,
                ConditionCode = Deicer.Thaw(src.ConditionCode),
                CodeSize = Deicer.Thaw(src.CodeSize),
                FormattedInstruction = formatted,
                Code = Deicer.Thaw(src.Code),
                CpuidFeatures = src.CpuidFeatures.Map(x => Deicer.Thaw(x)),
                DeclareDataCount = src.DeclareDataCount,
                Encoding = Deicer.Thaw(src.Encoding),
                FarBranch16 = src.FarBranch16,
                FarBranch32 = src.FarBranch32,
                FarBranchSelector = src.FarBranchSelector,
                FlowControl = Deicer.Thaw(src.FlowControl),
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
                MemorySize = Deicer.Thaw(src.MemorySize),
                MemoryIndex = Deicer.Thaw(src.MemoryIndex),
                MemoryIndexScale = src.MemoryIndexScale,
                MemoryDisplacement = src.MemoryDisplacement,
                MemoryAddress64 = src.MemoryAddress64,
                MemoryDisplSize = src.MemoryDisplSize,
                MemorySegment = Deicer.Thaw(src.MemorySegment),
                MemoryBase =  Deicer.Thaw(src.MemoryBase),
                MergingMasking = src.MergingMasking,
                Mnemonic = Deicer.Thaw(src.Mnemonic),
                NearBranch16 = src.NearBranch16,
                NearBranch32 = src.NearBranch32,
                NearBranch64 = src.NearBranch64,
                NearBranchTarget = src.NearBranchTarget,
                NextIP = src.NextIP,
                NextIP16 = src.NextIP16,
                NextIP32 = src.NextIP32,
                OpCode = FxCodeInfo(src.OpCode),
                OpCount = src.OpCount,
                OpMask = Deicer.Thaw(src.OpMask),
                Op0Kind = Deicer.Thaw(src.Op0Kind),
                Op1Kind = Deicer.Thaw(src.Op1Kind),
                Op2Kind = Deicer.Thaw(src.Op2Kind),
                Op3Kind = Deicer.Thaw(src.Op3Kind),
                Op4Kind = Deicer.Thaw(src.Op4Kind),
                Op0Register = Deicer.Thaw(src.Op0Register),
                Op1Register = Deicer.Thaw(src.Op1Register),
                Op2Register = Deicer.Thaw(src.Op2Register),
                Op3Register = Deicer.Thaw(src.Op3Register),
                Op4Register = Deicer.Thaw(src.Op4Register),
                RflagsRead = Deicer.Thaw(src.RflagsRead),
                RflagsWritten = Deicer.Thaw(src.RflagsWritten),
                RflagsCleared = Deicer.Thaw(src.RflagsCleared),
                RflagsSet = Deicer.Thaw(src.RflagsSet),
                RflagsUndefined = Deicer.Thaw(src.RflagsUndefined),
                RflagsModified = Deicer.Thaw(src.RflagsModified),
                RoundingControl = Deicer.Thaw(src.RoundingControl),
                SegmentPrefix = Deicer.Thaw(src.SegmentPrefix),
                SuppressAllExceptions = src.SuppressAllExceptions,
                StackPointerIncrement = src.StackPointerIncrement,
                ZeroingMasking = src.ZeroingMasking,
           };
        }
    }
}