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
            var w = n128;
            var t = z16i;
            var s = z8i;
            
            var zb = DataBlocks.single(w,t);
            var eb = DataBlocks.single(w,t);            
            var count = ginx.vcount(w,s);

            for(var i=0; i< SampleSize; i ++)
            {
                var x = Random.CpuVector(w,s);
                var xs = x.ToSpan();

                var y = Random.CpuVector(w,s);
                var ys = y.ToSpan();

                dinx.vmul(x,y, out var z1, out var z2);
                z1.StoreTo(zb);
                z2.StoreTo(zb.Slice(count/2));
                
                for(var j=0; j< count; j++)
                    eb[j] = int16(xs[j] * ys[j]);
                
                Claim.eq(eb,zb);
            }
        }
        
        public void vmul_128x16i()
        {
            var w = n128;
            var t = z32i;
            var s = z16i;
            
            var zb = DataBlocks.single(w,t);
            var eb = DataBlocks.single(w,t);            
            var count = ginx.vcount(w,s);

            for(var i=0; i< SampleSize; i ++)
            {
                var x = Random.CpuVector(w,s);
                var xs = x.ToBlock();

                var y = Random.CpuVector(w,s);
                var ys = y.ToBlock();

                dinx.vmul(x,y, out var z1, out var z2);
                z1.StoreTo(zb);
                z2.StoreTo(zb.Slice(count/2));
                
                for(var j=0; j< count; j++)
                    eb[j] = xs[j] * ys[j];
                
                Claim.eq(eb,zb);
            }
        }

        public void vmul_256x8i()
        {
            var w = n256;
            var t = z16i;
            var s = z8i;
            
            var zb = DataBlocks.single(w,t);
            var eb = DataBlocks.single(w,t);            
            var count = ginx.vcount(w,s);

            for(var i=0; i< SampleSize; i ++)
            {
                var x = Random.CpuVector(w,s);
                var xs = x.ToSpan();

                var y = Random.CpuVector(w,s);
                var ys = y.ToSpan();

                dinx.vmul(x,y, out var z1, out var z2);
                z1.StoreTo(zb);
                z2.StoreTo(zb.Slice(count/2));
                
                for(var j=0; j< count; j++)
                    eb[j] = int16(xs[j] * ys[j]);
                
                Claim.eq(eb,zb);
            }
        }

        public void vmul_256x8u()
        {
            var w = n256;
            var t = z16;
            var s = z8;

            var zb = DataBlocks.single(w,t);
            var eb = DataBlocks.single(w,t);            
            var count = ginx.vcount(w,s);            

            for(var i=0; i< SampleSize; i ++)
            {
                var x = Random.CpuVector(w,s);
                var xs = x.ToSpan();

                var y = Random.CpuVector(w,s);
                var ys = y.ToSpan();

                dinx.vmul(x,y, out var z1, out var z2);
                z1.StoreTo(zb);
                z2.StoreTo(zb.Slice(count/2));
                
                for(var j=0; j< count; j++)
                    eb[j] = uint16(xs[j] * ys[j]);
                
                Claim.eq(eb,zb);
            }
        }

        public void vmul_256x16i()
        {
            var w = n256;
            var t = z32i;
            var s = z16i;
            
            var zb = DataBlocks.single(w,t);
            var eb = DataBlocks.single(w,t);            
            var count = ginx.vcount(w,z16);

            for(var i=0; i< SampleSize; i ++)
            {
                var x = Random.CpuVector(w,s);
                var xs = x.ToSpan();

                var y = Random.CpuVector(w,s);
                var ys = y.ToSpan();

                dinx.vmul(x,y, out var a1, out var a2);
                a1.StoreTo(zb);
                a2.StoreTo(zb.Slice(count/2));
                
                for(var j=0; j< count; j++)
                    eb[j] = xs[j] * ys[j];
                
                Claim.eq(eb,zb);
            }
        }

        public void vmul_256x16u()
        {
            var w = n256;
            var t = z32;
            var s = z16;
            
            var zb = DataBlocks.single(w,t);
            var eb = DataBlocks.single(w,t);            
            var count = ginx.vcount(w,s);

            for(var i=0; i< SampleSize; i ++)
            {
                var x = Random.CpuVector(w,s);
                var xs = x.ToSpan();

                var y = Random.CpuVector(w,s);
                var ys = y.ToSpan();

                dinx.vmul(x,y, out var z1, out var z2);
                z1.StoreTo(zb);
                z2.StoreTo(zb.Slice(count/2));
                
                for(var j=0; j< count; j++)
                    eb[j] = uint32(xs[j] * ys[j]);
                
                Claim.eq(eb,zb);
            }
        }


        public void mul_64u()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var xi = Random.Next<uint>();
                var yi = Random.Next<uint>();
                var z = (ulong)xi * (ulong)yi;
                Claim.eq(z, Math128.mul(xi,yi));
            }
        }
    }
}