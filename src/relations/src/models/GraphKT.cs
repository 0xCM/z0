//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a graph in which data may be associated with each node
    /// </summary>
    /// <typeparam name="K">The vertex index type</typeparam>
    /// <typeparam name="T">The node payload type</typeparam>
    public class Graph<K,T>
        where K : unmanaged
        where T : unmanaged
    {
        readonly Node<K,T>[] Nodes;

        readonly Arrow<Node<K>>[] Edges;

        public Graph(Node<K,T>[] nodes, Arrow<Node<K>>[] edges)
        {
            Nodes = nodes;
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
        public ref Node<K,T> Vertex(K index)
            => ref Nodes[core.bw32(index)];

        /// <summary>
        /// Looks up an edge based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        [MethodImpl(Inline)]
        public ref Arrow<Node<K>> Edge(uint index)
            => ref Edges[index];

        /// <summary>
        /// Looks up a vertex based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        public ref Node<K,T> this[K index]
        {
            [MethodImpl(Inline)]
            get => ref Vertex(index);
        }
    }
}