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

    class IceExtractors
    {
        static IceConversion Deicer => IceConversion.Service;

        [MethodImpl(Inline)]
        public static Func<UsedMemory[]> UsedMemoryDefer(Iced.InstructionInfo src)
            => () => UsedMemory(src);

        [MethodImpl(Inline)]
        public static UsedMemory[] UsedMemory(Iced.InstructionInfo src)
            => src.GetUsedMemory().Map(x => Deicer.Thaw(x));

        [MethodImpl(Inline)]
        public static UsedRegister[] UsedRegisters(Iced.InstructionInfo src)
            => src.GetUsedRegisters().Map(x => Deicer.Thaw(x));

        [MethodImpl(Inline)]
        public static Func<UsedRegister[]> UsedRegistersDefer(Iced.InstructionInfo src)
            => () => src.GetUsedRegisters().Map(x => Deicer.Thaw(x));

        [MethodImpl(Inline)]
        public static Func<InstructionInfo> InxsInfoDefer(Iced.Instruction src)
            => () => InxsInfo(src);

        [MethodImpl(Inline)]
        public static InstructionInfo InxsInfo(Iced.Instruction src)
            => Deicer.Thaw(src.GetInfo());

        [MethodImpl(Inline)]
        public static Func<OpAccess[]> OpAccessDefer(Iced.InstructionInfo src)
            => () => OpAccess(src);
        
        [MethodImpl(Inline)]
        public static Func<AsmFlowInfo> FlowInfoDefer(Iced.Code src)    
            => () => FlowInfo(src);

        public static AsmFxCode InstructionCode(Iced.Instruction src)
        {
            var opcode = Iced.EncoderCodeExtensions.ToOpCode(src.Code);
            return new AsmFxCode(
                opcode.ToOpCodeString(), 
                opcode.ToInstructionString());
        }

        public static AsmFlowInfo FlowInfo(Iced.Code src)    
            => new AsmFlowInfo
            {
                Code = Deicer.Thaw(src), 
                ConditionCode = Deicer.Thaw(src.GetConditionCode()),
                IsStackInstruction = src.IsStackInstruction(), 
                FlowControl = Deicer.Thaw(src.FlowControl()),
                IsJccShortOrNear = src.IsJccShortOrNear(),
                IsJccNear = src.IsJccNear(),
                IsJccShort = src.IsJccShort(),
                IsJmpShort = src.IsJmpShort(),
                IsJmpNear = src.IsJmpNear(),
                IsJmpShortOrNear = src.IsJmpShortOrNear(),
                IsJmpFar = src.IsJmpFar(),
                IsCallNear = src.IsCallNear(),
                IsCallFar = src.IsCallFar(),
                IsJmpNearIndirect = src.IsJmpNearIndirect(),
                IsJmpFarIndirect = src.IsJmpFarIndirect(),
                IsCallNearIndirect = src.IsCallNearIndirect(),
                IsCallFarIndirect = src.IsCallFarIndirect()                
            };


        [MethodImpl(Inline)]
        public static OpAccess[] OpAccess(Iced.InstructionInfo src)
            => Memories.array(
                    Deicer.Thaw(src.Op0Access), 
                    Deicer.Thaw(src.Op0Access),
                    Deicer.Thaw(src.Op2Access),
                    Deicer.Thaw(src.Op3Access),
                    Deicer.Thaw(src.Op4Access)).Where(x => x != 0);
 
        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        public static OpCodeInfo OpcodeInfo(Iced.OpCodeInfo src)
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
                Code = Deicer.Thaw(src.Code),
                Encoding = Deicer.Thaw(src.Encoding),
                Fwait = src.Fwait,
                IsInstruction = src.IsInstruction,
                IsGroup = src.IsGroup,
                IsLIG = src.IsLIG,
                IsWIG = src.IsWIG,
                IsWIG32 = src.IsWIG32,
                GroupIndex = src.GroupIndex,
                L = src.L,
                MandatoryPrefix = Deicer.Thaw(src.MandatoryPrefix),
                Mode16 = src.Mode16,
                Mode32 = src.Mode32,
                Mode64 = src.Mode64,
                OpCode = src.OpCode,
                OperandSize = src.OperandSize,
                OpCount = src.OpCount,
                Op0Kind = Deicer.Thaw(src.Op0Kind),
                Op1Kind = Deicer.Thaw(src.Op1Kind),
                Op2Kind = Deicer.Thaw(src.Op2Kind),
                Op3Kind = Deicer.Thaw(src.Op3Kind),
                Op4Kind = Deicer.Thaw(src.Op4Kind),
                RequireNonZeroOpMaskRegister = src.RequireNonZeroOpMaskRegister,
                Table = Deicer.Thaw(src.Table),
                TupleType = Deicer.Thaw(src.TupleType),
                W = src.W,
            };


        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        public static Instruction Inxs(Iced.Instruction src, string formatted)
        {
            var info = src.GetInfo();
            return new Instruction
            {
                UsedMemory = UsedMemoryDefer(info),
                UsedRegisters = UsedRegistersDefer(info),
                Access = OpAccessDefer(info),
                FlowInfo = FlowInfoDefer(src.Code),
                InstructionCode = InstructionCode(src),
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
                OpCode = OpcodeInfo(src.OpCode),
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