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

    /// <summary>
    /// Defines a graph in which data may be associated with each node
    /// </summary>
    /// <typeparam name="I">The vertex index type</typeparam>
    /// <typeparam name="T">The node payload type</typeparam>
    public class Graph<I,T>
        where I : unmanaged
        where T : unmanaged
    {
        readonly Node<I,T>[] Nodes;

        readonly Link<I>[] Edges;

        public Graph(Node<I,T>[] nodes, Link<I>[] edges)
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
        public ref Node<I,T> Vertex(I index)
            => ref Nodes[force<I,ulong>(index)];

        /// <summary>
        /// Looks up an edge based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        [MethodImpl(Inline)]
        public ref Link<I> Edge(int index)
            => ref Edges[index];

        /// <summary>
        /// Looks up a vertex based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        public ref Node<I,T> this[I index]
        {
            [MethodImpl(Inline)]
            get => ref Vertex(index);
        }
    }
}