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
        [MethodImpl(Inline)]
        public static Implication<A,C> implies<A,C>(A @if, C then)
            where A : IEquatable<A>
            where C : IEquatable<C>
                => new Implication<A,C>(@if, then);
    }
}