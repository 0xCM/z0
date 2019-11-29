//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_reverse : IntrinsicTest<t_reverse>
    {

        public void vreverse_128x8uu()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(n128);
                var xs = x.ToSpan();
                xs.Reverse();
                var ys = dinx.vreverse(x).ToSpan();
                Claim.eq(xs,ys);

            }
        }

        public void vreverse_128x16u()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<ushort>(n128);
                var xs = x.ToSpan();
                xs.Reverse();
                var ys = dinx.vreverse(x).ToSpan();
                Claim.eq(xs,ys);

            }
        }

        public void vreverse_128x32u()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<uint>(n128);
                var xs = x.ToSpan();
                xs.Reverse();
                var ys = dinx.vreverse(x).ToSpan();
                Claim.eq(xs,ys);

            }
        }

        public void vreverse_256x64u()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var inc = ginx.vincrements<ulong>(n256);
                var dec = ginx.vdecrements<ulong>(n256);
                var y = dinx.vreverse(inc);
                Claim.eq(dec,y);
            }
        }

    }

}