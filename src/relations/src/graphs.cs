//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Graphs;

    using static Root;

    [ApiHost]
    public readonly struct graphs
    {
        [MethodImpl(Inline)]
        internal static uint hash<T>(T src)
            => alg.hash.calc(core.u64(src));

        [MethodImpl(Inline)]
        public static Digraph digraph(params Edge[] edges)
            => new Digraph(edges);

        [MethodImpl(Inline)]
        public static LabeledEdge<V> edge<V>(Label label, V src, V dst)
            where V : unmanaged, ILabeledVertex, IEquatable<V>
                => new LabeledEdge<V>(label,src,dst);

        [MethodImpl(Inline), Op]
        public static Vertex16 vertex(ushort key)
            => new Vertex16(key);

        [MethodImpl(Inline)]
        public static LabeledVertex<V> node<V>(Label name, V value)
            where V : unmanaged, IEquatable<V>
                => new LabeledVertex<V>(name,value);

        [MethodImpl(Inline)]
        public static LabeledDigraph<V> digraph<V>()
            where V : unmanaged, ILabeledVertex, IEquatable<V>
                => new LabeledDigraph<V>();
    }
}