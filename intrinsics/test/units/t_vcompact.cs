//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vcompact : t_vinx<t_vcompact>
    {
        public void vcompact_2x128x64u_128x32u()
        {
            var n = n128;
            var x0 = dinx.vparts(n, 25, 50);
            var x1 = dinx.vparts(n, 75, 10);
            dinx.vcompact(x0,x1, out var dst);
            var expect = dinx.vparts(n,25,50,75,10);
            Claim.eq(expect,dst);
        }

        public void vinflate_128x8u()
        {
            var src = ginx.vincrements<byte>(n128);
            dinx.vinflate(src, out Vector128<ushort> lo, out Vector128<ushort> hi);
            var loExpect = ginx.vincrements<ushort>(n128);
            var hiExpect = ginx.vincrements<ushort>(n128,8);
            Claim.eq(loExpect, lo);
            Claim.eq(hiExpect, hi);

            var dst = dinx.vcompact(lo,hi);
            Claim.eq(src,dst);
        }

        public void vinflate_128x8u_128x16u()
        {
            var src = ginx.vincrements<byte>(n128);            
            dinx.vinflate(src, out Vector128<ushort> lo, out Vector128<ushort> hi);
            for(var i=0; i<8; i++)
                Claim.eq(src.Item(i), lo.Item(i));            
        }

        public void vcompact_basecase_128()
        {
            var n = n128;
            var a = ginx.vincrements<uint>(n,0);
            var b = ginx.vincrements<uint>(n,4);
            var c = ginx.vincrements<uint>(n,8);
            var d = ginx.vincrements<uint>(n,12);
            var abActual = dinx.vcompact(a,b);
            var abExpect = ginx.vincrements<ushort>(n);
            Claim.eq(abExpect, abActual);

            dinx.vcompact(a,b,c,d, out var abcdActual);
            var abcdExpect = ginx.vincrements<byte>(n);
            Claim.eq(abcdExpect, abcdActual);
            
        }
        
        public void vcompact_basecase_256()
        {
            var n = n256;
            var a = ginx.vincrements<uint>(n,0);
            var b = ginx.vincrements<uint>(n,8);
            var c = ginx.vincrements<uint>(n,16);
            var d = ginx.vincrements<uint>(n,24);
            var abActual = dinx.vcompact(a,b);
            var abExpect = ginx.vincrements<ushort>(n);
            Claim.eq(abExpect, abActual);


            dinx.vcompact(a,b,c,d, out var abcdActual);
            var abcdExpect = ginx.vincrements<byte>(n);
            Claim.eq(abcdExpect, abcdActual);

            Claim.eq(dinx.vcompact(ginx.vincrements<ushort>(n), out Vector128<byte> dst), ginx.vincrements<byte>(n128));

            //inversion
            dinx.vinflate(abcdActual, out var a0, out var b0, out var c0, out var d0);
            Claim.eq(a,a0);
            Claim.eq(b,b0);
            Claim.eq(c,c0);
            Claim.eq(d,d0);
        }

    }

}