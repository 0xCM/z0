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
        protected override int SampleSize => Pow2.T04;

        protected override int CycleCount => Pow2.T03;

        protected void nbm_and_check<N,T>(N n = default, T zero = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix(n,zero);
                var B = Random.BitMatrix(n,zero);
                var C1 = BitMatrix.and(A,B).Data;
                var C2 = mathspan.and(A.Data, B.Data);
                Claim.eq(A.Order, natval<N>());
                Claim.eq(B.Order, natval<N>());                
                Claim.eq(C1,C2);
            }
        }

        protected void nbm_xor_check<N,T>(N n = default, T zero = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix(n,zero);
                var B = Random.BitMatrix(n,zero);
                var C1 = BitMatrix.xor(A, B).Data;
                var C2 = mathspan.xor(A.Data, B.Data);
                Claim.eq(A.Order, natval<N>());
                Claim.eq(B.Order, natval<N>());                
                Claim.eq(C1,C2);
            }
        }

         protected void gbm_and_bench<T>(T zero = default)
            where T : unmanaged
        {
            var count = counter();
            var A = BitMatrix.alloc<T>();
            var B = BitMatrix.alloc<T>();
            var C = BitMatrix.alloc<T>();

            for(var i=0; i<OpCount; i++)
            {
                Random.BitMatrix<T>(ref A);
                Random.BitMatrix<T>(ref B);
                count.Start();
                BitMatrix.and(A,B, ref C);
                count.Stop();
            }

            var n = BitMatrix<T>.N;
            Benchmark($"bmand_{n}x{n}g", count);
        }

        protected void gbm_and_check<T>(T zero = default)
            where T : unmanaged
        {
            for(var i = 0; i< SampleSize; i++)
            {
                var A = Random.BitMatrix<T>();
                var B = Random.BitMatrix<T>();
                var C = BitMatrix.alloc<T>();                
                BitMatrix.and(A,B, ref C);

                var rbA = A.ToRowBits();
                var rbB = B.ToRowBits();
                var rbC = rbA & rbB;

                Claim.yea(BitMatrix.same(rbC.ToBitMatrix(),C));                                                                     
            }
        }

       protected void gbm_xor_check<T>(T zero = default)
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            for(var i=0; i<SampleSize; i++)
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

        protected void nbm_check_extract<M,N,T>(BitMatrix<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var row=0; row< src.RowCount; row++)
            {
                var vector = src.GetRow(row);
                for(var col=0; col<vector.Width; col++)
                    Claim.eq(vector[col], src[row,col]);
            }
        }

        protected void nbm_transpose_check<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var sample = 0; sample <SampleSize; sample++)
            {
                var A = Random.BitMatrix(m,n,zero);
                var B = A.Transpose();
                for(var i=0; i<B.RowCount; i++)
                for(var j=0; j<B.ColCount; j++)
                    Claim.eq(B[i,j], A[j,i]);
            }
        }

    }
}