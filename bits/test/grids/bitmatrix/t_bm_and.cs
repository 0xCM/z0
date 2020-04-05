//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Gone;
    
    public class t_bm_and : t_bm<t_bm_and>
    {
        public void bm_and_n64x64x64()
            => bm_and_check<N64,ulong>();

        public void bm_and_n64x64x16()
            => bm_and_check<N64,ushort>();

        public void bm_and_n256x256x32()
            => bm_and_check<N256,uint>();

        public void bm_and_g8x8x8()
            => bm_and_check<byte>();

        public void bm_and_g16x16x16()
            => bm_and_check<ushort>();

        public void bm_and_g32x32x16()
            => bm_and_check<uint>();

        public void bm_and_g64x64x64()
            => bm_and_check<ulong>();        

        void gbm_and_8x8g_bench()
            => bm_and_bench<byte>();

        void gbm_and_16x16g_bench()
            => bm_and_bench<ushort>();

        void gbm_and_32x32g_bench()
            => bm_and_bench<uint>();

        void gbm_and_64x64g_bench()
            => bm_and_bench<ulong>();

        public void bm_and_4x4x4()
        {
            var n = n4;
            for(var i=0; i<RepCount; i++)
            {
                var A = Random.BitMatrix(n);
                var B = Random.BitMatrix(n);
                var Z = A & B;
                
                var a = (ushort)A;
                var b = (ushort)B;
                var z = (ushort)Z;
                Claim.eq(math.and(a,b),z);
            }
        }

        public void bm_and_8x8x8()
        {
            var n = n8;
            Span<byte> dst = stackalloc byte[8];
            for(var i=0; i<RepCount; i++)
            {
                var A = Random.BitMatrix(n8);
                var B = Random.BitMatrix(n8);
                var C = A & B;

                for(var j=0; j<dst.Length; j++)
                    dst[j] = (byte)(A.Bytes[j] & B.Bytes[j]);

                var D = BitMatrix.primal(n,dst);
                Claim.require(D == C);                
            }
        }


        public void bm_and_32x32x32()
        {
            for(var i=0; i<RepCount; i++)
            {
                var A = Random.BitMatrix32();
                var B = Random.BitMatrix32();
                var C = A & B;

                var D = BitMatrix.from(n32,gspan.and(A.Bytes, B.Bytes));
                Claim.require(C == D);
            }
        }

        public void bm_and_64x64x64()
        {
            for(var i=0; i<RepCount; i++)
            {
                var A = Random.BitMatrix64();
                var B = Random.BitMatrix64();
                var C = A & B;

                var D = BitMatrix.primal(n64,gspan.and(A.Bytes, B.Bytes));
                Claim.require(C == D);
            }
        }
    }
}