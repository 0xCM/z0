//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Graphs
    {
        public readonly struct Edge<V> : IEdge<V>, IEquatable<Edge<V>>
            where V : unmanaged, IVertex, IEquatable<V>
        {
            public Label Label {get;}

            public V Source {get;}

            public V Target {get;}

            [MethodImpl(Inline)]
            public Edge(Label label, V src, V dst)
            {
                Label = label;
                Source = src;
                Target = dst;
            }

            [MethodImpl(Inline)]
            public Edge(V src, V dst)
            {
                Label = default;
                Source = src;
                Target = dst;
            }

            [MethodImpl(Inline)]
            public bool Equals(Edge<V> src)
                => Source.Equals(src.Source) && Target.Equals(src.Target);

            [MethodImpl(Inline)]
            public static implicit operator Edge<V>((V a, V b) src)
                => new Edge<V>(src.a, src.b);
        }
    }
}