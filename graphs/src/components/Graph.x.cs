//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Arrows;

    public static class GraphX
    {
        [MethodImpl(Inline)]
        public static void Deconstruct<T>(this Edge<T> edge, out T source, out T target)
            where T : unmanaged
        {
            source = edge.Source;
            target = edge.Target;
        }

        /// <summary>
        /// Produces an edge that connects a source vertex to a target vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        /// <param name="dst">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="T">The vertex payload type</typeparam>
        [MethodImpl(Inline)]
        public static Edge<V> Connect<V,T>(this Vertex<V,T> src, Vertex<V,T> dst)
            where V : unmanaged
            where T : unmanaged
                => Graph.connect(src,dst);

        /// <summary>
        /// Produces an edge that connects a source vertex to a target vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        /// <param name="dst">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]
        public static Edge<V> Connect<V>(this Vertex<V> src, Vertex<V> dst)
            where V : unmanaged
                => Graph.connect(src,dst);       

        /// <summary>
        /// Renders a graph using basic graphviz format
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="label">An optional label for the graph</param>
        /// <typeparam name="V">The verex index type</typeparam>
        public static string Format<V>(this Graph<V> graph, string label = null)
            where V : unmanaged
                => Graph.format(graph,label);

        /// <summary>
        /// Finds the edges in a graph that target an identified vertex
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="target">The index of the target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<Edge<V>> Incoming<V>(this Graph<V> graph, V target)
            where V : unmanaged
                => Graph.incoming(graph, target);

        /// <summary>
        /// Finds the edges in a graph that emit from an identified vertex
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="target">The index of the target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<Edge<V>> Outgoing<V>(this Graph<V> graph, V source)
            where V : unmanaged
                => Graph.outgoing(graph, source);
    }
}