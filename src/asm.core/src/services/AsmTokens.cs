//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;


    public readonly struct AsmTokens
    {
        internal sealed class OpCodes : TokenSet<OpCodes>
        {
            public override Type[] Types()
                => typeof(AsmOpCodes).GetNestedTypes().Enums().Tagged<SymSourceAttribute>();
        }
    }
}