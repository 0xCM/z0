//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Seed;
    using static Memories;

    public class t_vmove : t_inx<t_vmove>
    {   

        public void vmove_128x16u()
        {
            var src = gvec.vinc(w128,z16);
            Claim.eq((ushort)3,VMov.vmove(src, w16, n3, n0));
            Claim.eq((ushort)2,VMov.vmove(src, w16, n2, n0));
            Claim.eq((ushort)1,VMov.vmove(src, w16, n1, n0));
        }

    }
}