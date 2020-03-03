//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vhi : t_vinx<t_vhi>
    {   
        public void vhi_128x8u()
            => vhi_check<byte>(n128,z8);

        public void vhi_128x8i()
            => vhi_check<sbyte>(n128,z8i);

        public void vhi_128x16i()
            => vhi_check<short>(n128,z16i);

        public void vhi_128x16u()
            => vhi_check<ushort>(n128,z16);

        public void vhi_128x32i()
            => vhi_check<int>(n128);

        public void vhi_128x32u()
            => vhi_check<uint>(n128);

        public void vhi_128x64i()
            => vhi_check<long>(n128);

        public void vhi_128x64u()
            => vhi_check<ulong>(n128);

        public void vhi_128x32f()
            => vhi_check<float>(n128);

        public void vhi_128x64f()
            => vhi_check<double>(n128);

        public void vhi_256x8u()
            => vhi_check<byte>(n256);

        public void vhi_256x8i()
            => vhi_check<sbyte>(n256);

        public void vhi_256x16i()
            => vhi_check<short>(n256);

        public void vhi_256x16u()
            => vhi_check<ushort>(n256);

        public void vhi_256x32i()
            => vhi_check<int>(n256);

        public void vhi_256x32u()
            => vhi_check<uint>(n256);

        public void vhi_256x64i()
            => vhi_check<long>(n256);

        public void vhi_256x64u()
            => vhi_check<ulong>(n256);

        public void vhi_256x32f()
            => vhi_check<float>(n256);

        public void vhi_256x64f()
            => vhi_check<double>(n256);
 
        protected void vhi_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var count = vcount(w,t);
            var f = VX.vhi(w,t);
            var r = Random.VectorEmitter(w,t);
            for(var rep=0; rep < RepCount; rep++)
            {                
                var x = r.Invoke();
                var h = f.Invoke(x);

                for(int i=0, j = count/2; j < count; i++, j++)
                    Claim.eq(x.Cell(j), h.Cell(i));
            }
        }

        protected void vhi_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var f = VX.vhi(w,t);
            var r = Random.VectorEmitter(w,t);
            for(var rep=0; rep < RepCount; rep++)
            {
                var x = r.Invoke();
                var y = f.Invoke(x);
                var z = ginx.vinsert(y,x,1);
                Claim.eq(x,z);
            }
        } 
    }

}