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
    using static VOpTypes;

    public class t_vconcat : t_vinx<t_vconcat>
    {     
        public void Check()
        {
            var w = n128;
            CheckExec(w,z8);
            CheckExec(w,z8i);
            CheckExec(w,z16);
            CheckExec(w,z16i);
            CheckExec(w,z32);
            CheckExec(w,z32i);
            CheckExec(w,z64);
            CheckExec(w,z64i);
        }

        protected void CheckExec<T>(N128 w, T t = default)
            where T : unmanaged
                => check(() => Checker(w,t), TestCaseName(@op(w,t)));

        protected Action<N128,T> Checker<T>(N128 w, T t = default)
            where T : unmanaged
                => Check<T>;

        void Check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            for(var i=0; i< SampleCount; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                var z = @op(w,t).Invoke(x,y);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var expect = xs.Concat(ys).LoadVector(n256);
                Claim.eq(expect,z);
            }
        }


        [MethodImpl(Inline)]
        Concat2x128<T> @op<T>(N128 w, T t = default)
            where T : unmanaged
                => VOps.vconcat(w,t);

    }
}