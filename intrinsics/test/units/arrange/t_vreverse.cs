//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Nats;
    using static vgeneric;

    public class t_vreverse : t_vinx<t_vreverse>
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
            var v1 = Data.vincrements<T>(w);
            var v2 = Data.decrements<T>(w);
            var v3 = gvec.vreverse(v1);
            Claim.eq(v2,v3);
        }

        void check_invariant<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var v1 = Data.vincrements<T>(w);
            var v2 = Data.decrements<T>(w);            
            var v3 = gvec.vreverse(v1);
            Claim.eq(v2,v3);
        }

        void vreverse_check<F,T>(F f, N128 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp128Api<T>
        {
            var n = vcount(w,t);
            var r = Random.VectorEmitter(w,t);

            void check()
            {
                var input = r.Invoke();                
                var output = f.Invoke(input);
                var expect = vgeneric.vzero(w,t);
                for(var j = 0; j < n; j++)
                    expect = vgeneric.vcell(vgeneric.vcell(input,(n - 1) - j),j,expect);

                Claim.eq(expect,output);
            }

            CheckAction(check, CaseName(f));
        }

        void vreverse_check<F,T>(F f, N256 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp256Api<T>
        {
            var n = vcount(w,t);
            var r = Random.VectorEmitter(w,t);

            void check()
            {
                var input = r.Invoke();                
                var output = f.Invoke(input);
                var expect = vgeneric.vzero(w,t);
                for(var j = 0; j < n; j++)
                    expect = vgeneric.vcell(vcell(input,(n - 1) - j),j,expect);

                Claim.eq(expect,output);
            }

            CheckAction(check, CaseName(f));
        } 
   }
}