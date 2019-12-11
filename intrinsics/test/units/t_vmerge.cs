//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;
    using static HexConst;

    public class t_vmerge : t_vinx<t_vmerge>
    {
        public void vmerge_basecase()
        {
            const byte m1 = (byte)Blend8x16.LLRRLLRR;            
            const byte m2 = m1 ^ byte.MaxValue; 
                    
            var n = n128;
            var x = dinx.vparts(n, 0,1,2,3,4,5,6,7); 
            var y = dinx.vparts(n, 8,9,A,B,C,D,E,F); 
            var x0 = dinx.vblend(x,y, m1);
            var x1 = dinx.vblend(x,y, m2);

            var merged1 = dinx.vconcat(x0, x1);
            var merged2 = dinx.vmerge(x, y, m1, m2);
            Claim.eq(merged1, merged2);

            var merged3 = dinx.vmerge(x0, x1, m1, m2);
            Claim.eq(dinx.vconcat(x,y), merged3);

        }

        public void vmerge_example()
        {
            var a = dinx.vparts(n128, 0u,1,2,3);
            var b = dinx.vparts(n128, 4u,5,6,7);
            var c = dinx.vparts(n128, 8u,9,10,11);
            var d = dinx.vparts(n128, 12u,13,14,15);
            var x0 = dinx.vmergelo(v8u(a), v8u(b));
            var y0 = dinx.vmergelo(v8u(c), v8u(d));
            var z0 = v8u(dinx.vmergelo(v16u(x0),v16u(y0)));
            var z1 = v8u(dinx.vmergehi(v16u(x0),v16u(y0)));
            var x1 = dinx.vmergehi(v8u(a), v8u(b));
            var y1 = dinx.vmergehi(v8u(c), v8u(d));
            var z2 = v8u(dinx.vmergelo(v16u(x1),v16u(y1)));
            var z3 = v8u(dinx.vmergehi(v16u(x1),v16u(y1)));                            
        }

        public void vunpack_lo_8()
        {

            var x = ginx.vincrements<byte>(n128);
            var y = dinx.vadd(x, dinx.vbroadcast(n128, (byte)16));

            var lo = ginx.vmergelo(x,y);
            var hi = ginx.vmergehi(x,y);


            /*

            [ 0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15]
            [16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31]
            
            [ 0, 16,  1, 17,  2, 18,  3, 19,  4, 20,  5, 21,  6, 22,  7, 23]
            
            [ 8, 24,  9, 25, 10, 26, 11, 27, 12, 28, 13, 29, 14, 30, 15, 31]

            */
            Trace(x.Format(pad:2));
            Trace(y.Format(pad:2));
            Trace(lo.Format(pad:2));
            Trace(hi.Format(pad:2));
        }
    }
}