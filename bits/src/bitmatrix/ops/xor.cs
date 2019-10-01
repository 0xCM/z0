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

    partial class BitMatrix
    {
        /// <summary>
        /// Computes the logical XOR between two primal bitmatrices of order 8
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 xor(in BitMatrix8 A, in BitMatrix8 B)
             => BitMatrix8.From((ulong)A ^ (ulong)B);             

        /// <summary>
        /// Computes the logical XOR between two primal bitmatrices of order 16
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix16 xor(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 C)
        {
            dinx.vxor(Vec256.Load(ref A[0]), Vec256.Load(ref B[0])).StoreTo(ref C[0]);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static BitMatrix16 xor(BitMatrix16 lhs, BitMatrix16 rhs)
        {
            var dst = BitMatrix16.Alloc();
            lhs.GetCells(out Vec256<ushort> vLhs);
            rhs.GetCells(out Vec256<ushort> vRhs);
            dinx.vxor(vLhs,vRhs).StoreTo(ref dst.Data[0]);
            return dst;
        }

        public static BitMatrix32 xor(in BitMatrix32 A, in BitMatrix32 B)
        {
            const int rowstep = 8;
            var dst = BitMatrix32.Alloc();
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                var x1 = vload256(ref A[i]);
                var x2 = vload256(ref B[i]);
                dinx.vxor(in x1,in x2).StoreTo(ref dst[i]);
            }
            return dst;
        }


        /// <summary>
        /// Computes the logical XOR between two primal bitmatrices of order 32
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        public static ref BitMatrix32 xor(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 C)
        {
            const int rowstep = 8;
            for(var i=0; i< A.RowCount; i += rowstep)
                dinx.vxor(Vec256.Load(ref A[i]), Vec256.Load(ref B[i])).StoreTo(ref C[i]);
            return ref C;
        }

        public static ref BitMatrix64 xor(ref BitMatrix64 A, BitMatrix64 B)
        {
            const int rowstep = 4;
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                A.GetCells(i, out Vec256<ulong> vLhs);
                B.GetCells(i, out Vec256<ulong> vRhs);
                dinx.vxor(vLhs,vRhs).StoreTo(ref A[i]);
            }
            return ref A;
        }


        /// <summary>
        /// Computes the logical XOR between two primal bitmatrices of order 64
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 xor(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = A.Replicate();
            return xor(ref C, B);
        }

        /// <summary>
        /// Computes the bitwise XOR between two square bitmatrices of common natural order and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<N,T> xor<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, ref BitMatrix<N,T> C)        
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.xor(A.Data, B.Data, C.Data);
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise XOR between two bitmatrices of common natural dimension and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<M,N,T> xor<M,N,T>(in BitMatrix<M,N,T> A, in BitMatrix<M,N,T> B, ref BitMatrix<M,N,T> C)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.xor(A.Data, B.Data, C.Data);
            return ref C;
        }
    }

}