//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bg_bitread : t_bg<t_bg_bitread>
    {        
        public void gbg_bitread_20x20x32()
            => gbg_bitread_check<uint>(20,20);

        public void gbg_bitread_21x30x32()
            => gbg_bitread_check<uint>(21,30);

        public void gbg_bitread_17x25x32()
            => gbg_bitread_check<uint>(17,25);

        public void gbg_bitread_256x67x64()
            => gbg_bitread_check<ulong>(256,67);

        public void gbg_bitread_250x67x64()
            => gbg_bitread_check<ulong>(250,67);

        public void gbg_bitread_250x67x8()
            => gbg_bitread_check<byte>(250,67);

        public void gbg_bitread_250x67x16()
            => gbg_bitread_check<ushort>(250,67);

        public void gbg_bitread_250x67x32()
            => gbg_bitread_check<uint>(250,67);

        public void gbg_bitread_249x128x64_bench()
            => gbg_bitread_bench<ulong>(249,128, Pow2.T08);

        public void gbg_bitread_249x128x8_bench()
            => gbg_bitread_bench<byte>(249,128, Pow2.T08);

        public void gbg_bitread_64x64x64_bench()
            => gbg_bitread_bench<byte>(64,64, Pow2.T08);

        public void gbm_bitread_64x64x64_bench()
            => gbm_bitread_bench<ulong>(Pow2.T08);

        public void gbg_bitwrite_249x128x64_bench()
            => gbg_bitwrite_bench<ulong>(249,128, Pow2.T08);

        public void gbg_bitwrite_249x128x8_bench()
            => gbg_bitwrite_bench<byte>(249,128, Pow2.T08);

    }

}