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

    public class t_sb_mask : t_sb<t_sb_mask>
    {
                    
        public void sb_mask_basecase()
        {
            void case1()
            {
                var m = BitMask.pow2(3, 9, 11);
                var bs = m.ToBitString();
                var seq = bs.BitSeq;
                Claim.yea(seq[3] == 1);
                Claim.yea(seq[9] == 1);
                Claim.yea(seq[11] == 1);

                
                seq[3] = 0;
                seq[9] = 0;
                seq[11] = 0;
                Claim.yea(bs.Format(true) == string.Empty);
            }

            void case2()
            {
                
                Claim.eq((Pow2.pow(3) - 1)^Pow2.pow(3), BitMask.lomask64(3));
                Claim.eq((Pow2.pow(7) - 1)^Pow2.pow(7), BitMask.lomask64(7));
                Claim.eq((Pow2.pow(13) - 1)^Pow2.pow(13), BitMask.lomask64(13));
                Claim.eq((Pow2.pow(25) - 1)^Pow2.pow(25), BitMask.lomask64(25));
                Claim.eq((Pow2.pow(59) - 1)^Pow2.pow(59), BitMask.lomask64(59));

            }

            void case3()
            {
                
                Claim.eq(4, Bits.pop(BitMask.lomask64(3)));
                Claim.eq(7, Bits.pop(BitMask.lomask64(6)));
                Claim.eq(13, Bits.pop(BitMask.lomask64(12)));
                Claim.eq(25, Bits.pop(BitMask.lomask64(24)));
                Claim.eq(59, Bits.pop(BitMask.lomask64(58)));

            }

            void case4()
            {
                var lomask = BitMask.lomask<uint>(6);
                var himask = BitMask.himask<uint>(8);
                var src = uint.MaxValue;
                var dst = gmath.xor(gmath.xor(src,lomask), himask);
                Claim.eq(7, gbits.ntz(dst));
                Claim.eq(8, gbits.nlz(dst));

            }


            case1();
            case2();
            case3();
            case4();
        }


        public void sb_mask_hilo()
        {

        }


        public void takemask_basecases()
        {
            void example()
            {
                var x1 = 0b10000000_10000000_10000000_10000000u;            
                var e1 = 0b11000000_11000000_11000000_00000000u;
                var a1 = gbits.clearbyte(x1,0) | (x1 << 7);
                Claim.eq(e1,a1);

            }

            // [1000_1000 1000_1000 1000_1000 1000_1000 1000_1000 1000_1000 1000_1000 1000_1000]
            // [1000_1000 1000_1000 1000_1000 1000_1000 1000_1000 1000_1000 1000_1000 1000_1000]
            var x = vbuild.vbroadcast(n256, (byte)Pow2.T07);
            var m = ginx.vtakemask(x);
            Claim.eq(uint.MaxValue,m);


            

        }

    }

}