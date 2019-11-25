//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_nbc_disable : t_bc<t_nbc_disable>
    {
        public void gbc_disable_16x16()
            => nbc_disable_check<N16,ushort>();

        public void nbc_disable_16x16()
            => nbc_disable_check<N16,ushort>();

        public void gbc_disable_32x32()
            => gbc_disable_check<uint>(32);

        public void nbc_disable_32x32()
            => nbc_disable_check<N32,uint>();

        public void gbc_disable_64x64()
            => gbc_disable_check<ulong>(64);

        public void nbc_disable_64x64()
            => nbc_disable_check<N64,ulong>();

        public void gbc_disable_213x8()
            => gbc_disable_check<byte>(213);

        public void gbc_disable_213x16()
            => gbc_disable_check<ushort>(213);

        public void gbc_disable_213x32()
            => gbc_disable_check<uint>(213);

        public void gbc_disable_213x64()
            => gbc_disable_check<ulong>(213);
        
        public void nbc_disable_213x8()
            => nbc_disable_check(n213, z8);

        public void nbc_disable_213x16()
            => nbc_disable_check(n213, z16);

        public void nbc_disable_213x32()
            => nbc_disable_check(n213, z32);


        public void nbc_disable_213x64()
            => nbc_disable_check(n213, z64);


        void nbv_disable_707x64u()
        {
            var n707 = nat(n7,n0,n7);
            Claim.eq(707,(int)n707.NatValue);
            nbc_disable_check(n707, (ulong)0);
        }

    }

}