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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Consequent<C> consequence<C>(TermId id, C term)
            where C : IEquatable<C>
                => new Consequent<C>(id, term);
    }
}