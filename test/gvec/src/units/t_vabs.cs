//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Konst;

    public class t_vabs : t_inx<t_vabs>
    {
        public void vabs_check()
        {
            vabs_check(n128);
            vabs_check(n256);
        }
        
        void vabs_check(N128 w)
        {
            vabs_check(w, z8i);
            vabs_check(w, z16i);
            vabs_check(w, z32i);
            vabs_check(w, z64i);
        }

        void vabs_check(N256 w)
        {
            vabs_check(w, z8i);
            vabs_check(w, z16i);
            vabs_check(w, z32i);
            vabs_check(w, z64i);
        }

        void vabs_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckSVF.CheckUnaryOp(VSvc.vabs(w,t),w,t);
            
        void vabs_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckSVF.CheckUnaryOp(VSvc.vabs(w,t),w,t);
    }

}