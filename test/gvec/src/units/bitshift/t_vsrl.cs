//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Memories;

    public class t_vsrl : t_inx<t_vsrl>
    {
        public void vsrl_check()
        {
            vsrl_check(n128);
            vsrl_check(n256);
        }
        
        void vsrl_check(N128 w)
        {
            vsrl_check(w, z8);                
            vsrl_check(w, z8i);
            vsrl_check(w, z16);
            vsrl_check(w, z32);
            vsrl_check(w, z32i);
            vsrl_check(w, z64);
            vsrl_check(w, z64i);
        }

        void vsrl_check(N256 w)
        {
            vsrl_check(w, z8);                
            vsrl_check(w, z8i);
            vsrl_check(w, z16);
            vsrl_check(w, z32);
            vsrl_check(w, z32i);
            vsrl_check(w, z64);
            vsrl_check(w, z64i);
        }

        void vsrl_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckSVF.CheckShiftOp(VSvc.vsrl(w,t),w,t);

        void vsrl_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckSVF.CheckShiftOp(VSvc.vsrl(w,t),w,t);

    }
}