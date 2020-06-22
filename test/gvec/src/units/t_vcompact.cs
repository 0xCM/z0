//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Vectors;
    using static Konst;

    public class t_vcompact : t_inx<t_vcompact>
    {
        public void vcompact2_128x16x2_128x8_outline()
        {
            var w = n128;
            var cellmax = Max8u;
            
            var vsmax = vbroadcast(w, (ushort)cellmax);
            var vtmax = vbroadcast(w,cellmax);
            var expect = dvec.vsub(vtmax, gvec.vinc(w,z8));

            var x = dvec.vsub(vsmax, gvec.vinc(w, z16));
            var y = dvec.vsub(vsmax, gvec.vinc(w, (ushort)8));
            var actual = dvec.vcompact(x,y,n128,z8);
            
            Claim.veq(expect,actual);            
        }

        public void vcompact2_256x16x2_256x8_outline()
        {
            var w = n256;
            var cellmax = Max8u;
            
            var vsmax = vbroadcast(w, (ushort)cellmax);
            var vtmax = vbroadcast(w,cellmax);
            var expect = dvec.vsub(vtmax, gvec.vinc(w,z8));

            var x = dvec.vsub(vsmax, gvec.vinc(w, z16));
            var y = dvec.vsub(vsmax, gvec.vinc(w, (ushort)16));
            var actual = dvec.vcompact(x,y,n256,z8);
            
            Claim.veq(expect,actual);            
        }

        public void vcompact2_2x128x32u_128x16u_outline()
        {   
            var w = n128;
            var cellmax = Max16u;
            
            var vsmax = vbroadcast(w, (uint)cellmax);
            var vtmax = vbroadcast(w,cellmax);
            var expect = dvec.vsub(vtmax, gvec.vinc(w,z16));

            var x = dvec.vsub(vsmax, gvec.vinc(w, 0u));
            var y = dvec.vsub(vsmax, gvec.vinc(w, 4u));
            var actual = dvec.vcompact(x,y,n128,z16);
            
            Claim.veq(expect,actual);            
        }

        public void vcompact2_2x256x32u_256x16u_outline()
        {   
            var w = n256;
            var cellmax = Max16u;

            var vsmax = vbroadcast<uint>(w, (uint)cellmax);
            var vtmax = vbroadcast(w,cellmax);
            
            var x = dvec.vsub(vsmax, gvec.vinc(w, 0u));
            var y = dvec.vsub(vsmax, gvec.vinc(w, 8u));
            var v = dvec.vcompact(x,y,n256,z16);
            var expect = dvec.vsub(vtmax, gvec.vinc(w,z16));
            Claim.veq(expect,v);            
        }

        public void vcompact_2x128x64u_128x32u_outline()
        {
            var n = n128;
            var x0 = vparts(n, 25, 50);
            var x1 = vparts(n, 75, 10);
            var dst = dvec.vcompact(x0,x1,n128,z32);
            var expect = vparts(n,25,50,75,10);
            Claim.veq(expect,dst);
        }

        public void vinflate_128x8u_outline()
        {
            var src = VData.vincrements<byte>(n128);
            var z =  dvec.vinflate(src, n256, z16);
            var lo = dvec.vlo(z);
            var hi = dvec.vhi(z);
            var loExpect = VData.vincrements<ushort>(n128);
            var hiExpect = gvec.vinc<ushort>(n128,8);
            Claim.veq(loExpect, lo);
            Claim.veq(hiExpect, hi);

            var dst = dvec.vcompact(lo,hi,n128,z8);
            Claim.veq(src,dst);
        }

        public void vinflate_128x8u_128x16u_outline()
        {
            var src = VData.vincrements<byte>(n128);            
            var z =  dvec.vinflate(src, n256, z16);
            var lo = dvec.vlo(z);
            var hi = dvec.vhi(z);
            for(var i=0; i<8; i++)
                Claim.eq(src.Cell(i), lo.Cell(i));            
        }

        public void vcompact_128_outline()
        {
            var n = n128;
            var a = gvec.vinc<uint>(n,0);
            var b = gvec.vinc<uint>(n,4);
            var c = gvec.vinc<uint>(n,8);
            var d = gvec.vinc<uint>(n,12);
            Vector512<uint> v512 = (a,b,c,d);
            var abActual = dvec.vcompact(a,b,n128,z16);
            var abExpect = VData.vincrements<ushort>(n);
            Claim.veq(abExpect, abActual);

            var abcdActual = dvec.vcompact(a,b,c,d, n128, z8);
            var abcdExpect = VData.vincrements<byte>(n);
            Claim.veq(abcdExpect, abcdActual);
            
        }
        
        public void vinflate_256x8_1024x32_outline()
        {
            var n = n256;

            var a0 = gvec.vinc<uint>(n,0);
            var b0 = gvec.vinc<uint>(n,8);
            var c0 = gvec.vinc<uint>(n,16);
            var d0 = gvec.vinc<uint>(n,24);      

            var compacted = dvec.vcompact(a0,b0,c0,d0, n256, z8);        
            var inflated = dvec.vinflate(compacted, n1024, z32);

            Claim.veq(VData.vincrements<ushort>(n), dvec.vcompact(a0,b0,n256,z16));
            Claim.veq(VData.vincrements<byte>(n), compacted);
            Claim.veq(a0,inflated.A);
            Claim.veq(b0,inflated.B);
            Claim.veq(c0,inflated.C);
            Claim.veq(d0,inflated.D);
        }

        public void vpackus_128x16x2_128x8_outline()
        {
            void case1()
            {
                var x = vparts(n128,0,1,2,4,4,5,6,7);
                var y = vparts(n128,8,9,10,11,12,13,14,15);
                var z = dvec.vpackus(x,y);
                var e = vparts(n128,0,1,2,4,4,5,6,7,8,9,10,11,12,13,14,15);
                Claim.veq(e,z);
            }

            void case2()
            {
                var x = vparts(n128,127,0,127,0,127,0,127,0);
                var y = dvec.vpackus(x,x);
                Notify(y.Format());
            }        
            case1();
            case2();            
        }
    }
}