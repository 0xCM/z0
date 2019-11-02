//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;
    using static BitParts;

    public class t_bitpart12 : BitPartTest<t_bitpart12>
    {

        public void part12x3_check()
        {
            Span<byte> dst = stackalloc byte[4];
            BitParts.part12x3(0b111_111_111_111, dst);


            Claim.eq(dst[0], (byte)7);
            Claim.eq(dst[1], (byte)7);
            Claim.eq(dst[2], (byte)7);
            Claim.eq(dst[3], (byte)7);
        }

    }

}