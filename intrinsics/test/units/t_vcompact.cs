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
            
            var vsmax = CpuVector.vbroadcast(w, (ushort)cellmax);
            var vtmax = CpuVector.vbroadcast(w,cellmax);
            var expect = dinx.vsub(vtmax, CpuVector.vincrements(w,z8));

            var x = dinx.vsub(vsmax, CpuVector.vincrements(w, z16));
            var y = dinx.vsub(vsmax, CpuVector.vincrements(w, (ushort)8));
            var actual = dinx.vcompact(x,y,n128,z8);
            
            Claim.eq(expect,actual);            
        }

        public void vcompact2_256x16x2_256x8_outline()
        {
            var w = n256;
            var cellmax = u8max;
            
            var vsmax = CpuVector.vbroadcast(w, (ushort)cellmax);
            var vtmax = CpuVector.vbroadcast(w,cellmax);
            var expect = dinx.vsub(vtmax, CpuVector.vincrements(w,z8));

            var x = dinx.vsub(vsmax, CpuVector.vincrements(w, z16));
            var y = dinx.vsub(vsmax, CpuVector.vincrements(w, (ushort)16));
            var actual = dinx.vcompact(x,y,n256,z8);
            
            Claim.eq(expect,actual);            
        }

        public void vcompact2_2x128x32u_128x16u_outline()
        {   
            var w = n128;
            var cellmax = u16max;
            
            var vsmax = CpuVector.vbroadcast(w, (uint)cellmax);
            var vtmax = CpuVector.vbroadcast(w,cellmax);
            var expect = dinx.vsub(vtmax, CpuVector.vincrements(w,z16));

            var x = dinx.vsub(vsmax, CpuVector.vincrements(w, 0u));
            var y = dinx.vsub(vsmax, CpuVector.vincrements(w, 4u));
            var actual = dinx.vcompact(x,y,n128,z16);
            
            Claim.eq(expect,actual);            
        }

        public void vcompact2_2x256x32u_256x16u_outline()
        {   
            var w = n256;
            var cellmax = u16max;

            var vsmax = CpuVector.vbroadcast(w,(uint)cellmax);
            var vtmax = CpuVector.vbroadcast(w,cellmax);
            
            var x = dinx.vsub(vsmax, CpuVector.vincrements(w, 0u));
            var y = dinx.vsub(vsmax, CpuVector.vincrements(w, 8u));
            var v = dinx.vcompact(x,y,n256,z16);
            var expect = dinx.vsub(vtmax, CpuVector.vincrements(w,z16));
            Claim.eq(expect,v);            
        }

        public void vcompact_2x128x64u_128x32u_outline()
        {
            var n = n128;
            var x0 = CpuVector.parts(n, 25, 50);
            var x1 = CpuVector.parts(n, 75, 10);
            var dst = dinx.vcompact(x0,x1,n128,z32);
            var expect = CpuVector.parts(n,25,50,75,10);
            Claim.eq(expect,dst);
        }

        public void vinflate_128x8u_outline()
        {
            var src = CpuVector.vincrements<byte>(n128);
            var z =  dinx.vinflate(src, n256, z16);
            var lo = dinx.vlo(z);
            var hi = dinx.vhi(z);
            var loExpect = CpuVector.vincrements<ushort>(n128);
            var hiExpect = CpuVector.vincrements<ushort>(n128,8);
            Claim.eq(loExpect, lo);
            Claim.eq(hiExpect, hi);

            var dst = dinx.vcompact(lo,hi,n128,z8);
            Claim.eq(src,dst);
        }

        public void vinflate_128x8u_128x16u_outline()
        {
            var src = CpuVector.vincrements<byte>(n128);            
            var z =  dinx.vinflate(src, n256, z16);
            var lo = dinx.vlo(z);
            var hi = dinx.vhi(z);
            for(var i=0; i<8; i++)
                Claim.eq(src.Item(i), lo.Item(i));            
        }

        public void vcompact_128_outline()
        {
            var n = n128;
            var a = CpuVector.vincrements<uint>(n,0);
            var b = CpuVector.vincrements<uint>(n,4);
            var c = CpuVector.vincrements<uint>(n,8);
            var d = CpuVector.vincrements<uint>(n,12);
            Vector512<uint> v512 = (a,b,c,d);
            var abActual = dinx.vcompact(a,b,n128,z16);
            var abExpect = CpuVector.vincrements<ushort>(n);
            Claim.eq(abExpect, abActual);

            var abcdActual = dinx.vcompact(a,b,c,d, n128, z8);
            var abcdExpect = CpuVector.vincrements<byte>(n);
            Claim.eq(abcdExpect, abcdActual);
            
        }
        
        public void vinflate_256x8_1024x32_outline()
        {
            var n = n256;

            var a0 = CpuVector.vincrements<uint>(n,0);
            var b0 = CpuVector.vincrements<uint>(n,8);
            var c0 = CpuVector.vincrements<uint>(n,16);
            var d0 = CpuVector.vincrements<uint>(n,24);      


            var compacted = dinx.vcompact(a0,b0,c0,d0, n256, z8);        
            var inflated = dinx.vinflate(compacted, n1024, z32);

            Claim.eq(CpuVector.vincrements<ushort>(n), dinx.vcompact(a0,b0,n256,z16));
            Claim.eq(CpuVector.vincrements<byte>(n), compacted);
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
                var y = dinx.vpackus_alt(x,x);
                Trace(y.Format());
            }        
            case1();
            case2();
            
        }

        


    }

}