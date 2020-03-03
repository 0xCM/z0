//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;
    using static Literals;
    using static vfuncs;

    public class t_veq : t_vinx<t_veq>
    {     
        public void veq_check()
        {            
            veq_basecase(n128);
            veq_basecase(n256);
            veq_check(n128);
            veq_check(n256);
        }

        void veq_check(N128 w)
        {
            veq_check(w, z8);                
            veq_check(w, z8i);
            veq_check(w, z16);
            veq_check(w, z16i);
            veq_check(w, z32);
            veq_check(w, z32i);
            veq_check(w, z64);
            veq_check(w, z64i);

        }

        void veq_check(N256 w)
        {
            veq_check(w, z8);                
            veq_check(w, z8i);
            veq_check(w, z16);
            veq_check(w, z16i);
            veq_check(w, z32);
            veq_check(w, z32i);
            veq_check(w, z64);
            veq_check(w, z64i);
        }            

        void veq_basecase(N128 w)
        {
            veq_basecase(w, z8);                
            veq_basecase(w, z8i);
            veq_basecase(w, z16);
            veq_basecase(w, z16i);
            veq_basecase(w, z32);
            veq_basecase(w, z32i);
            veq_basecase(w, z64);
            veq_basecase(w, z64i);
        }

        void veq_basecase(N256 w)
        {
            veq_basecase(w, z8);                
            veq_basecase(w, z8i);
            veq_basecase(w, z16);
            veq_basecase(w, z16i);
            veq_basecase(w, z32);
            veq_basecase(w, z32i);
            veq_basecase(w, z64);
            veq_basecase(w, z64i);
        }

        void veq_basecase<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var name = CaseName(NaturalIdentity.contracted(MethodInfo.GetCurrentMethod().Name,w,t));
            var f = VX.veq(w,t);
            var x = Random.Blocks<T>(w, RepCount/vcount(w,t));
            var result = blocks.alloc<T>(w, x.BlockCount);
            result.Fill(ones(t));
            CheckExplicit(f,x,x,result, name);
        }

        void veq_basecase<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var name = CaseName(NaturalIdentity.contracted(MethodInfo.GetCurrentMethod().Name,w,t));
            var f = VX.veq(w,t);
            var x = Random.Blocks<T>(w, RepCount/vcount(w,t));
            var result = blocks.alloc<T>(w, x.BlockCount);
            result.Fill(ones(t));
            CheckExplicit(f,x,x,result,name);
        }

        void veq_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckBinaryScalarMatch(VX.veq(w,t),w,t);

        void veq_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckBinaryScalarMatch(VX.veq(w,t),w,t);            
    }
}