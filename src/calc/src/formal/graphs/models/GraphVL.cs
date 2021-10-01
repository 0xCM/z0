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
        public class Graph<V,L>
            where V : unmanaged, IVertex, IEquatable<V>
            where L : unmanaged, IEquatable<L>
        {
            MutableSet<V> _Vertices;

            MutableSet<Edge<V,L>> _Edges;

            public Graph()
            {
                _Vertices = new();
                _Edges = new();
            }

            public void Connect(Label<L> label, V src, V dst)
            {
                _Vertices.Union(src,dst);
                _Edges.Union(new Edge<V,L>(label,src,dst));
            }
        }
    }
}