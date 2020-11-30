//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost("fsm.dfa")]
    public readonly struct Dfa
    {
        [MethodImpl(Inline)]
        public static Alphabet<A> alphabet<A>(A[] terms)
            where A : unmanaged, ISymbol<A>
                => new Alphabet<A>(terms);

        [MethodImpl(Inline), Op]
        public static Alphabet<Symbol<AsciChar>> asci(AsciChar[] src)
            => src.Map(s => Symbolic.symbol(s));
    }
}