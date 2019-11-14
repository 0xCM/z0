//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vblend : IntrinsicTest<t_vblend>
    {
        
        public void vblendv_256x64u_check_explicit()
        {
            // z[i] = testbit(spec[i],7) ? y[i] : x[i]
            const int bitpos = 63;
            const ulong pickX = 0;
            const ulong pickY = ulong.MaxValue;
            const int len = 4;


            var x = dinx.vparts(0ul,2ul,4ul,6ul);
            var y = dinx.vparts(1ul,3ul,5ul,7ul);
            var m = dinx.vparts(pickY, pickX, pickY, pickX);
            var expect = dinx.vparts(1ul, 2ul, 5ul, 6ul);
            var actual = dinx.vblend4x64(x,y,m);
            Claim.eq(expect,actual);

            var xs = x.ToSpan();
            var ys = y.ToSpan();
            var ms = m.ToSpan();
            Span<ulong> zs = stackalloc ulong[len];
            for(var i=0; i<len; i++)
                zs[i] = gbits.test(ms[i], bitpos) ? ys[i] : xs[i];

            var z = ginx.vload(n256,zs);
            Claim.eq(expect,z);
            
        }
        
        public void vblend_256x64u_check()
        {
            const int bitpos = 63;
            const ulong pickX = 0ul;
            const ulong pickY = ulong.MaxValue;
            const int len = 4;
            var n = n256;

            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<ulong>(n);
                var y = Random.CpuVector<ulong>(n);
                
                var selector = Random.BitSpan(len);
                var ms = BlockedSpan.alloc<ulong>(n);
                for(var i = 0; i< len; i++)
                    ms[i] = selector[i] ? pickY : pickX;

                var m = ms.TakeVector();
                var actual = dinx.vblend4x64(x,y,m);

                
                var xs = x.ToSpan();
                var ys = y.ToSpan();


                Span<ulong> zs = stackalloc ulong[len];                
                for(var i=0; i<len; i++)
                    zs[i] = gbits.test(ms[i], bitpos) ? ys[i] : xs[i];


                var expect = ginx.vload(n,zs);
                if(!expect.Equals(actual))
                {
                    Trace("x", xs.FormatList());
                    Trace("y", ys.FormatList());
                    Trace("mask (vector)", m.FormatList());
                    Trace("mask (span)", ms.FormatList());
                    Trace("z", actual.FormatList());
                }

                Claim.eq(expect,actual);

            }
  
        }

        public void vblend_128x16u_check()
        {
            var x = dinx.vparts(n128, 0,2,4,6,8,10,12,14); 
            var y = dinx.vparts(n128, 1,3,5,7,9,11,13,15); 
            
            var z = dinx.vblend8x16(x,y, Blend8x16.LLLLLLLL);
            Claim.eq(x,z);          

            z = dinx.vblend8x16(x,y, Blend8x16.RRRRRRRR);
            Claim.eq(z,y);

            z = dinx.vblend8x16(x,y, Blend8x16.LLLLRRRR);
            Claim.eq(dinx.vparts(n128, 0,2,4,6,9,11,13,15), z);

            z = dinx.vblend8x16(x,y, Blend8x16.RRRRLLLL);
            Claim.eq(dinx.vparts(n128,1,3,5,7,8,10,12,14), z);

        }
        public void vblend_128x32u_check()
        {

            var x = dinx.vparts(1u,3,5,7);
            var y = dinx.vparts(2u,4,6,8);

            var spec = Blend4x32.LLLL;
            Vector128<uint> z = dinx.vblend4x32(x,y, spec);
            Claim.eq(z,x);

            spec = Blend4x32.LLLR;
            z = dinx.vblend4x32(x,y, spec);
            Claim.eq(z, dinx.vparts(1u,3,5,8));

            spec = Blend4x32.LLRL;
            z = dinx.vblend4x32(x,y, spec);
            Claim.eq(z, dinx.vparts(1u,3,6,7));

            spec = Blend4x32.LLRR;
            z = dinx.vblend4x32(x,y, spec);
            Claim.eq(z, dinx.vparts(1u,3,6,8));

            spec = Blend4x32.RLLL;
            z = dinx.vblend4x32(x,y, spec);
            Claim.eq(z, dinx.vparts(2u,3,5,7));


            spec = Blend4x32.RRRR;
            z = dinx.vblend4x32(x,y, spec);
            Claim.eq(z,y);
        }

        public void vblend_256x32u_check()
        {

            var x = dinx.vparts(n256, 1u, 3, 5, 7, 9,  11, 13, 15);
            var y = dinx.vparts(n256, 2u, 4, 6, 8, 10, 12, 14, 16);
            var spec = Blend8x32.LLLLLLLL;
            var z = dinx.vblend8x32(x,y, spec);
            Trace($"vblend({x},{y},{spec}) = {z}");
            Claim.eq(z,x);

            spec = Blend8x32.LRLRLRLR;
            z = dinx.vblend8x32(x,y, spec);
            Trace($"vblend({x},{y},{spec}) = {z}");
            Claim.eq(z,dinx.vparts(n256,1u,4,5,8,9,12,13,16));


            spec = Blend8x32.RRRRRRRR;
            z = dinx.vblend8x32(x,y, spec);
            Trace($"vblend({x},{y},{spec}) = {z}");
            Claim.eq(z,y);

        }
    }
}