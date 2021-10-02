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
            Label Label {get;}
        }

        public interface IEdge<V> : IEdge
            where V : IEquatable<V>
        {
            V Source {get;}

            V Target {get;}
        }

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