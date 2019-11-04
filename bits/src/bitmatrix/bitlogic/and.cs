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
        /// Computes the logical And between two generic bitmatrices, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="T">The primal type over which the matrices are constructed</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe BitMatrix<T> and<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.and(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the logical and btween two generic bitmatrices, depositing the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrices are constructed</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> and<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitPoints.and(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical And between two source bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix4 and(in BitMatrix4 A, in BitMatrix4 B)
        {
            var a = (ushort)A;
            var b = (ushort)B;
            var c = math.and(a,b);
            return BitMatrix4.From(c);
        }

        /// <summary>
        /// Computes the logical And between two source bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 and(in BitMatrix8 A, in BitMatrix8 B)
        {
            var Z = BitMatrix.alloc(n8);
            BitPoints.and(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }

        /// <summary>
        /// Computes the logical and btween two source bitmatrices and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 and(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
        {
            BitPoints.and(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical And between two primal bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 and(in BitMatrix16 A, in BitMatrix16 B)
        {
            var Z = BitMatrix.alloc(n16);
            BitPoints.and(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }

        /// <summary>
        /// Computes the logical And btween two source bitmatrices and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 and(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
        {
            BitPoints.and(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical And between two primal bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 and(in BitMatrix32 A, in BitMatrix32 B)
        {
            var Z = BitMatrix.alloc(n32);
            BitPoints.and(A.HeadPtr,B.HeadPtr,Z.HeadPtr);
            return Z;
        }

        /// <summary>
        /// Computes the logical and btween two source bitmatrices and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 and(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
        {
            BitPoints.and(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical And between two priaml bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 and(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = BitMatrix.alloc(n64);
            BitPoints.and(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the logical and btween two source bitmatrices and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 and(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
        {
            BitPoints.and(A.HeadPtr, B.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the bitwise AND between two square bitmatrices of common natural order and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<N,T> and<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, ref BitMatrix<N,T> C)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.and(A.Data, B.Data, C.Data);
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise AND between two square bitmatrices of common order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> and<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var C = alloc<N,T>();
            return and(in A, in B, ref C);
        }

        /// <summary>
        /// Computes the bitwise AND between two bitmatrices of common dimension and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<M,N,T> and<M,N,T>(in BitMatrix<M,N,T> A, in BitMatrix<M,N,T> B, ref BitMatrix<M,N,T> C)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.and(A.Data, B.Data, C.Data);
            return ref C;
        } 
 
    }
}