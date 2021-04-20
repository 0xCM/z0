//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    using T = AsmTokens.RexPrefixToken;

    /// <summary>
    /// Defines the rex prefix codes
    /// </summary>
    [PrefixCodes]
    public enum RexPrefixCode : byte
    {
        None = 0,

        [PrefixCode(T.Rex40)]
        Rex40 = x40,

        [PrefixCode(T.Rex41)]
        RexB = x41,

        [PrefixCode(T.Rex42)]
        Rex42 = x42,

        [PrefixCode(T.Rex43)]
        Rex43 = x43,

        [PrefixCode(T.Rex44)]
        RexR = x44,

        [PrefixCode(T.Rex45)]
        Rex45 = x45,

        [PrefixCode(T.Rex46)]
        Rex46 = x46,

        [PrefixCode(T.Rex47)]
        Rex47 = x47,

        [PrefixCode(T.RexW)]
        RexW = x48,

        [PrefixCode(T.Rex49)]
        Rex49 = x49,

        [PrefixCode(T.Rex4A)]
        Rex4A = x4a,

        [PrefixCode(T.Rex4B)]
        Rex4B = x4b,

        [PrefixCode(T.Rex4C)]
        Rex4C = x4c,

        [PrefixCode(T.Rex4D)]
        Rex4D = x4d,

        [PrefixCode(T.Rex4E)]
        Rex4E = x4e,

        [PrefixCode(T.Rex4F)]
        Rex4F = x4f,
    }
}