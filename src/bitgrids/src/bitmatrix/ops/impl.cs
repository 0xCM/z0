//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; using static Memories;

    partial class BitMatrix
    {
        /// <summary>
        /// Computes the converse implication for generic bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline), Impl, NumericClosures(UnsignedInts)]
        public static unsafe BitMatrix<T> impl<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            LSquare.impl(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for generic bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline), Impl, NumericClosures(UnsignedInts)]
        public static unsafe ref BitMatrix<T> impl<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            LSquare.impl(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline), Impl]
        public static unsafe ref BitMatrix8 impl(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
        {
             LSquare.impl(in A.Head, in B.Head, ref Z.Head);
             return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Impl]
        public static unsafe BitMatrix8 impl(in BitMatrix8 A, in BitMatrix8 B)
        {
            var Z = BitMatrix.alloc(n8);
            LSquare.impl(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline), Impl]
        public static unsafe ref BitMatrix16 impl(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
        {
            LSquare.impl(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Impl]
        public static unsafe BitMatrix16 impl(in BitMatrix16 A, in BitMatrix16 B)
        {
            var Z = BitMatrix.alloc(n16);
            LSquare.impl(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline), Impl]
        public static unsafe ref BitMatrix32 impl(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
        {
            LSquare.impl(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Impl]
        public static unsafe BitMatrix32 impl(in BitMatrix32 A, in BitMatrix32 B)
        {
            var Z = BitMatrix.alloc(n32);
            LSquare.impl(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline), Impl]
        public static unsafe ref BitMatrix64 impl(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
        {
            LSquare.impl(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Impl]
        public static unsafe BitMatrix64 impl(in BitMatrix64 A, in BitMatrix64 B)
        {
            var Z = BitMatrix.alloc(n64);
            LSquare.impl(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }
    }
}