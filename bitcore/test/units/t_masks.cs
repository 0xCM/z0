//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;
    using static As;

    public class t_masks : t_bitcore<t_masks>
    {                    
        public void verify_mask_literals()
        {
            verify_mask_literals(z8);
            verify_mask_literals(z16);
            verify_mask_literals(z32);
            verify_mask_literals(z64);
        }

        void verify_mask_literals<T>(T t = default)
            where T : unmanaged
        {

            var literals = typeof(BitMasks).BinaryLiterals<T>();
            var masks = literals.ToArray();            
            foreach(var m in masks)
            {
                var bits = BitSpan.parse(m.Text);
                var bitval = bits.Convert<T>();
                if(gmath.neq(bitval,m.Value))
                    Claim.failwith($"{m.Name}:{BitString.normalize(m.Text)} != {BitString.scalar(m.Value)}");
                
            }
        }

        public void lomask_outline()
        {

            void case2()
            {
                
                Claim.eq((Pow2.pow(3) - 1)^Pow2.pow(3), BitMask.lo64(3));
                Claim.eq((Pow2.pow(7) - 1)^Pow2.pow(7), BitMask.lo64(7));
                Claim.eq((Pow2.pow(13) - 1)^Pow2.pow(13), BitMask.lo64(13));
                Claim.eq((Pow2.pow(25) - 1)^Pow2.pow(25), BitMask.lo64(25));
                Claim.eq((Pow2.pow(59) - 1)^Pow2.pow(59), BitMask.lo64(59));

            }

            void case3()
            {
                
                Claim.eq(4, Bits.pop(BitMask.lo64(3)));
                Claim.eq(7, Bits.pop(BitMask.lo64(6)));
                Claim.eq(13, Bits.pop(BitMask.lo64(12)));
                Claim.eq(25, Bits.pop(BitMask.lo64(24)));
                Claim.eq(59, Bits.pop(BitMask.lo64(58)));

            }

            void case4()
            {
                var lomask = BitMask.lo<uint>(6);
                var himask = BitMask.hi<uint>(8);
                var src = uint.MaxValue;
                var dst = gmath.xor(gmath.xor(src,lomask), himask);
                Claim.eq(7, gbits.ntz(dst));
                Claim.eq(8, gbits.nlz(dst));

                Claim.eq(7, Bits.pop(BitMask.lo<uint>(6)));
                Claim.eq(12, Bits.pop(BitMask.lo<uint>(11)));

            }

            case2();
            case3();
            case4();
        }

        public void himask_8u()
            => sb_himask_check(z8);

        public void himask_16u()
            => sb_himask_check(z16);

        public void himask_32u()
            => sb_himask_check(z32);

        public void himask_64u()
            => sb_himask_check(z64);

        void sb_himask_check<T>(T t = default)
            where T : unmanaged
        {
            var mincount = 1;
            var maxcount = bitsize<T>();
            for(var i=0; i< RepCount; i++)
            {
                var count = Random.Single(mincount,maxcount);
                var mask = BitMask.hi(count,t);                
                var pop = gbits.pop(mask);
                if(pop != count)
                {
                    Trace("count", count.ToString());
                    Trace("popcount", pop.ToString());
                    Trace("mask", BitString.scalar(mask).Format());
                }
                
                Claim.eq(count, gbits.pop(mask));

                var lowered = gmath.srl(mask, (byte)(bitsize(t) -  count));
                var width = gbits.width(lowered);
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