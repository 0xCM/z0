//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vsub : t_vinx<t_vsub>
    {
        public void vsub_check()
        {            
            vsub_check(n128);
            vsub_check(n256);
        }

        void vsub_check(N128 w)
        {
            vsub_check(w, z8);                
            vsub_check(w, z8i);
            vsub_check(w, z16);
            vsub_check(w, z16i);
            vsub_check(w, z32);
            vsub_check(w, z32i);
            vsub_check(w, z64);
            vsub_check(w, z64i);

        }

        void vsub_check(N256 w)
        {
            vsub_check(w, z8);                
            vsub_check(w, z8i);
            vsub_check(w, z16);
            vsub_check(w, z16i);
            vsub_check(w, z32);
            vsub_check(w, z32i);
            vsub_check(w, z64);
            vsub_check(w, z64i);
        }            

        void vsub_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckBinaryScalarMatch(VSvcFactories.vsub(w,t),w,t);
            
        void vsub_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckBinaryScalarMatch(VSvcFactories.vsub(w,t),w,t);
    }
}