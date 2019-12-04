//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_vnonz : t_vinx<t_vnonz>
    {
        public void vnonz_basecase()
        {
            Claim.yea(ginx.vnonz(dinx.vparts(n256, 1, 2, 3, 4)));
            Claim.yea(ginx.vnonz(dinx.vparts(n256, 1, 0, 0, 0)));
            Claim.nea(ginx.vnonz(dinx.vparts(n256, 0, 0, 0, 0)));

            Claim.yea(ginx.vnonz(dinx.vparts(n128, 1, 2, 3, 4)));
            Claim.yea(ginx.vnonz(dinx.vparts(n128, 1, 0, 0, 0)));
            Claim.nea(ginx.vnonz(dinx.vparts(n128, 0, 0, 0, 0)));
        }

        public void vnonz_128()
        {
            vnonz_check<sbyte>(n128);
            vnonz_check<byte>(n128);
            vnonz_check<short>(n128);
            vnonz_check<ushort>(n128);
            vnonz_check<int>(n128);
            vnonz_check<uint>(n128);
            vnonz_check<long>(n128);
            vnonz_check<ulong>(n128);
        }

        public void vnonz_256()
        {
            nonzero256_check<sbyte>(n256);
            nonzero256_check<byte>(n256);
            nonzero256_check<short>(n256);
            nonzero256_check<ushort>(n256);
            nonzero256_check<int>(n256);
            nonzero256_check<uint>(n256);
            nonzero256_check<long>(n256);
            nonzero256_check<ulong>(n256);
        }
    }
}