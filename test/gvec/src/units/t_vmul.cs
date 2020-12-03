//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    public class tv_mul : t_inx<tv_mul>
    {
        public void vmul_128x8i()
        {
            var ws = n128;
            var wt = n256;
            var s = z8i;
            var t = z16i;

            for(var i=0; i< RepCount; i++)
            {
                var a = Random.CpuVector(ws,s);
                var b = Random.CpuVector(ws,s);
                var c = z.vmul(a,b);

                var xs = a.ToSpan();
                var ys = b.ToSpan();
                var zs = c.ToSpan();
                for(var j=0; j<zs.Length; j++)
                    Claim.eq(xs[j]*ys[j], zs[j]);
            }
        }

        public void vmul_128x8u()
        {
            var ws = n128;
            var wt = n256;
            var s = z8;
            var t = z16;

            for(var i=0; i< RepCount; i++)
            {
                var a = Random.CpuVector(ws,s);
                var b = Random.CpuVector(ws,s);
                var c = z.vmul(a,b);

                var xs = a.ToSpan();
                var ys = b.ToSpan();
                var zs = c.ToSpan();
                for(var j=0; j<zs.Length; j++)
                    Claim.eq((ushort)(xs[j]*ys[j]), zs[j]);
            }
        }

        public void vmul_128x16i()
        {
            var ws = n128;
            var wt = n256;
            var s = z16i;
            var t = z32i;

            for(var i=0; i< RepCount; i++)
            {
                var a = Random.CpuVector(ws,s);
                var b = Random.CpuVector(ws,s);
                var c = z.vmul(a,b);

                var xs = a.ToSpan();
                var ys = b.ToSpan();
                var zs = c.ToSpan();
                for(var j=0; j<zs.Length; j++)
                    Claim.eq(xs[j]*ys[j], zs[j]);
            }
        }

        public void vmul_128x16u()
        {
            var ws = n128;
            var wt = n256;
            var s = z16;
            var t = z32;

            for(var rep=0; rep< RepCount; rep++)
            {
                var a = Random.CpuVector(ws,s);
                var b = Random.CpuVector(ws,s);
                var c = z.vmul(a,b);

                var xs = a.ToSpan();
                var ys = b.ToSpan();
                var zs = c.ToSpan();
                for(var j=0; j<zs.Length; j++)
                    Claim.eq((uint)xs[j]*(uint)ys[j], zs[j]);
            }
        }

        void vmul_128x32u()
        {
            var ws = n128;
            var wt = n256;
            var s = z32;
            var t = z64;
            var count = vcount(ws,s);

            var a0 = gvec.vinc(ws,1u);
            var a1 = gvec.vinc(ws,a0.LastCell() + 1);
            var b0 = z.vmul(a0,a1);
            var b1 = z.vmul(z.vswaphl(a0), z.vswaphl(a1));
            Trace("x", a0.Format());
            Trace("y", a1.Format());
            Trace("lo", b0.Format());
            Trace("hi", b1.Format());

            for(var rep=0; rep< RepCount; rep++)
            {
                var x = Random.CpuVector(ws,s);
                var y = Random.CpuVector(ws,s);
                var x0 = math.mul64(vcell(x,0), vcell(y,0));
                var x1 = math.mul64(vcell(x,1), vcell(y,1));
                var x2 = math.mul64(vcell(x,2), vcell(y,2));
                var x3 = math.mul64(vcell(x,3), vcell(y,3));
                var expect = z.vparts(wt, x0,x1,x2,x3);
                var actual = z.vmul(x,y);

                Claim.veq(expect,actual);
            }
        }

        public void vmul_256x8u()
        {
            var ws = n256;
            var wt = n512;
            var s = z8;
            var t = z16;

            for(var i=0; i< RepCount; i++)
            {
                var a = Random.CpuVector(ws,s);
                var b = Random.CpuVector(ws,s);
                var c = z.vmul(a,b);

                var xs = a.ToSpan();
                var ys = b.ToSpan();
                var zs = c.ToSpan();
                for(var j=0; j<zs.Length; j++)
                    Claim.eq(xs[j]*ys[j], zs[j]);
            }
        }

        public void vmul_256x16u()
        {
            var w = n256;
            var t = z32;
            var s = z16;

            var zb = SpanBlocks.alloc<uint>(n512);
            var eb = SpanBlocks.alloc<uint>(n512);
            var count = vcount(w,s);

            for(var i=0; i< RepCount; i ++)
            {
                var x = Random.CpuVector(w,s);
                var xs = x.ToSpan();

                var y = Random.CpuVector(w,s);
                var ys = y.ToSpan();

                z.vmul(x,y).StoreTo(zb);

                for(var j=0; j< count; j++)
                    eb[j] = ScalarCast.uint32(xs[j] * ys[j]);

                Claim.eq(eb,zb);
            }
        }
    }
}