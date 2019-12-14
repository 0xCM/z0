//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bsp_bitstring : t_bitspan<t_bsp_bitstring>
    {

        public void bsp_16u_from_bs()
            => bitspan_from_bitstring_check<ushort>();

        public void bsp_32u_from_bs()
            => bitspan_from_bitstring_check<uint>();

        public void bsp_64u_from_bs()
            => bitspan_from_bitstring_check<ulong>();
    }
}