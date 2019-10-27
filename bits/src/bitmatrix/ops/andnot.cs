//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static unsafe BitMatrix<T> andnot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.andnot(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> andnot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> C)
            where T : unmanaged
        {
            BitPoints.andnot(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 andnot(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 C)
        {
             BitPoints.andnot(A.HeadPtr,B.HeadPtr,C.HeadPtr);
             return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 andnot(BitMatrix8 A, BitMatrix8 B)
        {
            var C = BitMatrix.alloc(n8);
            BitPoints.andnot(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 andnot(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 C)
        {
            BitPoints.andnot(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 andnot(BitMatrix16 A, BitMatrix16 B)
        {
            var C = BitMatrix.alloc(n16);
            BitPoints.andnot(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 andnot(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 C)
        {
            BitPoints.andnot(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 andnot(BitMatrix32 A, BitMatrix32 B)
        {
            var C = BitMatrix.alloc(n32);
            BitPoints.andnot(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 andnot(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 C)
        {
            BitPoints.andnot(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 andnot(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = BitMatrix.alloc(n64);
            BitPoints.andnot(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }
    }
}