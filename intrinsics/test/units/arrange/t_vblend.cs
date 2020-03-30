//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;

    using static Nats;
    using static vgeneric;
    using static HexConst;
    using K = Core;

    public class t_vblend : t_vinx<t_vblend>
    {            
        public void vblend_256x32f_outline()
        {
            var w = K.n256;
            var x = vgeneric.vpartsf(w, 0f, 1f, 2f, 3f, 4f, 5f, 6f, 7f);
            var y = vgeneric.vpartsf(w, 8f, 9f, 10f, 11f, 12f, 13f, 14f, 15f);
            var spec = vgeneric.vpartsf(w, 0f,-1,0f,-1,0f,-1,0f,-1);
            var z = dvec.vblendv(x,y,spec);
        }

        public void vblend_256x8u_outline()
        {
            var w = K.n256;
            var x = gvec.vinc(w, K.z8);
            var y = gvec.vdec(w, u8max);
            var spec = v8u(vgeneric.vbroadcast(w, (ushort)((ushort)Pow2.T07 << 8)));
            var z = gvec.vblend(x,y,spec);            
        }        

        public void vblend_128x16u_outline()
        {
            var w = K.n128;
            var alt = (uint)BitMasks.Msb16x8x1 << 16; 
            dvec.vcover(v16u(vgeneric.vbroadcast(w,alt)), out Vector128<byte> spec);
            var x = gvec.vinc(w,K.z16);
            var y = gvec.vdec(w,u16max);
            var z = gvec.vblend(x,y,spec);
        }

        public void vblend_256x16u_outline()
        {
            var w = K.n256;
            var altOdd = (uint)BitMasks.Msb16x8x1 << 16; 
            var altEven = (uint)BitMasks.Msb16x8x1; 
            dvec.vcover(v16u(vgeneric.vbroadcast(w,altOdd)), out Vector256<byte> spec);
            var x = gvec.vinc(w,K.z16);
            var y = gvec.vdec(w,u16max);
            var z = gvec.vblend(x,y,spec);
        }

        public void valignr_examples()
        {
            void example1()
            {
                var n = K.n128;
                var x = vgeneric.vbroadcast(n, (byte)1);
                var y = vgeneric.vbroadcast(n, (byte)2);
                trace($"x{n}", x.FormatAsList());
                trace($"y{n}", y.FormatAsList());                
                trace("valignr/3",gvec.valignr(x,y, 3).FormatAsList());
                trace("valignr/4",gvec.valignr(x,y, 4).FormatAsList());
                trace("valignr/5",gvec.valignr(x,y, 5).FormatAsList());
                trace("valignr/6",gvec.valignr(x,y, 6).FormatAsList());
                trace("valignr/7",gvec.valignr(x,y, 7).FormatAsList());
                trace("valignr/8",gvec.valignr(x,y, 8).FormatAsList());
            }

            void example2()
            {
                var n = K.n256;
                var x = vgeneric.vbroadcast(n, (byte)1);
                var y = vgeneric.vbroadcast(n, (byte)2);
                trace($"x{n}", x.Format(seplanes:true));
                trace($"y{n}", y.Format(seplanes:true));                
                trace("valignr/3",gvec.valignr(x,y, 3).Format(seplanes:true));
                trace("valignr/4",gvec.valignr(x,y, 4).Format(seplanes:true));
                trace("valignr/5",gvec.valignr(x,y, 5).Format(seplanes:true));
                trace("valignr/6",gvec.valignr(x,y, 6).Format(seplanes:true));
                trace("valignr/7",gvec.valignr(x,y, 7).Format(seplanes:true));
                trace("valignr/8",gvec.valignr(x,y, 8).Format(seplanes:true));
            }

        }

                
        public void vblend_8x16_basecases()
        {
            var n = K.n128;
            var x = vgeneric.vparts(n, 0,2,4,6,8,A,C,E); 
            var y = vgeneric.vparts(n, 1,3,5,7,9,B,D,F); 
            
            Claim.eq(x, dvec.vblend(x,y, Blend8x16.LLLLLLLL));          
            Claim.eq(y, dvec.vblend(x,y, Blend8x16.RRRRRRRR));
            Claim.eq(vgeneric.vparts(n, 0,2,4,6,9,B,D,F), dvec.vblend(x,y, Blend8x16.LLLLRRRR));
            Claim.eq(vgeneric.vparts(n, 1,3,5,7,8,A,C,E), dvec.vblend(x,y, Blend8x16.RRRRLLLL));

        }

        public void vblend_4x64_basecases()
        {            
            var n = K.n256;
            var w = K.w64;
            var left = vgeneric.vparts(n,0,1,2,3);
            var right = vgeneric.vparts(n,4,5,6,7);

            Claim.eq(vgeneric.vparts(n,0,5,2,7),dvec.vblend(left, right, Blend4x64.LRLR));    
            Claim.eq(vgeneric.vparts(n,4,1,6,3),dvec.vblend(left, right, Blend4x64.RLRL));    
            Claim.eq(vgeneric.vparts(n,0,1,2,3),dvec.vblend(left, right, Blend4x64.LLLL));    
            Claim.eq(vgeneric.vparts(n,4,5,6,7),dvec.vblend(left, right, Blend4x64.RRRR));    
        }

        public void vblend_2x64_basecases()
        {
            var n = K.w128;
            var w = K.w64;
            var left =  vgeneric.vparts(n,0,1);
            var right = vgeneric.vparts(n,4,5);
            Claim.eq(vgeneric.vparts(n, 0, 5),dvec.vblend(left, right, Blend2x64.LR));
            Claim.eq(vgeneric.vparts(n, 4, 1),dvec.vblend(left, right, Blend2x64.RL));
            Claim.eq(vgeneric.vparts(n, 0, 1),dvec.vblend(left, right, Blend2x64.LL));
            Claim.eq(vgeneric.vparts(n, 4, 5),dvec.vblend(left, right, Blend2x64.RR));
        }

        public void vblend_4x32_basecases()
        {
            var n = K.w128;
            var w = K.w32;
            var left =  vgeneric.vparts(n,0,1,2,3);
            var right = vgeneric.vparts(n,4,5,6,7);
            Claim.eq(vgeneric.vparts(n,0,5,2,7), dvec.vblend(left,right,Blend4x32.LRLR));
            Claim.eq(vgeneric.vparts(n,4,1,6,3), dvec.vblend(left,right,Blend4x32.RLRL));
            Claim.eq(vgeneric.vparts(n,0,1,6,7), dvec.vblend(left,right,Blend4x32.LLRR));
            Claim.eq(vgeneric.vparts(n,4,5,2,3), dvec.vblend(left,right,Blend4x32.RRLL));
        }

        public void vblend_8x32_basecases()
        {
            var n = K.w256;
            var w = K.w32;    
            var left =  vgeneric.vparts(n,0,1,2,3,4,5,6,7);
            var right = vgeneric.vparts(n,8,9,A,B,C,D,E,F);            
            Claim.eq(vgeneric.vparts(n,0,9,2,B,4,D,6,F),dvec.vblend(left,right, Blend8x32.LRLRLRLR));
            Claim.eq(vgeneric.vparts(n,8,1,A,3,C,5,E,7),dvec.vblend(left,right, Blend8x32.RLRLRLRL));
            Claim.eq(vgeneric.vparts(n,0,1,A,B,4,5,E,F),dvec.vblend(left,right, Blend8x32.LLRRLLRR));
            Claim.eq(vgeneric.vparts(n,8,9,2,3,C,D,6,7),dvec.vblend(left,right, Blend8x32.RRLLRRLL));

            
            var lrpattern = v32u(vgeneric.vbroadcast(n,((ulong)(uint.MaxValue) << 32)));
            for(var i=0; i < 8; i++)
                Claim.eq(vcell(lrpattern,i), parity.even(i) ? 0u : uint.MaxValue);
            
            var zero = vgeneric.vzero<uint>(n);            
            var ones = gvec.vones<uint>(n);
            Claim.eq(lrpattern, dvec.vblend(zero, ones, Blend8x32.LRLRLRLR));            
        }

        public void vblend_32x8_256x32u_basecase()
        {
            var n = K.w256;
            var x = vgeneric.vparts(n,0,1,2,3,4,5,6,7);
            var y = vgeneric.vparts(n,8,9,A,B,C,D,E,F);
            var e = vgeneric.vparts(n,0,9,2,B,4,D,6,F);
            var o = vgeneric.vparts(n,8,1,A,3,C,5,E,7);
            var mEven = Data.blendspec(n,false,n32);
            var mOdd = Data.blendspec(n,true,n32);
            Claim.eq(e,gvec.vblend(x,y,mEven));
            Claim.eq(o,gvec.vblend(x,y,mOdd));
        }

        public void vblend_32x8_256x64u_basecase()
        {
            var n = K.w256;
            var x = vgeneric.vparts(n,0,1,2,3);
            var y = vgeneric.vparts(n,4,5,6,7);
            var e = vgeneric.vparts(n,0,5,2,7);
            var o = vgeneric.vparts(n,4,1,6,3);
            var mEven = Data.blendspec(n,false,n64);
            var mOdd = Data.blendspec(n,true,n64);
            Claim.eq(e,gvec.vblend(x,y,mEven));
            Claim.eq(o,gvec.vblend(x,y,mOdd));

        }

        public void vblend_32x8_256x64u()
        {
            var n = K.n256;

            var selectors = Random.BitStream().Take(RepCount).ToArray();

            for(var sample=0; sample<RepCount; sample++)
            {
                var xs = Random.Blocks<ulong>(n);
                var x = xs.LoadVector();
                Claim.eq(x,vgeneric.vparts(n, xs[0], xs[1], xs[2], xs[3]));

                var ys = Random.Blocks<ulong>(n);
                var y = ys.LoadVector();
                Claim.eq(y,vgeneric.vparts(n, ys[0], ys[1], ys[2], ys[3]));

                var m = Data.blendspec(n256,false,n64);
                var es = Blocks.single<ulong>(n);
                for(var i=0; i<es.CellCount; i++)
                    es[i] = parity.odd(i) ? ys[i] : xs[i];
                var expect = es.LoadVector();
                var actual = gvec.vblend(x,y,m);

                Claim.eq(expect,actual);

            }
        }
    }
}