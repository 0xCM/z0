//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    public class t_vcover : t_inx<t_vcover>
    {
        public void vcover_512()
        {
            var data = CharBlocks.alloc(n32);

            Claim.eq(CharBlock32.Size, size<CharBlock32>());
            Claim.eq(memory.width<CharBlock32>(), 512u);
            Claim.eq(memory.width<CharBlock32>().Content, 512u);
            Claim.eq((uint)memory.width<CharBlock32>(), 512u);
            for(var i=0; i<32; i++)
            {

            }

        }
    }
}
