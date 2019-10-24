//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static int rowdim<T>(RowBits<T> A)
            where T : unmanaged
                => A.RowCount;

        [MethodImpl(Inline)]
        public static int rowdim<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
        {
            if(A.RowCount != B.RowCount)
                Errors.CountMismatch(A.RowCount, B.RowCount);
            return A.RowCount;
        }
                
        [MethodImpl(Inline)]
        public static int rowdim<T>(RowBits<T> A, RowBits<T> B, RowBits<T> C)
            where T : unmanaged
        {
            if(A.RowCount != B.RowCount || A.RowCount != C.RowCount)
                Errors.CountMismatch(A.RowCount, B.RowCount);
            return A.RowCount;
        }


        [MethodImpl(Inline)]
        public static Dim2 dim<T>(RowBits<T> A)
            where T : unmanaged
                => (A.RowCount, A.ColCount);
    }
}