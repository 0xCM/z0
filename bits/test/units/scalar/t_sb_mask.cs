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
            var m = 0ul;
            Bits.mask(ref m, 3, 9, 11);
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


    }

}