//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    using static Root;
    using static Nats;

    public static class BitGraph
    {
        /// <summary>
        /// Constructs the a generic graph determined by a generic adjacency bitmatrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline)]
        public static Graph<T> define<T>(in BitMatrix<T> A)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return define(BitMatrix.load(n8,A.Data));
            else if(typeof(T) == typeof(ushort))
                return define(BitMatrix.load(n16,A.Data));
            else if(typeof(T) == typeof(uint))
                return define(BitMatrix.load(n32,A.Data));
            else if(typeof(T) == typeof(ulong))
                return define(BitMatrix.load(n64,A.Data));
            else
                throw Unsupported.define<T>();
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
        internal static Graph<T> define<N,T>(BitMatrix<N,T> src, N dim = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var n = (int)dim.NatValue;
            var nodes = Graph.vertices<T>(n);
            var edges = new List<Edge<T>>();
            for(var row = 0; row < n; row++)
            for(var col = 0; col < n; col++)
                if(src[row,col])
                    edges.Add(Graph.connect(nodes[row], nodes[col]));
            return Graph.define(nodes, edges);
        }

        /// <summary>
        /// Constructs a 8-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> define(BitMatrix8 A)
            => define(BitMatrix.natural(A));            

        /// <summary>
        /// Constructs a 16-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> define(BitMatrix16 A)
            => define(BitMatrix.natural(A));            

        /// <summary>
        /// Constructs a 32-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> define(BitMatrix32 A)
            => define(BitMatrix.natural(A));            

        /// <summary>
        /// Constructs a 64-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> define(BitMatrix64 A)
            => define(BitMatrix.natural(A));            

        public static Graph<V> define<V,T>(in RowBits<T> src)
            where V : unmanaged
            where T : unmanaged
        {
            var m = src.RowCount;
            var n = src.RowWidth;
            
            var nodes = Graph.vertices<V>(m);
            var edges = new List<Edge<V>>();
            for(var row = 0; row < m; row++)
            for(var col = 0; col < n; col++)
                if(src[row,col])
                    edges.Add(Graph.connect(nodes[row], nodes[col]));
            return Graph.define(nodes, edges);
        }
    }
}