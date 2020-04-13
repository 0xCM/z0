//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Gone;

    public class t_vinsert : t_vinx<t_vinsert>
    {
        public void vinsert_128x8i()
            => vinsert_check<sbyte>(n128);            

        public void vinsert_128x8u()
            => vinsert_check<byte>(n128);            

        public void vinsert_128x16i()
            => vinsert_check<short>(n128);            

        public void vinsert_128x16u()
            => vinsert_check<ushort>(n128);            

        public void vinsert_128x32i()
            => vinsert_check<int>(n128);            

        public void vinsert_128x32u()
            => vinsert_check<uint>(n128);            

        public void vinsert_128x64i()
            => vinsert_check<long>(n128);            

        public void vinsert_128x64u()
            => vinsert_check<ulong>(n128);            

        public void vinsert_128x32f()
            => vinsert_check<float>(n128);
        
        public void vinsert_128x64f()
            => vinsert_check<double>(n128);

        protected void vinsert_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            for(var i=0; i < RepCount; i++)
            {
                var v128Src = Random.CpuVector<T>(w);
                var srcSpan = v128Src.ToSpan();

                var dst = Vectors.vzero(n256,t);
                
                var vLo = gvec.vinsert(v128Src, dst,0);
                var vLoSpan = vLo.ToSpan().Slice(0, vLo.Length()/2);

                var vHi = gvec.vinsert(v128Src, dst, 1);
                var vHiSpan = vHi.ToSpan().Slice(vLo.Length()/2);

                CheckNumeric.eq(srcSpan, vLoSpan);
                CheckNumeric.eq(srcSpan, vHiSpan);
            }
        }

    }
}
