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
            var tr = Vec256Pattern.ClearAlt<byte>();
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVec256<byte>();
                var y = dinx.vshuffle(x, tr);
                var xs = x.ToSpan256();
                for(var j =0; j< xs.Length; j++)
                {
                    if(j % 2 != 0)
                        xs[j] = 0;
                }

                var xt = xs.ToCpuVec256();                

                Claim.eq(xt,y);
            }
        }


    }


}