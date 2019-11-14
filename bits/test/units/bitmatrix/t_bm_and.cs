//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bm_and : BitMatrixTest<t_bm_and>
    {
        protected override int CycleCount => Pow2.T10;


        public void bm_and_8x8g()
            => bm_and_check<byte>();

        public void bm_and_16x16g()
            => bm_and_check<ushort>();

        public void bm_and_32x32g()
            => bm_and_check<uint>();

        public void bm_and_64x64g()
            => bm_and_check<ulong>();
        
        public void bm_and_8x8g_bench()
            => bm_and_bench<byte>();

        public void bm_and_16x16g_bench()
            => bm_and_bench<ushort>();

        public void bm_and_32x32g_bench()
            => bm_and_bench<uint>();

        public void bm_and_64x64g_bench()
            => bm_and_bench<ulong>();

        public void bm_and_64x64ng()
            => bm_and_check<N64,ulong>();

        public void bm_and_64x16ng()
            => bm_and_check<N64,ushort>();

        public void bm_and_256x256ng()
            => bm_and_check<N256,uint>();

        void bm_and_check<N,T>()
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix<N,T>();
                var B = Random.BitMatrix<N,T>();
                var C1 = BitMatrix.and(in A, in B).Data;
                var C2 = mathspan.and(A.Data, B.Data);
                Claim.eq(C1,C2);
            }
        }

         void bm_and_bench<T>()
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

        void bm_and_check<T>()
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
    }
}