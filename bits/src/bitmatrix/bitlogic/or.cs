//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitMatrix
    {
        /// <summary>
        /// Computes the logical OR between generic bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.or(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the logical OR between generic bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitPoints.or(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical OR between two primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 or(in BitMatrix8 A, in BitMatrix8 B)
        {
            var Z = BitMatrix.alloc(n8);
            BitPoints.or(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }

        /// <summary>
        /// Computes the logical OR between primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 or(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
        {
            BitPoints.or(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }


        /// <summary>
        /// Computes the logical Or of two primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 or(in BitMatrix16 A, in BitMatrix16 B)
        {
            var Z = BitMatrix.alloc(n16);
            BitPoints.or(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }            

        /// <summary>
        /// Computes the logical OR between two primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The taret matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 or(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
        {
            BitPoints.or(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical Or of two primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 or(in BitMatrix32 A, in BitMatrix32 B)
        {
            var Z = BitMatrix.alloc(n32);
            BitPoints.or(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }

        /// <summary>
        /// Computes the logical OR between two primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The taret matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 or(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
        {
            BitPoints.or(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical Or of two primal bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 or(in BitMatrix64 A, in BitMatrix64 B)        
        {
            var Z = BitMatrix.alloc(n64);
            BitPoints.or(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }

        /// <summary>
        /// Computes the logical OR between two primal bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The taret matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 or(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
        {
            BitPoints.or(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the bitwise OR between two square bitmatrices of common natural order and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<N,T> or<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, ref BitMatrix<N,T> C)        
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.or(A.Data, B.Data, C.Data);
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise OR between two bitmatrices of common natural dimension and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<M,N,T> or<M,N,T>(in BitMatrix<M,N,T> A, in BitMatrix<M,N,T> B, ref BitMatrix<M,N,T> C)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.or(A.Data, B.Data, C.Data);
            return ref C;
        }

    }
}