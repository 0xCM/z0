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
        public static unsafe BitMatrix<T> and<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.and(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> and<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitPoints.and(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static BitMatrix4 and(in BitMatrix4 A, in BitMatrix4 B)
        {
            var a = (ushort)A;
            var b = (ushort)B;
            var c = math.and(a,b);
            return BitMatrix4.From(c);
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 and(in BitMatrix8 A, in BitMatrix8 B)
        {
            var Z = BitMatrix.alloc(n8);
            BitPoints.and(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 and(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
        {
            BitPoints.and(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }


        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 and(in BitMatrix16 A, in BitMatrix16 B)
        {
            var Z = BitMatrix.alloc(n16);
            BitPoints.and(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 and(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
        {
            BitPoints.and(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 and(in BitMatrix32 A, in BitMatrix32 B)
        {
            var Z = BitMatrix.alloc(n32);
            BitPoints.and(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 and(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
        {
            BitPoints.and(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 and(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = BitMatrix.alloc(n64);
            BitPoints.and(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 and(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
        {
            BitPoints.and(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }


    }
}