//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using Iced = Iced.Intel;
    using NI = NumericIndicator;
    using TI = TypeIndicator;
    using MZ = Asm.IceMemorySize;
    using NK = NumericKind;
    using SI = SegmentedIdentity;
    using FIX = CellWidth;

    [ApiHost]
    public readonly partial struct IceExtractors
    {
        public static IceUsedMemory[] UsedMemory(Iced.InstructionInfo src)
            => src.GetUsedMemory().Map(x => Deicer.Thaw(x));

        public static IceUsedRegister[] UsedRegisters(Iced.InstructionInfo src)
            => src.GetUsedRegisters().Map(x => Deicer.Thaw(x));

        [MethodImpl(Inline)]
        public static Func<IceOpAccess[]> OpAccessDefer(Iced.InstructionInfo src)
            => () => access(src);

        [Op]
        public static AsmInstructionSpecExprLegacy specifier(Iced.Instruction src)
        {
            var iceOpCode = Iced.EncoderCodeExtensions.ToOpCode(src.Code);
            return new AsmInstructionSpecExprLegacy(AsmOpCodeExprLegacy.cleanse(iceOpCode.ToOpCodeString()), iceOpCode.ToInstructionString());
        }

        [MethodImpl(Inline), Op]
        public static IceOpAccess[] access(Iced.InstructionInfo src)
            => root.array(
                    Deicer.Thaw(src.Op0Access),
                    Deicer.Thaw(src.Op0Access),
                    Deicer.Thaw(src.Op2Access),
                    Deicer.Thaw(src.Op3Access),
                    Deicer.Thaw(src.Op4Access)).Where(x => x != 0);

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [Op]
        public static IceInstruction extract(Iced.Instruction src, string formatted, BinaryCode encoded)
        {
            var info = src.GetInfo();
            root.require(src.ByteLength == encoded.Length, () => $"The instruction byte length {src.ByteLength} does not match the encoded length {encoded.Length}");
            return new IceInstruction
            {
                UsedMemory = UsedMemory(info),
                UsedRegisters = UsedRegisters(info),
                Access = OpAccessDefer(info),
                Specifier = specifier(src),
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
                OpCode = extract(src.OpCode),
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

        /// <summary>
        /// Assigns identity to a <see cref='IceMemorySize'/> specification
        /// </summary>
        /// <param name="src">A memory size specification</param>
        [Op]
        public static SegmentedIdentity identify(IceMemorySize src)
            => src switch {
                    MZ.UInt8 => NK.U8,
                    MZ.UInt16 => NK.U16,
                    MZ.UInt32 => NK.U32,
                    MZ.UInt64 => NK.U64,
                    MZ.Int8 => NK.I8,
                    MZ.Int16 => NK.I16,
                    MZ.Int32 => NK.I32,
                    MZ.Int64 => NK.I64,
                    MZ.Float32 => NK.F32,
                    MZ.Float64 => NK.F64,
                    MZ.Packed128_Int8 => (TI.Signed, FIX.W128, FIX.W8, NI.Signed),
                    MZ.Packed128_UInt8 => (TI.Unsigned, FIX.W128, FIX.W8, NI.Unsigned),
                    MZ.Packed128_Int16 => (TI.Signed, FIX.W128, FIX.W16, NI.Signed),
                    MZ.Packed128_UInt16 => (TI.Unsigned, FIX.W128, FIX.W16, NI.Unsigned),
                    MZ.Packed128_Int32 => (TI.Signed, FIX.W128, FIX.W32, NI.Signed),
                    MZ.Packed128_UInt32 => (TI.Unsigned, FIX.W128, FIX.W32, NI.Unsigned),
                    MZ.Packed128_Int64 => (TI.Signed, FIX.W128, FIX.W64, NI.Signed),
                    MZ.Packed128_UInt64 => (TI.Unsigned, FIX.W128, FIX.W64, NI.Unsigned),
                    MZ.Packed128_Float32 => (TI.Float, FIX.W128, FIX.W32, NI.Float),
                    MZ.Packed128_Float64 => (TI.Float, FIX.W128, FIX.W64, NI.Float),
                    MZ.Packed256_Int8 => (TI.Signed, FIX.W256, FIX.W8, NI.Signed),
                    MZ.Packed256_UInt8 => (TI.Unsigned, FIX.W256, FIX.W8, NI.Unsigned),
                    MZ.Packed256_Int16 => (TI.Signed, FIX.W256, FIX.W16, NI.Signed),
                    MZ.Packed256_UInt16 => (TI.Unsigned, FIX.W256, FIX.W16, NI.Unsigned),
                    MZ.Packed256_Int32 => (TI.Signed, FIX.W256, FIX.W32, NI.Signed),
                    MZ.Packed256_UInt32 => (TI.Unsigned, FIX.W256, FIX.W32, NI.Unsigned),
                    MZ.Packed256_Int64 => (TI.Signed, FIX.W256, FIX.W64, NI.Signed),
                    MZ.Packed256_UInt64 => (TI.Unsigned, FIX.W256, FIX.W64, NI.Unsigned),
                    MZ.Packed256_Float32 => (TI.Float, FIX.W256, FIX.W32, NI.Float),
                    MZ.Packed256_Float64 => (TI.Float, FIX.W256, FIX.W64, NI.Float),
                    MZ.Unknown => SI.Empty,
                    _ => SI.from(src.ToString())
            };

        /// <summary>
        /// Converts the iced-defined data structure to a Z0-defined replication of the iced structure
        /// </summary>
        /// <param name="src">The iced source value</param>
        [Op]
        public static IceOpCodeInfo extract(Iced.OpCodeInfo src)
            => new IceOpCodeInfo
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
                OpCodeString = AsmOpCodeExprLegacy.conform(src.ToOpCodeString()),
                InstructionString = src.ToInstructionString(),
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

        static IceConverters Deicer => IceConverters.Service;
    }
}