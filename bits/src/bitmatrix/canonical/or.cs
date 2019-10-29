//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static unsafe BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.or(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> C)
            where T : unmanaged
        {
            BitPoints.or(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return ref C;
        }

        /// <summary>
        /// Computes the logical OR between two primal bitmatrices of order 8
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 or(BitMatrix8 A, BitMatrix8 B)
        {
            var Z = BitMatrix.alloc(n8);
            BitPoints.or(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }

        /// <summary>
        /// Computes the logical OR between two primal bitmatrices of order 16
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 or(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
        {
            BitPoints.or(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 or(in BitMatrix16 A, in BitMatrix16 B)
        {
            var Z = BitMatrix.alloc(n16);
            BitPoints.or(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }            

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 or(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
        {
            BitPoints.or(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical Or between two primal bitmatrices of order 32
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 or(in BitMatrix32 A, in BitMatrix32 B)
        {
            var Z = BitMatrix.alloc(n32);
            BitPoints.or(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 or(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
        {
            BitPoints.or(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 or(in BitMatrix64 A, in BitMatrix64 B)        
        {
            var Z = BitMatrix.alloc(n64);
            BitPoints.or(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }
    }
}