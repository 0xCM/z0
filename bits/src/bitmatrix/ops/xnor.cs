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
    
        public static BitMatrix<T> xnor<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
        {
            var rc = math.min(A.RowCount, B.RowCount);
            var C = BitMatrix.Alloc<T>(rc);
            for(var i=0; i<rc; i++)
                C[i] = bitvector.xnor(A[i], B[i]);
            return C;
        }


    }

}