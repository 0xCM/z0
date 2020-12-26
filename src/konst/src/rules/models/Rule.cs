//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Rule<A,C> : IRule<Proposition<A,C>>, IEquatable<Rule<A,C>>
        where A : IEquatable<A>
        where C : IEquatable<C>
    {
        public TermId Id {get;}

        public Index<Proposition<A,C>> Terms {get;}

        [MethodImpl(Inline)]
        public Rule(TermId id, Proposition<A,C>[] terms)
        {
            Id  = id;
            Terms = terms;
        }

        public bool Equals(Rule<A,C> src)
            => Index.equals(Terms.View, src.Terms.View);
    }
}