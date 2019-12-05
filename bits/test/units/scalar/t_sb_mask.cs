//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_sb_mask : t_sb<t_sb_mask>
    {
        

        
        
        public void sb_mask_basecase()
        {
            void case1()
            {
                var m = Bits.mask(3, 9, 11);
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
                
                Claim.eq((Pow2.pow(3) - 1)^Pow2.pow(3), Bits.lomask(3));
                Claim.eq((Pow2.pow(7) - 1)^Pow2.pow(7), Bits.lomask(7));
                Claim.eq((Pow2.pow(13) - 1)^Pow2.pow(13), Bits.lomask(13));
                Claim.eq((Pow2.pow(25) - 1)^Pow2.pow(25), Bits.lomask(25));
                Claim.eq((Pow2.pow(59) - 1)^Pow2.pow(59), Bits.lomask(59));

            }

            void case3()
            {
                
                Claim.eq(4, Bits.pop(Bits.lomask(3)));
                Claim.eq(7, Bits.pop(Bits.lomask(6)));
                Claim.eq(13, Bits.pop(Bits.lomask(12)));
                Claim.eq(25, Bits.pop(Bits.lomask(24)));
                Claim.eq(59, Bits.pop(Bits.lomask(58)));

            }

            RunLocals();
        }


    }

}