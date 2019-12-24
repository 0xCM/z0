//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        
            for(var i=0; i< SampleCount; i++)
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
        
            for(var i=0; i< SampleCount; i++)
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
        
            for(var i=0; i< SampleCount; i++)
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
        
            for(var i=0; i< SampleCount; i++)
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


        public void vmul_256x8u()
        {
            var ws = n256;
            var wt = n512;
            var s = z8;
            var t = z16;
        
            for(var i=0; i< SampleCount; i++)
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

        //problem?
        void vmul_256x16u()
        {
            var w = n256;
            var t = z32;
            var s = z16;
            
            var zb = DataBlocks.single(w,t);
            var eb = DataBlocks.single(w,t);            
            var count = CpuVector.vcount(w,s);

            for(var i=0; i< SampleCount; i ++)
            {
                var x = Random.CpuVector(w,s);
                var xs = x.ToSpan();

                var y = Random.CpuVector(w,s);
                var ys = y.ToSpan();

                dinx.vmul(x,y).StoreTo(zb);

                for(var j=0; j< count; j++)
                    eb[j] = uint32(xs[j] * ys[j]);
                
                Claim.eq(eb,zb);
            }
        }


        public void mul_64u()
        {
            for(var i=0; i< SampleCount; i++)
            {
                var xi = Random.Next<uint>();
                var yi = Random.Next<uint>();
                var z = (ulong)xi * (ulong)yi;
                Claim.eq(z, Math128.mul(xi,yi));
            }
        }
    }
}