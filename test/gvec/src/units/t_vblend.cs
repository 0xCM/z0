//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;

    using static HexConst;
    using static Konst;
    using static z;

    using M = BitMasks.Literals;

    public class t_vblend : t_inx<t_vblend>
    {
        public void vblend_256x32f_outline()
        {
            var w = n256;
            var x = z.vparts(w,0f, 1f, 2f, 3f, 4f, 5f, 6f, 7f);
            var y = z.vparts(w,8f, 9f, 10f, 11f, 12f, 13f, 14f, 15f);
            var spec = z.vparts(w,0f,-1,0f,-1,0f,-1,0f,-1);
            var _z = z.vblendv(x,y,spec);
        }

        public void vblend_256x8u_outline()
        {
            var w = n256;
            var a = gvec.vinc(w, z8);
            var b = gvec.vdec(w, Max8u);
            var spec = z.v8u(z.vbroadcast(w, (ushort)((ushort)Pow2.T07 << 8)));
            var c = gvec.vblend(a,b,spec);
        }

        public void vblend_128x16u_outline()
        {
            var w = n128;
            var alt = (uint)M.Msb16x8x1 << 16;
            z.vcover(z.v16u(z.vbroadcast(w,alt)), out Vector128<byte> spec);
            var a = gvec.vinc(w,z16);
            var b = gvec.vdec(w,Max16u);
            var c = gvec.vblend(a,b,spec);
        }

        public void vblend_256x16u_outline()
        {
            var w = n256;
            var altOdd = (uint)M.Msb16x8x1 << 16;
            var altEven = (uint)M.Msb16x8x1;
            z.vcover(z.v16u(z.vbroadcast<uint>(w, altOdd)), out Vector256<byte> spec);
            var a = gvec.vinc(w,z16);
            var b = gvec.vdec(w,Max16u);
            var c = gvec.vblend(a,b,spec);
        }

        public void valignr_examples()
        {
            var sfk = SequenceFormatKind.List;
            var sep = Chars.Comma;
            var pad = 2;
            void example1()
            {
                var n = n128;
                var x = z.vbroadcast(n, (byte)1);
                var y = z.vbroadcast(n, (byte)2);
                Trace($"x{n}", x.Format());
                Trace($"y{n}", y.Format());
                Trace("valignr/3",gvec.valignr(x,y, 3).Format());
                Trace("valignr/4",gvec.valignr(x,y, 4).Format());
                Trace("valignr/5",gvec.valignr(x,y, 5).Format());
                Trace("valignr/6",gvec.valignr(x,y, 6).Format());
                Trace("valignr/7",gvec.valignr(x,y, 7).Format());
                Trace("valignr/8",gvec.valignr(x,y, 8).Format());
            }

            void example2()
            {
                var n = n256;
                var x = z.vbroadcast(n, (byte)1);
                var y = z.vbroadcast(n, (byte)2);
                Trace($"x{n}", x.FormatLanes());
                Trace($"y{n}", y.FormatLanes());
                Trace("valignr/3", gvec.valignr(x,y, 3).FormatLanes());
                Trace("valignr/4", gvec.valignr(x,y, 4).FormatLanes());
                Trace("valignr/5", gvec.valignr(x,y, 5).FormatLanes());
                Trace("valignr/6", gvec.valignr(x,y, 6).FormatLanes());
                Trace("valignr/7", gvec.valignr(x,y, 7).FormatLanes());
                Trace("valignr/8", gvec.valignr(x,y, 8).FormatLanes());
            }
        }

        public void vblend_8x16_basecases()
        {
            var n = n128;
            var x = z.vparts(n, 0,2,4,6,8,A,C,E);
            var y = z.vparts(n, 1,3,5,7,9,B,D,F);

            Claim.veq(x, z.vblend(x,y, Blend8x16.LLLLLLLL));
            Claim.veq(y, z.vblend(x,y, Blend8x16.RRRRRRRR));
            Claim.veq(z.vparts(n, 0,2,4,6,9,B,D,F), z.vblend(x,y, Blend8x16.LLLLRRRR));
            Claim.veq(z.vparts(n, 1,3,5,7,8,A,C,E), z.vblend(x,y, Blend8x16.RRRRLLLL));

        }

        public void vblend_4x64_basecases()
        {
            var n = n256;
            var w = w64;
            var left = z.vparts(n,0,1,2,3);
            var right = z.vparts(n,4,5,6,7);

            Claim.veq(z.vparts(n,0,5,2,7), z.vblend4x64(left, right, Blend4x64.LRLR));
            Claim.veq(z.vparts(n,4,1,6,3), z.vblend4x64(left, right, Blend4x64.RLRL));
            Claim.veq(z.vparts(n,0,1,2,3), z.vblend4x64(left, right, Blend4x64.LLLL));
            Claim.veq(z.vparts(n,4,5,6,7), z.vblend4x64(left, right, Blend4x64.RRRR));
        }

        public void vblend_2x64_basecases()
        {
            var n = w128;
            var w = w64;
            var left =  z.vparts(0,1);
            var right = z.vparts(4,5);
            Claim.veq(z.vparts(0, 5), z.vblend2x64(left, right, Blend2x64.LR));
            Claim.veq(z.vparts(4, 1), z.vblend2x64(left, right, Blend2x64.RL));
            Claim.veq(z.vparts(0, 1), z.vblend2x64(left, right, Blend2x64.LL));
            Claim.veq(z.vparts(4, 5), z.vblend2x64(left, right, Blend2x64.RR));
        }

        public void vblend_4x32_basecases()
        {
            var n = w128;
            var w = w32;
            var left =  z.vparts(n,0,1,2,3);
            var right = z.vparts(n,4,5,6,7);
            Claim.veq(z.vparts(n,0,5,2,7), z.vblend(left,right,Blend4x32.LRLR));
            Claim.veq(z.vparts(n,4,1,6,3), z.vblend(left,right,Blend4x32.RLRL));
            Claim.veq(z.vparts(n,0,1,6,7), z.vblend(left,right,Blend4x32.LLRR));
            Claim.veq(z.vparts(n,4,5,2,3), z.vblend(left,right,Blend4x32.RRLL));
        }

        public void vblend_8x32_basecases()
        {
            var n = w256;
            var w = w32;
            var left =  z.vparts(0,1,2,3,4,5,6,7);
            var right = z.vparts(8,9,A,B,C,D,E,F);
            Claim.veq(z.vparts(0,9,2,B,4,D,6,F), z.vblend(left,right, Blend8x32.LRLRLRLR));
            Claim.veq(z.vparts(8,1,A,3,C,5,E,7), z.vblend(left,right, Blend8x32.RLRLRLRL));
            Claim.veq(z.vparts(0,1,A,B,4,5,E,F), z.vblend(left,right, Blend8x32.LLRRLLRR));
            Claim.veq(z.vparts(8,9,2,3,C,D,6,7), z.vblend(left,right, Blend8x32.RRLLRRLL));

            var lrpattern = z.v32u(z.vbroadcast(n,((ulong)(uint.MaxValue) << 32)));
            for(byte i=0; i < 8; i++)
                Claim.eq(z.vcell(lrpattern,i), gmath.even(i) ? 0u : uint.MaxValue);

            var zero = z.vzero<uint>(n);
            var ones = gvec.vones<uint>(n);
            Claim.veq(lrpattern, z.vblend(zero, ones, Blend8x32.LRLRLRLR));
        }

        public void vblend_32x8_256x32u_basecase()
        {
            var n = w256;
            var x = z.vparts(0,1,2,3,4,5,6,7);
            var y = z.vparts(8,9,A,B,C,D,E,F);
            var e = z.vparts(0,9,2,B,4,D,6,F);
            var o = z.vparts(8,1,A,3,C,5,E,7);
            var mEven = z.vblendspec(n,false,n32);
            var mOdd = z.vblendspec(n,true,n32);
            Claim.veq(e,gvec.vblend(x,y,mEven));
            Claim.veq(o,gvec.vblend(x,y,mOdd));
        }

        public void vblend_32x8_256x64u_basecase()
        {
            var n = w256;
            var x = z.vparts(n,0,1,2,3);
            var y = z.vparts(n,4,5,6,7);
            var e = z.vparts(n,0,5,2,7);
            var o = z.vparts(n,4,1,6,3);
            var mEven = z.vblendspec(n,false,n64);
            var mOdd = z.vblendspec(n,true,n64);
            Claim.veq(e,gvec.vblend(x,y,mEven));
            Claim.veq(o,gvec.vblend(x,y,mOdd));
        }

        public void vblend_32x8_256x64u()
        {
            var n = n256;

            var selectors = Random.BitStream32().Take(RepCount).ToArray();

            for(var sample=0; sample<RepCount; sample++)
            {
                var xs = Random.Blocks<ulong>(n);
                var x = xs.LoadVector();
                Claim.veq(x, z.vparts(n, xs[0], xs[1], xs[2], xs[3]));

                var ys = Random.Blocks<ulong>(n);
                var y = ys.LoadVector();
                Claim.veq(y, z.vparts(n, ys[0], ys[1], ys[2], ys[3]));

                var m = z.vblendspec(n256,false,n64);
                var es = SpanBlocks.alloc<ulong>(n);
                for(var i=0; i<es.CellCount; i++)
                    es[i] = gmath.odd(i) ? ys[i] : xs[i];
                var expect = es.LoadVector();
                var actual = gvec.vblend(x,y,m);

                Claim.veq(expect,actual);
            }
        }
    }
}