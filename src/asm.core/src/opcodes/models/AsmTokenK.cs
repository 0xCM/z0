//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmToken<K>
        where K : unmanaged
    {
        public Sym<K> Symbol {get;}

        [MethodImpl(Inline)]
        public AsmToken(Sym<K> symbol)
        {
            Symbol = symbol;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmToken<K>(Sym<K> src)
            => new AsmToken<K>(src);
    }
}