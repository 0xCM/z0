//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class BitMatrix
    {
        /// <summary>
        /// Computes the converse implication for generic bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline), Or, NumericClosures(Closure)]
        public static ref readonly BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> Z)
            where T : unmanaged
        {
            LogicSquare.or(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical Or between two bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Or]
        public static BitMatrix4 or(in BitMatrix4 A, in BitMatrix4 B)
        {
            var a = (ushort)A;
            var b = (ushort)B;
            return math.or(a,b);
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline), Or]
        public static ref BitMatrix8 or(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
        {
             LogicSquare.or(in A.Head, in B.Head, ref Z.Head);
             return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Or]
        public static BitMatrix8 or(in BitMatrix8 A, in BitMatrix8 B)
        {
            var Z = BitMatrix.alloc(n8);
            LogicSquare.or(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline), Or]
        public static ref BitMatrix16 or(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
        {
            LogicSquare.or(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Or]
        public static BitMatrix16 or(in BitMatrix16 A, in BitMatrix16 B)
        {
            var Z = BitMatrix.alloc(n16);
            LogicSquare.or(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline), Or]
        public static ref BitMatrix32 or(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
        {
            LogicSquare.or(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Or]
        public static BitMatrix32 or(in BitMatrix32 A, in BitMatrix32 B)
        {
            var Z = BitMatrix.alloc(n32);
            LogicSquare.or(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline), Or]
        public static ref BitMatrix64 or(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
        {
            LogicSquare.or(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Or]
        public static BitMatrix64 or(in BitMatrix64 A, in BitMatrix64 B)
        {
            var Z = BitMatrix.alloc(n64);
            LogicSquare.or(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }
    }
}