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

    public class t_sb_blsi : t_sb<t_sb_blsi>
    {

        /// <summary>
        /// Illustrates blsi is an identity function over a domain consisting of powers of 2
        /// </summary>
        public void blsi_idpow2()
        {
            for(byte i = 0; i< 64; i++)
                Claim.eq(Pow2.pow(i), gbits.blsi(Pow2.pow(i)));
        }

        public void sb_blsi_8()
            => sb_blsi_check<byte>();

        public void sb_blsi_16()
            => sb_blsi_check<ushort>();

        public void sb_blsi_32()
            => sb_blsi_check<uint>();

        public void sb_blsi_64()
            => sb_blsi_check<ulong>();

    }
}