//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class t_bzhi : ScalarBitTest<t_blsic>
    {
    
        public void bzhi_64u_check()
        {
            bzhi_check<ulong>();

            var dst = 0ul;
            Bits.puthi(7,ref dst);
            Bits.split(dst,out var lo, out var hi);

            Claim.eq(7,hi);
            Claim.eq(0,lo);
        }

        public void bzhi_8u_check()
        {
            bzhi_8u_check(2);
            bzhi_8u_check(3);
            bzhi_8u_check(4);
            bzhi_8u_check(5);
        }

        public void bzhi_16u_check()
        {
            bzhi_16u_check(3);
            bzhi_16u_check(5);
            bzhi_16u_check(8);
            bzhi_16u_check(9);
            bzhi_16u_check(13);

        }

        public void bzhi_32u_check()
        {
            bzhi_check<uint>();
        }

        public void bzhi_64u_bench()
        {
            bzhi_bench<ulong>();
        }

        public void bzhi_32u_bench()
        {
            bzhi_bench<uint>();
        }

        void bzhi_8u_check(byte maxlen)
        {
            byte source = 0xFF;
            var srclen = 8;

            var bs0 = source.ToBitString();
            var bv0 = bs0.ToBitVector(n8);

            Claim.eq(srclen, bs0.PopCount());
            Claim.eq(srclen, bs0.Length);

            Claim.eq(srclen, bv0.Pop());
            
            var bs1 = bs0.Truncate(maxlen);
            Claim.eq(maxlen, bs1.PopCount());
            Claim.eq(maxlen, bs1.Length);

            var bv1 = Bits.bzhi(bv0.Scalar, maxlen).ToBitVector();
            Claim.eq(maxlen, bv1.Pop());

            var bs2 = bs1.Pad(srclen);
            Claim.eq(srclen, bs2.Length);
            Claim.eq(maxlen, bs2.PopCount());
        }

        void bzhi_16u_check(byte maxlen)
        {
            var source = UInt16.MaxValue; 
            var srclen = 16;

            var bs0 = source.ToBitString();
            var bv0 = bs0.ToBitVector(n16);

            Claim.eq(srclen, bs0.PopCount());
            Claim.eq(srclen, bs0.Length);

            Claim.eq(srclen, bv0.Pop());
            
            var bs1 = bs0.Truncate(maxlen);
            Claim.eq(maxlen, bs1.PopCount());
            Claim.eq(maxlen, bs1.Length);

            var bv1 = Bits.bzhi(bv0.Scalar, maxlen).ToBitVector();
            Claim.eq(maxlen, bv1.Pop());

            var bs2 = bs1.Pad(srclen);
            Claim.eq(srclen, bs2.Length);
            Claim.eq(maxlen, bs2.PopCount());
        }

        void bzhi_check<T>()
            where T : unmanaged
        {
            var width = bitsize<T>();
            for(var i= 0; i< SampleSize; i++)
            {
                var x = Random.Next<T>();
                var j = Random.Next(2u, width - width/2);
                var y = gbits.bzhi(x, j);

                var x0 = gbits.range(x,0,j - 1);
                var y0 = gbits.range(y,0,j - 1);
                var y1 = gbits.range(y,j, width - 1);
                Claim.eq(x0,y0);
                Claim.nea(gmath.nonzero(y1));            
                        
            }
        }

        void bzhi_bench<T>(SystemCounter counter = default)
            where T : unmanaged
        {
            var last = default(T);
            var width = bitsize<T>();
            var j = Random.Next(2u, width - width/2);
            for(var i=0; i< OpCount; i++)
            {
                var x = Random.Next<T>();
                counter.Start();
                last = gbits.bzhi(x, j);
                counter.Stop();
            }


            Benchmark($"bzhi_g{moniker<T>()}", counter);

        }

    }

}
