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

    public class t_packing : BitPartTest<t_packing>
    {                    


        public void unpack_8x1_check()
        {
            for(var i=0; i<= 255; i++)            
            {
                byte b = (byte)i;
                var x = BitStore.bitseq(b);
                var y = BitStore.select(b);
                Claim.eq(x,y);

                var up1 = BitParts.unpack8x1((byte)i);
                Span<byte> up2 = stackalloc byte[8];
                BitParts.unpack8x1(b, up2);
                Claim.eq(BitString.FromBitSeq(up1), BitString.FromBitSeq(up2));
            }
        }

        public void unpack_64x1_check()
        {
            Span<byte> dst = stackalloc byte[64];

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.Next<ulong>();
                BitParts.unpack64x1(src, dst);
                var bitsPC = dst.PopCount();
                var bytes = Unmanaged.ByteSpan(ref src);
                var bytesPC = bytes.PopCount();
                Claim.eq(bitsPC, bytesPC);        
            }
        }

        public void unpack_32x1_check()
        {

            Span<byte> y1 = stackalloc byte[32];
            Span<byte> y2 = stackalloc byte[32];
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<uint>();
                BitParts.unpack32x1_bmi(x, y1);
                BitParts.unpack32x1(x, y2);
                Claim.eq(y1.ToBitString(), y2.ToBitString());
            }            
        }    
    
        public void unpack_32x1_bench()
        {
            run_unpack_32x1_bmibench();
            run_unpack_32x1_bench();
        }

        public void unpack_8x1_bench()
        {
            run_unpack_8x1_bench();
            run_unpack_8x1_bmibench();
        }

        void run_unpack_32x1_bmibench(SystemCounter counter = default)
        {
        
            Span<byte> y1 = stackalloc byte[32];
            for(var i=0; i<OpCount; i++)
            {
                var x = Random.Next<uint>();
                counter.Start();            
                BitParts.unpack32x1_bmi(x, y1);
                counter.Stop();
            }

            Benchmark("unpack_32x1_bmi",counter);            
        }

        void run_unpack_32x1_bench(SystemCounter counter = default)
        {
        
            Span<byte> y1 = stackalloc byte[32];
            for(var i=0; i<OpCount; i++)
            {
                var x = Random.Next<uint>();
                counter.Start();            
                BitParts.unpack32x1(x, y1);
                counter.Stop();
            }

            Benchmark("unpack_32x1",counter);            
        }

        void run_unpack_8x1_bench(SystemCounter counter = default)
        {
            ReadOnlySpan<byte> last = default;
            for(var i=0; i<OpCount; i++)
            {
                var x = Random.Next<byte>();
                counter.Start();            
                last = BitParts.unpack8x1(x);
                counter.Stop();
            }

            Benchmark("unpack_8x1_lu",counter);            
        }

        void run_unpack_8x1_bmibench(SystemCounter counter = default)
        {
            Span<byte> last = stackalloc byte[8];
            for(var i=0; i<OpCount; i++)
            {
                var x = Random.Next<byte>();
                counter.Start();            
                BitParts.unpack8x1(x,last);
                counter.Stop();
            }

            Benchmark("unpack_8x1_bmi",counter);            
        }

    }
}