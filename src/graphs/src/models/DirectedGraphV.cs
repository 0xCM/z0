//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Graphs
{
    using System;

    public class DirectedGraph<V>
        where V : unmanaged, IVertex, IEquatable<V>
    {
        MutableSet<V> _Vertices;

        MutableSet<Edge<V>> _Edges;

        public DirectedGraph()
        {
            _Vertices = new();
            _Edges = new();
        }

        public void Connect(Label label, V src, V dst)
        {
            _Vertices.Union(src,dst);
            _Edges.Union(new Edge<V>(label, src,dst));
        }

        public void Trace(EdgeReader<V> f)
        {
            foreach(var e in _Edges)
                f(e);
        }
    }
}