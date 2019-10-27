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
        public static unsafe BitMatrix<T> nand<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.nand(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> nand<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> C)
            where T : unmanaged
        {
            BitPoints.nand(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 nand(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 C)
        {
             BitPoints.nand(A.HeadPtr,B.HeadPtr,C.HeadPtr);
             return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 nand(BitMatrix8 A, BitMatrix8 B)
        {
            var C = BitMatrix.alloc(n8);
            BitPoints.nand(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 nand(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 C)
        {
            BitPoints.nand(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 nand(BitMatrix16 A, BitMatrix16 B)
        {
            var C = BitMatrix.alloc(n16);
            BitPoints.nand(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 nand(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 C)
        {
            BitPoints.nand(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 nand(BitMatrix32 A, BitMatrix32 B)
        {
            var C = BitMatrix.alloc(n32);
            BitPoints.nand(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 nand(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 C)
        {
            BitPoints.nand(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 nand(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = BitMatrix.alloc(n64);
            BitPoints.nand(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }
    }

}