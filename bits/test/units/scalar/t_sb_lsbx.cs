//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class t_sb_lsbx : t_sb<t_sb_lsbx>
    {
        public void xlsb_basecases()
        {
            //xlsb is an identity function over a domain consisting of powers of 2
            for(byte i = 0; i< 64; i++)
                Claim.eq(Pow2.pow(i), gbits.lsbx(Pow2.pow(i)));
        }

        public void sb_lsbx_8()
            => sb_lsbx_check<byte>();

        public void sb_lsbx_16()
            => sb_lsbx_check<ushort>();

        public void sb_lsbx_32()
            => sb_lsbx_check<uint>();

        public void sb_lsbx_64()
            => sb_lsbx_check<ulong>();

    }
}