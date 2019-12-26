//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_vand : t_vinx<t_vand>
    {
        public void check()
        {            
            check(n128);
            check(n256);
        }

        void check(N128 w)
        {
            v_check(VOps.vand(w,z8), w, z8);                
            v_check(VOps.vand(w,z8i), w, z8i);
            v_check(VOps.vand(w,z16),  w, z16);
            v_check(VOps.vand(w,z16i), w, z16i);
            v_check(VOps.vand(w,z32), w, z32);
            v_check(VOps.vand(w,z32i), w, z32i);
            v_check(VOps.vand(w,z64), w, z64);
            v_check(VOps.vand(w,z64i), w, z64i);

        }

        void check(N256 w = default)
        {
            v_check(VOps.vand(w,z8), w, z8);                
            v_check(VOps.vand(w,z8i), w, z8i);
            v_check(VOps.vand(w,z16),  w, z16);
            v_check(VOps.vand(w,z16i), w, z16i);
            v_check(VOps.vand(w,z32), w, z32);
            v_check(VOps.vand(w,z32i), w, z32i);
            v_check(VOps.vand(w,z64), w, z64);
            v_check(VOps.vand(w,z64i), w, z64i);
        }            

        void v_check<F,T>(F f, N128 w, T t = default)
            where T : unmanaged
            where F : IVBinOp128D<T>
                => check_binary_scalar_match(f,w,t);
            
        void v_check<F,T>(F f, N256 w, T t = default)
            where T : unmanaged
            where F : IVBinOp256D<T>
                => check_binary_scalar_match(f,w,t);
    }
}
