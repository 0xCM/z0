//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vblendbits : t_vinx<t_vblendbits>
    {

        public void vblendbits_basecases()
        {
            var n = n256;
            //LRLRLRLR
            //10101010
            var mask =  dinx.vbroadcast(n, (byte)0b10101010);
            var zero = ginx.vzero<byte>(n);
            var ones =  ginx.vones<byte>(n);
            var blend = dinx.vblendbits(zero,ones,mask);
            Claim.eq(blend,mask);

        }

        public void vblendbits_128x8u()
            => vblendbits_check<byte>(n128);

        public void vblendbits_128x16u()
            => vblendbits_check<ushort>(n128);

        public void vblendbits_128x32u()
            => vblendbits_check<uint>(n128);

        public void vblendbits_128x64u()
            => vblendbits_check<ulong>(n128);

        public void vblendbits_256x8u()
            => vblendbits_check<byte>(n256);

        public void vblendbits_256x16u()
            => vblendbits_check<ushort>(n256);

        public void vblendbits_256x32u()
            => vblendbits_check<uint>(n256);

        public void vblendbits_256x64u()
            => vblendbits_check<ulong>(n256);

        protected void vblendbits_check<T>(N256 n)
            where T : unmanaged
        {
            for(var sample=0; sample<SampleSize; sample++)
            {

                var x = Random.CpuVector<T>(n);
                var y = Random.CpuVector<T>(n);
                var m = Random.CpuVector<T>(n);
                var r = ginx.vblendbits(x,y,m);
                
                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var ms = m.ToSpan();
                var rs = r.ToSpan();
                for(var i = 0; i<xs.Length; i++)
                    Claim.eq(rs[i],gmath.blend(xs[i],ys[i],ms[i]));

                vblendbits_drill(x,y,m,r);                    
            }

        }

        protected void vblendbits_drill<T>(Vector256<T> left, Vector256<T> right, Vector256<T> mask,Vector256<T> result)
            where T : unmanaged
        {
            
            var lbs = left.ToBitString();
            var rbs = right.ToBitString();
            var bsm = mask.ToBitString();
            var bsr = result.ToBitString();
            for(var i=0; i<lbs.Length; i++)
            {
                var a = bsm[i] ? rbs[i] : lbs[i];
                Claim.eq(a, bsr[i]);

            }
            
        }

        protected void vblendbits_check<T>(N128 n)
            where T : unmanaged
        {
            for(var sample=0; sample<SampleSize; sample++)
            {
                var left = Random.CpuVector<T>(n);
                var right = Random.CpuVector<T>(n);
                var mask = Random.CpuVector<T>(n);
                var result = ginx.vblendbits(left,right,mask);
                
                var ls = left.ToSpan();
                var rs = right.ToSpan();
                var ms = mask.ToSpan();
                var os = result.ToSpan();
                for(var i = 0; i<ls.Length; i++)
                    Claim.eq(os[i],gmath.blend(ls[i],rs[i],ms[i]));

            }
        }
    }

}
