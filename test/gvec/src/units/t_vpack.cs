//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Part;
    using static LimitValues;
    using static memory;

    public class t_vpack : t_inx<t_vpack>
    {
        public void vpackus_128x16x2_128x8_outline()
        {
            void case1()
            {
                var a = cpu.vparts(w128,0,1,2,4,4,5,6,7);
                var b = cpu.vparts(w128,8,9,10,11,12,13,14,15);
                var c = cpu.vpackus(a,b);
                var d = cpu.vparts(w128,0,1,2,4,4,5,6,7,8,9,10,11,12,13,14,15);
                Claim.veq(d,c);
            }

            void case2()
            {
                var x = cpu.vparts(w128,127,0,127,0,127,0,127,0);
                var y = cpu.vpackus(x,x);
                Notify(y.Format());
            }
            case1();
            case2();
        }

        public void vpack_128()
        {
            var w = w128;
            var a = gvec.vinc<uint>(w,0);
            var b = gvec.vinc<uint>(w,4);
            var c = gvec.vinc<uint>(w,8);
            var d = gvec.vinc<uint>(w,12);
            Vector512<uint> v512 = (a,b,c,d);
            var abActual = cpu.vpack128x16u(a,b, w);
            var abExpect = gcpu.vinc<ushort>(w);
            Claim.veq(abExpect, abActual);

            var abcdActual = cpu.vpack128x8u(a, b, c, d, w);
            var abcdExpect = gcpu.vinc<byte>(w);
            Claim.veq(abcdExpect, abcdActual);
        }

        public void vpack_128x16x2_128x8()
        {
            var w = w128;
            var cellmax = Max8u;

            var vsmax = cpu.vbroadcast(w, (ushort)cellmax);
            var vtmax = cpu.vbroadcast(w,cellmax);
            var expect = cpu.vsub(vtmax, gvec.vinc(w,z8));

            var x = cpu.vsub(vsmax, gvec.vinc(w, z16));
            var y = cpu.vsub(vsmax, gvec.vinc(w, (ushort)8));
            var actual = cpu.vpack128x8u(x, y, w128);

            Claim.veq(expect,actual);
        }

        public void vpack_256x16x2_256x8()
        {
            var w = w256;
            var cellmax = Max8u;

            var vsmax = cpu.vbroadcast(w, (ushort)cellmax);
            var vtmax = cpu.vbroadcast(w,cellmax);
            var expect = cpu.vsub(vtmax, gvec.vinc(w,z8));

            var x = cpu.vsub(vsmax, gvec.vinc(w, z16));
            var y = cpu.vsub(vsmax, gvec.vinc(w, (ushort)16));
            var actual = cpu.vpack256x8u(x, y,w256);

            Claim.veq(expect,actual);
        }

        public void vpack_2x128x32u_128x16u()
        {
            var w = w128;
            var cellmax = Max16u;

            var vsmax = cpu.vbroadcast(w, (uint)cellmax);
            var vtmax = cpu.vbroadcast(w,cellmax);
            var expect = cpu.vsub(vtmax, gvec.vinc(w,z16));

            var x = cpu.vsub(vsmax, gvec.vinc(w, 0u));
            var y = cpu.vsub(vsmax, gvec.vinc(w, 4u));
            var actual = cpu.vpack128x16u(x,y, w128);

            Claim.veq(expect,actual);
        }

        public void vpack_2x256x32u_256x16u()
        {
            var w = w256;
            var cellmax = Max16u;

            var vsmax = gcpu.vbroadcast<uint>(w, (uint)cellmax);
            var vtmax = cpu.vbroadcast(w,cellmax);

            var x = cpu.vsub(vsmax, gvec.vinc(w, 0u));
            var y = cpu.vsub(vsmax, gvec.vinc(w, 8u));
            var v = cpu.vpack256x16u(x,y,n256);
            var expect = cpu.vsub(vtmax, gvec.vinc(w, z16));
            Claim.veq(expect,v);
        }

        public void vpack_2x128x64u_128x32u()
        {
            var w = w128;
            var x0 = cpu.vparts(w, 25, 50);
            var x1 = cpu.vparts(w, 75, 10);
            var dst = cpu.vpack128x32u(x0, x1, w);
            var expect = cpu.vparts(w, 25, 50, 75, 10);
            Claim.veq(expect,dst);
        }
    }
}