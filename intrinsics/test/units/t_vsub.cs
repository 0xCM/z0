//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vsub : t_vinx<t_vsub>
    {
        public void check()
        {            
            check(n128);
            check(n256);
        }

        void check(N128 w)
        {
            check(VOps.vsub(w,z8), w, z8);                
            check(VOps.vsub(w,z8i), w, z8i);
            check(VOps.vsub(w,z16),  w, z16);
            check(VOps.vsub(w,z16i), w, z16i);
            check(VOps.vsub(w,z32), w, z32);
            check(VOps.vsub(w,z32i), w, z32i);
            check(VOps.vsub(w,z64), w, z64);
            check(VOps.vsub(w,z64i), w, z64i);

        }

        void check(N256 w)
        {
            check(VOps.vsub(w,z8), w, z8);                
            check(VOps.vsub(w,z8i), w, z8i);
            check(VOps.vsub(w,z16),  w, z16);
            check(VOps.vsub(w,z16i), w, z16i);
            check(VOps.vsub(w,z32), w, z32);
            check(VOps.vsub(w,z32i), w, z32i);
            check(VOps.vsub(w,z64), w, z64);
            check(VOps.vsub(w,z64i), w, z64i);
        }            

        void check<F,T>(F f, N128 w, T t = default)
            where T : unmanaged
            where F : IVBinOp128D<T>
                => check_binary_scalar_match(f,w,t);
            
        void check<F,T>(F f, N256 w, T t = default)
            where T : unmanaged
            where F : IVBinOp256D<T>
                => check_binary_scalar_match(f,w,t);
    }
}