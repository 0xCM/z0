//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_nbc_pop : t_bc<t_nbc_pop>
    {

        public void nbc_pop_8x8()
            => nbc_pop_check<N8,byte>();

        public void nbc_pop_9x8()
            => nbc_pop_check<N9,byte>();

        public void nbc_pop_16x8()
            => nbc_pop_check<N16,byte>();

        public void nbc_pop_31x8()
            => nbc_pop_check<N31,byte>();

        public void nbc_pop_10x16()
            => nbc_pop_check<N10,ushort>();

        public void nbc_pop_11x16()
            => nbc_pop_check<N11,ushort>();

        public void nbc_pop_16x16()
            => nbc_pop_check<N16,ushort>();

        public void nbc_pop_64x16()
            => nbc_pop_check<N64,ushort>();

        public void nbc_pop_128x16()
            => nbc_pop_check<N128,ushort>();

        public void nbc_pop_256x16()
            => nbc_pop_check<N256,ushort>();

        public void nbc_pop_512x16()
            => nbc_pop_check<N512,ushort>();

        public void nbc_pop_1024x16()
            => nbc_pop_check<N1024,ushort>();

        public void nbc_pop_2048x16()
            => nbc_pop_check<N2048,ushort>();

        public void nbc_pop_4096x16()
            => nbc_pop_check<N4096,ushort>();

        public void nbc_pop_8192x16()
            => nbc_pop_check<N8192,ushort>();

        public void nbc_pop_16384x16()
            => nbc_pop_check<N16384,ushort>();

        public void nbc_pop_64x64()
            => nbc_pop_check<N64,ulong>();

        public void nbc_pop_256x64()
            => nbc_pop_check<N256,ulong>();

        public void nbc_pop_512x64()
            => nbc_pop_check<N512,ulong>();

        public void nbc_pop_1024x64()
            => nbc_pop_check<N1024,ulong>();

        public void nbc_pop_2048x64()
            => nbc_pop_check<N2048,ulong>();

        public void nbc_pop_4096x64()
            => nbc_pop_check<N4096,ulong>();

        public void nbc_pop_8192x64()
            => nbc_pop_check<N8192,ulong>();

        public void nbc_pop_16384x64()
            => nbc_pop_check<N16384,ulong>();
    }

}