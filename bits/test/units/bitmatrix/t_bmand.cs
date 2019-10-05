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
    using static nfunc;
    
    public class tbm_and : BitMatrixTest<tbm_and>
    {
        void bm_and_4x4_check_fixme()
        {            
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitMatrix(n4);
                var y = Random.BitMatrix(n4);

                var xBytes = x.Data.Replicate();
                var yBytes = y.Data.Replicate();
                var zBytes = mathspan.xor(xBytes, yBytes);
                var expect = BitMatrix4.Define(zBytes);

                var actual = x ^ y;
                Claim.yea(expect == actual);                
            }
        }


        public void ms_and_8u_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Span<byte>(SampleSize);
                var y = Random.Span<byte>(SampleSize);
                var z0 = mathspan.and(x,y);
                for(var j=0; j<z0.Length; j++)
                    Claim.eq((byte)(x[i] & y[i]), z0[i]);
            }
        }

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


                //var expect = BitMatrix8.From(mathspan.and(A.Bytes.Replicate(), B.Bytes));

                var C = A & B;

                Claim.yea(expect == C);                
            }
        }

        public void bmand_8x8x8g_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix<N8,byte>();
                var B = Random.BitMatrix<N8,byte>();
                sw.Start();
                var result = A & B;                               
                sw.Stop();
            }
            Collect((SampleSize, sw, "bmand_8x8x8g"));            
        }


        public void bmand_16x16x16d_bench()
        {
            var count = counter();
            for(var i=0; i<OpCount; i++)
            {
                var x = Random.BitMatrix(n16);
                var y = Random.BitMatrix(n16);
                count.Start();
                var result = x & y;                               
                count.Stop();
            }
            Benchmark("bmand_16x16x16d", count);            
        }

        public void bmand_16x16x16g_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<OpCount; i++)
            {
                var A = Random.BitMatrix<N16,ushort>();
                var B = Random.BitMatrix<N16,ushort>();
                sw.Start();
                var result = A & B;                               
                sw.Stop();
            }
            Collect((OpCount, sw, "bmand_16x16x16g"));            
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

        public void bmand_32x32x32d_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<OpCount; i++)
            {
                var x = Random.BitMatrix(n32);
                var y = Random.BitMatrix(n32);
                sw.Start();
                var result = x & y;                               
                sw.Stop();
            }
            OpTime time = (OpCount, sw, "bmand_32x32x32d");            
            Collect(time);
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

        public void bmand_32x32x32g_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<OpCount; i++)
            {
                var A = Random.BitMatrix<N32,uint>();
                var B = Random.BitMatrix<N32,uint>();
                sw.Start();
                var result = A & B;                               
                sw.Stop();
            }
            Collect((OpCount, sw, "bmand_32x32x32g"));            
        }

        public void bmand_63x63x8g_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<OpCount; i++)
            {
                var A = Random.BitMatrix<N63,byte>();
                var B = Random.BitMatrix<N63,byte>();
                sw.Start();
                var result = A & B;                               
                sw.Stop();
            }
            Collect((OpCount, sw, "bmand_63x63x8g"));            
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

        public void bmand_64x64x64d_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<OpCount; i++)
            {
                var x = Random.BitMatrix(n64);
                var y = Random.BitMatrix(n64);
                sw.Start();
                var result = x & y;                               
                sw.Stop();
            }
            Collect((OpCount, sw, "bmand_64x64x64d"));            
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
         
        public void bmand_64x64x64g_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<OpCount; i++)
            {
                var A = Random.BitMatrix<N64,ulong>();
                var B = Random.BitMatrix<N64,ulong>();
                sw.Start();
                var result = A & B;                               
                sw.Stop();
            }
            Collect((OpCount, sw, "bmand_64x64x64g"));            
        }


    }

}