//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bm_xor : t_bm<t_bm_xor>
    {        
        public void bm_xor_g8x8x8()
            => bm_xor_check<byte>();

        public void bm_xor_g16x16x16()
            => bm_xor_check<ushort>();

        public void bm_xor_g32x32x32()
            => bm_xor_check<uint>();

        public void bm_xor_g64x64x64()
            => bm_xor_check<ulong>();

        public void bm_xor_n64x64x8()
            => bm_xor_check<N64,byte>();

        public void bm_xor_n50x50x16()
            => bm_xor_check<N50,ushort>();

        public void bm_xor_n64x64x64()
            => bm_xor_check<N64,ulong>();

        public void bm_xor_n64x64x16()
            => bm_xor_check<N64,ushort>();

        public void bm_xor_n256x256x32()
            => bm_xor_check<N256,uint>();

        public void bm_xor_n331x331x8()
            => bm_xor_check(natseq(n3,n3,n1), z8);
    }

}