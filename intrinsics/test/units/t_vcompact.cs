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
            
            var vsmax = CpuVector.broadcast(w, (ushort)cellmax);
            var vtmax = CpuVector.broadcast(w,cellmax);
            var expect = dinx.vsub(vtmax, CpuVector.increments(w,z8));

            var x = dinx.vsub(vsmax, CpuVector.increments(w, z16));
            var y = dinx.vsub(vsmax, CpuVector.increments(w, (ushort)8));
            var actual = dinx.vcompact2(x,y);
            
            Claim.eq(expect,actual);            
        }

        public void vcompact2_256x16x2_256x8_outline()
        {
            var w = n256;
            var cellmax = u8max;
            
            var vsmax = CpuVector.broadcast(w, (ushort)cellmax);
            var vtmax = CpuVector.broadcast(w,cellmax);
            var expect = dinx.vsub(vtmax, CpuVector.increments(w,z8));

            var x = dinx.vsub(vsmax, CpuVector.increments(w, z16));
            var y = dinx.vsub(vsmax, CpuVector.increments(w, (ushort)16));
            var actual = dinx.vcompact2(x,y);
            
            Claim.eq(expect,actual);            
        }

        public void vcompact2_2x128x32u_128x16u_outline()
        {   
            var w = n128;
            var cellmax = u16max;
            
            var vsmax = CpuVector.broadcast(w, (uint)cellmax);
            var vtmax = CpuVector.broadcast(w,cellmax);
            var expect = dinx.vsub(vtmax, CpuVector.increments(w,z16));

            var x = dinx.vsub(vsmax, CpuVector.increments(w, 0u));
            var y = dinx.vsub(vsmax, CpuVector.increments(w, 4u));
            var actual = dinx.vcompact2(x,y);
            
            Claim.eq(expect,actual);            
        }

        public void vcompact2_2x256x32u_256x16u_outline()
        {   
            var w = n256;
            var cellmax = u16max;

            var vsmax = CpuVector.broadcast(w,(uint)cellmax);
            var vtmax = CpuVector.broadcast(w,cellmax);
            
            var x = dinx.vsub(vsmax, CpuVector.increments(w, 0u));
            var y = dinx.vsub(vsmax, CpuVector.increments(w, 8u));
            var v = dinx.vcompact2(x,y);
            var expect = dinx.vsub(vtmax, CpuVector.increments(w,z16));
            Claim.eq(expect,v);            
        }

        public void vcompact_2x128x64u_128x32u_outline()
        {
            var n = n128;
            var x0 = CpuVector.parts(n, 25, 50);
            var x1 = CpuVector.parts(n, 75, 10);
            dinx.vcompact(x0,x1, out var dst);
            var expect = CpuVector.parts(n,25,50,75,10);
            Claim.eq(expect,dst);
        }

        public void vinflate_128x8u_outline()
        {
            var src = CpuVector.increments<byte>(n128);
            dinx.vinflate(src, out Vector128<ushort> lo, out Vector128<ushort> hi);
            var loExpect = CpuVector.increments<ushort>(n128);
            var hiExpect = CpuVector.increments<ushort>(n128,8);
            Claim.eq(loExpect, lo);
            Claim.eq(hiExpect, hi);

            var dst = dinx.vcompact(lo,hi);
            Claim.eq(src,dst);
        }

        public void vinflate_128x8u_128x16u_outline()
        {
            var src = CpuVector.increments<byte>(n128);            
            dinx.vinflate(src, out Vector128<ushort> lo, out Vector128<ushort> hi);
            for(var i=0; i<8; i++)
                Claim.eq(src.Item(i), lo.Item(i));            
        }

        public void vcompact_128_outline()
        {
            var n = n128;
            var a = CpuVector.increments<uint>(n,0);
            var b = CpuVector.increments<uint>(n,4);
            var c = CpuVector.increments<uint>(n,8);
            var d = CpuVector.increments<uint>(n,12);
            var abActual = dinx.vcompact(a,b);
            var abExpect = CpuVector.increments<ushort>(n);
            Claim.eq(abExpect, abActual);

            dinx.vcompact(a,b,c,d, out var abcdActual);
            var abcdExpect = CpuVector.increments<byte>(n);
            Claim.eq(abcdExpect, abcdActual);
            
        }
        
        public void vinflate_256x8_1024x32_outline()
        {
            var n = n256;

            var a0 = CpuVector.increments<uint>(n,0);
            var b0 = CpuVector.increments<uint>(n,8);
            var c0 = CpuVector.increments<uint>(n,16);
            var d0 = CpuVector.increments<uint>(n,24);      


            dinx.vcompact(a0,b0,c0,d0, out var compacted);        
            var inflated = dinx.vinflate(compacted, n1024, z32);

            Claim.eq(CpuVector.increments<ushort>(n), dinx.vcompact(a0,b0));
            Claim.eq(CpuVector.increments<byte>(n), compacted);
            Claim.eq(a0,inflated.A);
            Claim.eq(b0,inflated.B);
            Claim.eq(c0,inflated.C);
            Claim.eq(d0,inflated.D);
        }

        public void vpackus_128x16x2_128x8_outline()
        {
            void case1()
            {
                var x = CpuVector.parts(n128,0,1,2,4,4,5,6,7);
                var y = CpuVector.parts(n128,8,9,10,11,12,13,14,15);
                var z = dinx.vpackus(x,y);
                var e = CpuVector.parts(n128,0,1,2,4,4,5,6,7,8,9,10,11,12,13,14,15);
                Claim.eq(e,z);
            }

            void case2()
            {
                var x = CpuVector.parts(n128,127,0,127,0,127,0,127,0);
                var y = dinx.vpackus2(x,x);
                Trace(y.Format());
            }        
            case1();
            case2();
            
        }

        


    }

}