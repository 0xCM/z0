//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Renders a graph using basic graphviz format
        /// </summary>
        /// <param name="graph">The declaring graph</param>
        /// <param name="label">An optional label for the graph</param>
        /// <typeparam name="V">The verex index type</typeparam>
        public static string Format<V>(this Graph<V> graph, string label = null)
            where V : unmanaged
                => Graph.format(graph,label);
    }
}