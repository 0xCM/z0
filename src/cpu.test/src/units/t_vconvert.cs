//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Root;
    using static HexConst;

    public class t_vconvert : t_inx<t_vconvert>
    {
        public void block_32x8u_to_128x32u()
        {
            var blockA = SpanBlocks.parts<byte>(n32,1,2,3,4);
            var x = cpu.vparts(n128,1,2,3,4);
            var blockB = x.ToBlock();
            var y = vblocks.vinflate128x32u(blockA,0);
            var blockC = y.ToBlock();
            Claim.eq(x,y);
            Claim.eq(blockB,blockC);
        }

        public void block_64x8u_to_2x128x32u()
        {
            var block = SpanBlocks.parts<byte>(n64,1,2,3,4,5,6,7,8);
            var xE = cpu.vparts(n128,1,2,3,4);
            var yE = cpu.vparts(n128,5,6,7,8);
            var z = vblocks.vinflate256x32u(block,0);
            Claim.eq(xE, cpu.vlo(z));
            Claim.eq(yE, cpu.vhi(z));
        }

        public void block_32x8u_to_2x128x64u()
        {
            var block = SpanBlocks.parts<byte>(n32,1,2,3,4);
            var xE = cpu.vparts(1,2);
            var yE = cpu.vparts(3,4);

            var z = vpack.vinflate256x64u(block,0);
            Claim.eq(xE, cpu.vlo(z));
            Claim.eq(yE, cpu.vhi(z));
        }

        public void block_128x8u_to_2x128x16u()
        {
            var block = SpanBlocks.parts<byte>(n128,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16);
            var xE = cpu.vparts(n128,1,2,3,4,5,6,7,8);
            var yE = cpu.vparts(n128,9,10,11,12,13,14,15,16);
            var z = vpack.vinflate256x16u(block,0);

            Claim.eq(xE, cpu.vlo(z));
            Claim.eq(yE, cpu.vhi(z));
        }

        public void v128x8u_v128x16u()
        {
            var x = cpu.vparts(w128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var y = vpack.vlo128x16u(x);
            var z = cpu.vparts(w128,0,1,2,3,4,5,6,7);
            Claim.eq(y,z);
        }

        public void m64x8u_v128x16u()
        {
            var x = SpanBlocks.parts<byte>(w64,0,1,2,3,4,5,6,7);
            var y = vblocks.vinflate128x16u(x,0);
            var z = cpu.vparts(w128,0,1,2,3,4,5,6,7);

            Claim.eq(y,z);
        }

        public void blockspan_128x8u_v128x16u()
        {
            var x = SpanBlocks.parts<byte>(w128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var q = vpack.vinflate256x16u(x,0);
            var z0 = x.LoBlock(0);
            var z1 = x.HiBlock(0);
            var y0s = cpu.vlo(q).ToSpan();
            var y1s = cpu.vhi(q).ToSpan();

            for(var i=0; i <8; i++)
            {
                Claim.eq(z0[i], (byte)y0s[i]);
                Claim.eq(z1[i], (byte)y1s[i]);
            }
        }

        public void blockspan_64x8u_v2x128x32u()
        {
            var x = SpanBlocks.parts<byte>(n64,0,1,2,3,4,5,6,7);
            var y = vblocks.vinflate256x32u(x,0);
            var z0 = x.Slice(0,4);
            var z1 = x.Slice(4,4);
            var y0s = cpu.vlo(y).ToSpan();
            var y1s = cpu.vhi(y).ToSpan();

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

            var sb = SpanBlocks.single<byte>(sw);
            var tb = SpanBlocks.alloc<ushort>(tw,tbc);

            for(var sample = 0; sample < RepCount; sample++)
            {
                var sv = Random.CpuVector(sw, st);
                var tv = vpack.vinflate256x16u(sv);

                sv.StoreTo(sb);
                tv.StoreTo(tb);

                var i = 0;
                for(var block = 0; block<tb.BlockCount; block++)
                for(var j = 0; j < tb.BlockLength; j++, i++)
                {
                    var m  = tb[block,j];
                    var x = NumericCast.force<byte>(m);
                    Claim.eq(sb[i], x);
                }
            }
        }

        public void vconvert_128x8u_2x128x16u()
        {
            var sw = n128;
            var st = z8;

            var tw = n128;
            var tt = z16;

            var tbc = 2;

            var sb = SpanBlocks.single<byte>(sw);
            var tb = SpanBlocks.alloc<ushort>(tw,tbc);

            for(var sample = 0; sample < RepCount; sample++)
            {
                var sv = Random.CpuVector(sw,st);
                var tv = vpack.vinflate256x16u(sv);
                var tvLo = cpu.vlo(tv);
                var tvHi = cpu.vhi(tv);

                sv.StoreTo(sb);
                tvLo.StoreTo(tb,0);
                tvHi.StoreTo(tb,1);

                var i = 0;
                for(var block = 0; block < tbc; block++)
                for(var j = 0; j < tb.BlockLength; j++, i++)
                    Claim.eq(sb[i], NumericCast.force<byte>(tb[block,j]));
            }
        }
    }
}