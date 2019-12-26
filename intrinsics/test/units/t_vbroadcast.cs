//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_vbroadcast : t_vinx<t_vbroadcast>
    {
        public void vbc_128x8i()
            => vbroadcast_check<sbyte>(n128);   

        public void vbc_128x8u()        
            => vbroadcast_check<byte>(n128);   
        
        public void vbc_128x16i()
            => vbroadcast_check<short>(n128);   

        public void vbc_128x16u()
            => vbroadcast_check<ushort>(n128);   

        public void vbc_128x32i()
            => vbroadcast_check<int>(n128);   

        public void vbc_128x32u()
            => vbroadcast_check<uint>(n128);   

        public void vbc_128x64i()
            => vbroadcast_check<long>(n128);   

        public void vbc_128x64u()
            => vbroadcast_check<ulong>(n128);   

        public void vbc_128x32f()
            => vbroadcast_check<float>(n128); 

        public void vbc_128x64f()
            => vbroadcast_check<double>(n128);

        public void vbc_256x8i()
            => vbroadcast_check<sbyte>(n256);   
        
        public void vbc_256x8u()
            => vbroadcast_check<byte>(n256);   
        
        public void vbc_256x16i()
            => vbroadcast_check<short>(n256);   

        public void vbc_256x16u()
            => vbroadcast_check<ushort>(n256);   

        public void vbc_256x32i()
            => vbroadcast_check<int>(n256);   

        public void vbc_256x32u()
            => vbroadcast_check<uint>(n256);   

        public void vbc_256x64i()
            => vbroadcast_check<long>(n256);   

        public void vbc_256x64u()
            => vbroadcast_check<ulong>(n256);   

        public void vbc_256x32f()
            => vbroadcast_check<float>(n256); 

        public void vbc_256x64f()
            => vbroadcast_check<double>(n256);

        protected void vbroadcast_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var x = Random.Next<T>();
            var vX = CpuVector.vbroadcast(w,x);
            var data = vX.ToSpan();
            for(var i=0; i<data.Length; i++)
                Claim.eq(x,data[i]);            
        }

        protected void vbroadcast_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var x = Random.Next<T>();
            var vX = CpuVector.vbroadcast(w,x);
            var data = vX.ToSpan();
            for(var i=0; i<data.Length; i++)
                Claim.eq(x,data[i]);
        }

    }
}