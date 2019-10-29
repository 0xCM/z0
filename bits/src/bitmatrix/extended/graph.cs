//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;
    

    partial class BitMatrix
    {
        /// <summary>
        /// Constructs the a generic graph determined by a generic adjacency bitmatrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline)]
        public static Graph<T> graph<T>(in BitMatrix<T> A)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BitGraph.from(BitMatrix<N8,T>.Load(A.Data));
            else if(typeof(T) == typeof(ushort))
                return BitGraph.from(BitMatrix<N16,T>.Load(A.Data));
            else if(typeof(T) == typeof(uint))
                return BitGraph.from(BitMatrix<N32,T>.Load(A.Data));
            else if(typeof(T) == typeof(uint))
                return BitGraph.from(BitMatrix<N64,T>.Load(A.Data));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Constructs a 16-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix8 A)
            => BitGraph.from(natural(A));            

        /// <summary>
        /// Constructs a 16-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix16 A)
            => BitGraph.from(natural(A));            

        /// <summary>
        /// Constructs a 32-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix32 A)
            => BitGraph.from(natural(A));            

        /// <summary>
        /// Constructs a 64-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix64 A)
            => BitGraph.from(natural(A));            

    }

}