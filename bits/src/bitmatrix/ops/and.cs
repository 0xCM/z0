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
    using static As;

    partial class BitMatrix
    {

        public static BitMatrix<T> and<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
        {
            var rc = math.min(A.RowCount, B.RowCount);
            var C = BitMatrix.Alloc<T>(rc);
            for(var i=0; i<rc; i++)
                C[i] = bitvector.and(A[i],B[i]);
            return C;
        }

        [MethodImpl(Inline)]
        public static ref BitMatrix4 and(ref BitMatrix4 A, in BitMatrix4 B)
        {
             A.data = BitConverter.GetBytes((ushort) ((ushort)A & (ushort)B));
             return ref A;
        }

        [MethodImpl(Inline)]
        public static BitMatrix4 and(BitMatrix4 A, BitMatrix4 B)
        {
            var dst = A.Replicate();
            return and(ref dst, B);
        }

        /// <summary>
        /// Computes the logical AND between two primal bitmatrices of order 8
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 and(BitMatrix8 A, BitMatrix8 B)
             => BitMatrix8.From((ulong)A & (ulong)B);             

        /// <summary>
        /// Computes the logical AND between two primal bitmatrices of order 16
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 and(BitMatrix16 A, BitMatrix16 B)
        {
            ref var a = ref A.GetCells(out Vec256<ushort> _);
            ref var b = ref B.GetCells(out Vec256<ushort> _);
            var c = dinx.vand(a,b);
            return BitMatrix16.From(c);
        }

        public static ref BitMatrix32 and(ref BitMatrix32 A, BitMatrix32 B)
        {
            const int rowstep = 8;
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                A.GetCells(i, out Vec256<uint> x);
                B.GetCells(i, out Vec256<uint> y);
                dinx.vand(x,y).StoreTo(ref A[i]);
            }
            return ref A;
        }

        /// <summary>
        /// Computes the logical AND between two primal bitmatrices of order 16
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 and(BitMatrix32 A, BitMatrix32 B)
        {
            var C = A.Replicate();
            return and(ref C, B);
        }

        public static ref BitMatrix64 and(ref BitMatrix64 A, BitMatrix64 B)
        {
            const int rowstep = 4;
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                A.GetCells(i, out Vec256<ulong> vLhs);
                B.GetCells(i, out Vec256<ulong> vRhs);
                dinx.vand(vLhs,vRhs).StoreTo(ref A[i]);
            }
            return ref A;
        }

        [MethodImpl(Inline)]
        public static BitMatrix64 and(BitMatrix64 A, BitMatrix64 B)
        {
            var C = A.Replicate();
            return and(ref C, B);
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
            var C = Alloc<N,T>();
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