//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class t_bitparts : t_bits<t_bitparts>
    {
        public void part_64x1()
        {
            var src = ulong.MaxValue;
            Span<bit> dst = new bit[64];
            BitParts.part64x1(src, dst);
            for(var i=0; i< dst.Length; i++)
                Claim.require(dst[i]);
        }

        protected void bitpart_check<A,B>(SpanPartitioner<A,B> part, int count, int width)
            where A : unmanaged
            where B : unmanaged
        {
            Span<B> dst = stackalloc B[count];

            for(var sample = 0; sample < RepCount; sample++)
            {
                var x = Random.Next<A>();
                part(x, dst);
                var y = BitString.scalar(x).Partition(width).Map(bs => bs.ToBitVector(n8));
                for(var i=0; i<count; i++)
                    Claim.eq(y[i], BitString.scalar(dst[i]).ToBitVector(n8));
            }
        }


    }
}