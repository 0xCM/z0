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
        public void vbc_g128x8i()
            => vbc_g128_check<sbyte>();   

        public void vbc_g128x8u()        
            => vbc_g128_check<byte>();   
        

        public void vbc_g128x16i()
        {
            vbc_g128_check<short>();   
        }

        public void vbc_g128x16u()
        {
            vbc_g128_check<ushort>();   
        }

        public void vbc_g128x32i()
        {
            vbc_g128_check<int>();   
        }

        public void vbc_g128x32u()
        {
            vbc_g128_check<uint>();   
        }

        public void vbc_g128x64i()
        {
            vbc_g128_check<long>();   
        }

        public void vbc_g128x64u()
        {
            vbc_g128_check<ulong>();   
        }

        public void vbc_g128x32f()
        {
            vbc_g128_check<float>(); 
        }

        public void vbc_g128x64f()
        {
            vbc_g128_check<double>();
        }

        public void vbc_g256x8i()
        {
            vbc_g256_check<sbyte>();   
        }

        public void vbc_g256x8u()
        {
            vbc_g256_check<byte>();   
        }

        public void vbc_g256x16i()
        {
            vbc_g256_check<short>();   
        }

        public void vbc_g256x16u()
        {
            vbc_g256_check<ushort>();   
        }

        public void vbc_g256x32i()
        {
            vbc_g256_check<int>();   
        }

        public void vbc_g256x32u()
        {
            vbc_g256_check<uint>();   
        }

        public void vbc_g256x64i()
        {
            vbc_g256_check<long>();   
        }

        public void vbc_g256x64u()
        {
            vbc_g256_check<ulong>();   
        }

        public void vbc_g256x32f()
        {
            vbc_g256_check<float>(); 
        }

        public void vbc_g256x64f()
        {
            vbc_g256_check<double>();
        }

        void vbc_g128_check<T>()
            where T : unmanaged
        {
            var x = Random.Next<T>();
            var vX = ginx.vbroadcast(n128,x);
            var data = vX.ToSpan();
            for(var i=0; i<data.Length; i++)
                Claim.eq(x,data[i]);
            
        }

        void vbc_g256_check<T>()
            where T : unmanaged
        {
            var x = Random.Next<T>();
            var vX = ginx.vbroadcast(n256,x);
            var data = vX.ToSpan();
            for(var i=0; i<data.Length; i++)
                Claim.eq(x,data[i]);
        }

    }

}