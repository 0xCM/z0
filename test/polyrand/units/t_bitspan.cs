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

    using static BitSpanCases;

    public class t_bitspan : t_polyrand<t_bitspan>
    {
        public void t_bitspan_parse()
        {
            var spec = define(out ParseCase _);
            var counts = Random.Stream<ushort>(spec.MinBitCount, spec.MaxBitCount).Take(spec.RepCount).ToSpan();

            for(var i=0; i<counts.Length; i++)
            {
                var count = skip(counts,i);
                var bits = Random.BitSpan(BitSpans.alloc(count));
                PrimalClaims.eq(bits.Length, count);

                var formatted = bits.Format();
                PrimalClaims.eq(count, formatted.Length);

                var parsed = BitSpans.parse(formatted);
                PrimalClaims.require(bits.Equals(parsed));
            }
        }
    }
}