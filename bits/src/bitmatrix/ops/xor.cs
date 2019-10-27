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
        [MethodImpl(Inline)]
        public static unsafe BitMatrix<T> xor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.xor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> xor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> C)
            where T : unmanaged
        {
            BitPoints.xor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 xor(in BitMatrix8 A, in BitMatrix8 B)
        {
            var C = BitMatrix.alloc(n8);
            BitPoints.xor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 xor(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 C)
        {
            BitPoints.xor(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 xor(in BitMatrix16 A, in BitMatrix16 B)
        {
            var C = BitMatrix.alloc(n16);
            BitPoints.xor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 xor(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 C)
        {
            BitPoints.xor(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 xor(in BitMatrix32 A, in BitMatrix32 B)
        {
            var C = BitMatrix.alloc(n32);
            BitPoints.xor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }
        
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 xor(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 C)
        {
            BitPoints.xor(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 xor(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = BitMatrix.alloc(n64);
            BitPoints.xor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 xor(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 C)
        {
            BitPoints.xor(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }


    }

}