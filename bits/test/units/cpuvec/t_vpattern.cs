//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_vpattern : UnitTest<t_vpattern>
    {
        public void pattern_clearalt_256x8()
        {
            var tr = Vec256Pattern.ClearAltVector<byte>();
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = dinx.vshuffle(x, tr);
                var xs = x.ToBlockedSpan();
                for(var j =0; j< xs.Length; j++)
                {
                    if(j % 2 != 0)
                        xs[j] = 0;
                }

                var xt = xs.ToCpuVector();

                Claim.eq(xt,y);
            }
        }


    }


}