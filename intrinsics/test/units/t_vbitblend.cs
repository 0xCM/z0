//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vbitblend : t_vinx<t_vbitblend>
    {

        public void vbitblend_basecases()
        {
            var n = n256;
            var pattern = BitVector.natural(n8,(byte)0b10101010);
            var mask =  dinx.vbroadcast(n, pattern);
            var zero = vbuild.zero<byte>(n);
            var ones =  vbuild.ones<byte>(n);
            var blend = dinx.vbitblend(zero,ones,mask);
            Claim.eq(blend,mask);

        }

        public void vbitblend_128x8u()
            => vbitblend_check<byte>(n128);

        public void vbitblend_128x16u()
            => vbitblend_check<ushort>(n128);

        public void vbitblend_128x32u()
            => vbitblend_check<uint>(n128);

        public void vbitblend_128x64u()
            => vbitblend_check<ulong>(n128);

        public void vbitblend_256x8u()
            => vbitblend_check<byte>(n256);

        public void vbitblend_256x16u()
            => vbitblend_check<ushort>(n256);

        public void vbitblend_256x32u()
            => vbitblend_check<uint>(n256);

        public void vbitblend_256x64u()
            => vbitblend_check<ulong>(n256);

        protected void vbitblend_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var count = w/bitsize<T>();
            for(var sample=0; sample<SampleSize; sample++)
            {

                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                var mask = Random.CpuVector(w,t);
                var blended = ginx.vbitblend(x,y,mask);

                for(var i = 0; i<count; i++)
                    Claim.eq(vcell(blended,i),gmath.blend(vcell(x,i),vcell(y,i), vcell(mask,i)));

                vcheckmask(x,y,mask,blended);                    
            }
        }

        protected void vcheckmask<T>(Vector256<T> left, Vector256<T> right, Vector256<T> mask, Vector256<T> result)
            where T : unmanaged
        {
            var ld = DataBlocks.single<byte>(n256);

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

        protected void vbitblend_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var count = w/bitsize<T>();            
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                var m = Random.CpuVector(w,t);
                var r = ginx.vbitblend(x,y,m);

                for(var i = 0; i<count; i++)
                    Claim.eq(vcell(r,i),gmath.blend(vcell(x,i),vcell(y,i), vcell(m,i)));
            }
        }
    }

}
