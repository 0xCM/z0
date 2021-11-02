//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Graphs
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct graphs
    {
        [MethodImpl(Inline)]
        internal static uint hash<T>(T src)
            => alg.hash.calc(core.u64(src));

        [MethodImpl(Inline)]
        public static Digraph digraph(params Edge[] edges)
            => new Digraph(edges);

        [MethodImpl(Inline)]
        public static LabeledEdge<V> edge<V>(Label label, V src, V dst)
            where V : unmanaged, IVertex, IEquatable<V>
                => new LabeledEdge<V>(label,src,dst);

        [MethodImpl(Inline)]
        public static LabeledVertex<V> node<V>(Label name, V value)
            where V : unmanaged, IEquatable<V>
                => new LabeledVertex<V>(name,value);

        [MethodImpl(Inline)]
        public static LabeledDigraph<V> digraph<V>()
            where V : unmanaged, IVertex, IEquatable<V>
                => new LabeledDigraph<V>();
    }
}