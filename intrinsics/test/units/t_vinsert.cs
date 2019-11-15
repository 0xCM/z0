//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;

    public class t_vinsert : IntrinsicTest<t_vinsert>
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

        void vinsert_check<T>(N128 n)
            where T : unmanaged
        {
            for(var i=0; i < SampleSize; i++)
            {
                var v128Src = Random.CpuVector<T>(n128);
                var srcSpan = v128Src.ToSpan();

                var dst = default(Vector256<T>);
                
                var vLo = ginx.vinsert(v128Src, dst,0);
                var vLoSpan = vLo.ToSpan().Slice(0, vLo.Length()/2);

                var vHi = ginx.vinsert(v128Src, dst, 1);
                var vHiSpan = vHi.ToSpan().Slice(vLo.Length()/2);

                Claim.eq(srcSpan, vLoSpan);
                Claim.eq(srcSpan, vHiSpan);
            }
        }
    }
}
