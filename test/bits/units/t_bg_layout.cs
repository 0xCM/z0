//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public class t_bg_layout : t_bitgrids<t_bg_layout>
    {
        public void bg_layout_21x32x32()
        {
            var a0 = GridCalcs.grid(n21,n32,0u);
            var b0 = GridCalcs.grid(21, 32, 32);
            Claim.eq(a0,b0);

            var a1 = GridCalcs.grid(n32,n64,ushort.MinValue);
            var b1 = GridCalcs.grid(32, 64, 16);
            Claim.eq(a1,b1);

            var a2 = GridCalcs.grid(n5,n15,byte.MinValue);
            var b2 = GridCalcs.grid(5, 15, 8);
            Claim.eq(a2,b2);
        }
    }
}