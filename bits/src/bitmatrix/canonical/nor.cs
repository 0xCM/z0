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
        /// <summary>
        /// Computes the logical Nor between two generic bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="T">The primal type over which the matrices are constructed</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe BitMatrix<T> nor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.nor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the logical Nor btween two generic bitmatrices and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrices are constructed</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> nor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> C)
            where T : unmanaged
        {
            BitPoints.nor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return ref C;
        }

        /// <summary>
        /// Computes the logical Nor btween two primal bitmatrices and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 nor(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 C)
        {
             BitPoints.nor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
             return ref C;
        }

        /// <summary>
        /// Computes the logical Nor between two primal bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 nor(BitMatrix8 A, BitMatrix8 B)
        {
            var C = BitMatrix.alloc(n8);
            BitPoints.nor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the logical Nor btween two primal bitmatrices and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 nor(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 C)
        {
            BitPoints.nor(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        /// <summary>
        /// Computes the logical Nor between two primal bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 nor(BitMatrix16 A, BitMatrix16 B)
        {
            var C = BitMatrix.alloc(n16);
            BitPoints.nor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the logical Nor btween two primal bitmatrices and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 nor(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 C)
        {
            BitPoints.nor(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        /// <summary>
        /// Computes the logical Nor between two primal bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 nor(BitMatrix32 A, BitMatrix32 B)
        {
            var C = BitMatrix.alloc(n32);
            BitPoints.nor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the logical Nor btween two primal bitmatrices and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 nor(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 C)
        {
            BitPoints.nor(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        /// <summary>
        /// Computes the logical Nor between two primal bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 nor(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = BitMatrix.alloc(n64);
            BitPoints.nor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }
    }
}