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
        public void vsrlv_128x8u()
            => vsrlv_check(n128,z8);

        public void vsrlv_128x16u()
            => vsrlv_check(n128,z16);

        public void vsrlv_128x32u()
            => vsrlv_check(n128,z32);

        public void vsrlv_128x64u()
            => vsrlv_check(n128,z64);

        public void vsrlv_256x8u()
            => vsrlv_check(n256,z8);

        public void vsrlv_256x16u()
            => vsrlv_check(n256,z16);

        public void vsrlv_256x32u()
            => vsrlv_check(n256,z32);

        public void vsrlv_256x64u()
            => vsrlv_check(n256,z64);

        protected void vsrlv_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var shiftrange = (default(T),convert<int,T>(bitsize(t) - 1));
            var buffer = DataBlocks.single<T>(w);
            for(var sample = 0; sample < RepCount; sample++)
            {
                var x = Random.CpuVector<T>(w);
                var offsets = Random.CpuVector<T>(w, shiftrange);
                var actual = ginx.vsrlv(x,offsets);
                var expect = CpuVector.vload(w,mathspan.srlv<T>(x.ToSpan(), offsets.ToSpan(), buffer));
                Claim.eq(expect, actual);
            }
        }

        protected void vsrlv_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var shiftrange = (default(T),convert<int,T>(bitsize(t) - 1));
            var buffer = DataBlocks.single<T>(w);
            for(var sample = 0; sample < RepCount; sample++)
            {
                var x = Random.CpuVector<T>(w);
                var offsets = Random.CpuVector<T>(w, shiftrange);
                var actual = ginx.vsrlv(x,offsets);
                var expect = CpuVector.vload(w,mathspan.srlv<T>(x.ToSpan(), offsets.ToSpan(), buffer));
                Claim.eq(expect, actual);
            }
        }

    }
}