//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Pow2x16;

    [LiteralProvider]
    public readonly struct AsmSigTokenFacets
    {
        public const AsmSigToken MinId = AsmSigToken.AL;

        public const AsmSigToken MaxId = AsmSigToken.K1;

        public const byte IdentifierCount = (byte)MaxId - (byte)MinId + 1;

        public const ushort FirstClass = (ushort)P2ᐞ08;

        public const ushort LastClass = (ushort)P2ᐞ11;
    }
}