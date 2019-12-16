//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static HexConst;

    public class t_vconvert : t_vinx<t_vconvert>
    {   
        public void block_32x8u_to_128x32u()
        {
            var blockA = DataBlocks.parts<byte>(n32,1,2,3,4);
            var x = vbuild.parts(n128,1,2,3,4);
            var blockB = x.ToBlock();            
            dinx.vloadblock(blockA, out Vector128<uint> y);
            var blockC = y.ToBlock();            
            Claim.eq(x,y);
            Claim.eq(blockB,blockC);            
        }


        public void block_64x8u_to_2x128x32u()
        {
            var block = DataBlocks.parts<byte>(n64,1,2,3,4,5,6,7,8);
            var xE = vbuild.parts(n128,1,2,3,4);
            var yE = vbuild.parts(n128,5,6,7,8);
            var z = dinx.vloadblock(block, n128,z32);
            Claim.eq(xE, z.A);
            Claim.eq(yE, z.B);
        }

        public void block_32x8u_to_2x128x64u()
        {
            var block = DataBlocks.parts<byte>(n32,1,2,3,4);
            var xE = vbuild.parts(n128,1,2);
            var yE = vbuild.parts(n128,3,4);

            var z = dinx.vloadblock(block,n128,z64);
            Claim.eq(xE, z.A);
            Claim.eq(yE, z.B);
        }

        public void block_128x8u_to_2x128x16u()
        {
            var block = DataBlocks.parts<byte>(n128,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16);
            var xE = vbuild.parts(n128,1,2,3,4,5,6,7,8);
            var yE = vbuild.parts(n128,9,10,11,12,13,14,15,16);
            var z = dinx.vloadblock(block,n128,z16);
            
            Claim.eq(xE, z.A);
            Claim.eq(yE, z.B);
        }

        public void v128x8u_v128x16u()
        {
            var x = vbuild.parts(n128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var y = dinx.vmaplo(x, out Vector128<ushort> _);
            var z = vbuild.parts(n128,0,1,2,3,4,5,6,7);
            Claim.eq(y,z);
        }

        public void m64x8u_v128x16u()
        {
            var x = DataBlocks.parts<byte>(n64,0,1,2,3,4,5,6,7);
            var y = dinx.vloadblock(x, n128, z16);
            var z = vbuild.parts(n128,0,1,2,3,4,5,6,7);            

            Claim.eq(y,z);            
        }

        public void blockspan_128x8u_v128x16u()
        {
            var x = DataBlocks.parts<byte>(n128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var q = dinx.vloadblock(x, n128, z16);
            var z0 = x.LoBlock(0);
            var z1 = x.HiBlock(0);
            var y0s = q.A.ToSpan();
            var y1s = q.B.ToSpan();

            for(var i=0; i <8; i++)
            {
                Claim.eq(z0[i], (byte)y0s[i]);
                Claim.eq(z1[i], (byte)y1s[i]);
            }                                 
        }

        public void blockspan_64x8u_v2x128x32u()
        {
            var x = DataBlocks.parts<byte>(n64,0,1,2,3,4,5,6,7);
            var y = dinx.vloadblock(x,n128,z32);
            var z0 = x.Slice(0,4);
            var z1 = x.Slice(4,4);
            var y0s = y.A.ToSpan();
            var y1s = y.B.ToSpan();

            for(var i=0; i <4; i++)
            {
                Claim.eq(z0[i], (byte)y0s[i]);
                Claim.eq(z1[i], (byte)y1s[i]);
            }                                 
        }

        public void vconvert_128x8u_1x256x16u()
        {
            var sw = n128;
            var st = z8;

            var tw = n256;
            var tt = z16;

            var tbc = 1;

            var sb = DataBlocks.single(sw,st);
            var tb = DataBlocks.alloc(tw,tbc,tt);

            for(var sample = 0; sample < SampleSize; sample++)
            {
                var sv = Random.CpuVector(sw,st);
                var tv = dinx.vconvert(sv,tw,tt);
                
                sv.StoreTo(sb);
                tv.StoreTo(tb);
                
                var i = 0;
                for(var block = 0; block < tb.BlockCount; block++)
                for(var j = 0; j < tb.BlockLength; j++, i++)
                    Claim.eq(sb[i],convert(tb[block,j],st));
            }

        }

        public void vconvert_128x8u_2x128x16u()
        {
            var sw = n128;
            var st = z8;

            var tw = n128;
            var tt = z16;

            var tbc = 2;

            var sb = DataBlocks.single(sw,st);
            var tb = DataBlocks.alloc(tw,tbc,tt);

            for(var sample = 0; sample < SampleSize; sample++)
            {
                var sv = Random.CpuVector(sw,st);
                var tv = dinx.vconvert(sv,tw,tt);
                
                sv.StoreTo(sb);
                tv.A.StoreTo(tb,0);
                tv.B.StoreTo(tb,1);
                
                var i = 0;
                for(var block = 0; block < tbc; block++)
                for(var j = 0; j < tb.BlockLength; j++, i++)
                    Claim.eq(sb[i],convert(tb[block,j],st));
            }
        }
    }
}