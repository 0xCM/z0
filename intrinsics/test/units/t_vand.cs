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
            
            void check_128(N128 w = default)
            {
                vand_check(VOps.vand(w,z8));                
                vand_check(VOps.vand(w,z8i));
                vand_check(VOps.vand(w,z16));
                vand_check(VOps.vand(w,z16i));
                vand_check(VOps.vand(w,z32));
                vand_check(VOps.vand(w,z32i));
                vand_check(VOps.vand(w,z64));
                vand_check(VOps.vand(w,z64i));

            }

            void check_256(N256 w = default)
            {
                vand_check(VOps.vand(w,z8));                
                vand_check(VOps.vand(w,z8i));
                vand_check(VOps.vand(w,z16));
                vand_check(VOps.vand(w,z16i));
                vand_check(VOps.vand(w,z32));
                vand_check(VOps.vand(w,z32i));
                vand_check(VOps.vand(w,z64));
                vand_check(VOps.vand(w,z64i));
            }            

            check_128();
            check_256();
        }

        void vand_check<T>(IVBinOp128<T> op)
            where T : unmanaged
                => check_scalar_match(op);
            

        void vand_check<T>(IVBinOp256<T> op)
            where T : unmanaged
                => check_scalar_match(op);

    }

}