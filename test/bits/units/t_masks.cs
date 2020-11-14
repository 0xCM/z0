//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Text;

    using static Konst;
    using static z;

    public class t_masks : t_bitcore<t_masks>
    {
        public void lomask_case1()
        {
            Claim.eq((Pow2.pow(3) - 1)^Pow2.pow(3), lo64(3));
            Claim.eq((Pow2.pow(7) - 1)^Pow2.pow(7), lo64(7));
            Claim.eq((Pow2.pow(13) - 1)^Pow2.pow(13), lo64(13));
            Claim.eq((Pow2.pow(25) - 1)^Pow2.pow(25), lo64(25));
            Claim.eq((Pow2.pow(59) - 1)^Pow2.pow(59), lo64(59));
        }

        public void lomask_case2()
        {
            Claim.eq(4, Bits.pop(lo64(3)));
            Claim.eq(7, Bits.pop(lo64(6)));
            Claim.eq(13, Bits.pop(lo64(12)));
            Claim.eq(25, Bits.pop(lo64(24)));
            Claim.eq(59, Bits.pop(lo64(58)));
        }

        public void lomask_case3()
        {
            var lomask = BitMasks.lo<uint>(6);
            var himask = BitMasks.hi<uint>(8);
            var src = uint.MaxValue;
            var dst = gmath.xor(gmath.xor(src,lomask), himask);
            Claim.eq(7, gbits.ntz(dst));
            Claim.eq(8, gbits.nlz(dst));

            Claim.eq(7, Bits.pop(BitMasks.lo<uint>(6)));
            Claim.eq(12, Bits.pop(BitMasks.lo<uint>(11)));
        }

        public void himask_8u()
            => check_himask(z8);

        public void himask_16u()
            => check_himask(z16);

        public void himask_32u()
            => check_himask(z32);

        public void himask_64u()
            => check_himask(z64);

        void check_himask<T>(T t = default)
            where T : unmanaged
        {
            var mincount = 1;
            var maxcount = (int)bitwidth<T>();
            for(var i=0; i< RepCount; i++)
            {
                var count = Random.One(mincount,maxcount);
                var mask = BitMasks.hi(count,t);
                var pop = gbits.pop(mask);
                if(pop != count)
                {
                    Trace("count", count.ToString());
                    Trace("popcount", pop.ToString());
                    Trace("mask", BitString.scalar(mask).Format());
                }

                Claim.eq(count, gbits.pop(mask));

                var lowered = gmath.srl(mask, (byte)(bitwidth(t) -  count));
                var width = gbits.effwidth(lowered);
                if(count != width)
                {
                    Trace("mask", BitString.scalar(mask).Format());
                    Trace("lowered", BitString.scalar(lowered).Format());
                }
                Claim.eq(count, width);
            }
        }
    }
}