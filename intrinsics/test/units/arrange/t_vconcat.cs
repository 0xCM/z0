//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Nats;

    public class t_vconcat : t_vinx<t_vconcat>
    {     
        public void vconcat_check()
        {
            var w = n128;
            vconcat_check(w,z8);
            vconcat_check(w,z8i);
            vconcat_check(w,z16);
            vconcat_check(w,z16i);
            vconcat_check(w,z32);
            vconcat_check(w,z32i);
            vconcat_check(w,z64);
            vconcat_check(w,z64i);
        }

        void vconcat_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckAction(() => vconcat_checker(w,t), CaseName(VSvc.vconcat(w,t)));

        Action<N128,T> vconcat_checker<T>(N128 w, T t = default)
            where T : unmanaged
                => check<T>;

        void check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                var z = VSvc.vconcat(w,t).Invoke(x,y);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var expect = xs.Concat(ys).LoadVector(n256);
                Claim.eq(expect,z);
            }
        }

    }
}