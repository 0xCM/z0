//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    using static HexConst;

    public class t_vblend : t_inx<t_vblend>
    {            
        public void vblend_256x32f_outline()
        {
            var w = n256;
            var x = Vectors.vpartsf(w, 0f, 1f, 2f, 3f, 4f, 5f, 6f, 7f);
            var y = Vectors.vpartsf(w, 8f, 9f, 10f, 11f, 12f, 13f, 14f, 15f);
            var spec = Vectors.vpartsf(w, 0f,-1,0f,-1,0f,-1,0f,-1);
            var z = dvec.vblendv(x,y,spec);
        }

        public void vblend_256x8u_outline()
        {
            var w = n256;
            var x = gvec.vinc(w, z8);
            var y = gvec.vdec(w, u8max);
            var spec = v8u(Vectors.vbroadcast(w, (ushort)((ushort)Pow2.T07 << 8)));
            var z = gvec.vblend(x,y,spec);            
        }        

        public void vblend_128x16u_outline()
        {
            var w = n128;
            var alt = (uint)BitMasks.Msb16x8x1 << 16; 
            dvec.vcover(v16u(Vectors.vbroadcast(w,alt)), out Vector128<byte> spec);
            var x = gvec.vinc(w,z16);
            var y = gvec.vdec(w,u16max);
            var z = gvec.vblend(x,y,spec);
        }

        public void vblend_256x16u_outline()
        {
            var w = n256;
            var altOdd = (uint)BitMasks.Msb16x8x1 << 16; 
            var altEven = (uint)BitMasks.Msb16x8x1;
            dvec.vcover(v16u(Vectors.vbroadcast<uint>(w, altOdd)), out Vector256<byte> spec);
            var x = gvec.vinc(w,z16);
            var y = gvec.vdec(w,u16max);
            var z = gvec.vblend(x,y,spec);
        }

        public void valignr_examples()
        {
            var sfk = SequenceFormatKind.List;
            var sep = Chars.Comma;
            var pad = 2;
            void example1()
            {
                var n = n128;
                var x = Vectors.vbroadcast(n, (byte)1);
                var y = Vectors.vbroadcast(n, (byte)2);
                trace($"x{n}", x.Format());
                trace($"y{n}", y.Format());                
                trace("valignr/3",gvec.valignr(x,y, 3).Format());
                trace("valignr/4",gvec.valignr(x,y, 4).Format());
                trace("valignr/5",gvec.valignr(x,y, 5).Format());
                trace("valignr/6",gvec.valignr(x,y, 6).Format());
                trace("valignr/7",gvec.valignr(x,y, 7).Format());
                trace("valignr/8",gvec.valignr(x,y, 8).Format());
            }

            void example2()
            {
                var n = n256;
                var x = Vectors.vbroadcast(n, (byte)1);
                var y = Vectors.vbroadcast(n, (byte)2);
                trace($"x{n}", x.FormatLanes());
                trace($"y{n}", y.FormatLanes());
                trace("valignr/3",gvec.valignr(x,y, 3).FormatLanes());
                trace("valignr/4",gvec.valignr(x,y, 4).FormatLanes());
                trace("valignr/5",gvec.valignr(x,y, 5).FormatLanes());
                trace("valignr/6",gvec.valignr(x,y, 6).FormatLanes());
                trace("valignr/7",gvec.valignr(x,y, 7).FormatLanes());
                trace("valignr/8",gvec.valignr(x,y, 8).FormatLanes());
            }

        }

                
        public void vblend_8x16_basecases()
        {
            var n = n128;
            var x = Vectors.vparts(n, 0,2,4,6,8,A,C,E); 
            var y = Vectors.vparts(n, 1,3,5,7,9,B,D,F); 
            
            Claim.veq(x, dvec.vblend(x,y, Blend8x16.LLLLLLLL));          
            Claim.veq(y, dvec.vblend(x,y, Blend8x16.RRRRRRRR));
            Claim.veq(Vectors.vparts(n, 0,2,4,6,9,B,D,F), dvec.vblend(x,y, Blend8x16.LLLLRRRR));
            Claim.veq(Vectors.vparts(n, 1,3,5,7,8,A,C,E), dvec.vblend(x,y, Blend8x16.RRRRLLLL));

        }

        public void vblend_4x64_basecases()
        {            
            var n = n256;
            var w = w64;
            var left = Vectors.vparts(n,0,1,2,3);
            var right = Vectors.vparts(n,4,5,6,7);

            Claim.veq(Vectors.vparts(n,0,5,2,7),dvec.vblend(left, right, Blend4x64.LRLR));    
            Claim.veq(Vectors.vparts(n,4,1,6,3),dvec.vblend(left, right, Blend4x64.RLRL));    
            Claim.veq(Vectors.vparts(n,0,1,2,3),dvec.vblend(left, right, Blend4x64.LLLL));    
            Claim.veq(Vectors.vparts(n,4,5,6,7),dvec.vblend(left, right, Blend4x64.RRRR));    
        }

        public void vblend_2x64_basecases()
        {
            var n = w128;
            var w = w64;
            var left =  Vectors.vparts(n,0,1);
            var right = Vectors.vparts(n,4,5);
            Claim.veq(Vectors.vparts(n, 0, 5),dvec.vblend(left, right, Blend2x64.LR));
            Claim.veq(Vectors.vparts(n, 4, 1),dvec.vblend(left, right, Blend2x64.RL));
            Claim.veq(Vectors.vparts(n, 0, 1),dvec.vblend(left, right, Blend2x64.LL));
            Claim.veq(Vectors.vparts(n, 4, 5),dvec.vblend(left, right, Blend2x64.RR));
        }

        public void vblend_4x32_basecases()
        {
            var n = w128;
            var w = w32;
            var left =  Vectors.vparts(n,0,1,2,3);
            var right = Vectors.vparts(n,4,5,6,7);
            Claim.veq(Vectors.vparts(n,0,5,2,7), dvec.vblend(left,right,Blend4x32.LRLR));
            Claim.veq(Vectors.vparts(n,4,1,6,3), dvec.vblend(left,right,Blend4x32.RLRL));
            Claim.veq(Vectors.vparts(n,0,1,6,7), dvec.vblend(left,right,Blend4x32.LLRR));
            Claim.veq(Vectors.vparts(n,4,5,2,3), dvec.vblend(left,right,Blend4x32.RRLL));
        }

        public void vblend_8x32_basecases()
        {
            var n = w256;
            var w = w32;    
            var left =  Vectors.vparts(n,0,1,2,3,4,5,6,7);
            var right = Vectors.vparts(n,8,9,A,B,C,D,E,F);            
            Claim.veq(Vectors.vparts(n,0,9,2,B,4,D,6,F),dvec.vblend(left,right, Blend8x32.LRLRLRLR));
            Claim.veq(Vectors.vparts(n,8,1,A,3,C,5,E,7),dvec.vblend(left,right, Blend8x32.RLRLRLRL));
            Claim.veq(Vectors.vparts(n,0,1,A,B,4,5,E,F),dvec.vblend(left,right, Blend8x32.LLRRLLRR));
            Claim.veq(Vectors.vparts(n,8,9,2,3,C,D,6,7),dvec.vblend(left,right, Blend8x32.RRLLRRLL));

            
            var lrpattern = v32u(Vectors.vbroadcast(n,((ulong)(uint.MaxValue) << 32)));
            for(var i=0; i < 8; i++)
                Claim.eq(vcell(lrpattern,i), gmath.even(i) ? 0u : uint.MaxValue);
            
            var zero = Vectors.vzero<uint>(n);            
            var ones = gvec.vones<uint>(n);
            Claim.veq(lrpattern, dvec.vblend(zero, ones, Blend8x32.LRLRLRLR));            
        }

        public void vblend_32x8_256x32u_basecase()
        {
            var n = w256;
            var x = Vectors.vparts(n,0,1,2,3,4,5,6,7);
            var y = Vectors.vparts(n,8,9,A,B,C,D,E,F);
            var e = Vectors.vparts(n,0,9,2,B,4,D,6,F);
            var o = Vectors.vparts(n,8,1,A,3,C,5,E,7);
            var mEven = Data.blendspec(n,false,n32);
            var mOdd = Data.blendspec(n,true,n32);
            Claim.veq(e,gvec.vblend(x,y,mEven));
            Claim.veq(o,gvec.vblend(x,y,mOdd));
        }

        public void vblend_32x8_256x64u_basecase()
        {
            var n = w256;
            var x = Vectors.vparts(n,0,1,2,3);
            var y = Vectors.vparts(n,4,5,6,7);
            var e = Vectors.vparts(n,0,5,2,7);
            var o = Vectors.vparts(n,4,1,6,3);
            var mEven = Data.blendspec(n,false,n64);
            var mOdd = Data.blendspec(n,true,n64);
            Claim.veq(e,gvec.vblend(x,y,mEven));
            Claim.veq(o,gvec.vblend(x,y,mOdd));

        }

        public void vblend_32x8_256x64u()
        {
            var n = n256;

            var selectors = Random.BitStream().Take(RepCount).ToArray();

            for(var sample=0; sample<RepCount; sample++)
            {
                var xs = Random.Blocks<ulong>(n);
                var x = xs.LoadVector();
                Claim.veq(x,Vectors.vparts(n, xs[0], xs[1], xs[2], xs[3]));

                var ys = Random.Blocks<ulong>(n);
                var y = ys.LoadVector();
                Claim.veq(y,Vectors.vparts(n, ys[0], ys[1], ys[2], ys[3]));

                var m = Data.blendspec(n256,false,n64);
                var es = Blocks.single<ulong>(n);
                for(var i=0; i<es.CellCount; i++)
                    es[i] = gmath.odd(i) ? ys[i] : xs[i];
                var expect = es.LoadVector();
                var actual = gvec.vblend(x,y,m);

                Claim.veq(expect,actual);

            }
        }
    }
}