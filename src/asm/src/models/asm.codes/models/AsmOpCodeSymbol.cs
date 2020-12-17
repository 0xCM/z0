//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOpCodeSymbol : ISymbol<char>
    {
        public char Value {get;}

        [MethodImpl(Inline)]
        public AsmOpCodeSymbol(char src)
            => Value = src;

        [MethodImpl(Inline)]
        public static implicit operator AsmOpCodeSymbol(char src)
            => new AsmOpCodeSymbol(src);
    }
}