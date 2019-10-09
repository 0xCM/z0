//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class t_vbc : IntrinsicTest<t_vbc>
    {
        public void vbc_g128x8i_check()
        {
            vbc_g128_check<sbyte>();   
        }

        public void vbc_g128x8u_check()
        {
            vbc_g128_check<byte>();   
        }

        public void vbc_g128x16i_check()
        {
            vbc_g128_check<short>();   
        }

        public void vbc_g128x16u_check()
        {
            vbc_g128_check<ushort>();   
        }

        public void vbc_g128x32i_check()
        {
            vbc_g128_check<int>();   
        }

        public void vbc_g128x32u_check()
        {
            vbc_g128_check<uint>();   
        }

        public void vbc_g128x64i_check()
        {
            vbc_g128_check<long>();   
        }

        public void vbc_g128x64u_check()
        {
            vbc_g128_check<ulong>();   
        }

        public void vbc_g128x32f_check()
        {
            vbc_g128_check<float>(); 
        }

        public void vbc_g128x64f_check()
        {
            vbc_g128_check<double>();
        }

        public void vbc_g256x8i_check()
        {
            vbc_g256_check<sbyte>();   
        }

        public void vbc_g256x8u_check()
        {
            vbc_g256_check<byte>();   
        }

        public void vbc_g256x16i_check()
        {
            vbc_g256_check<short>();   
        }

        public void vbc_g256x16u_check()
        {
            vbc_g256_check<ushort>();   
        }

        public void vbc_g256x32i_check()
        {
            vbc_g256_check<int>();   
        }

        public void vbc_g256x32u_check()
        {
            vbc_g256_check<uint>();   
        }

        public void vbc_g256x64i_check()
        {
            vbc_g256_check<long>();   
        }

        public void vbc_g256x64u_check()
        {
            vbc_g256_check<ulong>();   
        }

        public void vbc_g256x32f_check()
        {
            vbc_g256_check<float>(); 
        }

        public void vbc_g256x64f_check()
        {
            vbc_g256_check<double>();
        }

        void vbc_g128_check<T>()
            where T : unmanaged
        {
            var x = Random.Next<T>();
            var vX = ginx.vbroadcast128(x);
            var vY = Vec128.Fill(x);
            Claim.eq(vX,vY);
        }

        void vbc_g256_check<T>()
            where T : unmanaged
        {
            var x = Random.Next<T>();
            var vX = ginx.vbroadcast256(x);
            var vY = Vec256.Fill(x);
            Claim.eq(vX,vY);
        }

    }

}