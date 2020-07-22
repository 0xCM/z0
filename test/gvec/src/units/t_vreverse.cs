//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Konst;
    using static z;

    public class t_vreverse : t_inx<t_vreverse>
    {
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
                => vreverse_check(VSvc.vreverse(w,t),w,t);

        void vreverse_check<T>(N256 w, T t = default)
            where T : unmanaged
                => vreverse_check(VSvc.vreverse(w,t),w,t);

        void check_invariant<T>(N128 w, T t = default)
            where T : unmanaged
        {            
            var v1 = V0.vincrements<T>(w);
            var v2 = VData.vdecrements<T>(w);
            var v3 = gvec.vreverse(v1);
            Claim.veq(v2,v3);
        }

        void check_invariant<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var v1 = V0.vincrements<T>(w);
            var v2 = VData.vdecrements<T>(w);            
            var v3 = gvec.vreverse(v1);
            Claim.veq(v2,v3);
        }

        void vreverse_check<F,T>(F f, N128 w, T t = default)
            where T : unmanaged
            where F : IUnaryOp128<T>
        {
            var n = vcount(w,t);
            var r = Random.VectorEmitter(w,t);

            void check()
            {
                var input = r.Invoke();                
                var output = f.Invoke(input);
                var expect = V0.vzero(w,t);
                for(byte j = 0; j < n; j++)
                    expect = vcell(V0.vcell(input,(n - 1) - j),j,expect);

                Claim.veq(expect,output);
            }

            CheckAction(check, CaseName(f));
        }

        void vreverse_check<F,T>(F f, N256 w, T t = default)
            where T : unmanaged
            where F : IUnaryOp256<T>
        {
            var n = vcount(w,t);
            var r = Random.VectorEmitter(w,t);

            void check()
            {
                var input = r.Invoke();                
                var output = f.Invoke(input);
                var expect = V0.vzero(w,t);
                for(byte j = 0; j < n; j++)
                    expect = vcell(V0.vcell(input,(n - 1) - j),j,expect);

                Claim.veq(expect,output);
            }

            CheckAction(check, CaseName(f));
        } 
   }
}