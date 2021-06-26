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

        [SymbolClassifier(typeof(PrefixToken))]
        Prefix = 1,

        [SymbolClassifier(typeof(RexBToken))]
        RexBExtension = 2,

        [SymbolClassifier(typeof(ModRmToken))]
        RegOpCodeMod = 4,

        [SymbolClassifier(typeof(SegOverrideToken))]
        SegOverride = 8,

        [SymbolClassifier(typeof(OffsetToken))]
        Offset = 16,

        [SymbolClassifier(typeof(ImmSizeToken))]
        ImmSize = 32,

        [SymbolClassifier(typeof(ExclusionToken))]
        Exclusion = 64,

        [SymbolClassifier(typeof(PrefixToken))]
        FpuDigit,
    }
}