//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Graphs
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct graphs
    {
        [MethodImpl(Inline)]
        internal static uint hash<T>(T src)
            => alg.hash.calc(u64(src));

        [MethodImpl(Inline)]
        public static Edge<V> edge<V>(Label label, V src, V dst)
            where V : unmanaged, IVertex, IEquatable<V>
                => new Edge<V>(label,src,dst);

        [MethodImpl(Inline)]
        public static Vertex<V> node<V>(Label name, V value)
            where V : unmanaged, IEquatable<V>
                => new Vertex<V>(name,value);

        [MethodImpl(Inline)]
        public static DirectedGraph<V> graph<V>()
            where V : unmanaged, IVertex, IEquatable<V>
                => new DirectedGraph<V>();
    }
}