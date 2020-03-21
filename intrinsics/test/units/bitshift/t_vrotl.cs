//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Nats;

    public class t_vrotl : t_vinx<t_vrotl>
    {
        public void vrotl_check()
        {
            vrotl_check(n128);
            vrotl_check(n256);
        }

        void vrotl_check(N128 w)
        {
            vrotl_check(w, z8);                
            vrotl_check(w, z16);
            vrotl_check(w, z32);
            vrotl_check(w, z64);
        }

        void vrotl_check(N256 w)
        {
            vrotl_check(w, z8);                
            vrotl_check(w, z16);
            vrotl_check(w, z32);
            vrotl_check(w, z64);
        }

        void vrotl_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckShiftScalarMatch(VSvcFactories.vrotl(w,t), w,t);
            
        void vrotl_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckShiftScalarMatch(VSvcFactories.vrotl(w,t), w,t);

    }
}