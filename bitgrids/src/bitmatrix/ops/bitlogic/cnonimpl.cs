//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitMatrix
    {
        /// <summary>
        /// Computes the converse implication for generic bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> cnonimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            BitSquare.cnonimpl(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for generic bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static ref BitMatrix<T> cnonimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitSquare.cnonimpl(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline), Op]
        public static ref BitMatrix8 cnonimpl(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
        {
             BitSquare.cnonimpl(in A.Head, in B.Head, ref Z.Head);
             return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Op]
        public static BitMatrix8 cnonimpl(in BitMatrix8 A, in BitMatrix8 B)
        {
            var Z = BitMatrix.alloc(n8);
            BitSquare.cnonimpl(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline), Op]
        public static ref BitMatrix16 cnonimpl(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
        {
            BitSquare.cnonimpl(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Op]
        public static BitMatrix16 cnonimpl(in BitMatrix16 A, in BitMatrix16 B)
        {
            var Z = BitMatrix.alloc(n16);
            BitSquare.cnonimpl(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline), Op]
        public static ref BitMatrix32 cnonimpl(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
        {
            BitSquare.cnonimpl(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Op]
        public static BitMatrix32 cnonimpl(in BitMatrix32 A, in BitMatrix32 B)
        {
            var Z = BitMatrix.alloc(n32);
            BitSquare.cnonimpl(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline), Op]
        public static ref BitMatrix64 cnonimpl(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
        {
            BitSquare.cnonimpl(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Op]
        public static BitMatrix64 cnonimpl(in BitMatrix64 A, in BitMatrix64 B)
        {
            var Z = BitMatrix.alloc(n64);
            BitSquare.cnonimpl(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }
    }
}