//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Konst;
    using static z;


    public interface IDfaTransition<Q,A>
        where A : unmanaged, ISymbol<A>
        where Q : struct, IIndex<A>
    {
        Q Next(Q q, Alphabet<A> s);
    }

    public readonly struct DfaTransition<Q,A> : IDfaTransition<Q,A>
        where A : unmanaged, ISymbol<A>
        where Q : struct, IIndex<A>
    {
        public Q Next(Q q, Alphabet<A> s)
        {
            return default;
        }
    }



    public readonly struct Dfa<Q,I,A,T>
        where A : unmanaged, ISymbol<A>
        where Q : struct, IIndex<A>
    {
        public Q States {get;}

        public Alphabet<A> Alphabet {get;}

        public A Initial {get;}

        public DfaTransition<Q,A> Transition {get;}
    }
}