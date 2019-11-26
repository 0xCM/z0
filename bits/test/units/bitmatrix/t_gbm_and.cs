//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_gbm_and : t_bm<t_gbm_and>
    {
        public void gbm_and_8x8()
            => gbm_and_check<byte>();

        public void gbm_and_16x16()
            => gbm_and_check<ushort>();

        public void gbm_and_32x32()
            => gbm_and_check<uint>();

        public void gbm_and_64x64()
            => gbm_and_check<ulong>();        

        void gbm_and_8x8g_bench()
            => gbm_and_bench<byte>();

        void gbm_and_16x16g_bench()
            => gbm_and_bench<ushort>();

        void gbm_and_32x32g_bench()
            => gbm_and_bench<uint>();

        void gbm_and_64x64g_bench()
            => gbm_and_bench<ulong>();


    }
}