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
        /// Constructs the a generic graph determined by a generic adjacency bitmatrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline)]
        public static Graph<T> from<T>(in BitMatrix<T> A)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return from(BitMatrix<N8,T>.Load(A.Data));
            else if(typeof(T) == typeof(ushort))
                return from(BitMatrix<N16,T>.Load(A.Data));
            else if(typeof(T) == typeof(uint))
                return from(BitMatrix<N32,T>.Load(A.Data));
            else if(typeof(T) == typeof(uint))
                return from(BitMatrix<N64,T>.Load(A.Data));
            else
                throw unsupported<T>();
        }


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
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var n = (int)dim.NatValue;
            var nodes = Graph.Vertices<T>(n);
            var edges = new List<Edge<T>>();
            for(var row = 0; row < n; row++)
            for(var col = 0; col < n; col++)
                if(src[row,col])
                    edges.Add(Graph.Connect(nodes[row], nodes[col]));
            return Graph.Define(nodes, edges);
        }

        /// <summary>
        /// Constructs a 16-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix8 A)
            => BitGraph.from(BitMatrix.natural(A));            

        /// <summary>
        /// Constructs a 16-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix16 A)
            => BitGraph.from(BitMatrix.natural(A));            

        /// <summary>
        /// Constructs a 32-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix32 A)
            => BitGraph.from(BitMatrix.natural(A));            

        /// <summary>
        /// Constructs a 64-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix64 A)
            => BitGraph.from(BitMatrix.natural(A));            

        public static Graph<V> from<V,T>(RowBits<T> src)
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
