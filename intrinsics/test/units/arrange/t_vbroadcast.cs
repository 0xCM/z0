//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

    public class t_vbroadcast : t_vinx<t_vbroadcast>
    {
        public void vbroadcast_check()        
        {
            vbroadcast_check(n128);
            vbroadcast_check(n256);
        }

        void vbroadcast_check(N128 w)
        {
            vbroadcast_check(w,z8);   
            vbroadcast_check(w,z8i);   
            vbroadcast_check(w,z16);   
            vbroadcast_check(w,z16i);   
            vbroadcast_check(w,z32);   
            vbroadcast_check(w,z32i);   
            vbroadcast_check(w,z64i);   
            vbroadcast_check(w,z64);   
            vbroadcast_check(w,z32f);
            vbroadcast_check(w,z64f);
        }

        void vbroadcast_check(N256 w)
        {
            vbroadcast_check(w,z8);   
            vbroadcast_check(w,z8i);   
            vbroadcast_check(w,z16);   
            vbroadcast_check(w,z16i);   
            vbroadcast_check(w,z32);   
            vbroadcast_check(w,z32i);   
            vbroadcast_check(w,z64i);   
            vbroadcast_check(w,z64);   
            vbroadcast_check(w,z32f);
            vbroadcast_check(w,z64f);
        }

        protected void vbroadcast_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckFactory(w, VF.vbroadcast(w,t,t), Checks.vbroadcast(w,t,t),t,t);            

        protected void vbroadcast_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckFactory(w, VF.vbroadcast(w,t,t), Checks.vbroadcast(w,t,t),t,t);            
    }
}