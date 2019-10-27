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
        public static unsafe BitMatrix<T> not<T>(in BitMatrix<T> A)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.not(A.HeadPtr, C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> not<T>(in BitMatrix<T> A, ref BitMatrix<T> C)
            where T : unmanaged
        {
            BitPoints.not(A.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 not(in BitMatrix8 A)
        {
            var C = BitMatrix.alloc(n8);
            BitPoints.not(A.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 not(in BitMatrix8 A, ref BitMatrix8 C)
        {
            BitPoints.not(A.HeadPtr, C.HeadPtr);
            return ref C;
        }


        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 not(in BitMatrix16 A, ref BitMatrix16 C)
        {
            BitPoints.not(A.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 not(in BitMatrix16 A)
        {
            var C = BitMatrix.alloc(n16);
            BitPoints.not(A.HeadPtr,C.HeadPtr);
            return C;
        }
        
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 not(in BitMatrix32 A, ref BitMatrix32 C)
        {
            BitPoints.not(A.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 not(in BitMatrix32 A)
        {
            var C = BitMatrix.alloc(n32);
            BitPoints.not(A.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 not(in BitMatrix64 A, ref BitMatrix64 C)
        {
            BitPoints.not(A.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 not(in BitMatrix64 A)
        {
            var C = BitMatrix.alloc(n64);
            BitPoints.not(A.HeadPtr, C.HeadPtr);
            return C;
        }
 

    }

}