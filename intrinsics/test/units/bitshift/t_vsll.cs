//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vsll : t_vinx<t_vsll>
    {


        public void vsll_check()
        {
            vsll_check(n128);
            vsll_check(n256);
        }

        void vsll_check(N128 w)
        {
            vsll_check(w, z8);                
            vsll_check(w, z8i);
            vsll_check(w, z16);
            vsll_check(w, z16i);
            vsll_check(w, z32);
            vsll_check(w, z32i);
            vsll_check(w, z64);
            vsll_check(w, z64i);
        }

        void vsll_check(N256 w)
        {
            vsll_check(w, z8);                
            vsll_check(w, z8i);
            vsll_check(w, z16);
            vsll_check(w, z16i);
            vsll_check(w, z32);
            vsll_check(w, z32i);
            vsll_check(w, z64);
            vsll_check(w, z64i);
        }

        void vsll_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckShiftScalarMatch(VX.vsll(w,t),w,t);
            
        void vsll_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckShiftScalarMatch(VX.vsll(w,t),w,t);

    }
}