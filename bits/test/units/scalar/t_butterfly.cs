//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_butterfly : t_sb<t_butterfly>
    {
        //[0 1 2 3] -> [0 2 1 3]
        public void butterfly_16x64u()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<ulong>();
                var y = gbits.butterfly(n16, x);
                Bits.split(x, out var x0, out var x1, out var x2, out var x3);
                Bits.split(y, out var y0, out var y1, out var y2, out var y3);
                Claim.eq(x0,y0);
                Claim.eq(x1,y2);
                Claim.eq(x2,y1);
                Claim.eq(x3,y3);
            }
        }        

        // [0 1 2 3] -> [0 2 1 3]
        public void butterfly_32x8()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<uint>();
                var y = gbits.butterfly(n8, x);
                Bits.split(x, out var x0, out var x1, out var x2, out var x3);
                Bits.split(y, out var y0, out var y1, out var y2, out var y3);
                Claim.eq(x0,y0);
                Claim.eq(x1,y2);
                Claim.eq(x2,y1);
                Claim.eq(x3,y3);
            }
        }        

        /*
        swaps the interior 4-bit segments of each 16-bit segment.
        [0 | 1 2 | 3 || 4 | 5 6 | 7] -> 
        [0 | 2 1 | 3 || 4 | 6 5 | 7]            
        */

        public void butterfly_32x4()
        {

            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<uint>();
                var b = bitstring(Bits.butterfly(n4, a));
                var c = bitstring(a);

                Claim.eq(uint8(c[0..3]), uint8(b[0..3]));
                Claim.eq(uint8(c[4..7]), uint8(b[8..11]));
                Claim.eq(uint8(c[8..11]), uint8(b[4..7]));
                Claim.eq(uint8(c[12..15]), uint8(b[12..15]));
                Claim.eq(uint8(c[16..19]), uint8(b[16..19]));
                Claim.eq(uint8(c[20..23]), uint8(b[24..27]));
                Claim.eq(uint8(c[24..27]), uint8(b[20..23]));
                Claim.eq(uint8(c[28..31]), uint8(b[28..31]));                            
            }

        }

        public void vbutterfly_128x32x4()
        {
            var n = n128;
            var w = n4;
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector<uint>(n);
                var y = gbits.vbutterfly(w, x);
                var xs = x.ToSpan();
                var zs = DataBlocks.alloc<uint>(n);
                for(var j=0; j<zs.Length; j++)
                    zs[j] = gbits.butterfly(w,xs[j]);
                var z = zs.TakeVector();
                Claim.eq(z,y);

            }
        }

        public void vbutterfly_256x32x4()
        {
            var n = n256;
            var w = n4;
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector<uint>(n);
                var y = gbits.vbutterfly(w, x);
                var xs = x.ToSpan();
                var zs = DataBlocks.alloc<uint>(n);
                for(var j=0; j<zs.Length; j++)
                    zs[j] = gbits.butterfly(w,xs[j]);
                var z = zs.TakeVector();
                Claim.eq(z,y);

            }
        }

        public void vbutterfly_128x64x1()
        {
            var n = n128;
            var w = n1;
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector<ulong>(n);
                var y = gbits.vbutterfly(w, x);
                var xs = x.ToSpan();
                var zs = DataBlocks.alloc<ulong>(n);
                for(var j=0; j<zs.Length; j++)
                    zs[j] = gbits.butterfly(w,xs[j]);
                var z = zs.TakeVector();
                Claim.eq(z,y);

            }
        }

        public void vbutterfly_256x64x1()
        {
            var n = n256;
            var w = n1;
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector<ulong>(n);
                var y = gbits.vbutterfly(w, x);
                var xs = x.ToSpan();
                var zs = DataBlocks.alloc<ulong>(n);
                for(var j=0; j<zs.Length; j++)
                    zs[j] = gbits.butterfly(w,xs[j]);
                var z = zs.TakeVector();
                Claim.eq(z,y);

            }
        }

        static Pair<bit> add(Triple<bit> x)
        {
            // 1 + 0 + 0 = 0 1
            // 1 + 1 + 0 = 1 0
            // 1 + 1 + 1 = 1 1
            // 0 + 1 + 1 = 1 0
            // 0 + 0 + 1 = 0 1
            // 1 + 0 + 1 = 1 0            

            return default;
        }


        void add_2()
        {
            var input = Triple.define(bit.On, bit.Off, bit.On);
            var output = add(input);
            Trace($"{input} | {output}");
        }

    }
}