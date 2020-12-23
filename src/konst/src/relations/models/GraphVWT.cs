//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static NumericCast;

    public class Graph<V,W,T>
        where V : unmanaged
        where W : unmanaged
        where T : unmanaged
    {
        readonly Node<V,T>[] Nodes;

        readonly Link<V,W>[] Edges;

        public Graph(Node<V,T>[] vertices, Link<V,W>[] edges)
        {
            Nodes = vertices;
            Edges = edges;
        }

        /// <summary>
        /// Specifies the edges declared by the graph
        /// </summary>
        public int EdgeCount
            => Edges.Length;

        /// <summary>
        /// Specifies the number of vertices declared by the graph
        /// </summary>
        public int VertexCount
            => Nodes.Length;

        /// <summary>
        /// Looks up a vertex based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        [MethodImpl(Inline)]
        public ref Node<V,T> Vertex(V index)
            => ref Nodes[force<V,ulong>(index)];

        /// <summary>
        /// Looks up an edge based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        [MethodImpl(Inline)]
        public ref Link<V,W> Edge(int index)
            => ref Edges[index];

        /// <summary>
        /// Looks up a vertex based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        public ref Node<V,T> this[V index]
        {
            [MethodImpl(Inline)]
            get => ref Vertex(index);
        }
    }

}