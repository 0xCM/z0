//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;

    using static core;

    partial struct Graphs
    {
        /*
            A graph is a pair G = (V, E), where V
            is a set whose elements are called vertices (singular: vertex), and E is a set
            of paired vertices, whose elements are called edges or links.

            The vertices x and y of an edge e(x, y) are called the endpoints of the edge. The edge is
            said to join x and y and to be incident on x and y. A vertex may belong to no edge,
            in which case it is not joined to any other vertex
        */

        public class Graph<V>
            where V : unmanaged, IVertex, IEquatable<V>
        {
            MutableSet<V> _Vertices;

            MutableSet<Edge<V>> _Edges;

            public Graph()
            {
                _Vertices = new();
                _Edges = new();
            }

            public void Connect(V src, V dst)
            {
                _Vertices.Union(src,dst);
                _Edges.Union(new Edge<V>(src,dst));
            }

            public void Trace(Action<Edge<V>> f)
            {
                iter(_Edges, f);
            }
        }
    }
}