//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static HexConst;
    using static z;

    public class t_vcover : t_inx<t_vcover>
    {
        public void vcover_512()
        {
            var data = CharBlocks.alloc(n32);

            Claim.eq(CharBlock32.Size, size<CharBlock32>());
            Claim.eq(bitwidth<CharBlock32>(), 512u);
            Claim.eq(bitsize<CharBlock32>().Content, 512u);
            Claim.eq((uint)bitsize<CharBlock32>(), 512u);
            for(var i=0; i<32; i++)
            {

            }

        }
    }
}
