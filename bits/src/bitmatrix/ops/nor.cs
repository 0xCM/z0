//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitMatrix
    {
        public static RowBits<T> nor<T>(RowBits<T> A, RowBits<T> B, RowBits<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = bitvector.nor(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static RowBits<T> nor<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => nor(A,B, A.Replicate(true));


    }

}