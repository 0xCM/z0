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
        public static OpCodeInfo ToZAsm(this Iced.OpCodeInfo src)
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
                Code = src.Code.ToZAsm(),
                Encoding = src.Encoding.ToZAsm(),
                Fwait = src.Fwait,
                IsInstruction = src.IsInstruction,
                IsGroup = src.IsGroup,
                IsLIG = src.IsLIG,
                IsWIG = src.IsWIG,
                IsWIG32 = src.IsWIG32,
                GroupIndex = src.GroupIndex,
                L = src.L,
                MandatoryPrefix = src.MandatoryPrefix.ToZAsm(),
                Mode16 = src.Mode16,
                Mode32 = src.Mode32,
                Mode64 = src.Mode64,
                OpCode = src.OpCode,
                OperandSize = src.OperandSize,
                OpCount = src.OpCount,
                Op0Kind = src.Op0Kind.ToZAsm(),
                Op1Kind = src.Op1Kind.ToZAsm(),
                Op2Kind = src.Op2Kind.ToZAsm(),
                Op3Kind = src.Op3Kind.ToZAsm(),
                Op4Kind = src.Op4Kind.ToZAsm(),
                RequireNonZeroOpMaskRegister = src.RequireNonZeroOpMaskRegister,
                Table = src.Table.ToZAsm(),
                TupleType = src.TupleType.ToZAsm(),
                W = src.W,
            };
    }
}