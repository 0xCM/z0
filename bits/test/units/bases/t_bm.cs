//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public abstract class t_bm<X> : t_bits<X>
        where X : t_bm<X>, new()
    {
        protected override int SampleCount => Pow2.T04;

        protected override int CycleCount => Pow2.T03;

        protected void bm_and_check<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i<SampleCount; i++)
            {
                var A = Random.BitMatrix(n,t);
                var B = Random.BitMatrix(n,t);
                var C1 = BitMatrix.and(A,B).Data;
                var C2 = mathspan.and(A.Data, B.Data);
                Claim.eq(A.Order, natval<N>());
                Claim.eq(B.Order, natval<N>());                
                Claim.eq(C1,C2);
            }
        }

        protected void bm_and_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i = 0; i< SampleCount; i++)
            {
                var A = Random.BitMatrix<T>();
                var B = Random.BitMatrix<T>();
                var C = BitMatrix.alloc<T>();                
                BitMatrix.and(A,B, C);

                var rbA = A.ToRowBits();
                var rbB = B.ToRowBits();
                var rbC = rbA & rbB;

                Claim.yea(BitMatrix.same(rbC.ToBitMatrix(),C));                                                                     
            }
        }

        protected void bm_xor_check<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i<SampleCount; i++)
            {
                var A = Random.BitMatrix(n,t);
                var B = Random.BitMatrix(n,t);
                var C1 = BitMatrix.xor(A, B).Data;
                var C2 = mathspan.xor(A.Data, B.Data);
                Claim.eq(A.Order, natval<N>());
                Claim.eq(B.Order, natval<N>());                
                Claim.eq(C1,C2);
            }
        }

       protected void bm_xor_check<T>(T t = default)
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            for(var i=0; i<SampleCount; i++)
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
                    Claim.yea(x == z);
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
                    Claim.eq(vector[col], src[row,col]);
            }
        }

        protected void bm_transpose_check<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var sample = 0; sample <SampleCount; sample++)
            {
                var A = Random.BitMatrix(m,n,t);
                var B = A.Transpose();
                for(var i=0; i<B.RowCount; i++)
                for(var j=0; j<B.ColCount; j++)
                    Claim.eq(B[i,j], A[j,i]);
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
                BitMatrix.and(A,B,C);
                clock.Stop();
            }

            var n = BitMatrix<T>.N;
            ReportBenchmark($"bmand_{n}x{n}g", OpCount, clock);
        }



    }
}