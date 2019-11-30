//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static zfunc;
    using System.Runtime.Intrinsics;


    public class t_vcover : IntrinsicTest<t_vcover>
    {

        public void vcover_basecase()
        {            
            var x1 = dinx.vparts(n128,4,8);
            var y1 = dinx.vparts(n128,4,4,4,4, 4,4,4,4, 8,8,8,8, 8,8,8,8);
            var z1 = dinx.vcover(x1, out Vector128<byte> _);
            Claim.eq(y1,z1);

            var x2 = dinx.vparts(n128,4,5,6,7);
            var y2 = dinx.vparts(n128,4,4,4,4, 5,5,5,5, 6,6,6,6, 7,7,7,7);
            var z2 = dinx.vcover(x2, out Vector128<byte> _);
            Claim.eq(y2,z2);

            var x3 = dinx.vparts(n128,4,5,6,7);
            var y3 = dinx.vparts(n128,4,4, 5,5, 6,6, 7,7);
            var z3 = dinx.vcover(x3, out Vector128<ushort> _);
            Claim.eq(y3,z3);

            var x4 = dinx.vparts(n128,4,5);
            var y4 = dinx.vparts(n128,4,4, 5,5);
            var z4 = dinx.vcover(x4, out Vector128<uint> _);
            Claim.eq(y4,z4);

            var x5 =dinx.vparts(n256,1,2,3,4);
            var y5 = dinx.vparts(n256,
                 1, 1, 1, 1, 1, 1, 1, 1, 
                 2, 2, 2, 2, 2, 2, 2, 2, 
                 3, 3, 3, 3, 3, 3, 3, 3, 
                 4, 4, 4, 4, 4, 4, 4, 4);
            dinx.vcover(x5, out Vector256<byte> z5);
            Claim.eq(y5,z5);

            var x6 =dinx.vparts(n256,1,2,3,4,5,6,7,8);
            var y6 = dinx.vparts(n256,
                 1, 1, 1, 1, 2, 2, 2, 2, 
                 3, 3, 3, 3, 4, 4, 4, 4, 
                 5, 5, 5, 5, 6, 6, 6, 6, 
                 7, 7, 7, 7, 8, 8, 8, 8);
            dinx.vcover(x6, out Vector256<byte> z6);
            Claim.eq(y6,z6);

            var x7 = dinx.vparts(n128,0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15);
            var y7 = dinx.vparts(n256,0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15);
            dinx.vexpand(x7, out Vector256<ushort> z7);
            Claim.eq(y7,z7);

        }

    }

}