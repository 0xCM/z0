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
    using static As;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> and<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> C)
            where T : unmanaged
        {
            BitPoints256.and(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return ref C;
        }


    }

}