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

        protected void nbm_and_check<N,T>()
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix<N,T>();
                var B = Random.BitMatrix<N,T>();
                var C1 = BitMatrix.and(in A, in B).Data;
                var C2 = mathspan.and(A.Data, B.Data);
                Claim.eq(A.Order, natval<N>());
                Claim.eq(B.Order, natval<N>());                
                Claim.eq(C1,C2);
            }
        }

         protected void gbm_and_bench<T>()
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

        protected void gbm_and_check<T>()
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

       protected void gbm_xor_check<T>()
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

        protected void bm_16x4_binary_check(Func<BitMatrix16x4,BitMatrix16x4,BitMatrix16x4> f, Func<ulong,ulong,ulong> g)
        {
            var m = n16;
            var n = n4;
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.Next<ulong>().ToPrimalBits(m,n);
                var B = Random.Next<ulong>().ToPrimalBits(m,n);
                var C = f(A,B);
                var Z = g(A,B).ToPrimalBits(m,n);
                var cbs = C.ToBitString();
                var zbs = Z.ToBitString();
                Claim.eq(zbs,cbs);
            }
        }

        protected void bm_16x4_unary_check(Func<BitMatrix16x4,BitMatrix16x4> f, Func<ulong,ulong> g)
        {
            var m = n16;
            var n = n4;
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.Next<ulong>().ToPrimalBits(m,n);
                var C = f(A);
                var Z = g(A).ToPrimalBits(m,n);
                var cbs = C.ToBitString();
                var zbs = Z.ToBitString();
                Claim.eq(zbs,cbs);
            }
        }

        protected void nbm_transpose_check<M,N,T>()
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var sample = 0; sample <SampleSize; sample++)
            {
                var src = Random.BitMatrix<M, N,T>();
                var tSrc = src.Transpose();
                for(var i=0; i<tSrc.RowCount; i++)
                for(var j=0; j<tSrc.ColCount; j++)
                    Claim.eq(tSrc[i,j], src[j,i]);
            }
        }

    }
}