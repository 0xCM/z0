//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vreverse : t_vinx<t_vreverse>
    {
        // public void vreverse_128x8u()
        //     => check(VX.vreverse(n128,z8), n128, z8);

        // public void vreverse_128x8i()
        //     => check(VX.vreverse(n128,z8i), n128, z8i);

        // public void vreverse_128x16u()
        //     => check(VX.vreverse(n128,z16), n128, z16);

        // public void vreverse_128x16i()
        //     => check(VX.vreverse(n128,z16i), n128, z16i);

        // public void vreverse_128x32u()
        //     => check(VX.vreverse(n128,z32), n128, z32);

        // public void vreverse_128x32i()
        //     => check(VX.vreverse(n128,z32i), n128, z32i);

        // public void vreverse_128x64u()
        //     => check(VX.vreverse(n128,z64), n128, z64);

        // public void vreverse_128x64i()
        //     => check(VX.vreverse(n128,z64i), n128, z64i);

        // public void vreverse_256x8u()
        //     => check(VX.vreverse(n256,z8), n256, z8);

        // public void vreverse_256x8i()
        //     => check(VX.vreverse(n256,z8i), n256, z8i);

        // public void vreverse_256x16u()
        //     => check(VX.vreverse(n256,z16), n256, z16);

        // public void vreverse_256x16i()
        //     => check(VX.vreverse(n256,z16i), n256, z16i);

        // public void vreverse_256x32u()
        //     => check(VX.vreverse(n256,z32), n256, z32);

        // public void vreverse_256x32i()
        //     => check(VX.vreverse(n256,z32i), n256, z32i);

        // public void vreverse_256x64u()
        //     => check(VX.vreverse(n256,z64), n256, z64);

        // public void vreverse_256x64i()
        //     => check(VX.vreverse(n256,z64i), n256, z64i);

        public void vreverse()
        {
            vreverse_check(n128);
            vreverse_check(n256);
        }

        void vreverse_check(N128 w)
        {
            vreverse_check(w, z8);
            vreverse_check(w, z8i);
            vreverse_check(w, z16);
            vreverse_check(w, z16i);
            vreverse_check(w, z32);
            vreverse_check(w, z32i);
            vreverse_check(w, z64);
            vreverse_check(w, z64i);
        }

        void vreverse_check(N256 w)
        {
            vreverse_check(w, z8);
            vreverse_check(w, z8i);
            vreverse_check(w, z16);
            vreverse_check(w, z16i);
            vreverse_check(w, z32);
            vreverse_check(w, z32i);
            vreverse_check(w, z64);
            vreverse_check(w, z64i);
        }

        void vreverse_check<T>(N128 w, T t = default)
            where T : unmanaged
                => vreverse_check(VX.vreverse(w,t),w,t);

        void vreverse_check<T>(N256 w, T t = default)
            where T : unmanaged
                => vreverse_check(VX.vreverse(w,t),w,t);

        void check_invariant<T>(N128 w, T t = default)
            where T : unmanaged
        {            
            var v1 = VPattern.vincrements<T>(w);
            var v2 = VPattern.vdecrements<T>(w);
            var v3 = ginx.vreverse(v1);
            Claim.eq(v2,v3);
        }

        void check_invariant<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var v1 = VPattern.vincrements<T>(w);
            var v2 = VPattern.vdecrements<T>(w);            
            var v3 = ginx.vreverse(v1);
            Claim.eq(v2,v3);
        }

        void vreverse_check<F,T>(F f, N128 w, T t = default)
            where T : unmanaged
            where F : IVUnaryOp128<T>
        {
            var n = vcount(w,t);
            var r = vemitter(w,t);

            void check()
            {
                var input = r.Invoke();                
                var output = f.Invoke(input);
                var expect = CpuVector.vzero(w,t);
                for(var j = 0; j < n; j++)
                    expect = vcell(vcell(input,(n - 1) - j),j,expect);

                Claim.eq(expect,output);
            }

            CheckAction(check, TestCaseName(f));

        }

        void vreverse_check<F,T>(F f, N256 w, T t = default)
            where T : unmanaged
            where F : IVUnaryOp256<T>
        {
            var n = vcount(w,t);
            var r = vemitter(w,t);

            void check()
            {
                var input = r.Invoke();                
                var output = f.Invoke(input);
                var expect = CpuVector.vzero(w,t);
                for(var j = 0; j < n; j++)
                    expect = vcell(vcell(input,(n - 1) - j),j,expect);

                Claim.eq(expect,output);

            }

            CheckAction(check, TestCaseName(f));

        } 
   }

}