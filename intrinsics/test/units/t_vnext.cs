//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    public class t_vnext : IntrinsicTest<t_vnext>
    {   
        public void next_128x8i()
            => next_check<byte>(n128);

        public void next_128x8u()        
            => next_check<byte>(n128);

        public void next_128x16i()
            => next_check<short>(n128);

        public void next_128x16u()        
            => next_check<ushort>(n128);

        public void next_128x32i()
           => next_check<int>(n128);

        public void next_128x32u()
            => next_check<uint>(n128);

        public void next_128x64i()        
            => next_check<long>(n128);        

        public void next_128x64u()
            => next_check<ulong>(n128);

        public void next_256x8i()
            => next_check<byte>(n256);

        public void next_256x8u()        
            => next_check<byte>(n256);

        public void next_256x16i()
            => next_check<short>(n256);

        public void next_256x16u()        
            => next_check<ushort>(n256);

        public void next_256x32i()
           => next_check<int>(n256);

        public void next_256x32u()
            => next_check<uint>(n256);

        public void next_256x64i()        
            => next_check<long>(n256);        

        public void next_256x64u()
            => next_check<ulong>(n256);

        protected void next_check<T>(N128 n)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n);
                var xs = x.ToSpan();
                var xn = x.Next();
                var xns = xn.ToSpan();
                var xp = x.Prior();
                var xps = xp.ToSpan();

                var uints = ginx.vunits<T>(n);
                
                Claim.yea(ginx.vadd<T>(xp, uints).Equals(x));
                Claim.yea(ginx.vsub<T>(xn, uints).Equals(x));

                for(var j=0; j< x.Length(); j++)
                {
                    Claim.eq(xns[j], gmath.inc(xs[j]));
                    Claim.eq(xps[j], gmath.dec(xs[j]));
                }
            }
        }

        protected void next_check<T>(N256 n)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n);
                var xs = x.ToSpan();
                var xn = x.Next();
                var xns = xn.ToSpan();
                var xp = x.Prior();
                var xps = xp.ToSpan();

                var uints = ginx.vunits<T>(n);
                
                Claim.yea(ginx.vadd<T>(xp, uints).Equals(x));
                Claim.yea(ginx.vsub<T>(xn, uints).Equals(x));

                for(var j=0; j< x.Length(); j++)
                {
                    Claim.eq(xns[j], gmath.inc(xs[j]));
                    Claim.eq(xps[j], gmath.dec(xs[j]));
                }
            }
        }

    }
}
