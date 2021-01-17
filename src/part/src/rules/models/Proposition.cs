//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        public interface IProposition : ITerm
        {

        }

        public interface IProposition<A,C> : IProposition
            where A : IAntecedant
            where C : IConsequent
        {
            A Antecedant {get;}

            C Consequence {get;}
        }

        public readonly struct Proposition<A,C> : IProposition<Antecedant<A>,Consequent<C>>, IEquatable<Proposition<A,C>>
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