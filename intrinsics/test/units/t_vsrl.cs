//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vsrl : t_vinx<t_vsrl>
    {
        public void check()
        {
            check(n128);
            check(n256);
        }
        void check(N128 w)
        {

            //check(VOps.vsrl(w,z16i), w, z16i);

            check(VX.vsrl(w,z8), w, z8);                
            check(VX.vsrl(w,z8i), w, z8i);
            check(VX.vsrl(w,z16),  w, z16);
            check(VX.vsrl(w,z32), w, z32);
            check(VX.vsrl(w,z32i), w, z32i);
            check(VX.vsrl(w,z64), w, z64);
            check(VX.vsrl(w,z64i), w, z64i);
        }

        void check(N256 w)
        {
            //check(VOps.vsrl(w,z16i), w, z16i);

            check(VX.vsrl(w,z8), w, z8);                
            check(VX.vsrl(w,z8i), w, z8i);
            check(VX.vsrl(w,z16),  w, z16);
            check(VX.vsrl(w,z32), w, z32);
            check(VX.vsrl(w,z32i), w, z32i);
            check(VX.vsrl(w,z64), w, z64);
            check(VX.vsrl(w,z64i), w, z64i);            
        }

        void check<F,T>(F f, N128 w, T t = default)
            where T : unmanaged
            where F : IVShiftOp128D<T>
                => CheckShiftScalarMatch(f,w,t);
            
        void check<F,T>(F f, N256 w, T t = default)
            where T : unmanaged
            where F : IVShiftOp256D<T>
                => CheckShiftScalarMatch(f,w,t);

    }
}