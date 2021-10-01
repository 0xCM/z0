//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost("models.graphs")]
    public readonly partial struct Graphs
    {
        [MethodImpl(Inline)]
        internal static uint hash<T>(T src)
            => alg.hash.calc(u64(src));

        public static Graph<V> graph<V>()
            where V : unmanaged, IVertex, IEquatable<V>
                => new Graph<V>();

        public static Graph<V,L> graph<V,L>()
            where V : unmanaged, IVertex, IEquatable<V>
            where L : unmanaged, IEquatable<L>
                => new Graph<V,L>();
    }
}