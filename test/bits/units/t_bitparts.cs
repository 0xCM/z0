//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class t_bitparts : t_bitcore<t_bitparts>
    {
        public void part_64x1()
        {
            var src = ulong.MaxValue;
            Span<bit> dst = new bit[64];
            BitParts.part64x1(src, dst);
            for(var i=0; i< dst.Length; i++)
                Claim.require(dst[i]);
        }
    }
}