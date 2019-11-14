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
    using static As;

    partial class BitMatrix
    {
        /// <summary>
        /// Applies the ternary select operator to generic source matrices, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <param name="C">The third matrix</param>
        /// <typeparam name="T">The primal type over which the matrices are constructed</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<T> select<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> C)
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            BitSquare.select(in A.Head, in B.Head, in C.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Applies the ternary select operator to generic source matrices, writing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <param name="C">The third matrix</param>
        /// <typeparam name="T">The primal type over which the matrices are constructed</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<T> select<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> C, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitSquare.select(in A.Head, in B.Head, in C.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Applies the ternary select operator to primal source matrices, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <param name="C">The third matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 select(in BitMatrix8 A, in BitMatrix8 B, in BitMatrix8 C)
        {
            var Z = BitMatrix.alloc(n8);
            BitSquare.select(in A.Head, in B.Head, in C.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Applies the ternary select operator to primal source matrices, writing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <param name="C">The third matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix8 select(in BitMatrix8 A, in BitMatrix8 B, in BitMatrix8 C, ref BitMatrix8 Z)
        {
            BitSquare.select(in A.Head, in B.Head, in C.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Applies the ternary select operator to primal source matrices, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <param name="C">The third matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 select(in BitMatrix16 A, in BitMatrix16 B, in BitMatrix16 C)
        {
            var Z = BitMatrix.alloc(n16);
            BitSquare.select(in A.Head, in B.Head, in C.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Applies the ternary select operator to primal source matrices, writing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <param name="C">The third matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix16 select(in BitMatrix16 A, in BitMatrix16 B, in BitMatrix16 C, ref BitMatrix16 Z)
        {
            BitSquare.select(in A.Head, in B.Head, in C.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Applies the ternary select operator to primal source matrices, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <param name="C">The third matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 select(in BitMatrix32 A, in BitMatrix32 B, in BitMatrix32 C)
        {
            var Z = BitMatrix.alloc(n32);
            BitSquare.select(in A.Head, in B.Head, in C.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Applies the ternary select operator to primal source matrices, writing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <param name="C">The third matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix32 select(in BitMatrix32 A, in BitMatrix32 B, in BitMatrix32 C, ref BitMatrix32 Z)
        {
            BitSquare.select(in A.Head, in B.Head, in C.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Applies the ternary select operator to primal source matrices, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <param name="C">The third matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 select(in BitMatrix64 A, in BitMatrix64 B, in BitMatrix64 C)
        {
            var Z = BitMatrix.alloc(n64);
            BitSquare.select(in A.Head, in B.Head, in C.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Applies the ternary select operator to primal source matrices, writing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <param name="C">The third matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix64 select(in BitMatrix64 A, in BitMatrix64 B, in BitMatrix64 C, ref BitMatrix64 Z)
        {
            BitSquare.select(in A.Head, in B.Head, in C.Head, ref Z.Head);
            return ref Z;
        }
    }
}