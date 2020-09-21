//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericCast;

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