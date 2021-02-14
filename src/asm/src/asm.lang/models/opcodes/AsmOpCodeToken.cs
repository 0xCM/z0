//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOpCodeToken
    {
        public TextBlock Expression {get;}

        [MethodImpl(Inline)]
        public AsmOpCodeToken(string src)
        {
            Expression = src;
        }
    }
}