//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Konst;

    public class t_vmakemask : t_inx<t_vmakemask>
    {
        public void vmakemask_128()
        {
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.BitVector(n16);
                var b = z.vtakemask(z.vmakemask(a));
                Claim.eq(b,a.Scalar);
            }
        }

        public void vmakemask_256()
        {
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.BitVector(n32);
                var b = z.vtakemask(z.vmakemask(a));
                Claim.eq(b,a.Scalar);
            }
        }
    }
}