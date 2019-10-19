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
        public static BitMatrix<T> nand<T>(BitMatrix<T> A, BitMatrix<T> B, BitMatrix<T> C)
            where T : unmanaged
        {
            var rc = rowdim(A,B,C);
            for(var i=0; i<rc; i++)
                C[i] = bitvector.nand(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static BitMatrix<T> nand<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => nand(A,B, A.Replicate(true));


    }

}