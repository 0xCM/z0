//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bit_partition : t_sb<t_bit_partition>    
    {            

        public void bitpart_63x3()
        {
            var src = ulong.MaxValue;
            var dst = NatSpan.alloc(n21,z8);
            Bits.part63x3(src, dst);
            for(var i=0; i<n21; i++)
                Claim.eq(dst[i],(byte)7);
        }


    }

}