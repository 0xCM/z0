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

    using static Konst;
    using static NumericCast;

    /// <summary>
    /// Defines a directed graph parameterized by the vertex index type
    /// </summary>
    /// <typeparam name="V">The vertex index type</typeparam>
    /// <remarks>For terminology consult, for example, https://xlinux.nist.gov/dads/<remarks>
    public class Graph<V>
        where V : unmanaged
    {
        readonly Node<V>[] Vertices;

        readonly Link<V>[] Edges;

        readonly Nodes<V> Index;

        [MethodImpl(Inline)]
        internal Graph(Node<V>[] vertices, Link<V>[] edges)
        {
            Vertices = vertices;
            Edges = edges;
            Index = Nodes<V>.Build(vertices, edges);
        }

        /// <summary>
        /// Retrieves the indices of a targets' source vertices
        /// </summary>
        /// <param name="source">The source vertex</param>
        [MethodImpl(Inline)]
        public List<V> Sources(V target)
            => Index.Sources(target);

        /// <summary>
        /// Retrieves the indices of a sources' target vertices
        /// </summary>
        /// <param name="source">The source vertex</param>
        [MethodImpl(Inline)]
        public List<V> Targets(V source)
            => Index.Targets(source);

        /// <summary>
        /// Looks up a vertex based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        [MethodImpl(Inline)]
        public ref Node<V> Vertex(V index)
            => ref Vertices[force<V,ulong>(index)];

        /// <summary>
        /// Looks up an edge based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        [MethodImpl(Inline)]
        public ref Link<V> Edge(int index)
            => ref Edges[index];

        /// <summary>
        /// Looks up a vertex based on its index
        /// </summary>
        /// <param name="index">The vertex index</param>
        public ref Node<V> this[V index]
        {
            [MethodImpl(Inline)]
            get => ref Vertex(index);
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
            => Vertices.Length;

        /// <summary>
        /// Computes the in-degree of a vertex; i.e. the count of incoming vertices
        /// </summary>
        /// <param name="target">The target vector</param>
        [MethodImpl(Inline)]
        public int InDegree(V target)
            => Sources(target).Count;

        /// <summary>
        /// Computes the out-degree of a vertex; i.e. the count of outgoing vertices
        /// </summary>
        /// <param name="source">The source vector</param>
        [MethodImpl(Inline)]
        public int OutDegree(V source)
            => Targets(source).Count;

        /// <summary>
        /// Determines whether a vertex is disconnected from the graph
        /// </summary>
        /// <param name="vertex">The vertext to test</param>
        [MethodImpl(Inline)]
        public bool IsIsolated(V vertex)
            => InDegree(vertex) == 0 && OutDegree(vertex) == 0;

        /// <summary>
        /// Determines whether the vertex is a sink, i.e. has no outgoing edges
        /// </summary>
        /// <param name="vertex">The vertex to test</param>
        /// <remarks>An isolated node in this context is not considered to be a
        /// sink (or source) so "degenerate" sinks are excluded
        /// </remarks>
        [MethodImpl(Inline)]
        public bool IsSink(V vertex)
            => OutDegree(vertex) == 0 && InDegree(vertex) != 0;

        /// <summary>
        /// Determines whether the vertex is a source, i.e. has only outgoing edges
        /// </summary>
        /// <param name="vertex">The vertex to test</param>
        /// <remarks>An isolated node in this context is not considered to be a
        /// sink (or source) so "degenerate" sources are excluded
        /// </remarks>
        [MethodImpl(Inline)]
        public bool IsSource(V vertex)
            => OutDegree(vertex) != 0 && InDegree(vertex) == 0;

        /// <summary>
        /// Traverses the graph until a sink is reached, a cycle is  detected,
        /// or an optionally-specified vertex is reached
        /// </summary>
        /// <param name="v0">The start vertex</param>
        /// <param name="traversed">The traversal action</param>
        /// <param name="vEnd">An optional endpoint</param>
        public void Traverse(V v0, Action<V> traversed, V vEnd = default)
        {
            foreach(var target in Targets(v0))
            {
                traversed(target);

                if(target.Equals(v0) || target.Equals(vEnd))
                    break;

                Traverse(target, traversed, v0);
            }
        }

        /// <summary>
        /// Computes the path from a source vertex to a sink, a specified endpoint or when a cycle is detected
        /// </summary>
        /// <param name="v0">The start vertex</param>
        /// <param name="vEnd">An optional endpoint</param>
        public IEnumerable<V> Path(V v0, V vEnd = default)
        {
            foreach(var target in Targets(v0))
            {
                yield return target;

                if(target.Equals(v0) || target.Equals(vEnd))
                    break;

                foreach(var subnode in Path(target,  v0))
                    yield return subnode;
            }
        }
    }
}