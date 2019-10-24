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
        public static RowBits<T> alloc<T>(int rows)
            where T : unmanaged
                => RowBits<T>.Alloc(rows);

        /// <summary>
        /// Loads loads rows from a bytespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of matrix coluns</typeparam>
        public static RowBits<T> load<T>(Span<byte> src)
            where T : unmanaged
                => RowBits<T>.From(src);

        /// <summary>
        /// Loads loads rows from a span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of matrix coluns</typeparam>
        public static RowBits<T> load<T>(Span<T> src)
            where T : unmanaged
                => RowBits<T>.From(src);

        /// <summary>
        /// Loads rows from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of matrix coluns</typeparam>
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


        public static ref RowBits<T> and<T>(in RowBits<T> A, in RowBits<T> B, ref RowBits<T> C)
            where T : unmanaged
        {
            var rc = BitMatrix.rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = bitvector.and(A[i],B[i]);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> and<T>(in RowBits<T> A, in RowBits<T> B)
            where T : unmanaged
        {
            var C = A.Replicate(true);
            return and(A,B, ref C);
        }

    }
}