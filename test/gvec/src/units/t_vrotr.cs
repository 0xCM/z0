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

    public class t_vrotr : t_inx<t_vrotr>
    {
        public void vrotr_check()
        {
            vrotr_check(n128);
            vrotr_check(n256);
        }

        void vrotr_check(N128 w)
        {
            vrotr_check(w, z8);                
            vrotr_check(w, z16);
            vrotr_check(w, z32);
            vrotr_check(w, z64);
        }

        void vrotr_check(N256 w)
        {
            vrotr_check(w, z8);                
            vrotr_check(w, z16);
            vrotr_check(w, z32);
            vrotr_check(w, z64);
        }

        void vrotr_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckSVF.CheckShiftOp(VSvc.vrotr(w,t), w,t);
            
        void vrotr_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckSVF.CheckShiftOp(VSvc.vrotr(w,t), w,t);

    }
}