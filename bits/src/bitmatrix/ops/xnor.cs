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
        public static unsafe BitMatrix<T> xnor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.xnor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

       [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> xnor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> C)
            where T : unmanaged
        {
            BitPoints.xnor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return ref C;
        }
    
        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 xnor(in BitMatrix8 A, in BitMatrix8 B)
        {
            var C = BitMatrix.alloc(n8);
            BitPoints.xnor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 xnor(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 C)
        {
            BitPoints.xnor(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 xnor(in BitMatrix16 A, in BitMatrix16 B)
        {
            var C = BitMatrix.alloc(n16);
            BitPoints.xnor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 xnor(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 C)
        {
            BitPoints.xnor(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 xnor(in BitMatrix32 A, in BitMatrix32 B)
        {
            var C = BitMatrix.alloc(n32);
            BitPoints.xnor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }
        
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 xnor(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 C)
        {
            BitPoints.xnor(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 xnor(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = BitMatrix.alloc(n64);
            BitPoints.xnor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 xnor(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 C)
        {
            BitPoints.xnor(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }
    }
}