//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public readonly struct AsmTokens
    {
        public sealed class OpCodes : TokenSet<OpCodes>
        {
            public override Type[] Types()
                => typeof(AsmOpCodes).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }

        public sealed class Sigs : TokenSet<Sigs>
        {
            public override Type[] Types()
                => typeof(AsmSigTokens).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }

        public sealed class Codes : TokenSet<Codes>
        {
            public override Type[] Types()
                => typeof(AsmCodes).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }

        public sealed class Bitfields : TokenSet<Bitfields>
        {
            public override Type[] Types()
                => typeof(AsmBitfieldTokens).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }
    }
}