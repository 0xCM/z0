//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static zfunc;
    using static HexConst;

    public class t_vblend : IntrinsicTest<t_vblend>
    {
        
        public void vblend_32x8_256x32u_basecase()
        {
            var n = n256;
            var w = n32;
            var x = dinx.vparts(n,0,1,2,3,4,5,6,7);
            var y = dinx.vparts(n,8,9,A,B,C,D,E,F);
            var e = dinx.vparts(n,0,9,2,B,4,D,6,F);
            var o = dinx.vparts(n,8,1,A,3,C,5,E,7);
            var mEven = PatternData.blendspec(n,false,w);
            var mOdd = PatternData.blendspec(n,true,w);
            Claim.eq(e,ginx.vblend32x8(x,y,mEven));
            Claim.eq(o,ginx.vblend32x8(x,y,mOdd));

        }

        public void vblend_32x8_256x64u_basecase()
        {
            var n = n256;
            var w = n64;
            var x = dinx.vparts(n,0,1,2,3);
            var y = dinx.vparts(n,4,5,6,7);
            var e = dinx.vparts(n,0,5,2,7);
            var o = dinx.vparts(n,4,1,6,3);
            var mEven = PatternData.blendspec(n,false,w);
            var mOdd = PatternData.blendspec(n,true,w);
            Claim.eq(e,ginx.vblend32x8(x,y,mEven));
            Claim.eq(o,ginx.vblend32x8(x,y,mOdd));

        }

        public void vblend_32x8_256x64u()
        {
            var n = n256;

            var selectors = Random.Bits(SampleSize).ToArray();

            for(var sample=0; sample<SampleSize; sample++)
            {
                var xs = Random.Blocks<ulong>(n);
                var x = xs.LoadVector();
                Claim.eq(x,dinx.vparts(n, xs[0], xs[1], xs[2], xs[3]));

                var ys = Random.Blocks<ulong>(n);
                var y = ys.LoadVector();
                Claim.eq(y,dinx.vparts(n, ys[0], ys[1], ys[2], ys[3]));

                var m = PatternData.blendspec(n256,false,n64);

                var es = DataBlocks.single<ulong>(n);
                for(var i=0; i<es.CellCount; i++)
                    es[i] = odd(i) ? ys[i] : xs[i];
                var expect = es.LoadVector();
                var actual = ginx.vblend32x8(x,y,m);

                Claim.eq(expect,actual);

            }
        }

        public void vblend_8x16_128x16u_basecase()
        {
            var n = n128;
            var x = dinx.vparts(n, 0,2,4,6,8,10,12,14); 
            var y = dinx.vparts(n, 1,3,5,7,9,11,13,15); 
            
            var z = dinx.vblend8x16(x,y, Blend8x16.LLLLLLLL);
            Claim.eq(x,z);          

            z = dinx.vblend8x16(x,y, Blend8x16.RRRRRRRR);
            Claim.eq(z,y);

            z = dinx.vblend8x16(x,y, Blend8x16.LLLLRRRR);
            Claim.eq(dinx.vparts(n, 0,2,4,6,9,11,13,15), z);

            z = dinx.vblend8x16(x,y, Blend8x16.RRRRLLLL);
            Claim.eq(dinx.vparts(n,1,3,5,7,8,10,12,14), z);

        }
        public void vblend_4x32_128x32u_basecase()
        {   
            var n = n128;

            var x = dinx.vparts(n,1u,3,5,7);
            var y = dinx.vparts(n,2u,4,6,8);

            var spec = Blend4x32.LLLL;
            var z = dinx.vblend4x32(x,y, spec);
            Claim.eq(z,x);

            spec = Blend4x32.LLLR;
            z = dinx.vblend4x32(x,y, spec);
            Claim.eq(z, dinx.vparts(n,1u,3,5,8));

            spec = Blend4x32.LLRL;
            z = dinx.vblend4x32(x,y, spec);
            Claim.eq(z, dinx.vparts(n,1u,3,6,7));

            spec = Blend4x32.LLRR;
            z = dinx.vblend4x32(x,y, spec);
            Claim.eq(z, dinx.vparts(n,1u,3,6,8));

            spec = Blend4x32.RLLL;
            z = dinx.vblend4x32(x,y, spec);
            Claim.eq(z, dinx.vparts(n,2u,3,5,7));


            spec = Blend4x32.RRRR;
            z = dinx.vblend4x32(x,y, spec);
            Claim.eq(z,y);
        }

        public void vblend_8x32_256x32u_basecase()
        {
            var n = n256;
            var x = dinx.vparts(n, 1, 3, 5, 7, 9,  11, 13, (uint)15);
            var y = dinx.vparts(n, 2, 4, 6, 8, 10, 12, 14, (uint)16);
            var spec = Blend8x32.LLLLLLLL;
            var z = dinx.vblend8x32(x,y, spec);
            Claim.eq(z,x);

            spec = Blend8x32.LRLRLRLR;
            z = dinx.vblend8x32(x,y, spec);
            Claim.eq(z, dinx.vparts(n, 1,4,5,8,9,12,13,(uint)16));

            spec = Blend8x32.RRRRRRRR;
            z = dinx.vblend8x32(x,y, spec);
            Claim.eq(z,y);

        }
    }
}