//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct Grammar<T,N>
        where T : unmanaged, IEquatable<T>, IComparable<T>
        where N : unmanaged, IEquatable<N>, IComparable<N>
    {
        public Index<T> Terminals {get;}

        public Index<N> Nonterminals {get;}

        public Grammar(T[] terminals, N[] nonterminals)
        {
            Terminals = terminals;
            Nonterminals = nonterminals;
        }
    }
}