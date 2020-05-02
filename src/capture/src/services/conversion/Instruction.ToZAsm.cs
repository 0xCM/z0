//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    using Iced = Iced.Intel;

    static partial class AsmSpecConversion
    {
        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        public static Instruction ToZAsm(this Iced.Instruction src, string formatted)
        {
            var info = src.GetInfo();
            return new Instruction
            {
                UsedMemory = ZAsmExtractors.UsedMemory(info),
                UsedRegisters = ZAsmExtractors.UsedRegisters(info),
                Access = ZAsmExtractors.OpAccess(info),
                FlowInfo = ZAsmExtractors.FlowInfo(src.Code),

                InstructionCode = src.ToInstructionCode(),
                ByteLength = src.ByteLength,
                ConditionCode = src.ConditionCode.ToZAsm(),
                CodeSize = src.CodeSize.ToZAsm(),
                FormattedInstruction = formatted,
                Code = src.Code.ToZAsm(),
                CpuidFeatures = src.CpuidFeatures.Map(x => x.ToZAsm()),
                DeclareDataCount = src.DeclareDataCount,
                Encoding = src.Encoding.ToZAsm(),
                FarBranch16 = src.FarBranch16,
                FarBranch32 = src.FarBranch32,
                FarBranchSelector = src.FarBranchSelector,
                FlowControl = src.FlowControl.ToZAsm(),
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
                MemorySize = src.MemorySize.ToZAsm(),
                MemoryIndex = src.MemoryIndex.ToZAsm(),
                MemoryIndexScale = src.MemoryIndexScale,
                MemoryDisplacement = src.MemoryDisplacement,
                MemoryAddress64 = src.MemoryAddress64,
                MemoryDisplSize = src.MemoryDisplSize,
                MemorySegment = src.MemorySegment.ToZAsm(),
                MemoryBase = src.MemoryBase.ToZAsm(),
                MergingMasking = src.MergingMasking,
                Mnemonic = src.Mnemonic.ToZAsm(),
                NearBranch16 = src.NearBranch16,
                NearBranch32 = src.NearBranch32,
                NearBranch64 = src.NearBranch64,
                NearBranchTarget = src.NearBranchTarget,
                NextIP = src.NextIP,
                NextIP16 = src.NextIP16,
                NextIP32 = src.NextIP32,
                OpCode = src.OpCode.ToZAsm(),
                OpCount = src.OpCount,
                OpMask = src.OpMask.ToZAsm(),
                Op0Kind = src.Op0Kind.ToZAsm(),
                Op1Kind = src.Op1Kind.ToZAsm(),
                Op2Kind = src.Op2Kind.ToZAsm(),
                Op3Kind = src.Op3Kind.ToZAsm(),
                Op4Kind = src.Op4Kind.ToZAsm(),
                Op0Register = src.Op0Register.ToZAsm(),
                Op1Register = src.Op1Register.ToZAsm(),
                Op2Register = src.Op2Register.ToZAsm(),
                Op3Register = src.Op3Register.ToZAsm(),
                Op4Register = src.Op4Register.ToZAsm(),
                RflagsRead = src.RflagsRead.ToZAsm(),
                RflagsWritten = src.RflagsWritten.ToZAsm(),
                RflagsCleared = src.RflagsCleared.ToZAsm(),
                RflagsSet = src.RflagsSet.ToZAsm(),
                RflagsUndefined = src.RflagsUndefined.ToZAsm(),
                RflagsModified = src.RflagsModified.ToZAsm(),
                RoundingControl = src.RoundingControl.ToZAsm(),
                SegmentPrefix = src.SegmentPrefix.ToZAsm(),
                SuppressAllExceptions = src.SuppressAllExceptions,
                StackPointerIncrement = src.StackPointerIncrement,
                ZeroingMasking = src.ZeroingMasking,
           };             
        }
    }
}