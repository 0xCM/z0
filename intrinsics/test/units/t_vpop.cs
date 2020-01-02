//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vpop : t_vinx<t_vpop>
    {
        public void vpop_check()
        {
            vpop_check(n128);
            vpop_check(n256);
        }

        void vpop_check(N128 w)
        {
            vpop_check(w,z8);
            vpop_check(w,z16);
            vpop_check(w,z32);
            vpop_check(w,z64);
        }

        void vpop_check(N256 w)
        {
            vpop_check(w,z8);
            vpop_check(w,z16);
            vpop_check(w,z32);
            vpop_check(w,z64);
        }

        void vpop_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var f = VX.vpop(w,t);
            var zero = gmath.zero(t);
            var src = Random.Blocks<T>(w, 3, (zero, gmath.maxval<T>()));

            (var x0, var x1, var x2) = src.LoadVectors(0,1,2);

            var vlen = vcount(w,t);
            var expect = 0u;

            for(var i=0; i<vlen; i++)
                expect += f.InvokeScalar(vcell(x0,i),vcell(x1,i),vcell(x2,i));

            var result = f.Invoke(x0,x1,x2);
            Claim.eq(expect,result);
        }

        void vpop_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var f = VX.vpop(w,t);
            var zero = gmath.zero(t);
            var src = Random.Blocks<T>(w, 3, (zero, gmath.maxval<T>()));

            (var x0, var x1, var x2) = src.LoadVectors(0,1,2);

            var vlen = vcount(w,t);
            var expect = 0u;

            for(var i=0; i<vlen; i++)
                expect += f.InvokeScalar(vcell(x0,i),vcell(x1,i),vcell(x2,i));

            var result = f.Invoke(x0,x1,x2);
            Claim.eq(expect,result);
        }
    }
}