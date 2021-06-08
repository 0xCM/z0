//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using T = AsmOpCodeTokens;

    [ApiHost]
    public readonly struct AsmHexCodes
    {
        public static RexPrefixKind RexW => RexPrefixKind.W;

        public static RexPrefixKind RexR => RexPrefixKind.R;

        public static RexPrefixKind RexX => RexPrefixKind.X;

        public static RexPrefixKind RexB => RexPrefixKind.B;

    }
}