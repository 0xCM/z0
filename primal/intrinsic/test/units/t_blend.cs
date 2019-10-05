//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.IO;
    
    using static zfunc;

    public class t_vblend : IntrinsicTest<t_vblend>
    {


        public void vblend_128x32u_check()
        {

            var x = Vec128.FromParts(1u,3,5,7);
            var y = Vec128.FromParts(2u,4,6,8);

            var spec = Blend32x4.LLLL;
            var z = dinx.vblend(x,y, spec);
            Claim.eq(z,x);

            spec = Blend32x4.LLLR;
            z = dinx.vblend(x,y, spec);
            Claim.eq(z, Vec128.FromParts(1u,3,5,8));

            spec = Blend32x4.LLRL;
            z = dinx.vblend(x,y, spec);
            Claim.eq(z, Vec128.FromParts(1u,3,6,7));

            spec = Blend32x4.LLRR;
            z = dinx.vblend(x,y, spec);
            Claim.eq(z, Vec128.FromParts(1u,3,6,8));

            spec = Blend32x4.RLLL;
            z = dinx.vblend(x,y, spec);
            Claim.eq(z, Vec128.FromParts(2u,3,5,7));


            spec = Blend32x4.RRRR;
            z = dinx.vblend(x,y, spec);
            Claim.eq(z,y);

        }


        public void vblend_256x32u_check()
        {

            var x = Vec256.FromParts(1u, 3, 5, 7, 9,  11, 13, 15);
            var y = Vec256.FromParts(2u, 4, 6, 8, 10, 12, 14, 16);
            var spec = Blend32x8.LLLLLLLL;
            var z = dinx.vblend(x,y, spec);
            Trace($"vblend({x},{y},{spec}) = {z}");
            Claim.eq(z,x);

            spec = Blend32x8.LRLRLRLR;
            z = dinx.vblend(x,y, spec);
            Trace($"vblend({x},{y},{spec}) = {z}");
            Claim.eq(z,Vec256.FromParts(1u,4,5,8,9,12,13,16));


            spec = Blend32x8.RRRRRRRR;
            z = dinx.vblend(x,y, spec);
            Trace($"vblend({x},{y},{spec}) = {z}");
            Claim.eq(z,y);

        }


    }

}