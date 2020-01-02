//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vlo : t_vinx<t_vlo>
    {   
        public void vlo_128x8u()
            => vlo_check<byte>(n128,z8);

        public void vlo_128x8i()
            => vlo_check<sbyte>(n128,z8i);

        public void vlo_128x16i()
            => vlo_check<short>(n128,z16i);

        public void vlo_128x16u()
            => vlo_check<ushort>(n128,z16);

        public void vlo_128x32i()
            => vlo_check<int>(n128);

        public void vlo_128x32u()
            => vlo_check<uint>(n128);

        public void vlo_128x64i()
            => vlo_check<long>(n128);

        public void vlo_128x64u()
            => vlo_check<ulong>(n128);

        public void vlo_128x32f()
            => vlo_check<float>(n128);

        public void vlo_128x64f()
            => vlo_check<double>(n128);

        public void vlo_256x8u()
            => vlo_check<byte>(n256);

        public void vlo_256x8i()
            => vlo_check<sbyte>(n256);

        public void vlo_256x16i()
            => vlo_check<short>(n256);

        public void vlo_256x16u()
            => vlo_check<ushort>(n256);

        public void vlo_256x32i()
            => vlo_check<int>(n256);

        public void vlo_256x32u()
            => vlo_check<uint>(n256);

        public void vlo_256x64i()
            => vlo_check<long>(n256);

        public void vlo_256x64u()
            => vlo_check<ulong>(n256);

        public void vlo_256x32f()
            => vlo_check<float>(n256);

        public void vlo_256x64f()
            => vlo_check<double>(n256);
 
        protected void vlo_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var count = vcount(w,t);
            var f = VX.vlo(w,t);
            var r = vemitter(w,t);
            for(var rep=0; rep < RepCount; rep++)
            {                
                var x = r.Invoke();
                var h = f.Invoke(x);

                for(int i=0; i < count/2; i++)
                    Claim.eq(x.Item(i), h.Item(i));
            }
        }

        protected void vlo_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var f = VX.vlo(w,t);
            var r = vemitter(w,t);
            for(var rep=0; rep < RepCount; rep++)
            {
                var x = r.Invoke();
                var y = f.Invoke(x);
                var z = ginx.vinsert(y,x,0);
                Claim.eq(x,z);
            }
        } 
    }

}