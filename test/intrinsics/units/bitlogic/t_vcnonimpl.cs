//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Core;

    public class t_vcnonimpl : t_vinx<t_vcnonimpl>
    {
        public void vcnonimpl_check()
        {            
            vcnonimpl_check(n128);
            vcnonimpl_check(n256);
        }

        void vcnonimpl_check(N128 w)
        {
            vcnonimpl_check(w, z8);                
            vcnonimpl_check(w, z8i);
            vcnonimpl_check(w, z16);
            vcnonimpl_check(w, z16i);
            vcnonimpl_check(w, z32);
            vcnonimpl_check(w, z32i);
            vcnonimpl_check(w, z64);
            vcnonimpl_check(w, z64i);

        }

        void vcnonimpl_check(N256 w)
        {
            vcnonimpl_check(w, z8);                
            vcnonimpl_check(w, z8i);
            vcnonimpl_check(w, z16);
            vcnonimpl_check(w, z16i);
            vcnonimpl_check(w, z32);
            vcnonimpl_check(w, z32i);
            vcnonimpl_check(w, z64);
            vcnonimpl_check(w, z64i);
        }            

        void vcnonimpl_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckBinaryScalarMatch(VSvc.vcnonimpl(w,t), w, t);
            
        void vcnonimpl_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckBinaryScalarMatch(VSvc.vcnonimpl(w,t), w, t);
     }
}
