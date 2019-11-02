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
    
    public class t_bmxor : BitMatrixTest<t_bmxor>
    {
        public void bmxor_16x16x16d_check()
        {
            for(var sample=0; sample<SampleSize; sample++)
            {
                var A = Random.BitMatrix(n16);
                var B = Random.BitMatrix(n16);
                var C = A ^ B;
                for(var i=0; i< C.RowCount; i++)
                for(var j=0; j< C.ColCount; j++)
                    Claim.eq(C[i,j], A[i,j] ^ B[i,j]);
            }
        }

        public void bmxor_32x32x32d_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix(n32);
                var B = Random.BitMatrix(n32);
                var C = A ^ B;

                var D = BitMatrix32.From(mathspan.xor(A.Bytes, B.Bytes));
                Claim.yea(C == D);
            }
        }

        public void bmxor_64x64x64d_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix64();
                var B = Random.BitMatrix64();
                var C = A ^ B;

                var D = BitMatrix64.From(mathspan.xor(A.Bytes, B.Bytes));
                Claim.yea(C == D);
            }
        }

        public void bmxor_16x16x16d_bench()
        {
            bm_xor_16x16_bench_noalloc();
            bm_xor_16x16_bench_alloc();
        }

        public void bmxor_32x32x32d_bench()
        {
            bm_xor_32x32_bench_noalloc();
        }

        public void bmxor_64x64x64d_bench()
        {
            bm_xor_64x64_bench_noalloc();
        }

        /// <summary>
        /// Performs allocation during each operation of the benchmark period
        /// </summary>
        /// <param name="sw">The counter</param>
        void bm_xor_16x16_bench_alloc(SystemCounter sw = default)
        {
            var opname = "bm_xor_16x16_alloc";
            var last = default(BitMatrix16);
            for(var i=0; i<OpCount; i++)
            {
                var A = Random.BitMatrix(n16);
                var B = Random.BitMatrix(n16);
                sw.Start();
                last = BitMatrix.xor(A,B);
                sw.Stop();
            }
            
            Benchmark(opname,sw);
        }

        /// <summary>
        /// Performs no allocation during the benchmark period
        /// </summary>
        /// <param name="sw">The counter</param>
        void bm_xor_16x16_bench_noalloc(SystemCounter sw = default)
        {
            var opname = "bm_xor_16x16";
            var C = BitMatrix16.Alloc();
            for(var i=0; i<OpCount; i++)
            {
                var A = Random.BitMatrix(n16);
                var B = Random.BitMatrix(n16);
                sw.Start();
                BitMatrix.xor(A, B, ref C);
                sw.Stop();
            }
            
            Benchmark(opname,sw);

        }

        /// <summary>
        /// Performs no allocation during the benchmark period
        /// </summary>
        /// <param name="sw">The counter</param>
        void bm_xor_32x32_bench_noalloc(SystemCounter sw = default)
        {
            var opname = "bm_xor_32x32";
            var last = BitMatrix.alloc(n32);
            for(var i=0; i<OpCount; i++)
            {
                var A = Random.BitMatrix(n32);
                var B = Random.BitMatrix(n32);
                sw.Start();
                BitMatrix.xor(in A,in B, ref last);
                sw.Stop();
            }
            
            Benchmark(opname,sw);

        }

        /// <summary>
        /// Performs no allocation during the benchmark period
        /// </summary>
        /// <param name="sw">The counter</param>
        void bm_xor_64x64_bench_noalloc(SystemCounter sw = default)
        {
            var opname = "bm_xor_64x64";
            var C = BitMatrix64.Alloc();
            for(var i=0; i<OpCount; i++)
            {
                var A = Random.BitMatrix(n64);
                var B = Random.BitMatrix(n64);
                sw.Start();
                BitMatrix.xor(A, B, ref C);
                sw.Stop();
            }
            
            Benchmark(opname,sw);

        }

    }

}