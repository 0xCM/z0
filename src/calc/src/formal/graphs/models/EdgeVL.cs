//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Graphs
    {
        public interface IEdge
        {

        }

        public interface IEdge<V> : IEdge
            where V : IEquatable<V>
        {
            V Source {get;}

            V Target {get;}
        }

        public interface IEdge<V,L> : IEdge<V>
            where L : unmanaged, IEquatable<L>
            where V : IEquatable<V>
        {
            Label<L> Label {get;}
        }

        public readonly struct Edge<V,L> : IEdge<V,L>, IEquatable<Edge<V,L>>
            where V : IVertex, IEquatable<V>
            where L : unmanaged, IEquatable<L>
        {
            public Label<L> Label {get;}

            public V Source {get;}

            public V Target {get;}

            [MethodImpl(Inline)]
            public Edge(Label<L> label, V src, V dst)
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