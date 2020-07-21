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

    public class t_vcompact : t_inx<t_vcompact>
    {
        public void vcompact_128_outline()
        {
            var n = n128;
            var a = gvec.vinc<uint>(n,0);
            var b = gvec.vinc<uint>(n,4);
            var c = gvec.vinc<uint>(n,8);
            var d = gvec.vinc<uint>(n,12);
            Vector512<uint> v512 = (a,b,c,d);
            var abActual = dvec.vcompact(a,b,n128,z16);
            var abExpect = V0.vincrements<ushort>(n);
            Claim.veq(abExpect, abActual);

            var abcdActual = dvec.vcompact(a,b,c,d, n128, z8);
            var abcdExpect = V0.vincrements<byte>(n);
            Claim.veq(abcdExpect, abcdActual);        
        }
        
        public void vcompact_128x16x2_128x8()
        {
            var w = n128;
            var cellmax = Max8u;
            
            var vsmax = V0d.vbroadcast(w, (ushort)cellmax);
            var vtmax = V0d.vbroadcast(w,cellmax);
            var expect = V0d.vsub(vtmax, gvec.vinc(w,z8));

            var x = V0d.vsub(vsmax, gvec.vinc(w, z16));
            var y = V0d.vsub(vsmax, gvec.vinc(w, (ushort)8));
            var actual = dvec.vcompact(x,y,n128,z8);
            
            Claim.veq(expect,actual);            
        }

        public void vcompact_256x16x2_256x8()
        {
            var w = n256;
            var cellmax = Max8u;
            
            var vsmax = vbroadcast(w, (ushort)cellmax);
            var vtmax = vbroadcast(w,cellmax);
            var expect = V0d.vsub(vtmax, gvec.vinc(w,z8));

            var x = V0d.vsub(vsmax, gvec.vinc(w, z16));
            var y = V0d.vsub(vsmax, gvec.vinc(w, (ushort)16));
            var actual = dvec.vcompact(x,y,n256,z8);
            
            Claim.veq(expect,actual);            
        }

        public void vcompact_2x128x32u_128x16u()
        {   
            var w = n128;
            var cellmax = Max16u;
            
            var vsmax = V0d.vbroadcast(w, (uint)cellmax);
            var vtmax = V0d.vbroadcast(w,cellmax);
            var expect = V0d.vsub(vtmax, gvec.vinc(w,z16));

            var x = V0d.vsub(vsmax, gvec.vinc(w, 0u));
            var y = V0d.vsub(vsmax, gvec.vinc(w, 4u));
            var actual = dvec.vcompact(x,y,n128,z16);
            
            Claim.veq(expect,actual);            
        }

        public void vcompact_2x256x32u_256x16u()
        {   
            var w = n256;
            var cellmax = Max16u;

            var vsmax = Vectors.vbroadcast<uint>(w, (uint)cellmax);
            var vtmax = vbroadcast(w,cellmax);
            
            var x = V0d.vsub(vsmax, gvec.vinc(w, 0u));
            var y = V0d.vsub(vsmax, gvec.vinc(w, 8u));
            var v = dvec.vcompact(x,y,n256,z16);
            var expect = V0d.vsub(vtmax, gvec.vinc(w,z16));
            Claim.veq(expect,v);            
        }

        public void vcompact_2x128x64u_128x32u()
        {
            var n = n128;
            var x0 = vparts(n, 25, 50);
            var x1 = vparts(n, 75, 10);
            var dst = dvec.vcompact(x0,x1,n128,z32);
            var expect = vparts(n,25,50,75,10);
            Claim.veq(expect,dst);
        }
    }
}