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
        public static BitMatrix<T> or<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
        {
            var rc = math.min(A.RowCount, B.RowCount);
            var C = BitMatrix.Alloc<T>(rc);
            for(var i=0; i<rc; i++)
                C[i] = bitvector.or(A[i], B[i]);
            return C;
        }

        /// <summary>
        /// Computes the logical OR between two primal bitmatrices of order 8
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 or(in BitMatrix8 lhs, in BitMatrix8 rhs)
             => BitMatrix8.From((ulong)lhs | (ulong)rhs);             

        /// <summary>
        /// Computes the logical OR between two primal bitmatrices of order 16
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 or(in BitMatrix16 lhs, in BitMatrix16 rhs)
        {
            ref var A = ref lhs.GetCells(out Vec256<ushort> _);
            ref var B = ref rhs.GetCells(out Vec256<ushort> _);
            var C = dinx.vor(A,B);
            return BitMatrix16.From(in C);
        }

        /// <summary>
        /// Computes the logical Or between two primal bitmatrices of order 32
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        public static BitMatrix32 or(BitMatrix32 A, BitMatrix32 B)
        {
            const int rowstep = 8;
            var dst = BitMatrix32.Alloc();
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                var x1 = vload256(ref A[i]);
                var x2 = vload256(ref B[i]);
                dinx.vor(in x1, in x2).StoreTo(ref dst[i]);
            }
            return dst;
        }

        public static ref BitMatrix64 or(ref BitMatrix64 A, in BitMatrix64 B)
        {
            const int rowstep = 4;
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                A.GetCells(i, out Vec256<ulong> vLhs);
                B.GetCells(i, out Vec256<ulong> vRhs);
                dinx.vor(vLhs,vRhs).StoreTo(ref A[i]);
            }
            return ref A;
        }

        [MethodImpl(Inline)]
        public static BitMatrix64 or(BitMatrix64 A, BitMatrix64 B)        
        {
            var C = A.Replicate();
            return or(ref C, B);
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