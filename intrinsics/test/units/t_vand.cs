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
        public void vand_check()
        {            
            vand_check(n128);
            vand_check(n256);
        }

        void vand_check(N128 w)
        {
            vand_check(w, z8);                
            vand_check(w, z8i);
            vand_check(w, z16);
            vand_check(w, z16i);
            vand_check(w, z32);
            vand_check(w, z32i);
            vand_check(w, z64);
            vand_check(w, z64i);

        }

        void vand_check(N256 w)
        {
            vand_check(w, z8);                
            vand_check(w, z8i);
            vand_check(w, z16);
            vand_check(w, z16i);
            vand_check(w, z32);
            vand_check(w, z32i);
            vand_check(w, z64);
            vand_check(w, z64i);
        }            

        void vand_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckBinaryScalarMatch(VX.vand(w,t), w, t);
            
        void vand_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckBinaryScalarMatch(VX.vand(w,t), w, t);
     }
}
