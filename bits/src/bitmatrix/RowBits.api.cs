//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Defines primar api surface for rowbit manipulation
    /// </summary>
    public static class RowBits
    {
        public static Graph<V> graph<V,T>(in RowBits<T> src)
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

        /// <summary>
        /// Allocates a specified number of rows
        /// </summary>
        /// <param name="rows">The row count</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of coluns in each row</typeparam>
        [MethodImpl(Inline)]        
        public static RowBits<T> alloc<T>(int rows)
            where T : unmanaged
                => new RowBits<T>(new T[rows]);

        /// <summary>
        /// Loads loads rows from a bytespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of matrix coluns</typeparam>
        [MethodImpl(Inline)]
        public static RowBits<T> load<T>(Span<byte> src)
            where T : unmanaged
                => new RowBits<T>(cast<T>(src));
        

        /// <summary>
        /// Loads loads rows from a span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of matrix coluns</typeparam>
        [MethodImpl(Inline)]
        public static RowBits<T> load<T>(Span<T> src)
            where T : unmanaged
                => new RowBits<T>(src);

        [MethodImpl(Inline)]
        public static RowBits<T> transfer<T>(Span<T> src)
            where T : unmanaged
                => RowBits.transfer(src);

        /// <summary>
        /// Loads rows from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of matrix coluns</typeparam>
        [MethodImpl(Inline)]
        public static RowBits<T> load<T>(params T[] src)
            where T : unmanaged
               => new RowBits<T>(src);

        [MethodImpl(Inline)]
        public static RowBits<T> block<T>(in RowBits<T> A, int firstRow)
            where T : unmanaged
                => load(A.data.Slice(firstRow));

        [MethodImpl(Inline)]
        public static RowBits<T> block<T>(in RowBits<T> A, int firstRow, int lastRow)
            where T : unmanaged
                => load(A.data.Slice(firstRow, lastRow - firstRow));

        [MethodImpl(Inline)]
        public static RowBits<T> not<T>(in RowBits<T> A, in RowBits<T> B)
            where T : unmanaged
        {            
            for(var i=0; i<A.RowCount; i++)
                B[i] = BitVector.not(A[i]); 
            return B;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> not<T>(in RowBits<T> A)
            where T : unmanaged
                => not(A, A.Replicate(true));

        [MethodImpl(Inline)]
        public static ref RowBits<T> and<T>(in RowBits<T> A, in RowBits<T> B, ref RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.and(A[i],B[i]);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> and<T>(in RowBits<T> A, in RowBits<T> B)
            where T : unmanaged
        {
            var C = A.Replicate(true);
            return and(A,B, ref C);
        }

        public static RowBits<T> andnot<T>(in RowBits<T> A, in RowBits<T> B,  in RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.cnonimpl(A[i],B[i]);
            return C;

        }

        [MethodImpl(Inline)]
        public static RowBits<T> andnot<T>(in RowBits<T> A, in RowBits<T> B)
            where T : unmanaged
                => andnot(A,B, A.Replicate(true));

        public static RowBits<T> or<T>(in RowBits<T> A, in RowBits<T> B, in RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.or(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> or<T>(in RowBits<T> A, in RowBits<T> B)
            where T : unmanaged
                => or(A,B, A.Replicate(true));

        public static RowBits<T> xor<T>(in RowBits<T> A, in RowBits<T> B, in RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.xor(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> xor<T>(in RowBits<T> A, in RowBits<T> B)
            where T : unmanaged
                => xor(A,B, A.Replicate(true));

        public static RowBits<T> nand<T>(in RowBits<T> A, in RowBits<T> B, in RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.nand(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> nand<T>(in RowBits<T> A, in RowBits<T> B)
            where T : unmanaged
                => nand(A,B, A.Replicate(true));

        public static RowBits<T> nor<T>(in RowBits<T> A, in RowBits<T> B, in RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.nor(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> nor<T>(in RowBits<T> A, in RowBits<T> B)
            where T : unmanaged
                => nor(A,B, A.Replicate(true));

        public static RowBits<T> xnor<T>(in RowBits<T> A, in RowBits<T> B, in RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.xnor(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> xnor<T>(in RowBits<T> A, in RowBits<T> B)
            where T : unmanaged
                => xnor(A,B, A.Replicate(true));

        [MethodImpl(Inline)]
        static int rowdim<T>(in RowBits<T> A, in RowBits<T> B, in RowBits<T> C)
            where T : unmanaged
        {
            if(A.RowCount != B.RowCount || A.RowCount != C.RowCount)
                Errors.CountMismatch(A.RowCount, B.RowCount);
            return A.RowCount;
        }


    }
}