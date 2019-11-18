//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines primar api surface for rowbit manipulation
    /// </summary>
    public static class RowBits
    {
        /// <summary>
        /// Allocates a specified number of rows
        /// </summary>
        /// <param name="rows">The row count</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of coluns in each row</typeparam>
        [MethodImpl(Inline)]        
        public static RowBits<T> alloc<T>(int rows)
            where T : unmanaged
                => RowBits<T>.Alloc(rows);

        /// <summary>
        /// Loads loads rows from a bytespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of matrix coluns</typeparam>
        [MethodImpl(Inline)]
        public static RowBits<T> load<T>(Span<byte> src)
            where T : unmanaged
                => RowBits<T>.From(src);

        /// <summary>
        /// Loads loads rows from a span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of matrix coluns</typeparam>
        [MethodImpl(Inline)]
        public static RowBits<T> load<T>(Span<T> src)
            where T : unmanaged
                => RowBits<T>.From(src);

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
        public static RowBits<T> load<T>(T[] src)
            where T : unmanaged
                => RowBits<T>.From(src);

        [MethodImpl(Inline)]
        public static RowBits<T> block<T>(RowBits<T> A, int firstRow)
            where T : unmanaged
                => load(A.data.Slice(firstRow));

        [MethodImpl(Inline)]
        public static RowBits<T> block<T>(RowBits<T> A, int firstRow, int lastRow)
            where T : unmanaged
                => load(A.data.Slice(firstRow, lastRow - firstRow));

        public static RowBits<T> not<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
        {            
            for(var i=0; i<A.RowCount; i++)
                B[i] = BitVector.not(A[i]); 
            return B;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> not<T>(RowBits<T> A)
            where T : unmanaged
                => not(A, A.Replicate(true));

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

        public static RowBits<T> andnot<T>(RowBits<T> A, RowBits<T> B,  RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.cnonimpl(A[i],B[i]);
            return C;

        }

        [MethodImpl(Inline)]
        public static RowBits<T> andnot<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => andnot(A,B, A.Replicate(true));

        public static RowBits<T> or<T>(RowBits<T> A, RowBits<T> B, RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.or(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> or<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => or(A,B, A.Replicate(true));

        public static RowBits<T> xor<T>(RowBits<T> A, RowBits<T> B, RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.xor(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> xor<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => xor(A,B, A.Replicate(true));

        public static RowBits<T> nand<T>(RowBits<T> A, RowBits<T> B, RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.nand(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> nand<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => nand(A,B, A.Replicate(true));

        public static RowBits<T> nor<T>(RowBits<T> A, RowBits<T> B, RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.nor(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> nor<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => nor(A,B, A.Replicate(true));

        public static RowBits<T> xnor<T>(RowBits<T> A, RowBits<T> B, RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = BitVector.xnor(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> xnor<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => xnor(A,B, A.Replicate(true));

        [MethodImpl(Inline)]
        static int rowdim<T>(RowBits<T> A, RowBits<T> B, RowBits<T> C)
            where T : unmanaged
        {
            if(A.RowCount != B.RowCount || A.RowCount != C.RowCount)
                Errors.CountMismatch(A.RowCount, B.RowCount);
            return A.RowCount;
        }


    }
}