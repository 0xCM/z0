//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    partial class BitMatrix
    {
        /// <summary>
        /// Computes the logical negation of a generic bitmatrix, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline)]
        public static BitMatrix<T> not<T>(in BitMatrix<T> A)
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            BitSquare.not(in A.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the logical negation of a generic bitmatrix, depositing the result to the caller-supplied target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="Z">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>        
        [MethodImpl(Inline)]
        public static ref BitMatrix<T> not<T>(in BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitSquare.not(in A.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical negation of the source matrix, returning the allocated result to the caller 
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix4 not(in BitMatrix4 A)
            => math.not((ushort)A);

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 not(in BitMatrix8 A)
        {
            var Z = BitMatrix.alloc(n8);
            BitSquare.not(in A.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, depositing the result to the caller-supplied target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix8 not(in BitMatrix8 A, ref BitMatrix8 Z)
        {
            BitSquare.not(in A.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 not(in BitMatrix16 A)
        {
            var Z = BitMatrix.alloc(n16);
            BitSquare.not(in A.Head, ref Z.Head);
            return Z;
        }
        
        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, depositing the result to the caller-supplied target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix16 not(in BitMatrix16 A, ref BitMatrix16 Z)
        {
            BitSquare.not(in A.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 not(in BitMatrix32 A)
        {
            var Z = BitMatrix.alloc(n32);
            BitSquare.not(in A.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, depositing the result to the caller-supplied target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix32 not(in BitMatrix32 A, ref BitMatrix32 Z)
        {
            BitSquare.not(in A.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, returning the allocated result to the caller
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 not(in BitMatrix64 A)
        {
            var Z = BitMatrix.alloc(n64);
            BitSquare.not(in A.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the logical negation of a primal bitmatrix, depositing the result to the caller-supplied target
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix64 not(in BitMatrix64 A, ref BitMatrix64 Z)
        {
            BitSquare.not(in A.Head, ref Z.Head);
            return ref Z;
        } 
    }

}