//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vmakemask : t_vinx<t_vmakemask>
    {
        public void vmakemask_128()
        {
            for(var i=0; i< SampleCount; i++)
            {
                var x = Random.BitVector(n16);
                var z = dinx.vtakemask(dinx.vmakemask(x));
                Claim.eq(z,x);
            }
        }

        public void vmakemask_256()
        {
            for(var i=0; i< SampleCount; i++)
            {
                var x = Random.BitVector(n32);
                var z = dinx.vtakemask(dinx.vmakemask(x));
                Claim.eq(z,x);

            }
        }
    }
}