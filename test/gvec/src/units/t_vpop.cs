//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static Memories;

    public class t_vpop : t_inx<t_vpop>
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
            var f = VSvc.vpop(w,t);

            void check()
            {
                var zed = As.zero(t);
                var src = Random.Blocks<T>(w, Interval.closed(zed, maxval(t)),3);

                (var x0, var x1, var x2) = src.LoadVectors(0,1,2);

                var vlen = vcount(w,t);
                var expect = 0u;

                for(var i=0; i<vlen; i++)
                    expect += f.Invoke(vcell(x0,i),vcell(x1,i),vcell(x2,i));

                var result = f.Invoke(x0,x1,x2);
                Claim.eq(expect,result);
            }

            CheckAction(check, CaseName(f));            
        }

        void vpop_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var f = VSvc.vpop(w,t);

            void check()
            {
                var zed = zero(t);
                var src = Random.Blocks<T>(w, Interval.closed(zed, maxval(t)),3);

                (var x0, var x1, var x2) = src.LoadVectors(0,1,2);

                var vlen = vcount(w,t);
                var expect = 0u;

                for(var i=0; i<vlen; i++)
                    expect += f.Invoke(vcell(x0,i),vcell(x1,i), vcell(x2,i));

                var result = f.Invoke(x0,x1,x2);
                Claim.eq(expect,result);
            }

            CheckAction(check, CaseName(f));            
        }
    }
}