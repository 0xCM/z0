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
        public static bit same<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            BitPoints.xnor(in A.Head,in B.Head, ref Z.Head);
            return BitPoints.testc(in Z.Head);
        }

        /// <summary>
        /// Determines whether two primal bitmatrices are identical, returning an enabled bit if so and a disabled bit otherwise
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static bit same(BitMatrix8 A, BitMatrix8 B)
        {
            var Z = BitMatrix.alloc(n8);
            BitPoints.xnor(in A.Head, in B.Head, ref Z.Head);
            return BitPoints.testc(in Z.Head);
        }

        /// <summary>
        /// Determines whether two primal bitmatrices are identical, returning an enabled bit if so and a disabled bit otherwise
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static bit same(BitMatrix16 A, BitMatrix16 B)
        {
            var Z = BitMatrix.alloc(n16);
            BitPoints.xnor(in A.Head, in B.Head, ref Z.Head);
            return BitPoints.testc(in Z.Head);
        }

        /// <summary>
        /// Determines whether two primal bitmatrices are identical, returning an enabled bit if so and a disabled bit otherwise
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static bit same(BitMatrix32 A, BitMatrix32 B)
        {
            var Z = BitMatrix.alloc(n32);
            BitPoints.xnor(in A.Head, in B.Head, ref Z.Head);
            return BitPoints.testc(in Z.Head);
        }

        /// <summary>
        /// Determines whether two primal bitmatrices are identical, returning an enabled bit if so and a disabled bit otherwise
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static bit same(BitMatrix64 A, BitMatrix64 B)
        {
            var Z = BitMatrix.alloc(n64);
            BitPoints.xnor(in A.Head, in B.Head, ref Z.Head);
            return BitPoints.testc(in Z.Head);
        }
    }
}