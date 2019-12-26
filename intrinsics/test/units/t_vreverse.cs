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
        public void vreverse_128x8u()
            => check(VOps.vreverse(n128,z8), n128, z8);

        public void vreverse_128x8i()
            => check(VOps.vreverse(n128,z8i), n128, z8i);

        public void vreverse_128x16u()
            => check(VOps.vreverse(n128,z16), n128, z16);

        public void vreverse_128x16i()
            => check(VOps.vreverse(n128,z16i), n128, z16i);

        public void vreverse_128x32u()
            => check(VOps.vreverse(n128,z32), n128, z32);

        public void vreverse_128x32i()
            => check(VOps.vreverse(n128,z32i), n128, z32i);

        public void vreverse_128x64u()
            => check(VOps.vreverse(n128,z64), n128, z64);

        public void vreverse_128x64i()
            => check(VOps.vreverse(n128,z64i), n128, z64i);

        public void vreverse_256x8u()
            => check(VOps.vreverse(n256,z8), n256, z8);

        public void vreverse_256x8i()
            => check(VOps.vreverse(n256,z8i), n256, z8i);

        public void vreverse_256x16u()
            => check(VOps.vreverse(n256,z16), n256, z16);

        public void vreverse_256x16i()
            => check(VOps.vreverse(n256,z16i), n256, z16i);

        public void vreverse_256x32u()
            => check(VOps.vreverse(n256,z32), n256, z32);

        public void vreverse_256x32i()
            => check(VOps.vreverse(n256,z32i), n256, z32i);

        public void vreverse_256x64u()
            => check(VOps.vreverse(n256,z64), n256, z64);

        public void vreverse_256x64i()
            => check(VOps.vreverse(n256,z64i), n256, z64i);

        void check(N128 w)
        {
            check(VOps.vreverse(w,z8), w, z8);
            check(VOps.vreverse(w,z8i), w, z8i);
            check(VOps.vreverse(w,z16), w, z16);
            check(VOps.vreverse(w,z16i), w, z16i);
            check(VOps.vreverse(w,z32), w, z32);
            check(VOps.vreverse(w,z32i), w, z32i);
            check(VOps.vreverse(w,z64), w, z64);
            check(VOps.vreverse(w,z64i), w, z64i);
        }

        void check(N256 w)
        {
            check(VOps.vreverse(w,z8), w, z8);
            check(VOps.vreverse(w,z8i), w, z8i);
            check(VOps.vreverse(w,z16), w, z16);
            check(VOps.vreverse(w,z16i), w, z16i);
            check(VOps.vreverse(w,z32), w, z32);
            check(VOps.vreverse(w,z32i), w, z32i);
            check(VOps.vreverse(w,z64), w, z64);
            check(VOps.vreverse(w,z64i), w, z64i);
        }

        void check_invariant<T>(N128 w, T t = default)
            where T : unmanaged
        {            
            var v1 = CpuVector.vincrements<T>(w);
            var v2 = CpuVector.vdecrements<T>(w);
            var v3 = ginx.vreverse(v1);
            Claim.eq(v2,v3);
        }

        void check_invariant<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var v1 = CpuVector.vincrements<T>(w);
            var v2 = CpuVector.vdecrements<T>(w);            
            var v3 = ginx.vreverse(v1);
            Claim.eq(v2,v3);
        }

        void check<F,T>(F f, N128 w, T t = default)
            where T : unmanaged
            where F : IVUnaryOp128<T>
        {
            var n = vcount(w,t);
            check_invariant(w,t);

            for(var i=0; i < SampleCount; i++)
            {
                var input = Random.CpuVector(w,t);                
                var output = f.Invoke(input);
                var expect = CpuVector.vzero(w,t);
                for(var j = 0; j < n; j++)
                    expect = vcell(vcell(input,(n - 1) - j),j,expect);

                Claim.eq(expect,output);
            }
        }

        void check<F,T>(F f, N256 w, T t = default)
            where T : unmanaged
            where F : IVUnaryOp256<T>
        {
            var n = vcount(w,t);
            check_invariant(w,t);

            for(var i=0; i < SampleCount; i++)
            {
                var input = Random.CpuVector(w,t);                
                var output = f.Invoke(input);
                var expect = CpuVector.vzero(w,t);
                for(var j = 0; j < n; j++)
                    expect = vcell(vcell(input,(n - 1) - j),j,expect);

                Claim.eq(expect,output);
            }
        } 
   }

}