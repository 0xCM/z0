//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

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
                var C1 = BitMatrixA.and(A,B).Content;
                var C2 = and(A.Content, B.Content);
                ClaimNumeric.eq(A.Order, nati<N>());
                ClaimNumeric.eq(B.Order, nati<N>());                
                ClaimNumeric.eq(C1,C2);
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
                BitMatrix.and(A,B,C);

                var rbA = A.ToRowBits();
                var rbB = B.ToRowBits();
                var rbC = rbA & rbB;

                Claim.require(BitMatrix.same(rbC.ToBitMatrix(),C));                                                                     
            }
        }

        Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< Claim.length(lhs,rhs); i++)
                dst[i] = gmath.xor(lhs[i], rhs[i]);
           return dst;        
        }

        Span<T> xor<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
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
                var C1 = BitMatrixA.xor(A, B).Content;
                var C2 = xor(A.Content, B.Content);
                ClaimNumeric.eq(A.Order, nati<N>());
                ClaimNumeric.eq(B.Order, nati<N>());                
                ClaimNumeric.eq(C1,C2);
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
                BitMatrix.xor(A,B, Z);

                for(var j =0; j< Z.Order; j++)
                {
                    var a = A[i];
                    var b = B[i];                    
                    var z = Z[i];

                    var x = BitVector.xor(a,b);
                    insist(x == z);
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
                {
                    var x = vector[col];
                    var y = src[row,col];
                    ClaimNumeric.eq(vector[col], src[row,col]);
                }
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
                    ClaimNumeric.eq(B[i,j], A[j,i]);
            }
        }

         protected void bm_and_bench<T>(T t = default)
            where T : unmanaged
        {
            var clock = counter();
            var a = BitMatrix.alloc<T>();
            var b = BitMatrix.alloc<T>();
            var c = BitMatrix.alloc<T>();

            for(var i=0; i<OpCount; i++)
            {
                Random.BitMatrix<T>(ref a);
                Random.BitMatrix<T>(ref b);
                clock.Start();
                BitMatrix.and(a, b, c);
                clock.Stop();
            }

            var n = BitMatrix<T>.N;
            ReportBenchmark($"bmand_{n}x{n}g", OpCount, clock);
        }
    }
}