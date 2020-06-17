//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Konst;
    using static Memories;

    public class t_vnonz : t_inx<t_vnonz>
    {
        public void vnonz_check()
        {
            vnonz_check(n128);
            vnonz_check(n256);
        }

        void vnonz_check(N128 w)
        {
            vnonz_check(w,z8i);
            vnonz_check(w,z8);
            vnonz_check(w,z16i);
            vnonz_check(w,z16);
            vnonz_check(w,z32i);
            vnonz_check(w,z32);
            vnonz_check(w,z64i);
            vnonz_check(w,z64);
        }

        void vnonz_check(N256 w)
        {
            vnonz_check(w,z8i);
            vnonz_check(w,z8);
            vnonz_check(w,z16i);
            vnonz_check(w,z16);
            vnonz_check(w,z32i);
            vnonz_check(w,z32);
            vnonz_check(w,z64i);
            vnonz_check(w,z64);
        }

        protected void vnonz_check<T>(N128 w, T t = default)
            where T : unmanaged
        {            
            var min = one(t);
            var max = maxval(t);
            var domain = Interval.closed(one(t), maxval(t));
            var f = VSvc.vnonz(w,t);

            Claim.nea(gvec.vnonz(Vectors.vzero(w,t)));
            
            for(var i=0; i<RepCount; i++)
                Claim.require(f.Invoke(Random.CpuVector(w, domain)));            
        }

        protected void vnonz_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var min = one(t);
            var max = maxval(t);
            var domain = Interval.closed(one(t), maxval(t));
            var f = VSvc.vnonz(w,t);

            Claim.nea(gvec.vnonz(Vectors.vzero(w,t)));
            
            for(var i=0; i<RepCount; i++)
                Claim.require(f.Invoke(Random.CpuVector(w,domain)));
        }
    }
}