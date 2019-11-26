//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_gbm_xor : t_bm<t_gbm_xor>
    {        
        public void gbm_xor_8()
            => gbm_xor_check<byte>();

        public void gbm_xor_16()
            => gbm_xor_check<ushort>();

        public void gbm_xor_32()
            => gbm_xor_check<uint>();

        public void gbm_xor_64()
            => gbm_xor_check<ulong>();
    }
}