//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    /// <summary>
    /// Defines the primary API surface for manipulated graphs
    /// and related elements
    /// </summary>
    public static class Graph
    {
        /// <summary>
        /// Creates a graph from supplied vertices and edges, sorting the provided vertices according to their index
        /// </summary>
        /// <param name="vertices">The vertices in the graph</param>
        /// <param name="edges">The edges that connect the vertices</param>
        [MethodImpl(Inline)]    
        public static Graph<V,T> define<V,T>(IEnumerable<Vertex<V,T>> vertices, IEnumerable<Edge<V>> edges)
            where V : unmanaged
            where T : unmanaged
                => new Graph<V,T>(vertices.OrderBy(x => x.Index,PrimalComparer.Get<V>()).ToArray(), edges.ToArray());

        /// <summary>
        /// Creates a graph from supplied vertices and edges and assumes the vertices are already appropriately sorted
        /// </summary>
        /// <param name="vertices">The vertices in the graph</param>
        /// <param name="edges">The edges that connect the vertices</param>
        [MethodImpl(Inline)]    
        public static Graph<V,T> define<V,T>(Span<Vertex<V,T>> vertices, IEnumerable<Edge<V>> edges)
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
        public static Graph<V> define<V>(Span<Vertex<V>> vertices, IEnumerable<Edge<V>> edges)
            where V : unmanaged
                => new Graph<V>(vertices.ToArray(), edges.ToArray());

        /// <summary>
        /// Creates a graph from supplied vertices and edges, sorting the provided vertices according to their index
        /// </summary>
        /// <param name="vertices">The vertices in the graph</param>
        /// <param name="edges">The edges that connect the vertices</param>
        public static Graph<V> define<V>(IEnumerable<Vertex<V>> vertices, IEnumerable<Edge<V>> edges)
            where V : unmanaged
                => new Graph<V>(vertices.OrderBy(x => x.Index,PrimalComparer.Get<V>()).ToArray(), edges.ToArray());
        
        public static Graph<V> define<V>(params Edge<V>[] edges)
            where V : unmanaged
        {
            var vertices = edges.Select(e => e.Source).Union(edges.Select(e => e.Target)).Select(x => new Vertex<V>(x));
            return define(vertices,edges);
        }

        public static Graph<V,W,T> define<V,W,T>(IEnumerable<Vertex<V,T>> vertices, IEnumerable<Edge<V,W>> edges)
            where V : unmanaged
            where W : unmanaged
            where T : unmanaged
                => new Graph<V,W,T>(vertices.OrderBy(x => x.Index,PrimalComparer.Get<V>()).ToArray(), edges.ToArray());

        /// <summary>
        /// Defines an edge from an index-identified source to an index identified target
        /// </summary>
        /// <param name="source">The source index</param>
        /// <param name="target">The target index</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]    
        public static Edge<V> edge<V>(V source, V target)
            where V : unmanaged
                => (source,target);

        /// <summary>
        /// Defines a weighted edge from an index-identified source to an index identified target
        /// </summary>
        /// <param name="source">The source index</param>
        /// <param name="target">The target index</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]    
        public static Edge<V,W> edge<V,W>(V source, V target, W weight)
            where V : unmanaged
            where W : unmanaged
                => (source,target,weight);

        /// <summary>
        /// Connects a source vertex to a target vertex
        /// </summary>
        /// <param name="source">The source vertex</param>
        /// <param name="target">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="T">The vertex payload type</typeparam>
        [MethodImpl(Inline)]    
        public static Edge<V> connect<V,T>(in Vertex<V,T> source, in Vertex<V,T> target)
            where V : unmanaged
            where T : unmanaged
                => new Edge<V>(source.Index,target.Index);

        /// <summary>
        /// Connects a source vertex to a target vertex
        /// </summary>
        /// <param name="source">The source vertex</param>
        /// <param name="target">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        public static Edge<V> connect<V>(in Vertex<V> source, in Vertex<V> target)
            where V : unmanaged
                => new Edge<V>(source.Index,target.Index);

        /// <summary>
        /// Creates a vertex without payload
        /// </summary>
        /// <param name="index">The index of the vertex that servies as a 
        /// unique identifier within the context of a graph</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Vertex<V> vertex<V>(V index)
            where V : unmanaged
                => new Vertex<V>(index);

        /// <summary>
        /// Defines a vertex sequence with a specified length
        /// </summary>
        /// <param name="count">The number of virtices in the sequence</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Span<Vertex<V>> vertices<V>(int count)
            where V : unmanaged
        {
            Span<Vertex<V>> dst = new Vertex<V>[count];
            for(var i=0; i<count; i++)
                dst[i] = new Vertex<V>(convert<V>(i));
            return dst;
        }

        /// <summary>
        /// Defines a vertex with payload for each source item
        /// </summary>
        /// <param name="s0">The first index assigned</param>
        /// <param name="data">The vertex payloads</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Span<Vertex<V,T>> vertices<V,T>(V s0, params T[] data)
            where V : unmanaged
            where T : unmanaged
        {
            var start = convert<V,ulong>(s0);
            Span<Vertex<V,T>> dst = new Vertex<V,T>[data.Length];

            for(var i=0; i<data.Length; i++, start++)
                dst[i] = new Vertex<V,T>(convert<V>(start),data[i]);
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
        public static Vertex<V,T> vertex<V,T>(V index, T data)
            where V : unmanaged
            where T : unmanaged
                => new Vertex<V, T>(index,data);

        /// <summary>
        /// Finds the edges in a graph that target an identified vertex
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="target">The index of the target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        public static ReadOnlySpan<Edge<V>> incoming<V>(Graph<V> graph, V target)
            where V : unmanaged
        {            
            var count = graph.EdgeCount;
            Span<Edge<V>> edges = new Edge<V>[count];
            var j = 0;
            for(var i = 0; i<count; i++)
            {
                ref readonly var edge = ref graph.Edge(i);
                if(gmath.eq(edge.Target, target))
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
        public static ReadOnlySpan<Edge<V>> outgoing<V>(Graph<V> graph, V source)
            where V : unmanaged
        {            
            var count = graph.EdgeCount;
            Span<Edge<V>> edges = new Edge<V>[count];
            var j = 0;
            for(var i = 0; i<count; i++)
            {
                ref readonly var edge = ref graph.Edge(i);
                if(gmath.eq(edge.Source, source))
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
            var text = sbuild();
            text.AppendLine("digraph " +(label ?? "g") + "   {");
            for(var i=0; i< count; i++)
            {
                ref readonly var edge = ref src.Edge(i);
                text.AppendLine($"    {edge.Source} -> {edge.Target}");                
            }
            text.AppendLine("}");
            return text.ToString();
        }

    }
}