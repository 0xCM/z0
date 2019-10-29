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
        [MethodImpl(Inline)]
        public static unsafe BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var C = BitMatrix.alloc<T>();
            BitPoints.or(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> C)
            where T : unmanaged
        {
            BitPoints.or(A.HeadPtr,B.HeadPtr,C.HeadPtr);
            return ref C;
        }

        /// <summary>
        /// Computes the logical OR between two primal bitmatrices of order 8
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 or(BitMatrix8 lhs, BitMatrix8 rhs)
             => BitMatrix8.From((ulong)lhs | (ulong)rhs);             

        /// <summary>
        /// Computes the logical OR between two primal bitmatrices of order 16
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 or(BitMatrix16 A, BitMatrix16 B, BitMatrix16 C)
        {
            A.Load(out Vector256<ushort> vA);
            B.Load(out Vector256<ushort> vB);
            dinx.vor(vA,vB).StoreTo(ref C.Head);
            return C;
        }

        [MethodImpl(Inline)]
        public static BitMatrix16 or(BitMatrix16 A, BitMatrix16 B)
            => or(A,B, BitMatrix16.Alloc());

        [MethodImpl(Inline)]
        static void or(int step, BitMatrix32 A, BitMatrix32 B, BitMatrix32 C)
        {
            A.Load(step, out Vector256<uint> x);
            B.Load(step, out Vector256<uint> y);
            dinx.vor(x,y).StoreTo(ref C[step]);
        }

        [MethodImpl(Inline)]
        public static BitMatrix32 or(BitMatrix32 A, BitMatrix32 B, BitMatrix32 C)
        {
            or(0,A,B,C);
            or(8,A,B,C);
            or(16,A,B,C);
            or(24,A,B,C);
            return C;
        }

        /// <summary>
        /// Computes the logical Or between two primal bitmatrices of order 32
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        public static BitMatrix32 or(BitMatrix32 A, BitMatrix32 B)
            => or(A,B, BitMatrix32.Alloc());

        [MethodImpl(Inline)]
        static void or(int step, BitMatrix64 A, BitMatrix64 B, BitMatrix64 C)
        {
            A.Load(step, out Vector256<ulong> x);
            B.Load(step, out Vector256<ulong> y);
            dinx.vand(x,y).StoreTo(ref C[step]);
        }


        public static ref BitMatrix64 or(ref BitMatrix64 A, in BitMatrix64 B)
        {
            const int step = 4;
            for(var i=0; i< A.RowCount; i += step)
            {
                A.Load(step, out Vector256<ulong> x);
                B.Load(step, out Vector256<ulong> y);
                dinx.vor(x,y).StoreTo(ref A[i]);
            }
            return ref A;
        }

        [MethodImpl(Inline)]
        public static BitMatrix64 or(BitMatrix64 A, BitMatrix64 B)        
        {
            var C = A.Replicate();
            return or(ref C, B);
        }

    }

}