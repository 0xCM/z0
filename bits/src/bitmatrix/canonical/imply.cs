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
        /// <summary>
        /// Computes the converse nonimplication,  A & (~B) for generic bitmatrices A and B
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe BitMatrix<T> imply<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.imply(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the converse nonimplication, Z := A & (~B) for source generic bitmatrices A and B and target matrix Z
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> imply<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitPoints.imply(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse nonimplication, Z :=- A & (~B) for source bitmatrices A and B and target matrix Z
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 imply(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
        {
             BitPoints.imply(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
             return ref Z;
        }

        /// <summary>
        /// Computes the converse nonimplication, A & (~B) for bitmatrices A and B
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 imply(BitMatrix8 A, BitMatrix8 B)
        {
            var C = BitMatrix.alloc(n8);
            BitPoints.imply(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the converse nonimplication, Z := A & (~B) for source bitmatrices A and B and target matrix Z
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 imply(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
        {
            BitPoints.imply(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse nonimplication, A & (~B) for bitmatrices A and B
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 imply(BitMatrix16 A, BitMatrix16 B)
        {
            var C = BitMatrix.alloc(n16);
            BitPoints.imply(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the converse nonimplication, Z := A & (~B) for source bitmatrices A and B and target matrix Z
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 imply(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
        {
            BitPoints.imply(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse nonimplication, A & (~B) for bitmatrices A and B
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 imply(BitMatrix32 A, BitMatrix32 B)
        {
            var C = BitMatrix.alloc(n32);
            BitPoints.imply(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the converse nonimplication, Z := A & (~B) for source bitmatrices A and B and target matrix Z
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 imply(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
        {
            BitPoints.imply(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse nonimplication, A & (~B) for bitmatrices A and B
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 imply(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = BitMatrix.alloc(n64);
            BitPoints.imply(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }
    }
}