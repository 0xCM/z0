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
        public readonly struct Antecedant<A> : IAntecedant<A>, IEquatable<Antecedant<A>>
            where A : IEquatable<A>
        {
            public TermId Id {get;}

            public Index<A> Terms {get;}

            [MethodImpl(Inline)]
            public Antecedant(TermId id, Index<A> terms)
            {
                Id = id;
                Terms = terms;
            }

            public bool Equals(Antecedant<A> src)
                => Rules.equals(this,src);
        }
    }
}