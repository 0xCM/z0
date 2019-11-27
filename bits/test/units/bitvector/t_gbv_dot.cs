//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_gbv_dot : t_bv<t_gbv_dot>
    {
        public void gbv_dot_8()
            => gbv_dot_check<byte>();

        public void gbv_dot_16()
            => gbv_dot_check<ushort>();

        public void gbv_dot_32()
            => gbv_dot_check<uint>();

        public void gbv_dot_64()
            => gbv_dot_check<ulong>();


    }
}