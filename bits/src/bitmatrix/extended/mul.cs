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
        /// <summary>
        /// Applies a bitmatrix to a bitvector to yield a transformed bitvector
        /// </summary>
        /// <param name="A">The bitmatrix that defines the transformation</param>
        /// <param name="x">The vector to be transformed</param>
        public static BitVector<T> mul<T>(BitMatrix<T> A, BitVector<T> x)
            where T : unmanaged
        {
            var n = BitMatrix<T>.N;
            var dst = BitVector.alloc<T>();
            for(var i=0; i< n; i++)
                dst[i] = BitVector.dot(A[i], x);
            return dst;        
        }

        /// <summary>
        /// Applies a bitmatrix to a bitvector to yield a transformed bitvector
        /// </summary>
        /// <param name="A">The bitmatrix that defines the transformation</param>
        /// <param name="x">The vector to be transformed</param>
        public static BitVector4 mul(BitMatrix4 A, BitVector4 x)
        {
            var n = BitMatrix4.N;
            var dst = BitVector.alloc(n);
            for(var i=0; i< n; i++)
                dst[i] = A.RowVector(i) % x;
            return dst;        
        }

        /// <summary>
        /// Applies a bitmatrix to a bitvector to yield a transformed bitvector
        /// </summary>
        /// <param name="A">The bitmatrix that defines the transformation</param>
        /// <param name="x">The vector to be transformed</param>
        public static BitVector8 mul(BitMatrix8 lhs, BitVector8 rhs)
        {
            var n = BitMatrix8.N;
            var dst = BitVector.alloc(n);
            for(var i=0; i< n; i++)
                dst[i] = lhs.RowVector(i) % rhs;
            return dst;        
        }

        /// <summary>
        /// Multiplies two primal bitmatrices of order 8, overwriting the left matrix with the result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        public static ref BitMatrix8 mul(ref BitMatrix8 A, BitMatrix8 B)
        {
            var C = B.Transpose();
            var n = BitMatrix8.N;

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

        /// <summary>
        /// Multiplies two primal bitmatrices of order 8, returning the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        public static BitMatrix8 mul(BitMatrix8 A, BitMatrix8 B)
        {
            var C = A.Replicate();
            return mul(ref C, B);
        }
        
        public static BitVector16 mul(BitMatrix16 A, BitVector16 x)
        {
            var n = BitMatrix16.N;
            var dst = BitVector.alloc(n);
            for(var i=0; i< n; i++)
                dst[i] = A.RowVector(i) % x;
            return dst;        
        }

        public static BitMatrix16 mul(BitMatrix16 A, BitMatrix16 B)
        {
            var n = BitMatrix16.N;
            var X = A.Replicate();
            var Y = B.Transpose();

            var dst = BitMatrix.alloc(n);
            for(var i=0; i< n; i++)
            {
                var row = X.RowVector(i);
                for(var j = 0; j< n; j++)
                    dst[i,j] = Y.RowVector(j) % row;
            }
            return dst;
        }

        public static ref BitMatrix32 mul(ref BitMatrix32 A, BitMatrix32 B)
        {
            var n = BitMatrix32.N;
            var C = B.Transpose();            
            
            for(var i=0; i< n; i++)
            {
                var r = A.RowVector(i);
                var z = BitVector.alloc(n);
                for(var j = 0; j< n; j++)
                    z[j] = r % C.RowVector(j);
                A[i] = (uint)z;
            }
            return ref A;

        }

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
                    z[j] = Z0.BitVector.dot(row, C.RowData(j));
                A[i] = (ulong)z;
            }

            return ref A;
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
        /// <param name="Z">The target matrix</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        public static ref BitMatrix<M, N, T> mul<M,P,N,T>(in BitMatrix<M,P,T> A, in BitMatrix<P,N,T> B, ref BitMatrix<M,N,T> Z)
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
                    Z[i,j] = row % y.RowVector(j);
            }

            return ref Z;
        }

        [MethodImpl(NotInline)]
        public static BitMatrix<M, N, T> mul<M,P,N,T>(in BitMatrix<M,P,T> A, in BitMatrix<P,N,T> B)
            where M : ITypeNat, new()
            where P : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var Z = alloc<M,N,T>();
            mul(A,B, ref Z);
            return Z;
        }

        /// <summary>
        /// Computes the product of square bitmatrices of common natural order and stores the result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        public static ref BitMatrix<N,T> mul<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, ref BitMatrix<N,T> Z)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var tr = B.Transpose();
            var n = (int)new N().value;
            for(var i=0; i<n; i++)
            {
                var row = A[i];
                for(var j=0; j<n; j++)
                    Z[i,j] = row % tr.RowVector(j);
            }

            return ref Z;
        }    

        /// <summary>
        /// Computes the product of square bitmatrices of common natural order and returns the allocated result
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="Z">The target matrix</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(NotInline)]
        public static BitMatrix<N,T> mul<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var Z = alloc<N,T>();
            mul(A,B, ref Z);
            return Z;
        }
   }
}