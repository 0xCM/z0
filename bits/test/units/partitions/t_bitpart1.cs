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
    using static BitParts;

    public class t_bitpart1 : BitPartTest<t_bitpart1>
    {

        protected override int CycleCount => Pow2.T18;        

        public void bitpart_32x1()
        {
            Span<byte> dst = stackalloc byte[32];
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.BitVector(n32);
                BitParts.part32x1(src, dst);
                var bs = src.ToBitString();

                for(var j=0; j<dst.Length; j++)
                    Claim.eq(src[j],(Bit)dst[j]);
                

            }
        }

        public void bitpart_64x1_check()
        {
            Span<byte> dst = stackalloc byte[64];
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.BitVector(n64);
                BitParts.part64x1(src, dst);
                var bs = src.ToBitString();
                for(var j=0; j<dst.Length; j++)
                    Claim.eq(src[j],(Bit)dst[j]);
                

            }
        }

        public void bitpart_64x1_bench()
        {

            var opname = "part64x1";
            var sw = stopwatch(false);
            Span<byte> dst = stackalloc byte[64];
            for(var i=0; i< OpCount; i++)  
            {
                var src = Random.Next<ulong>();
                sw.Start();
                BitParts.part64x1(src, dst);
                sw.Stop();
            }
            Collect((OpCount, sw, opname));

        }
        
        public void bitpart_32x1_bench()
        {        
            var opname = "part32x1_span";
            var sw = stopwatch(false);
            Span<byte> dst = stackalloc byte[32];
            for(var i=0; i< OpCount; i++)  
            {
                var src = Random.Next<uint>();
                sw.Start();
                BitParts.part32x1(src, dst);
                sw.Stop();
            }
            Collect((OpCount, sw, opname));
        }

    }

}