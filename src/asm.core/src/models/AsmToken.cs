//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmToken
    {
        public Sym Symbol {get;}

        [MethodImpl(Inline)]
        public AsmToken(Sym symbol)
        {
            Symbol = symbol;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmToken(Sym src)
            => new AsmToken(src);
    }
}