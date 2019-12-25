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
        public void vxor_check()
        {
            
            void check_128(N128 w = default)
            {
                vxor_check(VOps.vxor(w,z8));                
                vxor_check(VOps.vxor(w,z8i));
                vxor_check(VOps.vxor(w,z16));
                vxor_check(VOps.vxor(w,z16i));
                vxor_check(VOps.vxor(w,z32));
                vxor_check(VOps.vxor(w,z32i));
                vxor_check(VOps.vxor(w,z64));
                vxor_check(VOps.vxor(w,z64i));

            }

            void check_256(N256 w = default)
            {
                vxor_check(VOps.vxor(w,z8));                
                vxor_check(VOps.vxor(w,z8i));
                vxor_check(VOps.vxor(w,z16));
                vxor_check(VOps.vxor(w,z16i));
                vxor_check(VOps.vxor(w,z32));
                vxor_check(VOps.vxor(w,z32i));
                vxor_check(VOps.vxor(w,z64));
                vxor_check(VOps.vxor(w,z64i));
            }            

            check_128();
            check_256();
        }

        void vxor_check<T>(IVBinOp128<T> op)
            where T : unmanaged
                => check_scalar_match(op);
            

        void vxor_check<T>(IVBinOp256<T> op)
            where T : unmanaged
                => check_scalar_match(op);
    }
}
