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
        /// <summary>
        /// Determines whether two generic bitmatrices are identical, returning an enabled bit if so and a disabled bit otherwise
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="T">The primal type over which the matrices are constructed</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe bit same<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.xnor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return BitPoints.testc(C.HeadPtr);
        }

        /// <summary>
        /// Determines whether two primal bitmatrices are identical, returning an enabled bit if so and a disabled bit otherwise
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bit same(BitMatrix8 A, BitMatrix8 B)
        {
            var C = BitMatrix.alloc(n8);
            BitPoints.xnor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return BitPoints.testc(C.HeadPtr);
        }

        /// <summary>
        /// Determines whether two primal bitmatrices are identical, returning an enabled bit if so and a disabled bit otherwise
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bit same(BitMatrix16 A, BitMatrix16 B)
        {
            var C = BitMatrix.alloc(n16);
            BitPoints.xnor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return BitPoints.testc(C.HeadPtr);
        }

        /// <summary>
        /// Determines whether two primal bitmatrices are identical, returning an enabled bit if so and a disabled bit otherwise
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bit same(BitMatrix32 A, BitMatrix32 B)
        {
            var C = BitMatrix.alloc(n32);
            BitPoints.xnor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return BitPoints.testc(C.HeadPtr);
        }

        /// <summary>
        /// Determines whether two primal bitmatrices are identical, returning an enabled bit if so and a disabled bit otherwise
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bit same(BitMatrix64 A, BitMatrix64 B)
        {
            var C = BitMatrix.alloc(n64);
            BitPoints.xnor(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return BitPoints.testc(C.HeadPtr);
        }


    }
}