//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static Distribute;

    public class t_distribute : IntrinsicTest<t_distribute>
    {     

        public void spread_128x8u()
        {
            var src = ginx.vincrements<byte>(n128);
            spread(src, out var lo, out var hi);
            var loExpect = ginx.vincrements<ushort>(n128);
            var hiExpect = ginx.vincrements<ushort>(n128,8);
            Claim.eq(loExpect, lo);
            Claim.eq(hiExpect, hi);

            var dst = compact(lo,hi);
            Claim.eq(src,dst);
        }



    }

}