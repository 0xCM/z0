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
        public readonly struct Edge<V,L> : IEdge<V>, IEquatable<Edge<V,L>>
            where V : IVertex, IEquatable<V>
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
            public bool Equals(Edge<V,L> src)
                => Source.Equals(src.Source) && Target.Equals(src.Target) && Label.Equals(src.Label);
        }
    }
}