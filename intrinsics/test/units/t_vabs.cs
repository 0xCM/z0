//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vabs : t_vinx<t_vabs>
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
                => CheckUnaryScalarMatch(VX.vabs(w,t),w,t);
            
        void vabs_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckUnaryScalarMatch(VX.vabs(w,t),w,t);

    }

}