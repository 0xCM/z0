//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class BitGraph
    {

        /// <summary>
        /// Constructs a graph from an adjacency bitmatrix of natural order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dim">The dimension of the matrix</param>
        /// <param name="v">An arbitrary value to help type inference</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="N">The dimension type</typeparam>
        /// <typeparam name="T">The source matrix element type</typeparam>
        internal static Graph<T> from<N,T>(BitMatrix<N,T> src, N dim = default)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var n = (int)dim.value;
            var nodes = Graph.Vertices<T>(n);
            var edges = new List<Edge<T>>();
            for(var row = 0; row < n; row++)
            for(var col = 0; col < n; col++)
                if(src[row,col])
                    edges.Add(Graph.Connect(nodes[row], nodes[col]));
            return Graph.Define(nodes, edges);
        }

        internal static Graph<V> from<V,T>(RowBits<T> src)
            where V : unmanaged
            where T : unmanaged
        {
            var m = src.RowCount;
            var n = src.RowWidth;
            
            var nodes = Graph.Vertices<V>(m);
            var edges = new List<Edge<V>>();
            for(var row = 0; row < m; row++)
            for(var col = 0; col < n; col++)
                if(src[row,col])
                    edges.Add(Graph.Connect(nodes[row], nodes[col]));
            return Graph.Define(nodes, edges);
        }
    }
}
