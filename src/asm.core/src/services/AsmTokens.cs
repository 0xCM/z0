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
            public override string SetName
                => "asm.opcodes";

            public override Type[] Types()
                => typeof(AsmOpCodeTokens).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }

        public sealed class Sigs : TokenSet<Sigs>
        {
            public override string SetName
                => "asm.sigs";

            public override Type[] Types()
                => typeof(AsmSigTokens).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }

        public sealed class Codes : TokenSet<Codes>
        {
            public override string SetName
                => "asm.codes";

            public override Type[] Types()
                => typeof(AsmCodes).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }

        public sealed class Bitfields : TokenSet<Bitfields>
        {
            public override string SetName
                => "asm.bitfields";

            public override Type[] Types()
                => typeof(BitfieldTokens).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }

        public sealed class Regs : TokenSet<Regs>
        {
            public override string SetName
                => "asm.regs";

            public override Type[] Types()
                => typeof(RegTokens).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }

        public sealed class Conditions : TokenSet<Conditions>
        {
            public override string SetName
                => "asm.cc";

            public override Type[] Types()
                => typeof(ConditionCodes).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }
    }
}