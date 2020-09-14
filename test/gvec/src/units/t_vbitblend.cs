//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static V0;

    public class t_vbitblend : t_inx<t_vbitblend>
    {
        public void bitblend_basecases()
        {
            var n = n256;
            var mask = z.vbroadcast(n, BitMasks.msb(n2,n1,z8));
            var zero = z.vzero<byte>(n);
            var ones = gvec.vones<byte>(n);
            var blend = VBits.vblendbits<byte>(zero, ones, mask);
            Claim.veq(blend,mask);

        }

        public void bitblend_128x8u()
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

        void vbitblend_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var count = w/z.bitsize<T>();
            for(var sample=0; sample<RepCount; sample++)
            {

                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                var mask = Random.CpuVector(w,t);
                var blended = VBits.vblendbits(x,y,mask);

                for(var i = 0; i<count; i++)
                    Claim.Eq(vcell(blended,i),gmath.blend(vcell(x,i),vcell(y,i), vcell(mask,i)));

                vcheckmask(x,y,mask,blended);
            }
        }

        void vcheckmask<T>(Vector256<T> left, Vector256<T> right, Vector256<T> mask, Vector256<T> result)
            where T : unmanaged
        {
            var ld = BufferBlocks.alloc<byte>(n256);

            var lbs = left.ToBitString();
            var rbs = right.ToBitString();
            var bsm = mask.ToBitString();
            var bsr = result.ToBitString();
            for(var i=0; i<lbs.Length; i++)
            {
                var a = bsm[i] ? rbs[i] : lbs[i];
                Claim.Eq(a, bsr[i]);
            }
        }

        void vbitblend_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var count = w/z.bitsize<T>();
            for(var sample=0; sample<RepCount; sample++)
            {
                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                var m = Random.CpuVector(w,t);
                var r = VBits.vblendbits(x,y,m);

                for(var i = 0; i<count; i++)
                    Claim.Eq(vcell(r,i),gmath.blend(vcell(x,i),vcell(y,i), vcell(m,i)));
            }
        }
    }
}