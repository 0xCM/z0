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
                var z = dinx.vmul(x,y);

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
                var z = dinx.vmul(x,y);

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
                var z = dinx.vmul(x,y);

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
                var z = dinx.vmul(x,y);

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
        
            var a0 = VPattern.vincrements(ws,1u);
            var a1 = VPattern.vincrements(ws,a0.LastCell() + 1);
            var b0 = dinx.vmul(a0,a1);
            //var b1 = dinx.vmul(dinx.vperm4x32(a0, Perm4L.BADC), dinx.vperm4x32(a1, Perm4L.BADC));
            var b1 = dinx.vmul(dinx.vswaphl(a0), dinx.vswaphl(a1));
            Trace("x",a0.Format());
            Trace("y",a1.Format());
            Trace("lo", b0.Format());
            Trace("hi", b1.Format());

            for(var rep=0; rep< RepCount; rep++)
            {
                var x = Random.CpuVector(ws,s);
                var y = Random.CpuVector(ws,s);
                var x0 = Math128.mul(vcell(x,0), vcell(y,0));
                var x1 = Math128.mul(vcell(x,1), vcell(y,1));
                var x2 = Math128.mul(vcell(x,2), vcell(y,2));
                var x3 = Math128.mul(vcell(x,3), vcell(y,3));
                var expect = CpuVector.vparts(wt, x0,x1,x2,x3);
                var actual = dinx.vmul(x,y);

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
                var z = dinx.vmul(x,y);

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
            
            var zb = DataBlocks.single(w,t);
            var eb = DataBlocks.single(w,t);            
            var count = CpuVector.vcount(w,s);

            for(var i=0; i< RepCount; i ++)
            {
                var x = Random.CpuVector(w,s);
                var xs = x.ToSpan();

                var y = Random.CpuVector(w,s);
                var ys = y.ToSpan();

                dinx.vmul(x,y).StoreTo(zb);

                for(var j=0; j< count; j++)
                    eb[j] = uint32(xs[j] * ys[j]);
                
                Claim.numeq(eb,zb);
            }
        }
    }
}