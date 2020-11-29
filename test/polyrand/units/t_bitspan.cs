//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public class t_bitspan : t_polyrand<t_bitspan>
    {
        public void t_bitspan_parse()
        {
            const uint BitCount = 377;

            var bits = Random.BitSpan(BitSpans.alloc(BitCount));
            Claim.eq(bits.Length, BitCount);


            // var input = Random.BitSpan(BitCount);

        }
    }

}