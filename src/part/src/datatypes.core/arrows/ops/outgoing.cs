//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Arrows
    {
        /// <summary>
        /// Finds the edges in a graph that emit from an identified vertex
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="target">The index of the target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        public static ReadOnlySpan<Arrow<V>> outgoing<V>(Graph<V> graph, V source)
            where V : unmanaged
        {
            var count = graph.EdgeCount;
            var buffer = alloc<Arrow<V>>(count);
            Span<Arrow<V>> edges = buffer;
            var j = 0;
            for(var i = 0; i<count; i++)
            {
                ref readonly var edge = ref graph.Edge(i);
                if(edge.Source.Equals(source))
                    seek(edges,j++) = edge;
            }
            return slice(edges,0, j);
        }
    }
}