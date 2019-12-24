//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vadd : t_vinx<t_vadd>
    {
        public void vadd_check()
        {
            
            void check_128(N128 w = default)
            {
                vadd_check(VOps.vadd(w,z8));                
                vadd_check(VOps.vadd(w,z8i));
                vadd_check(VOps.vadd(w,z16));
                vadd_check(VOps.vadd(w,z16i));
                vadd_check(VOps.vadd(w,z32));
                vadd_check(VOps.vadd(w,z32i));
                vadd_check(VOps.vadd(w,z64));
                vadd_check(VOps.vadd(w,z64i));

            }

            void check_256(N256 w = default)
            {
                vadd_check(VOps.vadd(w,z8));                
                vadd_check(VOps.vadd(w,z8i));
                vadd_check(VOps.vadd(w,z16));
                vadd_check(VOps.vadd(w,z16i));
                vadd_check(VOps.vadd(w,z32));
                vadd_check(VOps.vadd(w,z32i));
                vadd_check(VOps.vadd(w,z64));
                vadd_check(VOps.vadd(w,z64i));
            }            

            check_128();
            check_256();
        }

        void vadd_check<T>(IVBinOp128<T> op)
            where T : unmanaged
                => verify_random(op);
            

        void vadd_check<T>(IVBinOp256<T> op)
            where T : unmanaged
                => verify_random(op);

    }
}