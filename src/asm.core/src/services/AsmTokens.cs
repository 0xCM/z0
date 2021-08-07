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
            public override string Name
                => "asm.opcodes";

            public override Type[] Types()
                => typeof(AsmOpCodeTokens).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }

        public sealed class Sigs : TokenSet<Sigs>
        {
            public override string Name
                => "asm.sigs";

            public override Type[] Types()
                => typeof(AsmSigs).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }

        public sealed class Codes : TokenSet<Codes>
        {
            public override string Name
                => "asm.codes";

            public override Type[] Types()
                => typeof(AsmCodes).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }

        public sealed class Regs : TokenSet<Regs>
        {
            public override string Name
                => "asm.regs";

            public override Type[] Types()
                => typeof(RegTokens).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }

        public sealed class Conditions : TokenSet<Conditions>
        {
            public override string Name
                => "asm.cc";

            public override Type[] Types()
                => typeof(ConditionCodes).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }
    }
}