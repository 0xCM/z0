//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vdec : t_vinx<t_vdec>
    {

        public void vdec_check()
        {
            vdec_check(n128);
            vdec_check(n256);
        }
        
        void vdec_check(N128 w)
        {
            vdec_check(w, z8);                
            vdec_check(w, z8i);
            vdec_check(w, z16);
            vdec_check(w, z16i);
            vdec_check(w, z32);
            vdec_check(w, z32i);
            vdec_check(w, z64);
            vdec_check(w, z64i);
        }

        void vdec_check(N256 w)
        {
            vdec_check(w, z8);                
            vdec_check(w, z8i);
            vdec_check(w, z16);
            vdec_check(w, z16i);
            vdec_check(w, z32);
            vdec_check(w, z32i);
            vdec_check(w, z64);
            vdec_check(w, z64i);
        }

        void vdec_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckUnaryScalarMatch(VX.vdec(w,t),w,t);
            
        void vdec_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckUnaryScalarMatch(VX.vdec(w,t),w,t);

    }
}