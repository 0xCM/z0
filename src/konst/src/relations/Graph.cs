//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static NumericCast;

    /// <summary>
    /// Defines the primary API surface for manipulated graphs and related elements
    /// </summary>
    public readonly struct Graphs
    {
        /// <summary>
        /// Defines a weighted edge from an index-identified source to an index identified target
        /// </summary>
        /// <param name="src">The source index</param>
        /// <param name="dst">The target index</param>
        /// <typeparam name="S">The vertex index type</typeparam>
        [MethodImpl(Inline)]
        public static Link<S,T> edge<S,T>(S src, T dst)
            where S : unmanaged
            where T : unmanaged
                => (src,dst);

        /// <summary>
        /// Creates a graph from supplied vertices and edges and assumes the vertices are already appropriately sorted
        /// </summary>
        /// <param name="vertices">The vertices in the graph</param>
        /// <param name="edges">The edges that connect the vertices</param>
        [MethodImpl(Inline)]
        public static Graph<V,T> define<V,T>(Span<Node<V,T>> vertices, IEnumerable<Link<V>> edges)
            where V : unmanaged
            where T : unmanaged
                => new Graph<V,T>(vertices.ToArray(), edges.ToArray());

        /// <summary>
        /// Creates a graph from supplied vertices and edges
        /// </summary>
        /// <param name="vertices">The vertices in the graph</param>
        /// <param name="edges">The edges that connect the vertices</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]
        public static Graph<V> define<V>(Span<Node<V>> vertices, IEnumerable<Link<V>> edges)
            where V : unmanaged
                => new Graph<V>(vertices.ToArray(), edges.ToArray());

        /// <summary>
        /// Defines an edge from an index-identified source to an index identified target
        /// </summary>
        /// <param name="source">The source index</param>
        /// <param name="target">The target index</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]
        public static Link<V> edge<V>(V source, V target)
            where V : unmanaged
                => (source,target);

        /// <summary>
        /// Connects a source vertex to a target vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        /// <param name="dst">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="T">The vertex payload type</typeparam>
        [MethodImpl(Inline)]
        public static Link<T> connect<T>(Node<T> src, Node<T> dst)
            where T : unmanaged
                => new Link<T>(src, dst);

        /// <summary>
        /// Connects a source vertex to a target vertex
        /// </summary>
        /// <param name="source">The source vertex</param>
        /// <param name="target">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="T">The vertex payload type</typeparam>
        [MethodImpl(Inline)]
        public static Link<V> connect<V,T>(in Node<V,T> source, in Node<V,T> target)
            where V : unmanaged
            where T : unmanaged
                => new Link<V>(source.Index, target.Index);

        /// <summary>
        /// Connects a source vertex to a target vertex
        /// </summary>
        /// <param name="source">The source vertex</param>
        /// <param name="target">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        public static Link<V> connect<V>(in Node<V> source, in Node<V> target)
            where V : unmanaged
                => new Link<V>(source.Content, target.Content);

        /// <summary>
        /// Creates a vertex without payload
        /// </summary>
        /// <param name="index">The index of the vertex that servies as a
        /// unique identifier within the context of a graph</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Node<V> vertex<V>(V index)
            where V : unmanaged
                => new Node<V>(index);

        /// <summary>
        /// Defines a vertex sequence with a specified length
        /// </summary>
        /// <param name="count">The number of virtices in the sequence</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Span<Node<V>> vertices<V>(int count)
            where V : unmanaged
        {
            Span<Node<V>> dst = new Node<V>[count];
            for(var i=0; i<count; i++)
                dst[i] = new Node<V>(force<V>(i));
            return dst;
        }

        /// <summary>
        /// Defines a vertex with payload for each source item
        /// </summary>
        /// <param name="s0">The first index assigned</param>
        /// <param name="data">The vertex payloads</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Span<Node<V,T>> vertices<V,T>(V s0, params T[] data)
            where V : unmanaged
            where T : unmanaged
        {
            var start = force<V,ulong>(s0);
            Span<Node<V,T>> dst = new Node<V,T>[data.Length];

            for(var i=0; i<data.Length; i++, start++)
                dst[i] = new Node<V,T>(force<V>(start),data[i]);
            return dst;
        }

        /// <summary>
        /// Creates a vertex with payload
        /// </summary>
        /// <param name="index">The index of the vertex that servies as a
        /// unique identifier within the context of a graph</param>
        /// <typeparam name="V">The index type</typeparam>
        /// <typeparam name="V">The payload type</typeparam>
        [MethodImpl(Inline)]
        public static Node<V,T> vertex<V,T>(V index, T data)
            where V : unmanaged
            where T : unmanaged
                => new Node<V, T>(index,data);

        /// <summary>
        /// Finds the edges in a graph that target an identified vertex
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="target">The index of the target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        public static ReadOnlySpan<Link<V>> incoming<V>(Graph<V> graph, V target)
            where V : unmanaged
        {
            var count = graph.EdgeCount;
            Span<Link<V>> edges = new Link<V>[count];
            var j = 0;
            for(var i = 0; i<count; i++)
            {
                ref readonly var edge = ref graph.Edge(i);
                if(edge.Target.Equals(target))
                    edges[j++] = edge;
            }
            return edges.Slice(0, j);
        }

        /// <summary>
        /// Finds the edges in a graph that emit from an identified vertex
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="target">The index of the target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        public static ReadOnlySpan<Link<V>> outgoing<V>(Graph<V> graph, V source)
            where V : unmanaged
        {
            var count = graph.EdgeCount;
            Span<Link<V>> edges = new Link<V>[count];
            var j = 0;
            for(var i = 0; i<count; i++)
            {
                ref readonly var edge = ref graph.Edge(i);
                if(edge.Source.Equals(source))
                    edges[j++] = edge;
            }
            return edges.Slice(0, j);
        }

        /// <summary>
        /// Renders a graph using basic graphviz format
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="label">An optional label for the graph</param>
        /// <typeparam name="V">The verex index type</typeparam>
        public static string format<V>(Graph<V> src, string label = null)
            where V : unmanaged
        {
            var count = src.EdgeCount;
            var fmt = new StringBuilder();
            fmt.AppendLine("digraph " +(label ?? "g") + "   {");
            for(var i=0; i< count; i++)
            {
                ref readonly var edge = ref src.Edge(i);
                fmt.AppendLine($"    {edge.Source} -> {edge.Target}");
            }
            fmt.AppendLine("}");
            return fmt.ToString();
        }
    }
}