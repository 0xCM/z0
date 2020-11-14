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

   public readonly struct Nonterminal<S> : INonterminal<S>
        where S : unmanaged
    {
        public S Value {get;}

        [MethodImpl(Inline)]
        public Nonterminal(S value)
            => Value = value;

        [MethodImpl(Inline)]
        public static implicit operator Nonterminal<S>(S src)
            => new Nonterminal<S>(src);

        [MethodImpl(Inline)]
        public static implicit operator S(Nonterminal<S> src)
            => src.Value;
    }
}