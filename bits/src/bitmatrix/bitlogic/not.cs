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
        /// Computes the logical negation of a generic bitmatrix, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe BitMatrix<T> not<T>(in BitMatrix<T> A)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.not(A.HeadPtr, C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the logical negation of a generic bitmatrix, depositing the result to the caller-supplied target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="Z">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> not<T>(in BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitPoints.not(A.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix8 not(in BitMatrix8 A)
        {
            var C = BitMatrix.alloc(n8);
            BitPoints.not(A.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, depositing the result to the caller-supplied target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix8 not(in BitMatrix8 A, ref BitMatrix8 Z)
        {
            BitPoints.not(A.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix16 not(in BitMatrix16 A)
        {
            var C = BitMatrix.alloc(n16);
            BitPoints.not(A.HeadPtr,C.HeadPtr);
            return C;
        }
        
        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, depositing the result to the caller-supplied target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 not(in BitMatrix16 A, ref BitMatrix16 Z)
        {
            BitPoints.not(A.HeadPtr, Z.HeadPtr);
            return ref Z;

        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix32 not(in BitMatrix32 A)
        {
            var C = BitMatrix.alloc(n32);
            BitPoints.not(A.HeadPtr,C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, depositing the result to the caller-supplied target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 not(in BitMatrix32 A, ref BitMatrix32 Z)
        {
            BitPoints.not(A.HeadPtr, Z.HeadPtr);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static unsafe BitMatrix64 not(in BitMatrix64 A)
        {
            var C = BitMatrix.alloc(n64);
            BitPoints.not(A.HeadPtr, C.HeadPtr);
            return C;
        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, depositing the result to the caller-supplied target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 not(in BitMatrix64 A, ref BitMatrix64 Z)
        {
            BitPoints.not(A.HeadPtr, Z.HeadPtr);
            return ref Z;
        } 

         /// <summary>
        /// Computes the bitwise compliement of entries in the source matrix not stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> not<N,T>(BitMatrix<N,T> A, BitMatrix<N,T> B)        
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            mathspan.not(A.Data, B.Data);
            return  B;
        }

        /// <summary>
        /// Computes the bitwise compliement of entries in the source matrix not stores the
        /// result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static  BitMatrix<M,N,T> not<M,N,T>(BitMatrix<M,N,T> A, BitMatrix<M,N,T> B)        
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            mathspan.not(A.Data,B.Data);
            return B;
        }

    }

}