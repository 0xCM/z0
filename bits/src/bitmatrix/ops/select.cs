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
        public static unsafe BitMatrix<T> select<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> C)
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            BitPoints.select(A.HeadPtr, B.HeadPtr, C.HeadPtr, Z.HeadPtr);
            return Z;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> select<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> C, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitPoints.select(A.HeadPtr, B.HeadPtr, C.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 select(in BitMatrix8 A, in BitMatrix8 B, in BitMatrix8 C)
        {
            var Z = BitMatrix.alloc(n8);
            BitPoints.select(A.HeadPtr, B.HeadPtr, C.HeadPtr, Z.HeadPtr);
            return Z;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 select(in BitMatrix8 A, in BitMatrix8 B, in BitMatrix8 C, ref BitMatrix8 Z)
        {
            BitPoints.select(A.HeadPtr, B.HeadPtr, C.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 select(in BitMatrix16 A, in BitMatrix16 B, in BitMatrix16 C)
        {
            var Z = BitMatrix.alloc(n16);
            BitPoints.select(A.HeadPtr, B.HeadPtr, C.HeadPtr, Z.HeadPtr);
            return Z;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 select(in BitMatrix16 A, in BitMatrix16 B, in BitMatrix16 C, ref BitMatrix16 Z)
        {
            BitPoints.select(A.HeadPtr, B.HeadPtr, C.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 select(in BitMatrix32 A, in BitMatrix32 B, in BitMatrix32 C)
        {
            var Z = BitMatrix.alloc(n32);
            BitPoints.select(A.HeadPtr, B.HeadPtr, C.HeadPtr, Z.HeadPtr);
            return Z;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 select(in BitMatrix32 A, in BitMatrix32 B, in BitMatrix32 C, ref BitMatrix32 Z)
        {
            BitPoints.select(A.HeadPtr, B.HeadPtr, C.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 select(in BitMatrix64 A, in BitMatrix64 B, in BitMatrix64 C)
        {
            var Z = BitMatrix.alloc(n64);
            BitPoints.select(A.HeadPtr, B.HeadPtr, C.HeadPtr, Z.HeadPtr);
            return Z;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 select(in BitMatrix64 A, in BitMatrix64 B, in BitMatrix64 C, ref BitMatrix64 Z)
        {
            BitPoints.select(A.HeadPtr, B.HeadPtr, C.HeadPtr, Z.HeadPtr);
            return ref Z;
        }
    }
}