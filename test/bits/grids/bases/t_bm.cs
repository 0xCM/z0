//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;
    using static Memories;
    using static CheckNumeric;

    public abstract class t_bm<X> : t_bitgrids_base<X>
        where X : t_bm<X>, new()
    {
        protected override int RepCount => Pow2.T04;

        protected override int CycleCount => Pow2.T03;

        protected void bm_and_check<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i<RepCount; i++)
            {
                var A = Random.BitMatrix(n,t);
                var B = Random.BitMatrix(n,t);
                var C1 = BitMatrix.and(A,B).Data;
                var C2 = gspan.and(A.Data, B.Data);
                eq(A.Order, nati<N>());
                eq(B.Order, nati<N>());                
                eq(C1,C2);
            }
        }

        protected void bm_and_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i = 0; i< RepCount; i++)
            {
                var A = Random.BitMatrix<T>();
                var B = Random.BitMatrix<T>();
                var C = BitMatrix.alloc<T>();                
                BitMatrix.and(A,B, ref C);

                var rbA = A.ToRowBits();
                var rbB = B.ToRowBits();
                var rbC = rbA & rbB;

                Claim.require(BitMatrix.same(rbC.ToBitMatrix(),C));                                                                     
            }
        }

        static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< Claim.length(lhs,rhs); i++)
                dst[i] = gmath.xor(lhs[i], rhs[i]);
           return dst;        
        }

        static Span<T> xor<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => xor(lhs,rhs, lhs);

        protected void bm_xor_check<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i<RepCount; i++)
            {
                var A = Random.BitMatrix(n,t);
                var B = Random.BitMatrix(n,t);
                var C1 = BitMatrix.xor(A, B).Data;
                var C2 = xor(A.Data, B.Data);
                eq(A.Order, nati<N>());
                eq(B.Order, nati<N>());                
                eq(C1,C2);
            }
        }

       protected void bm_xor_check<T>(T t = default)
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            for(var i=0; i<RepCount; i++)
            {
                var A = Random.BitMatrix<T>();
                var B = Random.BitMatrix<T>();
                BitMatrix.xor(A,B, ref Z);

                for(var j =0; j< Z.Order; j++)
                {
                    var a = A[i];
                    var b = B[i];                    
                    var z = Z[i];

                    var x = BitVector.xor(a,b);
                    require(x == z);
                }
            }
        }

        protected void bm_extract_check<M,N,T>(BitMatrix<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var row=0; row< src.RowCount; row++)
            {
                var vector = src.ReadRow(row);
                for(var col=0; col<vector.Width; col++)
                    eq(vector[col], src[row,col]);
            }
        }

        protected void bm_transpose_check<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var sample = 0; sample <RepCount; sample++)
            {
                var A = Random.BitMatrix(m,n,t);
                var B = A.Transpose();
                for(var i=0; i<B.RowCount; i++)
                for(var j=0; j<B.ColCount; j++)
                    eq(B[i,j], A[j,i]);
            }
        }

         protected void bm_and_bench<T>(T t = default)
            where T : unmanaged
        {
            var clock = counter();
            var A = BitMatrix.alloc<T>();
            var B = BitMatrix.alloc<T>();
            var C = BitMatrix.alloc<T>();

            for(var i=0; i<OpCount; i++)
            {
                Random.BitMatrix<T>(ref A);
                Random.BitMatrix<T>(ref B);
                clock.Start();
                BitMatrix.and(A,B,ref C);
                clock.Stop();
            }

            var n = BitMatrix<T>.N;
            ReportBenchmark($"bmand_{n}x{n}g", OpCount, clock);
        }
    }
}