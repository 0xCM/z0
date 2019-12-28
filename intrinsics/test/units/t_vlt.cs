//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vlt : t_vinx<t_vlt>
    {        
        public void vlt_check()
        {
            
            check(n128);
            check(n256);
        }

        void check(N128 w)
        {
            v_check(VX.vlt(w,z8), w, z8);                
            v_check(VX.vlt(w,z8i), w, z8i);
            v_check(VX.vlt(w,z16),  w, z16);
            v_check(VX.vlt(w,z16i), w, z16i);
            v_check(VX.vlt(w,z32), w, z32);
            v_check(VX.vlt(w,z32i), w, z32i);
            v_check(VX.vlt(w,z64), w, z64);
            v_check(VX.vlt(w,z64i), w, z64i);
        }

        void check(N256 w)
        {
            v_check(VX.vlt(w,z8), w, z8);                
            v_check(VX.vlt(w,z8i), w, z8i);
            v_check(VX.vlt(w,z16),w, z16);
            v_check(VX.vlt(w,z16i),w, z16i);
            v_check(VX.vlt(w,z32),w, z32);
            v_check(VX.vlt(w,z32i),w, z32i);
            v_check(VX.vlt(w,z64),w, z64);
            v_check(VX.vlt(w,z64i),w, z64i);
        }            

        void v_check<F,T>(F f, N128 w, T t = default)
            where T : unmanaged
            where F : IVBinOp128D<T>
             => CheckBinaryScalarMatch(f,w,t);

        void v_check<F,T>(F f, N256 w, T t = default)
            where T : unmanaged
            where F : IVBinOp256D<T>
             => CheckBinaryScalarMatch(f,w,t);            
 
    }
}