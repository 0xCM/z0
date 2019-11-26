//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_pbm_and : t_bm<t_pbm_and>
    {                
        public void pbm_and_4x4()
        {
            var n = n4;
            for(var i=0; i<SampleSize; i++)
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

        public void pbm_and_8x8()
        {
            var n = n8;
            Span<byte> dst = stackalloc byte[8];
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix(n8);
                var B = Random.BitMatrix(n8);
                var C = A & B;

                for(var j=0; j<dst.Length; j++)
                    dst[j] = (byte)(A.Bytes[j] & B.Bytes[j]);

                var D = BitMatrix.primal(n,dst);
                Claim.yea(D == C);                
            }
        }

        public void pbm_and_32x32()
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

        public void pbm_and_64x64()
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
    }

}