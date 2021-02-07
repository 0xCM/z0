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
    using static z;

    public class t_vinflate : t_inx<t_vinflate>
    {
        public void vinflate_128x8u()
        {
            var v128x8u_input = gvec.vinc<byte>(n128,0);
            var v256x16u =  cpu.vinflate256x16u(v128x8u_input, w256);
            var v128x16u_a = cpu.vlo(v256x16u);
            var v128x16u_b = cpu.vhi(v256x16u);
            var v128x16u_a_expect = gvec.vinc<ushort>(n128,0);
            var v128x16u_b_expect = gvec.vinc<ushort>(n128,8);
            var v128x8u_output = cpu.vpack128x8u(v128x16u_a, v128x16u_b, w128);

            Claim.veq(v128x16u_a_expect, v128x16u_a);
            Claim.veq(v128x16u_b_expect, v128x16u_b);
            Claim.veq(v128x8u_input, v128x8u_output);
        }

        public void vinflate_128x8u_128x16u()
        {
            var v128x8u = gvec.vinc(default(Vector128<byte>));
            var v256x16u =  cpu.vinflate256x16u(v128x8u, n256);
            var v128x16u_a = cpu.vlo(v256x16u);
            var v128x16u_b = cpu.vhi(v256x16u);

            for(byte i=0; i<8; i++)
                Claim.eq(vcell(v128x8u, i), vcell(v128x16u_a,i));
        }


        public void vinflate_256x8_1024x32()
        {
            var w = n256;

            var a0 = gvec.vinc<uint>(w,0);
            var b0 = gvec.vinc<uint>(w,8);
            var c0 = gvec.vinc<uint>(w,16);
            var d0 = gvec.vinc<uint>(w,24);

            var u16inc = gvec.vinc<ushort>(w,0);
            var u8inc = gvec.vinc<byte>(w,0);

            var c8 = cpu.vpack256x8u(a0, b0, c0, d0, w256);
            var c16 = cpu.vpack256x16u(a0, b0, w256);
            var v1024x32u = cpu.vinflate1024x32u(c8, w1024);
            Claim.veq(u16inc, c16);
            Claim.veq(u8inc, c8);
            Claim.veq(a0, v1024x32u.A);
            Claim.veq(b0, v1024x32u.B);
            Claim.veq(c0, v1024x32u.C);
            Claim.veq(d0, v1024x32u.D);
        }
    }
}