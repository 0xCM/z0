//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    public class t_vbfly : t_inx<t_vbfly>
    {
        //[0 1 2 3] -> [0 2 1 3]
        public void butterfly_16x64u()
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<ulong>();
                var y = gbits.bfly(n16, x);
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
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<uint>();
                var y = gbits.bfly(n8, x);
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
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<uint>();
                var b = BitString.scalar(Bits.bfly(n4, a));
                var c = BitString.scalar(a);

                Claim.eq(BitString.scalar<byte>(c[0..3]), BitString.scalar<byte>(b[0..3]));
                Claim.eq(BitString.scalar<byte>(c[4..7]), BitString.scalar<byte>(b[8..11]));
                Claim.eq(BitString.scalar<byte>(c[8..11]), BitString.scalar<byte>(b[4..7]));
                Claim.eq(BitString.scalar<byte>(c[12..15]), BitString.scalar<byte>(b[12..15]));
                Claim.eq(BitString.scalar<byte>(c[16..19]), BitString.scalar<byte>(b[16..19]));
                Claim.eq(BitString.scalar<byte>(c[20..23]), BitString.scalar<byte>(b[24..27]));
                Claim.eq(BitString.scalar<byte>(c[24..27]), BitString.scalar<byte>(b[20..23]));
                Claim.eq(BitString.scalar<byte>(c[28..31]), BitString.scalar<byte>(b[28..31]));
            }

        }

        public void vbutterfly_128x32x4()
        {
            var n = n128;
            var w = n4;
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.CpuVector<uint>(n);
                var y = gcpu.vbfly<uint>(w, x);
                var xs = x.ToSpan();
                var zs = SpanBlocks.alloc<uint>(n);
                for(var j=0; j<zs.CellCount; j++)
                    zs[j] = gbits.bfly(w,xs[j]);
                var z = zs.LoadVector();
                Claim.veq(z,y);
            }
        }

        public void vbutterfly_256x32x4()
        {
            var n = n256;
            var w = n4;
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.CpuVector<uint>(n);
                var y = gcpu.vbfly<uint>(w, x);
                var xs = x.ToSpan();
                var zs = SpanBlocks.alloc<uint>(n);
                for(var j=0; j<zs.CellCount; j++)
                    zs[j] = gbits.bfly(w,xs[j]);
                var z = zs.LoadVector();
                Claim.veq(z,y);

            }
        }

        public void vbutterfly_128x64x1()
        {
            var n = n128;
            var w = n1;
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.CpuVector<ulong>(n);
                var y = gcpu.vbfly<ulong>(w, x);
                var xs = x.ToSpan();
                var zs = SpanBlocks.alloc<ulong>(n);
                for(var j=0; j<zs.CellCount; j++)
                    zs[j] = gbits.bfly(w,xs[j]);
                var z = zs.LoadVector();
                Claim.veq(z,y);
            }
        }

        public void vbutterfly_256x64x1()
            => vbutterfly_check(n256, n1, z64);

        protected void vbutterfly_check<T>(N256 w, N1 b, T t = default)
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.CpuVector<T>(w);
                var y = gcpu.vbfly(b, x);
                var xs = x.ToSpan();
                var zs = SpanBlocks.alloc<T>(w);
                for(var j=0; j<zs.CellCount; j++)
                    zs[j] = gbits.bfly(b,xs[j]);
                var z = zs.LoadVector();
                Claim.veq(z,y);
            }
        }
    }
}