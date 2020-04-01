//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Core;
    
    /// <summary>
    /// Defines a graph in which data may be associated with each node and edges are weighted
    /// </summary>
    /// <typeparam name="V">The vertex index type</typeparam>
    /// <typeparam name="W">The weight type</typeparam>
    /// <typeparam name="T">The vertext payload type</typeparam>
    public class Graph<V,W,T>
        where V : unmanaged
        where W : unmanaged
        where T : unmanaged
    {
        readonly Vertex<V,T>[] vertices;

        readonly Edge<V,W>[] edges;

        internal Graph(Vertex<V,T>[] vertices, Edge<V,W>[] edges)
        {
            this.vertices = vertices;
            this.edges = edges;            
        }

        /// <summary>
        /// Specifies the edges declared by the graph
        /// </summary>
        public int EdgeCount
            => edges.Length;

        /// <summary>
        /// Specifies the number of vertices declared by the graph
        /// </summary>
        public int VertexCount
            => vertices.Length;

        /// <summary>
        /// Looks up a vertex based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        [MethodImpl(Inline)]
        public ref Vertex<V,T> Vertex(V index)
            => ref vertices[convert<V,ulong>(index)];

        /// <summary>
        /// Looks up an edge based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        [MethodImpl(Inline)]
        public ref Edge<V,W> Edge(int index)
            => ref edges[index];

        /// <summary>
        /// Looks up a vertex based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        public ref Vertex<V,T> this[V index]
        {
            [MethodImpl(Inline)]
            get => ref Vertex(index);
        }
    }
 
}