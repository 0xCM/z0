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
            
            void check128(N128 w = default)
            {
                v_check(VOps.vlt(w,z8), w, z8);                
                v_check(VOps.vlt(w,z8i), w, z8i);
                v_check(VOps.vlt(w,z16),  w, z16);
                v_check(VOps.vlt(w,z16i), w, z16i);
                v_check(VOps.vlt(w,z32), w, z32);
                v_check(VOps.vlt(w,z32i), w, z32i);
                v_check(VOps.vlt(w,z64), w, z64);
                v_check(VOps.vlt(w,z64i), w, z64i);

            }

            void check256(N256 w = default)
            {
                v_check(VOps.vlt(w,z8), w, z8);                
                v_check(VOps.vlt(w,z8i), w, z8i);
                v_check(VOps.vlt(w,z16),w, z16);
                v_check(VOps.vlt(w,z16i),w, z16i);
                v_check(VOps.vlt(w,z32),w, z32);
                v_check(VOps.vlt(w,z32i),w, z32i);
                v_check(VOps.vlt(w,z64),w, z64);
                v_check(VOps.vlt(w,z64i),w, z64i);
            }            

            check128();
            check256();
        }

        void v_check<F,T>(F f, N128 w, T t = default)
            where T : unmanaged
            where F : IVBinOp128D<T>
        {
            check_binary_scalar_match(f,w,t);

        }

        void v_check<F,T>(F f, N256 w, T t = default)
            where T : unmanaged
            where F : IVBinOp256D<T>
        {
            check_binary_scalar_match(f,w,t);
            
        }    
 
 
    }
}