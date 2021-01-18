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

    using static Part;

    /// <summary>
    /// Defines the primary API surface for manipulated graphs and related elements
    /// </summary>
    [ApiHost]
    public readonly struct Graphs
    {
        const NumericKind Closure = UnsignedInts;

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


        [MethodImpl(Inline), Op]
        public static uint hash32(LinkType src)
            => alg.hash.calc(src.Source) ^ alg.hash.calc(src.Target) ^ alg.hash.calc(src.Kind);

        [MethodImpl(Inline), Op]
        public static ulong hash64(LinkType src)
            => alg.hash.calc(src.Kind, src.Source, src.Target);

        [MethodImpl(Inline), Op]
        public static bool eq(LinkType a, LinkType b)
            => a.Source == b.Source && a.Target == b.Target;

        [MethodImpl(Inline)]
        public static LinkType type<T>(T t = default)
            => new LinkType<T>(typeof(T), typeof(T));

        [MethodImpl(Inline), Op]
        public static LinkType type(Type src, Type dst)
            => new LinkType(src,dst);

        [MethodImpl(Inline), Op]
        public static LinkType type(Type src, Type dst, Type kind)
            => new LinkType(src,dst, kind);

        [MethodImpl(Inline)]
        public static LinkType type<S,T>()
            => new LinkType<S,T>(typeof(S), typeof(T));

        [MethodImpl(Inline)]
        public static LinkType type<S,T,K>()
            where K : unmanaged
                => new LinkType<S,T,K>(typeof(S), typeof(T), typeof(K));

        [MethodImpl(Inline)]
        public static string identifier<S,T>(Link<S,T> link)
            => Relations.RenderLink<S,T>().Format(link.Source, link.Target);

        [MethodImpl(Inline), Closures(Closure)]
        public static string identifier<T>(Link<T> link)
            => Relations.RenderLink<T>().Format(link.Source, link.Target);
    }
}