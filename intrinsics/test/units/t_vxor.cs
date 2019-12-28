//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_vxor : t_vinx<t_vxor>
    {
        public void check()
        {    
            check(n128);
            check(n256);
        }

        void check(N128 w)
        {
            check(VX.vxor(w,z8), w, z8);                
            check(VX.vxor(w,z8i), w, z8i);
            check(VX.vxor(w,z16),  w, z16);
            check(VX.vxor(w,z16i), w, z16i);
            check(VX.vxor(w,z32), w, z32);
            check(VX.vxor(w,z32i), w, z32i);
            check(VX.vxor(w,z64), w, z64);
            check(VX.vxor(w,z64i), w, z64i);

        }

        void check(N256 w)
        {
            check(VX.vxor(w,z8), w, z8);                
            check(VX.vxor(w,z8i), w, z8i);
            check(VX.vxor(w,z16),  w, z16);
            check(VX.vxor(w,z16i), w, z16i);
            check(VX.vxor(w,z32), w, z32);
            check(VX.vxor(w,z32i), w, z32i);
            check(VX.vxor(w,z64), w, z64);
            check(VX.vxor(w,z64i), w, z64i);
        }            

        void check<F,T>(F f, N128 w, T t = default)
            where T : unmanaged
            where F : IVBinOp128D<T>
                => CheckBinaryScalarMatch(f,w,t);
            
        void check<F,T>(F f, N256 w, T t = default)
            where T : unmanaged
            where F : IVBinOp256D<T>
                => CheckBinaryScalarMatch(f,w,t);

    }
}
