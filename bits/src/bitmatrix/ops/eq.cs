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
        public static unsafe bool eq<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.xnor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return BitPoints.testc(C.HeadPtr);
        }

        [MethodImpl(Inline)]
        public static unsafe bool eq(BitMatrix8 A, BitMatrix8 B)
        {
            var C = BitMatrix.alloc(n8);
            BitPoints.andnot(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return BitPoints.testz(C.HeadPtr);
        }

        [MethodImpl(Inline)]
        public static bool eq(BitMatrix16 A, BitMatrix16 B)
            => testz(andnot(A,B));

        [MethodImpl(Inline)]
        public static bool eq(BitMatrix32 A, BitMatrix32 B)
            => testz(andnot(A,B));

        [MethodImpl(Inline)]
        public static bool eq(BitMatrix64 A, BitMatrix64 B)
            => testz(andnot(A,B));


    }
}