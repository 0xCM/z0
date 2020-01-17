//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitMatrix
    {
        
        [MethodImpl(Inline)]
        public static BitMatrix<T> rnot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => not(B);


        [MethodImpl(Inline)]
        public static ref BitMatrix<T> rnot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref not(B, ref Z);

    }

}