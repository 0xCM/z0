//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    public class t_veq : t_vinx<t_veq>
    {     
        public void veq_check()
        {
            
            void check128(N128 w = default)
            {
                veq_check(VOps.veq(w,z8));                
                veq_check(VOps.veq(w,z8i));
                veq_check(VOps.veq(w,z16));
                veq_check(VOps.veq(w,z16i));
                veq_check(VOps.veq(w,z32));
                veq_check(VOps.veq(w,z32i));
                veq_check(VOps.veq(w,z64));
                veq_check(VOps.veq(w,z64i));

            }

            void check256(N256 w = default)
            {
                veq_check(VOps.veq(w,z8));                
                veq_check(VOps.veq(w,z8i));
                veq_check(VOps.veq(w,z16));
                veq_check(VOps.veq(w,z16i));
                veq_check(VOps.veq(w,z32));
                veq_check(VOps.veq(w,z32i));
                veq_check(VOps.veq(w,z64));
                veq_check(VOps.veq(w,z64i));
            }            

            check128();
            check256();
        }

        void veq_check<T>(IVBinOp128<T> op)
            where T : unmanaged
        {
            var w = n128;
            var t = default(T);
            check_scalar_match(op);
            
            var x = Random.Blocks<T>(w, SampleCount/vcount(w,t));
            var result = DataBlocks.alloc<T>(w, x.BlockCount);
            result.Fill(gmath.ones<T>());
            check_explicit(op,x,x,result);

        }

        void veq_check<T>(IVBinOp256<T> op)
            where T : unmanaged
        {
            var w = n256;
            var t = default(T);
            check_scalar_match(op);
            
            var x = Random.Blocks<T>(w, SampleCount/vcount(w,t));
            var result = DataBlocks.alloc<T>(w, x.BlockCount);
            result.Fill(gmath.ones<T>());
            check_explicit(op,x,x,result);

        }    
    }
}