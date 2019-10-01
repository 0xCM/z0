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
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {

        public static BitVector8 mul(BitMatrix8 lhs, BitVector8 rhs)
        {
            var dst = BitVector8.Alloc();
            for(var i=0; i< 8; i++)
                dst[i] = lhs.RowVector(i) % rhs;
            return dst;        
        }

        public static BitMatrix8 mul(BitMatrix8 lhs, BitMatrix8 rhs)
        {
            var x = lhs;
            var y = rhs.Transpose();
            var dst = BitMatrix8.Alloc();
            var n = 8;

            for(var i=0; i< n; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector8.Alloc();
                for(var j = 0; j< n; j++)
                    z[j] = r % y.RowVector(j);
                dst[i] = (byte)z;
            }
            return dst;
        }

        public static BitVector16 mul(BitMatrix16 m, BitVector16 y)
        {
            const int N = 16;
            var dst = BitVector16.Alloc();
            for(var i=0; i< N; i++)
                dst[i] = m.RowVector(i) % y;
            return dst;        
        }

        public static BitMatrix16 mul(BitMatrix16 lhs, BitMatrix16 rhs)
        {
            var x = lhs.Replicate();
            var y = rhs.Transpose();
            const int N = 16;

            var dst = BitMatrix16.Alloc();
            for(var i=0; i< N; i++)
            {
                var r = x.RowVector(i);
                for(var j = 0; j< N; j++)
                    dst[i,j] = y.RowVector(j) % r;
            }
            return dst;
        }

        public static ref BitMatrix32 mul(ref BitMatrix32 A, BitMatrix32 B)
        {
            const int N = 32;

            var x = A;
            var y = B.Transpose();
            ref var dst = ref A;

            for(var i=0; i< N; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector32.Alloc();
                for(var j = 0; j< N; j++)
                    z[j] = r % y.RowVector(j);
                dst[i] = (uint)z;
            }
            return ref dst;

        }

        [MethodImpl(Inline)]
        public static BitMatrix32 mul(BitMatrix32 A, BitMatrix32 B)
        {
            var C = A.Replicate();
            return mul(ref C, B);
        }

        public static BitVector32 mul(BitMatrix32 A, BitVector32 x)
        {
            const int N = 32;
            var dst = BitVector32.Alloc();
            for(var i=0; i< N; i++)
                dst[i] = A.RowVector(i) % x;
            return dst;        
        }

        public static ref BitMatrix64 mul(ref BitMatrix64 A, BitMatrix64 B)
        {
            const int N = 64;                        
            var x = A;
            var y = B.Transpose();
            ref var dst = ref A;

            for(var i=0; i< N; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector64.Alloc();
                for(var j = 0; j< N; j++)
                    z[j] = r % y.RowVector(j);
                dst[i] = (ulong)z;
            }
            return ref dst;
        }

        public static BitMatrix64 mul(BitMatrix64 A, BitMatrix64 B)
        {
            var C = A.Replicate();
            return mul(ref C, B);
        }

        public static BitVector64 mul(BitMatrix64 A, BitVector64 B)
        {
            const int N = 64;                        
            var dst = BitVector64.Alloc();
            for(var i=0; i< N; i++)
                dst[i] = A.RowVector(i) % B;
            return dst;        
        }
        

        /// <summary>
        /// Computes the product of bitmatrices of comparible natural dimensions and stores the
        /// result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        public static ref BitMatrix<M, N, T> mul<M,P,N,T>(in BitMatrix<M,P,T> A, in BitMatrix<P,N,T> B, ref BitMatrix<M,N,T> C)
            where M : ITypeNat, new()
            where P : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var x = A;
            var y = B.Transpose();
            var n = (int)new N().value;
            for(var i=0; i<n; i++)
            for(var j=0; j<n; j++)
                C[i,j] = x.RowVector(i) % y.RowVector(j);

            return ref C;
        }

        /// <summary>
        /// Computes the product of square bitmatrices of common natural order and stores the
        /// result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        public static ref BitMatrix<N,T> mul<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, ref BitMatrix<N,T> C)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var x = A;
            var y = B.Transpose();
            var n = (int)new N().value;
            for(var i=0; i<n; i++)
            for(var j=0; j<n; j++)
                C[i,j] = x.RowVector(i) % y.RowVector(j);

            return ref C;
        }

    }

}