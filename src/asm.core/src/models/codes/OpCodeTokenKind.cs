//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static AsmCodes;

    [Flags]
    public enum OpCodeTokenKind : byte
    {
        None = 0,

        [SymClass(typeof(PrefixToken))]
        Prefix = 1,

        [SymClass(typeof(RexBToken))]
        RexBExtension = 2,

        [SymClass(typeof(ModRmToken))]
        RegOpCodeMod = 4,

        [SymClass(typeof(SegOverrideToken))]
        SegOverride = 8,

        [SymClass(typeof(OffsetToken))]
        Offset = 16,

        [SymClass(typeof(ImmSizeToken))]
        ImmSize = 32,

        [SymClass(typeof(ExclusionToken))]
        Exclusion = 64,

        [SymClass(typeof(PrefixToken))]
        FpuDigit,
    }
}