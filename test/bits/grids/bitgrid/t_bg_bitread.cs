//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public class t_bg_bitread : t_bg<t_bg_bitread>
    {        
        public void bg_bitread_20x20x32()
            => gbg_bitread_check<uint>(20,20);

        public void bg_bitread_21x30x32()
            => gbg_bitread_check<uint>(21,30);

        public void bg_bitread_17x25x32()
            => gbg_bitread_check<uint>(17,25);

        public void bg_bitread_256x67x64()
            => gbg_bitread_check<ulong>(256,67);

        public void bg_bitread_250x67x64()
            => gbg_bitread_check<ulong>(250,67);

        public void bg_bitread_250x67x8()
            => gbg_bitread_check<byte>(250,67);

        public void bg_bitread_250x67x16()
            => gbg_bitread_check<ushort>(250,67);

        public void bg_bitread_250x67x32()
            => gbg_bitread_check<uint>(250,67);

        public void bg_bitread_249x128x64_bench()
            => bg_bitread_bench<ulong>(249,128);

        public void bg_bitread_249x128x8_bench()
            => bg_bitread_bench<byte>(249,128);

        public void bg_bitread_64x64x64_bench()
            => bg_bitread_bench<byte>(64,64);

        public void bm_bitread_64x64x64_bench()
            => bm_bitread_bench<ulong>();

        public void bg_bitwrite_249x128x64_bench()
            => bg_bitwrite_bench<ulong>(249,128);

        public void bg_bitwrite_249x128x8_bench()
            => bg_bitwrite_bench<byte>(249,128);
    }
}