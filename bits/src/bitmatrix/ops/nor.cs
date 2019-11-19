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

    partial class BitMatrix
    {
        /// <summary>
        /// Computes the converse implication for generic bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline)]
        public static BitMatrix<T> nor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            BitSquare.nor(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for generic bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline)]
        public static ref BitMatrix<T> nor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitSquare.nor(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix8 nor(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
        {
             BitSquare.nor(in A.Head, in B.Head, ref Z.Head);
             return ref Z;
        }

        /// <summary>
        /// Computes the logical Nor between two bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix4 nor(in BitMatrix4 A, in BitMatrix4 B)
        {
            var a = (ushort)A;
            var b = (ushort)B;
            return math.nor(a,b);
        }

        /// <summary>
        /// Computes the logical Nor between two bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 nor(in BitMatrix8 A, in BitMatrix8 B)
        {
            var Z = BitMatrix.alloc(n8);
            BitSquare.nor(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the logical Nor between bitmatrices and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix16 nor(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
        {
            BitSquare.nor(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical Nor between two bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 nor(in BitMatrix16 A, in BitMatrix16 B)
        {
            var Z = BitMatrix.alloc(n16);
            BitSquare.nor(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the logical Nor between bitmatrices and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix32 nor(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
        {
            BitSquare.nor(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 nor(in BitMatrix32 A, in BitMatrix32 B)
        {
            var Z = BitMatrix.alloc(n32);
            BitSquare.nor(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="B">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix64 nor(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
        {
            BitSquare.nor(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the converse implication for primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 nor(in BitMatrix64 A, in BitMatrix64 B)
        {
            var Z = BitMatrix.alloc(n64);
            BitSquare.nor(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }
    }
}