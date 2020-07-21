//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Konst;
    using static z;

    public class t_vinflate : t_inx<t_vinflate>
    {
        public void vinflate_128x8u()
        {
            var src = V0.vincrements<byte>(n128);
            var z =  dvec.vinflate(src, n256, z16);
            var lo = V0d.vlo(z);
            var hi = V0d.vhi(z);
            var loExpect = V0.vincrements<ushort>(n128);
            var hiExpect = gvec.vinc<ushort>(n128,8);
            Claim.veq(loExpect, lo);
            Claim.veq(hiExpect, hi);

            var dst = dvec.vcompact(lo,hi,n128,z8);
            Claim.veq(src,dst);
        }

        public void vinflate_128x8u_128x16u()
        {
            var src = V0.vincrements<byte>(n128);            
            var z =  dvec.vinflate(src, n256, z16);
            var lo = V0d.vlo(z);
            var hi = V0d.vhi(z);
            for(var i=0; i<8; i++)
                Claim.eq(src.Cell(i), lo.Cell(i));            
        }

        public void vinflate_256x8_1024x32()
        {
            var n = n256;

            var a0 = gvec.vinc<uint>(n,0);
            var b0 = gvec.vinc<uint>(n,8);
            var c0 = gvec.vinc<uint>(n,16);
            var d0 = gvec.vinc<uint>(n,24);      

            var compacted = dvec.vcompact(a0,b0,c0,d0, n256, z8);        
            var inflated = dvec.vinflate(compacted, n1024, z32);

            Claim.veq(V0.vincrements<ushort>(n), dvec.vcompact(a0,b0,n256,z16));
            Claim.veq(V0.vincrements<byte>(n), compacted);
            Claim.veq(a0,inflated.A);
            Claim.veq(b0,inflated.B);
            Claim.veq(c0,inflated.C);
            Claim.veq(d0,inflated.D);
        }
    }
}