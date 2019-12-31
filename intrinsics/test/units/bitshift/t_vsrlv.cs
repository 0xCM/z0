//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vsrlv : t_vinx<t_vsrlv>
    {
        public void vsrlv_check()
        {
            vsrlv_check(n128);
            vsrlv_check(n256);
        }

        void vsrlv_check(N128 w)
        {
            vsrlv_check(w, z8);
            vsrlv_check(w, z16);
            vsrlv_check(w, z32);
            vsrlv_check(w, z32i);
            vsrlv_check(w, z64);
            vsrlv_check(w, z64i);
        }

        void vsrlv_check(N256 w)
        {
            vsrlv_check(w, z8);
            vsrlv_check(w, z16);
            vsrlv_check(w, z32);
            vsrlv_check(w, z32i);
            vsrlv_check(w, z64);
            vsrlv_check(w, z64i);
        }

        void vsrlv_check<T>(N128 w, T t = default)
            where T : unmanaged        
        {
            var min = gmath.zero(t);
            var max = convert<int,T>(bitsize(t) - 1);
            
            Pair<Vector128<T>> @case(int i)
            {
                var x = Random.CpuVector(w,t);
                var offsets = Random.CpuVector(w, min, max);
                return (x,offsets);
            }

            CheckScalarMatch(VX.vsrlv(w,t),@case);            
        }

        void vsrlv_check<T>(N256 w, T t = default)
            where T : unmanaged        
        {
            var min = gmath.zero(t);
            var max = convert<int,T>(bitsize(t) - 1);
            
            Pair<Vector256<T>> @case(int i)
            {
                var x = Random.CpuVector(w,t);
                var offsets = Random.CpuVector(w, min, max);
                return (x,offsets);
            }

            CheckScalarMatch(VX.vsrlv(w,t),@case);            
        }
    }
}