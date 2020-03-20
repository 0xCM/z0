//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static As;

    public class tv_mul : t_vinx<tv_mul>
    {

        public void vmul_128x8i()
        {
            var ws = n128;
            var wt = n256;
            var s = z8i;
            var t = z16i;
        
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.CpuVector(ws,s);
                var y = Random.CpuVector(ws,s);
                var z = dvec.vmul(x,y);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = z.ToSpan();
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
                var x = Random.CpuVector(ws,s);
                var y = Random.CpuVector(ws,s);
                var z = dvec.vmul(x,y);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = z.ToSpan();
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
                var x = Random.CpuVector(ws,s);
                var y = Random.CpuVector(ws,s);
                var z = dvec.vmul(x,y);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = z.ToSpan();
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
                var x = Random.CpuVector(ws,s);
                var y = Random.CpuVector(ws,s);
                var z = dvec.vmul(x,y);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = z.ToSpan();
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
            var b0 = dvec.vmul(a0,a1);
            var b1 = dvec.vmul(dvec.vswaphl(a0), dvec.vswaphl(a1));
            trace("x",a0.FormatAsList());
            trace("y",a1.FormatAsList());
            trace("lo", b0.Format());
            trace("hi", b1.Format());

            for(var rep=0; rep< RepCount; rep++)
            {
                var x = Random.CpuVector(ws,s);
                var y = Random.CpuVector(ws,s);
                var x0 = Math128.mul(vcell(x,0), vcell(y,0));
                var x1 = Math128.mul(vcell(x,1), vcell(y,1));
                var x2 = Math128.mul(vcell(x,2), vcell(y,2));
                var x3 = Math128.mul(vcell(x,3), vcell(y,3));
                var expect = vgeneric.vparts(wt, x0,x1,x2,x3);
                var actual = dvec.vmul(x,y);

                Claim.eq(expect,actual);


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
                var x = Random.CpuVector(ws,s);
                var y = Random.CpuVector(ws,s);
                var z = dvec.vmul(x,y);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = z.ToSpan();
                for(var j=0; j<zs.Length; j++)
                    Claim.eq(xs[j]*ys[j], zs[j]);
            }
        }

        public void vmul_256x16u()
        {
            var w = n256;
            var t = z32;
            var s = z16;
            
            var zb = Blocks.single(n512,t);
            var eb = Blocks.single(n512,t);            
            var count = vgeneric.vcount(w,s);

            for(var i=0; i< RepCount; i ++)
            {
                var x = Random.CpuVector(w,s);
                var xs = x.ToSpan();

                var y = Random.CpuVector(w,s);
                var ys = y.ToSpan();

                dvec.vmul(x,y).StoreTo(zb);

                for(var j=0; j< count; j++)
                    eb[j] = uint32(xs[j] * ys[j]);
                
                Claim.numeq(eb,zb);
            }
        }
    }
}