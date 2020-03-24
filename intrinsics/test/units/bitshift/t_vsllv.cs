//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static Nats;

    public class t_vsllv : t_vinx<t_vsllv>
    {
        public void vsllv_check()
        {
            vsllv_check(n128);
            vsllv_check(n256);
        }

        void vsllv_check(W128 w)
        {
            vsllv_check(w, z8);
            vsllv_check(w, z16);
            vsllv_check(w, z32);
            vsllv_check(w, z32i);
            vsllv_check(w, z64);
            vsllv_check(w, z64i);
        }

        void vsllv_check(W256 w)
        {
            vsllv_check(w, z8);
            vsllv_check(w, z16);
            vsllv_check(w, z32);
            vsllv_check(w, z32i);
            vsllv_check(w, z64);
            vsllv_check(w, z64i);
        }

        void vsllv_check<T>(W128 w, T t = default)
            where T : unmanaged        
        {
            var domain = Interval.closed(zero(t),convert<int,T>(bitsize(t) - 1));
            
            Pair<Vector128<T>> @case(int i)
            {
                var x = Random.CpuVector(w,t);
                var offsets = Random.CpuVector(w, domain);
                return (x,offsets);
            }

            CheckScalarMatch(VSvc.vsllv(w,t),@case);            
        }

        void vsllv_check<T>(W256 w, T t = default)
            where T : unmanaged        
        {
            var domain = Interval.closed(zero(t),convert<int,T>(bitsize(t) - 1));
            
            Pair<Vector256<T>> @case(int i)
            {
                var x = Random.CpuVector(w,t);
                var offsets = Random.CpuVector(w, domain);
                return (x,offsets);
            }

            CheckScalarMatch(VSvc.vsllv(w,t),@case);            
        }
    }
}