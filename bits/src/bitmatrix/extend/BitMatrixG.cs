//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class BitMatrixGx
    {   
        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < N
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public static void RowSwap<T>(this BitMatrix<T> A, int i, int j)
            where T : unmanaged
            => A.Data.Swap(i,j);

        [MethodImpl(Inline)]
        public static void Update<T>(this BitMatrix<T> dst, BitMatrix<T> src)
            where T : unmanaged
            => src.Data.CopyTo(dst.Data);

        [MethodImpl(NotInline)]
        public static BitMatrix<T> Replicate<T>(this BitMatrix<T> A)
            where T : unmanaged
                => new BitMatrix<T>(A.Data.Replicate());


        [MethodImpl(Inline)]
        public static void Fill<T>(this RowBits<T> src, T value)
            where T : unmanaged
                => src.data.Fill(value);
    }
}
