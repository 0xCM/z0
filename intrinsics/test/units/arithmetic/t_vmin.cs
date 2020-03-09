//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vmin : t_vinx<t_vmin>
    {
        public void vmin_check()
        {
            vmin_check(n128);
            vmin_check(n256);
        }
        
        void vmin_check(N128 w)
        {
            vmin_check(w,z8);
            vmin_check(w,z8i);
            vmin_check(w,z16);
            vmin_check(w,z16i);
            vmin_check(w,z32);
            vmin_check(w,z32i);
            vmin_check(w,z64);
            vmin_check(w,z64i);
            vmin_check(w,z32f);
            vmin_check(w,z64f);
        }

        void vmin_check(N256 w)
        {
            vmin_check(w,z8);
            vmin_check(w,z8i);
            vmin_check(w,z16);
            vmin_check(w,z16i);
            vmin_check(w,z32);
            vmin_check(w,z32i);
            vmin_check(w,z64);
            vmin_check(w,z64i);
            vmin_check(w,z32f);
            vmin_check(w,z64f);
        }

        void vmin_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckBinaryScalarMatch(VSvcFactories.vmin(w,t), w, t);
            
        void vmin_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckBinaryScalarMatch(VSvcFactories.vmin(w,t), w, t);
    }
}