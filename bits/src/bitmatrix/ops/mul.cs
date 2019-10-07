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

        public static ref BitMatrix8 mul(ref BitMatrix8 A, BitMatrix8 B)
        {
            var C = B.Transpose();
            var n = 8;

            for(var i=0; i< n; i++)
            {
                var r = A.RowVector(i);
                var z = BitVector8.Alloc();
                for(var j = 0; j< n; j++)
                    z[j] = r % C.RowVector(j);
                A[i] = (byte)z;
            }
            return ref A;
        }

        [MethodImpl(Inline)]
        public static BitMatrix8 mul(BitMatrix8 A, BitMatrix8 B)
        {
            var C = A.Replicate();
            return mul(ref C, B);
        }

        
        public static BitVector16 mul(BitMatrix16 A, BitVector16 x)
        {
            const int N = 16;
            var dst = BitVector16.Alloc();
            for(var i=0; i< N; i++)
                dst[i] = A.RowVector(i) % x;
            return dst;        
        }

        public static BitMatrix16 mul(BitMatrix16 A, BitMatrix16 B)
        {
            var x = A.Replicate();
            var y = B.Transpose();
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
            var C = B.Transpose();            
            
            for(var i=0; i< N; i++)
            {
                var r = A.RowVector(i);
                var z = BitVector32.Alloc();
                for(var j = 0; j< N; j++)
                    z[j] = r % C.RowVector(j);
                A[i] = (uint)z;
            }
            return ref A;

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
            var y = BitVector32.Alloc();
            for(var i=0; i< N; i++)
                y[i] = A.RowVector(i) % x;
            return y;        
        }

        public static ref BitMatrix64 mul(ref BitMatrix64 A, BitMatrix64 B)
        {
            const int N = 64;                        
            var C = B.Transpose();
            for(var i=0; i< N; i++)
            {
                ref readonly var row = ref A.RowData(i);
                var z = BitVector64.Alloc();
                for(var j=0; j< N; j++)
                    z[j] = Z0.bitvector.dot(row, C.RowData(j));
                A[i] = (ulong)z;
            }

            return ref A;
        }

        [MethodImpl(Inline)]
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
            {
                var row = x.RowVector(i);
                for(var j=0; j<n; j++)
                    C[i,j] = row % y.RowVector(j);
            }

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
            {
                var row = x.RowVector(i);
                for(var j=0; j<n; j++)
                    C[i,j] = row % y.RowVector(j);
            }

            return ref C;
        }
    }
}