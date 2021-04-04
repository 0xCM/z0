//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Arrows
    {
        /// <summary>
        /// Creates a graph from supplied vertices and edges and assumes the vertices are already appropriately sorted
        /// </summary>
        /// <param name="vertices">The vertices in the graph</param>
        /// <param name="edges">The edges that connect the vertices</param>
        [MethodImpl(Inline)]
        public static Graph<V,T> graph<V,T>(Index<Node<V,T>> vertices, Index<Arrow<V>> edges)
            where V : unmanaged
            where T : unmanaged
                => new Graph<V,T>(vertices, edges);

        /// <summary>
        /// Creates a graph from supplied vertices and edges
        /// </summary>
        /// <param name="vertices">The vertices in the graph</param>
        /// <param name="edges">The edges that connect the vertices</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]
        public static Graph<V> graph<V>(Index<Node<V>> vertices, Index<Arrow<V>> edges)
            where V : unmanaged
                => new Graph<V>(vertices, edges);
    }
}