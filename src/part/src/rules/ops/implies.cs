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
        public static Implication<I,A,C> implies<I,A,C>(I index, A @if, C then)
            where I : unmanaged, IEquatable<I>
            where A : IEquatable<A>
            where C : IEquatable<C>
                => new Implication<I,A,C>(index, @if, then);

    }
}