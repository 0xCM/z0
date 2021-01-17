//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Rules
    {
        [MethodImpl(Inline)]
        public static Rule<A,C> rule<A,C>(TermId id, Proposition<A,C>[] terms)
            where A : IEquatable<A>
            where C : IEquatable<C>
                => new Rule<A,C>(id,terms);

    }
}