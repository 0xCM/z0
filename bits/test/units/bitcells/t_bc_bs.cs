//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bc_create : t_bc<t_bc_create>
    {

        public void gbc_16u_from_bs_check()
            => gbc_from_bs_check<ushort>();

        public void gbc_32u_from_bs_check()
            => gbc_from_bs_check<uint>();

        public void gbc_64u_from_bs_check()
            => gbc_from_bs_check<ulong>();
    }
}