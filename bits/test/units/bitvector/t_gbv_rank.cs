//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_gbv_rank : t_bv<t_gbv_rank>
    {
        public void gbv_rank_8()
            => gbv_rank_check<byte>();

        public void gbv_rank_16()
            => gbv_rank_check<ushort>();

        public void gbv_rank_32()
            => gbv_rank_check<uint>();

        public void gbv_rank_64()
            => gbv_rank_check<ulong>();
    }

}