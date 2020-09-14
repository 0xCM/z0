//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static HexConst;
    using static z;

    public class t_vconvert : t_inx<t_vconvert>
    {
        public void block_32x8u_to_128x32u()
        {
            var blockA = BufferBlocks.parts<byte>(n32,1,2,3,4);
            var x = vparts(n128,1,2,3,4);
            var blockB = x.ToBlock();
            var y = vconvert(blockA, n128, z32);
            var blockC = y.ToBlock();
            Claim.eq(x,y);
            Claim.eq(blockB,blockC);
        }

        public void block_64x8u_to_2x128x32u()
        {
            var block = BufferBlocks.parts<byte>(n64,1,2,3,4,5,6,7,8);
            var xE = vparts(n128,1,2,3,4);
            var yE = vparts(n128,5,6,7,8);
            var z = vconvert(block, n256, z32);
            Claim.eq(xE, vlo(z));
            Claim.eq(yE, vhi(z));
        }

        public void block_32x8u_to_2x128x64u()
        {
            var block = BufferBlocks.parts<byte>(n32,1,2,3,4);
            var xE = vparts(1,2);
            var yE = vparts(3,4);

            var z = vconvert(block,n256,z64);
            Claim.eq(xE, vlo(z));
            Claim.eq(yE, vhi(z));
        }

        public void block_128x8u_to_2x128x16u()
        {
            var block = BufferBlocks.parts<byte>(n128,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16);
            var xE = vparts(n128,1,2,3,4,5,6,7,8);
            var yE = vparts(n128,9,10,11,12,13,14,15,16);
            var z = vconvert(block,n256,z16);

            Claim.eq(xE, vlo(z));
            Claim.eq(yE, vhi(z));
        }

        public void v128x8u_v128x16u()
        {
            var x = vparts(n128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var y = vmaplo(x, n128, z16);
            var z = vparts(n128,0,1,2,3,4,5,6,7);
            Claim.eq(y,z);
        }

        public void m64x8u_v128x16u()
        {
            var x = BufferBlocks.parts<byte>(n64,0,1,2,3,4,5,6,7);
            var y = vconvert(x, n128, z16);
            var z = vparts(w128,0,1,2,3,4,5,6,7);

            Claim.eq(y,z);
        }

        public void blockspan_128x8u_v128x16u()
        {
            var x = BufferBlocks.parts<byte>(n128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var q = vconvert(x, n256, z16);
            var z0 = x.LoBlock(0);
            var z1 = x.HiBlock(0);
            var y0s = vlo(q).ToSpan();
            var y1s = vhi(q).ToSpan();

            for(var i=0; i <8; i++)
            {
                Claim.eq(z0[i], (byte)y0s[i]);
                Claim.eq(z1[i], (byte)y1s[i]);
            }
        }

        public void blockspan_64x8u_v2x128x32u()
        {
            var x = BufferBlocks.parts<byte>(n64,0,1,2,3,4,5,6,7);
            var y = vconvert(x,n256,z32);
            var z0 = x.Slice(0,4);
            var z1 = x.Slice(4,4);
            var y0s = vlo(y).ToSpan();
            var y1s = vhi(y).ToSpan();

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

            var sb = BufferBlocks.alloc<byte>(sw);
            var tb = BufferBlocks.alloc<ushort>(tw,tbc);

            for(var sample = 0; sample < RepCount; sample++)
            {
                var sv = Random.CpuVector(sw,st);
                var tv = vconvert(sv,tw,tt);

                sv.StoreTo(sb);
                tv.StoreTo(tb);

                var i = 0;
                for(var block = 0; block < tb.BlockCount; block++)
                for(var j = 0; j < tb.BlockLength; j++, i++)
                    Claim.eq(sb[i], convert(tb[block,j],st));
            }
        }

        public void vconvert_128x8u_2x128x16u()
        {
            var sw = n128;
            var st = z8;

            var tw = n128;
            var tt = z16;

            var tbc = 2;

            var sb = BufferBlocks.alloc<byte>(sw);
            var tb = BufferBlocks.alloc(tw,tbc,tt);

            for(var sample = 0; sample < RepCount; sample++)
            {
                var sv = Random.CpuVector(sw,st);
                var tv = vconvert(sv,n256,tt);
                var tvLo = vlo(tv);
                var tvHi = vhi(tv);

                sv.StoreTo(sb);
                tvLo.StoreTo(tb,0);
                tvHi.StoreTo(tb,1);

                var i = 0;
                for(var block = 0; block < tbc; block++)
                for(var j = 0; j < tb.BlockLength; j++, i++)
                    Claim.eq(sb[i], convert(tb[block,j],st));
            }
        }
    }
}