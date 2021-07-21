//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct Proposition<A,C> : IRule<Proposition<A,C>,A,C>, IEquatable<Proposition<A,C>>
            where A : IEquatable<A>
            where C : IEquatable<C>
        {
            public TermId Id {get;}

            public Antecedant<A> Antecedant {get;}

            public Consequent<C> Consequence {get;}

            [MethodImpl(Inline)]
            public Proposition(TermId id, Antecedant<A> a, Consequent<C> c)
            {
                Id = id;
                Antecedant = a;
                Consequence = c;
            }

            public bool Equals(Proposition<A,C> src)
                => Rules.equals(this, src);
        }
    }
}