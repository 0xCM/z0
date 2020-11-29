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

    using Check = CheckPrimal;

    using static BitSpanTests;

    public class t_bitspan : t_polyrand<t_bitspan>
    {
        public void t_bitspan_parse()
        {
            var spec = define(out Parse _);
            var counts = Random.Stream<ushort>(spec.MinBitCount, spec.MaxBitCount).Take(spec.RepCount).ToSpan();

            for(var i=0; i<counts.Length; i++)
            {
                var count = skip(counts,i);
                var bits = Random.BitSpan(BitSpans.alloc(count));
                Check.eq(bits.Length, count);

                var formatted = bits.Format();
                Check.eq(count, formatted.Length);

                var parsed = BitSpans.parse(formatted);
                Check.require(bits.Equals(parsed));
            }
        }
    }
}