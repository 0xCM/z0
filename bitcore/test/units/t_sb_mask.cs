//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;

    public class t_sb_mask : t_bitcore<t_sb_mask>
    {                    

        public void sb_lomask_outline()
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

        public void sb_himask_8u()
            => sb_himask_check(z8);

        public void sb_himask_16u()
            => sb_himask_check(z16);

        public void sb_himask_32u()
            => sb_himask_check(z32);

        public void sb_himask_64u()
            => sb_himask_check(z64);
    }
}