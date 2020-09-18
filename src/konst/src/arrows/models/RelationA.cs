//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct Relation<A>
    {
        public readonly A First;

        public readonly A Second;

        public readonly Facets Facets;

        [MethodImpl(Inline)]
        public Relation(A a, A b, Facets facets)
        {
            First = a;
            Second = b;
            Facets = facets;
        }
    }
}