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
        /// Computes the logical Xor between two generic bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <typeparam name="T">The primal type over which the matrices are constructed</typeparam>        
        [MethodImpl(Inline), Xor, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> xor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            BitSquare.xor(in A.Head,in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the logical Xor btween two generic bitmatrices, depositing the result to a caller-allocated target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrices are constructed</typeparam>        
        [MethodImpl(Inline), Xor, NumericClosures(NumericKind.UnsignedInts)]
        public static ref BitMatrix<T> xor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitSquare.xor(in A.Head,in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical Xor between two bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Xor]
        public static BitMatrix4 xor(in BitMatrix4 A, in BitMatrix4 B)
        {
            var a = (ushort)A;
            var b = (ushort)B;
            return math.xor(a,b);
        }

        /// <summary>
        /// Computes the logical Xor between two primal bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Xor]
        public static BitMatrix8 xor(in BitMatrix8 A, in BitMatrix8 B)
        {
            var Z = BitMatrix.alloc(n8);
            BitSquare.xor(in A.Head,in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the logical Xor btween two primal bitmatrices, depositing the result to a caller-allocated target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline), Xor]
        public static ref BitMatrix8 xor(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
        {
            BitSquare.xor(in A.Head,in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical Xor between two primal bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Xor]
        public static BitMatrix16 xor(in BitMatrix16 A, in BitMatrix16 B)
        {
            var Z = BitMatrix.alloc(n16);
            BitSquare.xor(in A.Head,in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the logical Xor btween two primal bitmatrices, depositing the result to a caller-allocated target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline), Xor]
        public static ref BitMatrix16 xor(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
        {
            BitSquare.xor(in A.Head,in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical Xor between two primal bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Xor]
        public static BitMatrix32 xor(in BitMatrix32 A, in BitMatrix32 B)
        {
            var Z = BitMatrix.alloc(n32);
            BitSquare.xor(in A.Head,in B.Head, ref Z.Head);
            return Z;
        }
        
        /// <summary>
        /// Computes the logical Xor btween two primal bitmatrices, depositing the result to a caller-allocated target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline), Xor]
        public static ref BitMatrix32 xor(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
        {
            BitSquare.xor(in A.Head,in B.Head, ref Z.Head);
            return ref Z;
        }

        /// <summary>
        /// Computes the logical Xor between two primal bitmatrices and returns the allocated result to the caller
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline), Xor]
        public static BitMatrix64 xor(in BitMatrix64 A, in BitMatrix64 B)
        {
            var Z = BitMatrix.alloc(n64);
            BitSquare.xor(in A.Head,in B.Head, ref Z.Head);
            return Z;
        }

        /// <summary>
        /// Computes the logical Xor btween two primal bitmatrices, depositing the result to a caller-allocated target
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        [MethodImpl(Inline), Xor]
        public static ref BitMatrix64 xor(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
        {
            BitSquare.xor(in A.Head,in B.Head, ref Z.Head);
            return ref Z;
        }
    }
}