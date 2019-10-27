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
        [MethodImpl(Inline)]
        public static Graph<byte> graph<T>(in BitMatrix<T> A)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BitGraph.FromMatrix(BitMatrix<N8,byte>.Load(A.Bytes));
            else if(typeof(T) == typeof(ushort))
                return BitGraph.FromMatrix(BitMatrix<N16,byte>.Load(A.Bytes));
            else if(typeof(T) == typeof(uint))
                return BitGraph.FromMatrix(BitMatrix<N32,byte>.Load(A.Bytes));
            else if(typeof(T) == typeof(uint))
                return BitGraph.FromMatrix(BitMatrix<N64,byte>.Load(A.Bytes));
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]    
        public static BitMatrix<N8,byte> natural(BitMatrix8 A)
            => BitMatrix<N8,byte>.Load(A.Bytes);

        [MethodImpl(Inline)]    
        public static BitMatrix<N16,byte> natural(BitMatrix16 A)
            => BitMatrix<N16,byte>.Load(A.Bytes);

        [MethodImpl(Inline)]    
        public static BitMatrix<N32,byte> natural(BitMatrix32 A)
            => BitMatrix<N32,byte>.Load(A.Bytes);

        [MethodImpl(Inline)]    
        public static BitMatrix<N64,byte> natural(BitMatrix64 A)
            => BitMatrix<N64,byte>.Load(A.Bytes);

        /// <summary>
        /// Constructs a 16-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix8 A)
            => BitGraph.FromMatrix(natural(A));            

        /// <summary>
        /// Constructs a 16-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix16 A)
            => BitGraph.FromMatrix(natural(A));            

        /// <summary>
        /// Constructs a 32-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix32 A)
            => BitGraph.FromMatrix(natural(A));            

        /// <summary>
        /// Constructs a 64-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public static Graph<byte> graph(BitMatrix64 A)
            => BitGraph.FromMatrix(natural(A));            

    }

}