//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_vcpu_patterns : t_vcpu<t_vcpu_patterns>
    {
        public void pattern_clearalt_256x8()
        {
            var tr = ginx.vpclearalt<byte>(n256);
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = dinx.vshuf16x8(x, tr);
                var xs = x.ToBlock();
                for(var j =0; j< xs.CellCount; j++)
                {
                    if(j % 2 != 0)
                        xs[j] = 0;
                }

                var xt = xs.LoadVector();

                Claim.eq(xt,y);
            }
        }
    }
}