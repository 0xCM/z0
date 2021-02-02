//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    [LiteralProvider]
    public readonly struct AsmSigOpKindFacets
    {
        public const AsmSigOpKind MinId = AsmSigOpKind.AL;

        public const AsmSigOpKind MaxId = AsmSigOpKind.MV;

        public const byte IdentifierCount = (byte)MaxId - (byte)MinId;

        public const AsmSigOpKind FirstClass = AsmSigOpKind.RegClass;

        public const AsmSigOpKind LastClass = AsmSigOpKind.ImmClass;
    }
}