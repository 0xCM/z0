//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_bm_mul : BitMatrixTest<t_bm_mul>
    {
        public void bmm_4x4_bench()
        {
            var sw = stopwatch(false);
            var last = BitMatrix4.Zero;

            for(var i=0; i< OpCount; i++)
            {
                var m1 = Random.BitMatrix4();
                var m2 = Random.BitMatrix4();
                sw.Start();
                last = m1 * m2;
                sw.Stop();
            }
            Collect((OpCount, snapshot(sw), "bmm_4x4"));
        }

        public void bmm_8x8()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var m1 = Random.BitMatrix8();
                var m2 = m1.Replicate();
                var m3 = Random.BitMatrix8();
                var m4 = m2 * m3;
                var m5 = BitRef.bmm(m1,m3);
                Claim.yea(m4 == m5);
            }            
        }

        public void bmm_8x8_bench()
        {
            var sw = stopwatch(false);
            var last = BitMatrix8.Zero;
            
            for(var i = 0; i < OpCount; i++)
            {
                var m1 = Random.BitMatrix8();
                var m2 = Random.BitMatrix8();
                sw.Start();
                last = m1 * m2;
                sw.Stop();
            }

            Collect((OpCount, snapshot(sw), "bmm_8x8"));
        }

        public void bmm_16x16_bench()
        {
            
            var last = BitMatrix16.Zero;

            var sw = stopwatch(false);
            for(var i=0; i< OpCount; i++)
            {
                var m1 = Random.BitMatrix16();
                var m2 = Random.BitMatrix16();
                sw.Start();
                last = m1 * m2;
                sw.Stop();
            }

            Collect((OpCount, snapshot(sw), "bmm_16x16"));
        }

        public void bmm_32x32()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var m1 = Random.BitMatrix(n32);
                var m2 = m1.Replicate();
                var m3 = Random.BitMatrix(n32);
                var m4 = m2 * m3;
                var m5 = BitRef.bmm(m1,m3);
                Claim.yea(m4 == m5);
            }            
        }

        public void bmm_32x32_bench()
        {
            var last = BitMatrix32.Zero;            
            var sw = stopwatch(false);

            var dst = BitMatrix.alloc(n32);
            for(var i=0; i< OpCount; i++)
            {
                var m1 = Random.BitMatrix(n32);
                var m3 = Random.BitMatrix(n32);
                sw.Start();
                last = m1 * m3;
                sw.Stop();                    
            }

            Collect((OpCount, snapshot(sw), "bmm_32x32_op"));
        }

        void bmm_64x64x64_()
        {
            var Aup = Matrix.alloc<N64,byte>();
            var Bup = Matrix.alloc<N64,byte>();
            var Cup = Matrix.alloc<N64,byte>();
            var A = Random.BitMatrix64();
            var B = Random.BitMatrix64();
            var C = A * B;

            BitMatrix.unpack(A,ref Aup);
            BitMatrix.unpack(B,ref Bup);
            IntMatrix.mul(Aup, Bup, ref Cup);
            Cup.Apply(x => even(x) ? (byte)0 : (byte)1);
            Trace(C.Format());
            Trace(Cup.Format());

        }
        
        public void bmm_64x64x64u_check()
        {
            for(var sample = 0; sample < SampleSize; sample++)
            {
                var A = Random.BitMatrix64();
                var B = Random.BitMatrix64();
                var C1 = BitMatrix.mul(A,B);
                //TODO
            }
        }

        public void bmv_64x64x64u_64u()
        {
            for(var sample = 0; sample < SampleSize; sample++)            
            {
                var A = Random.BitMatrix64();
                var x = Random.BitVector(n64);
                var z = A * x;            
                var y = BitVector64.Alloc();
                for(var i = 0; i<A.Order; i++)           
                {
                    var r = A[i];
                    y[i] = r % x;
                }
                
                Claim.yea(z == y);
            }
        }


        public void bmm_64x64x64u_bench()
        {
            run_bmm_64x64_bench();
        }

        void run_bmm_64x64_bench(SystemCounter counter = default)
        {
            var last = BitMatrix64.Zero;  
                        
            for(var i=0; i < OpCount; i++)
            {
                var m1 = Random.BitMatrix64();
                var m2 = Random.BitMatrix64();
                counter.Start();
                last = BitMatrix.mul(m1, m2);
                counter.Stop();                
            }

            Benchmark($"bmm_64x64x64u_new",counter);
        }



        public void bmv_8x8()
        {
            for(var sample = 0; sample < SampleSize; sample++)            
            {
                var m = Random.BitMatrix8();
                var c = Random.BitVector(n8);
                var z1 = m * c;            
                var z2 = BitVector8.Alloc();
                for(var i = 0; i<m.Order; i++)           
                    z2[i] = m[i] % c;
                
                Claim.yea(z1 == z2);
            }
        }

        public void bmv_16x16()
        {
            for(var sample = 0; sample < SampleSize; sample++)            
            {
                var m = Random.BitMatrix16();
                var c = Random.BitVector(n16);
                var z1 = m * c;            
                var z2 = BitVector16.Alloc();
                for(var i = 0; i<m.RowCount; i++)           
                {
                    var r = m[i];
                    z2[i] = r % c;
                }
                
                Claim.yea(z1 == z2);
            }
        }

        public void bmv_32x32()
        {
            for(var sample = 0; sample < SampleSize; sample++)            
            {
                var m = Random.BitMatrix32();
                var c = Random.BitVector(n32);
                var z1 = m * c;            
                var z2 = BitVector.alloc(n32);
                for(var i = 0; i<m.Order; i++)           
                {
                    var r = m[i];
                    z2[i] = r % c;
                }
                
                Claim.yea(z1 == z2);
            }
        }
    }

}