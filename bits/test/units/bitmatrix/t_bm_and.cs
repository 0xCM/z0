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

        public void bmand_8x8g_check()
            => bmand_check<byte>();

        public void bmand_16x16g_check()
            => bmand_check<ushort>();

        public void bmand_32x32g_check()
            => bmand_check<uint>();

        public void bmand_64x64g_check()
            => bmand_check<ulong>();
        
        public void bmand_8x8g_bench()
            => bmand_gbench<byte>();

        public void bmand_16x16g_bench()
            => bmand_gbench<ushort>();

        public void bmand_32x32g_bench()
            => bmand_gbench<uint>();

        public void bmand_64x64g_bench()
            => bmand_gbench<ulong>();

        public void bmand_ng_64x64x64g_check()
            => bmand_NxNg_check<N64,ulong>();

        public void bmand_ng_37x37x16g_check()
            => bmand_NxNg_check<N64,ushort>();

        public void bmand_ng_256x256x32g_check()
            => bmand_NxNg_check<N256,uint>();


        public void bmand_8x8x8d_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix(n8);
                var B = Random.BitMatrix(n8);
                Span<byte> dst = new byte[8];
                for(var j=0; j<dst.Length; j++)
                    dst[j] = (byte)(A.Bytes[j] & B.Bytes[j]);
                var expect = BitMatrix8.From(dst);
                var C = A & B;
                Claim.yea(expect == C);                
            }
        }

        public void bmand_32x32x32d_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix32();
                var B = Random.BitMatrix32();
                var C = A & B;

                var D = BitMatrix32.From(mathspan.and(A.Bytes, B.Bytes));
                Claim.yea(C == D);
            }
        }

        public void bmand_32x32x32g_check()
        {            
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix<N32,uint>();
                var B = Random.BitMatrix<N32,uint>();
                var C1 = BitMatrix.and(in A, in B);
                var C2 = BitMatrix32.From(C1);
                var C3 = BitMatrix32.From(A) & BitMatrix32.From(B);
                Claim.yea(C2 == C3);                    
            }
        }

        public void bmand_64x64x64d_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix64();
                var B = Random.BitMatrix64();
                var C = A & B;

                var D = BitMatrix64.From(mathspan.and(A.Bytes, B.Bytes));
                Claim.yea(C == D);
            }
        }

        void bmand_NxNg_check<N,T>()
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

        public void bmand_64x64x64g_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix<N64,ulong>();
                var B = Random.BitMatrix<N64,ulong>();
                var C1 = BitMatrix.and(in A, in B);
                var C2 = BitMatrix64.From(C1);
                var C3 = BitMatrix64.From(A) & BitMatrix64.From(B);
                Claim.yea(C2 == C3);                    
            }
        }

         void bmand_gbench<T>()
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

        void bmand_check<T>()
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