//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct SymbolSet
    {
        public Index<Sym> Symbols {get;}

        [MethodImpl(Inline)]
        public SymbolSet(Sym[] src)
        {
            Symbols = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator SymbolSet(Sym[] src)
            => new SymbolSet(src);
    }
}