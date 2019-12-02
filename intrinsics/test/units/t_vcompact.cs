//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vcompact : IntrinsicTest<t_vcompact>
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

            var abcdActual = dinx.vcompact(a,b,c,d);
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


            var abcdActual = dinx.vcompact(a,b,c,d);
            var abcdExpect = ginx.vincrements<byte>(n);
            Claim.eq(abcdExpect, abcdActual);


            Claim.eq(dinx.vcompact(ginx.vincrements<ushort>(n), out Vector128<byte> dst), ginx.vincrements<byte>(n128));

        }

    }

}