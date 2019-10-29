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
        public static unsafe BitMatrix<T> cnotimply<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.cnotimply(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the converse nonimplication, Z :=- A & (~B) for source generic bitmatrices A and B and target matrix Z
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> cnotimply<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitPoints.cnotimply(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse nonimplication, Z :=- A & (~B) for source bitmatrices A and B and target matrix Z
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 cnotimply(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
        {
             BitPoints.cnotimply(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
             return ref Z;
        }

        /// <summary>
        /// Computes the converse nonimplication, A & (~B) for bitmatrices A and B
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 cnotimply(BitMatrix8 A, BitMatrix8 B)
        {
            var C = BitMatrix.alloc(n8);
            BitPoints.cnotimply(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the converse nonimplication, Z :=- A & (~B) for source bitmatrices A and B and target matrix Z
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 cnotimply(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
        {
            BitPoints.cnotimply(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse nonimplication, A & (~B) for bitmatrices A and B
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 cnotimply(BitMatrix16 A, BitMatrix16 B)
        {
            var C = BitMatrix.alloc(n16);
            BitPoints.cnotimply(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the converse nonimplication, Z :=- A & (~B) for source bitmatrices A and B and target matrix Z
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 andnot(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
        {
            BitPoints.cnotimply(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse nonimplication, A & (~B) for bitmatrices A and B
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 cnotimply(BitMatrix32 A, BitMatrix32 B)
        {
            var C = BitMatrix.alloc(n32);
            BitPoints.cnotimply(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the converse nonimplication, Z :=- A & (~B) for source bitmatrices A and B and target matrix Z
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 cnotimply(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
        {
            BitPoints.cnotimply(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse nonimplication, A & (~B) for bitmatrices A and B
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 cnotimply(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = BitMatrix.alloc(n64);
            BitPoints.cnotimply(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }
    }
}