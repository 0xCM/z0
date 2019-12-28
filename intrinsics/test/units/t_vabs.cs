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

        public void check()
        {
            check(n128);
            check(n256);
        }
        
        void check(N128 w)
        {
            check(VX.vabs(w,z8i), w, z8i);
            check(VX.vabs(w,z16i), w, z16i);
            check(VX.vabs(w,z32i), w, z32i);
            check(VX.vabs(w,z64i), w, z64i);
        }

        void check(N256 w)
        {
            check(VX.vabs(w,z8i), w, z8i);
            check(VX.vabs(w,z16i), w, z16i);
            check(VX.vabs(w,z32i), w, z32i);
            check(VX.vabs(w,z64i), w, z64i);
        }

        void check<F,T>(F f, N128 w, T t = default)
            where T : unmanaged
            where F : IVUnaryOp128D<T>
                => CheckUnaryScalarMatch(f,w,t);
            
        void check<F,T>(F f, N256 w, T t = default)
            where T : unmanaged
            where F : IVUnaryOp256D<T>
                => CheckUnaryScalarMatch(f,w,t);

    }

}