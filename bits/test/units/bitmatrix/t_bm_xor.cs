//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bm_xor : t_bm<t_bm_xor>
    {        
        public void gbm_xor_8()
            => gbm_xor_check<byte>();

        public void gbm_xor_16()
            => gbm_xor_check<ushort>();

        public void gbm_xor_32()
            => gbm_xor_check<uint>();

        public void gbm_xor_64()
            => gbm_xor_check<ulong>();

        public void nbm_xor_50x8()
            => nbm_xor_check<N64,byte>();

        public void nbm_xor_50x16()
            => nbm_xor_check<N50,ushort>();

        public void nbm_xor_60x64()
            => nbm_xor_check<N64,ulong>();

        public void nbm_xor_331x8()
            => nbm_xor_check(natseq(n3,n3,n1), z8);

        public void nbm_xor_64x64()
            => nbm_xor_check<N64,ulong>();

        public void nbm_xor_64x16()
            => nbm_xor_check<N64,ushort>();

        public void nbm_xor_256x32()
            => nbm_xor_check<N256,uint>();
    }

}