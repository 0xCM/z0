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

        public static BitVector16 mul(in BitMatrix16 m, in BitVector16 y)
        {
            const int N = 16;
            var dst = BitVector16.Alloc();
            for(var i=0; i< N; i++)
                dst[i] = m.RowVector(i) % y;
            return dst;        
        }

        public static BitMatrix16 mul(in BitMatrix16 lhs, in BitMatrix16 rhs)
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


        /// <summary>
        /// Computes the product of 64-bit bitmatrices
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        public static BitMatrix64 mul(in BitMatrix64 A, in BitMatrix64 B)
        {
            var x = A;
            var y = B.Transpose();
            var C = BitMatrix64.Alloc();
            const int N = 64;

            for(var i=0; i< N; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector64.Alloc();
                for(var j = 0; j< N; j++)
                    z[j] = r % y.RowVector(j);
                C[i] = (ulong)z;
            }
            return C;
        }

        /// <summary>
        /// Computes the product of 64-bit bitmatrices and stores the result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        public static ref BitMatrix64 mul(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 C)
        {
            var x = A;
            var y = B.Transpose();
            const int N = 64;

            for(var i=0; i< N; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector64.Alloc();
                for(var j = 0; j< N; j++)
                    z[j] = r % y.RowVector(j);
                C[i] = (ulong)z;
            }
            return ref C;
        }

        public static BitMatrix32 mul(in BitMatrix32 A, in BitMatrix32 B)
        {
            var dst = BitMatrix32.Alloc();
            var x = A;
            var y = B.Transpose();
            const int N = 32;

            for(var row=0; row < N; row++)
            {
                var r = x.RowVector(row);
                for(var col = 0; col < N; col++)
                    dst[row,col] = y.RowVector(col) % r;
            }
            return dst;
        }

        public static BitVector32 mul(in BitMatrix32 A, in BitVector32 x)
        {
            const int N = 32;

            var dst = BitVector32.Alloc();
            for(var i=0; i< N; i++)
                dst[i] = A.RowVector(i) % x;
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