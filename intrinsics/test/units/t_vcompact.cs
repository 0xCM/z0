//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static As;

    public class t_vcompact : t_vinx<t_vcompact>
    {
        public void vcompact2_128x16x2_128x8_outline()
        {
            var w = n128;
            var cellmax = u8max;
            
            var vsmax = vbuild.broadcast(w, (ushort)cellmax);
            var vtmax = vbuild.broadcast(w,cellmax);
            var expect = dinx.vsub(vtmax, vbuild.increments(w,z8));

            var x = dinx.vsub(vsmax, vbuild.increments(w, z16));
            var y = dinx.vsub(vsmax, vbuild.increments(w, (ushort)8));
            var actual = dinx.vcompact2(x,y);
            
            Claim.eq(expect,actual);            
        }

        public void vcompact2_256x16x2_256x8_outline()
        {
            var w = n256;
            var cellmax = u8max;
            
            var vsmax = vbuild.broadcast(w, (ushort)cellmax);
            var vtmax = vbuild.broadcast(w,cellmax);
            var expect = dinx.vsub(vtmax, vbuild.increments(w,z8));

            var x = dinx.vsub(vsmax, vbuild.increments(w, z16));
            var y = dinx.vsub(vsmax, vbuild.increments(w, (ushort)16));
            var actual = dinx.vcompact2(x,y);
            
            Claim.eq(expect,actual);            
        }

        public void vcompact2_2x128x32u_128x16u_outline()
        {   
            var w = n128;
            var cellmax = u16max;
            
            var vsmax = vbuild.broadcast(w, (uint)cellmax);
            var vtmax = vbuild.broadcast(w,cellmax);
            var expect = dinx.vsub(vtmax, vbuild.increments(w,z16));

            var x = dinx.vsub(vsmax, vbuild.increments(w, 0u));
            var y = dinx.vsub(vsmax, vbuild.increments(w, 4u));
            var actual = dinx.vcompact2(x,y);
            
            Claim.eq(expect,actual);            
        }

        public void vcompact2_2x256x32u_256x16u_outline()
        {   
            var w = n256;
            var cellmax = u16max;

            var vsmax = vbuild.broadcast(w,(uint)cellmax);
            var vtmax = vbuild.broadcast(w,cellmax);
            
            var x = dinx.vsub(vsmax, vbuild.increments(w, 0u));
            var y = dinx.vsub(vsmax, vbuild.increments(w, 8u));
            var v = dinx.vcompact2(x,y);
            var expect = dinx.vsub(vtmax, vbuild.increments(w,z16));
            Claim.eq(expect,v);            
        }

        public void vcompact_2x128x64u_128x32u_outline()
        {
            var n = n128;
            var x0 = vbuild.parts(n, 25, 50);
            var x1 = vbuild.parts(n, 75, 10);
            dinx.vcompact(x0,x1, out var dst);
            var expect = vbuild.parts(n,25,50,75,10);
            Claim.eq(expect,dst);
        }

        public void vinflate_128x8u_outline()
        {
            var src = vbuild.increments<byte>(n128);
            dinx.vinflate(src, out Vector128<ushort> lo, out Vector128<ushort> hi);
            var loExpect = vbuild.increments<ushort>(n128);
            var hiExpect = vbuild.increments<ushort>(n128,8);
            Claim.eq(loExpect, lo);
            Claim.eq(hiExpect, hi);

            var dst = dinx.vcompact(lo,hi);
            Claim.eq(src,dst);
        }

        public void vinflate_128x8u_128x16u_outline()
        {
            var src = vbuild.increments<byte>(n128);            
            dinx.vinflate(src, out Vector128<ushort> lo, out Vector128<ushort> hi);
            for(var i=0; i<8; i++)
                Claim.eq(src.Item(i), lo.Item(i));            
        }

        public void vcompact_128_outline()
        {
            var n = n128;
            var a = vbuild.increments<uint>(n,0);
            var b = vbuild.increments<uint>(n,4);
            var c = vbuild.increments<uint>(n,8);
            var d = vbuild.increments<uint>(n,12);
            var abActual = dinx.vcompact(a,b);
            var abExpect = vbuild.increments<ushort>(n);
            Claim.eq(abExpect, abActual);

            dinx.vcompact(a,b,c,d, out var abcdActual);
            var abcdExpect = vbuild.increments<byte>(n);
            Claim.eq(abcdExpect, abcdActual);
            
        }
        
        public void vinflate_256x8_256x32x4_outline()
        {
            var n = n256;

            var a0 = vbuild.increments<uint>(n,0);
            var b0 = vbuild.increments<uint>(n,8);
            var c0 = vbuild.increments<uint>(n,16);
            var d0 = vbuild.increments<uint>(n,24);        

            dinx.vcompact(a0,b0,c0,d0, out var compacted);        
            dinx.vinflate(compacted, out var a1, out var b1, out var c1, out var d1);

            Claim.eq(vbuild.increments<ushort>(n), dinx.vcompact(a0,b0));
            Claim.eq(vbuild.increments<byte>(n), compacted);
            Claim.eq(a0,a1);
            Claim.eq(b0,b1);
            Claim.eq(c0,c1);
            Claim.eq(d0,d1);
        }

        public void vpackus_128x16x2_128x8_outline()
        {
            var x = vbuild.parts(n128,0,1,2,4,4,5,6,7);
            var y = vbuild.parts(n128,8,9,10,11,12,13,14,15);
            var z = dinx.vpackus(x,y);
            var e = vbuild.parts(n128,0,1,2,4,4,5,6,7,8,9,10,11,12,13,14,15);
            Claim.eq(e,z);
            
        }



    }

}