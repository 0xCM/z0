//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static HexConst;

    public class t_vblend : t_vinx<t_vblend>
    {
            
        // |  0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59 60 61 62 63 |
        // |  0 33  2 35  4 37  6 39  8 41 10 43 12 45 14 47 16 49 18 51 20 53 22 55 24 57 26 59 28 61 30 63 32  1 34  3 36  5 38  7 40  9 42 11 44 13 46 15 48 17 50 19 52 21 54 23 56 25 58 27 60 29 62 31 |
        // i = 0 ... 63
        // j = 0 ... 63            
        // p(i) = i, for i % 2 == 0
        // p(i) = j => p(j) = i for i%2 != 0


        public void vblend_256x32f_outline()
        {
            var w = n256;
            var x = vbuild.partsf(w, 0f, 1f, 2f, 3f, 4f, 5f, 6f, 7f);
            var y = vbuild.partsf(w, 8f, 9f, 10f, 11f, 12f, 13f, 14f, 15f);
            var spec = vbuild.partsf(w, 0f,-1,0f,-1,0f,-1,0f,-1);
            var z = dinx.vblendv(x,y,spec);
        }

        public void vblend_256x8u_outline()
        {
            var w = n256;
            var x = vbuild.increments(w, z8);
            var y = vbuild.decrements(w, z8max);
            var spec = v8u(vbuild.broadcast(w, (ushort)((ushort)Pow2.T07 << 8)));
            var z = ginx.vblend(x,y,spec);
            
        }        

        public void vblend_128x16u_outline()
        {
            var w = n128;
            var alt = (uint)BitMasks.Msb16x8 << 16; 
            dinx.vcover(v16u(vbuild.broadcast(w,alt)), out Vector128<byte> spec);
            var x = vbuild.increments(w,z16);
            var y = vbuild.decrements(w,z16max);
            var z = ginx.vblend(x,y,spec);


        }

        public void vblend_256x16u_outline()
        {
            var w = n256;
            var altOdd = (uint)BitMasks.Msb16x8 << 16; 
            var altEven = (uint)BitMasks.Msb16x8; 
            dinx.vcover(v16u(vbuild.broadcast(w,altOdd)), out Vector256<byte> spec);
            var x = vbuild.increments(w,z16);
            var y = vbuild.decrements(w,z16max);
            var z = ginx.vblend(x,y,spec);

        }

        public void valignr_examples()
        {
            void example1()
            {
                var n = n128;
                var x = vbuild.broadcast(n, (byte)1);
                var y = vbuild.broadcast(n, (byte)2);
                Trace($"x{n}", x.Format());
                Trace($"y{n}", y.Format());                
                Trace("valignr/3",ginx.valignr(x,y, 3).Format());
                Trace("valignr/4",ginx.valignr(x,y, 4).Format());
                Trace("valignr/5",ginx.valignr(x,y, 5).Format());
                Trace("valignr/6",ginx.valignr(x,y, 6).Format());
                Trace("valignr/7",ginx.valignr(x,y, 7).Format());
                Trace("valignr/8",ginx.valignr(x,y, 8).Format());
            }

            void example2()
            {
                var n = n256;
                var x = vbuild.broadcast(n, (byte)1);
                var y = vbuild.broadcast(n, (byte)2);
                Trace($"x{n}", x.Format(seplanes:true));
                Trace($"y{n}", y.Format(seplanes:true));                
                Trace("valignr/3",ginx.valignr(x,y, 3).Format(seplanes:true));
                Trace("valignr/4",ginx.valignr(x,y, 4).Format(seplanes:true));
                Trace("valignr/5",ginx.valignr(x,y, 5).Format(seplanes:true));
                Trace("valignr/6",ginx.valignr(x,y, 6).Format(seplanes:true));
                Trace("valignr/7",ginx.valignr(x,y, 7).Format(seplanes:true));
                Trace("valignr/8",ginx.valignr(x,y, 8).Format(seplanes:true));
            }

            example1();
            example2();
        }

        public void vblend_permute()
        {

            // x: 0 1 2 3 4 5 6 7  
            // y: 8 9 A B C D E F
            
            // paired blends
            // a: 0 9 2 B 4 D 6 F    (LRLRLRLR) (x,y)
            // b: 8 1 A 3 C 5 E 7    (RLRLRLRL) (x,y)
            
            // formatted as a permutation
            // 0 1 2 3 4 5 6 7 8 9 A B C D E F
            // 0 9 2 B 4 D 6 F 8 1 A 3 C 5 E 7 
            
            // As a product of transpositions
            // (1 9)(3 B)(5 D)(7 F)

            var n = n128;
            var x = vbuild.parts(n, 0,1,2,3,4,5,6,7); 
            var y = vbuild.parts(n, 8,9,A,B,C,D,E,F); 

            var a = dinx.vblend(x,y, Blend8x16.LRLRLRLR);
            var b = dinx.vblend(x,y, Blend8x16.RLRLRLRL);
            var c = vbuild.parts(n, 0,9,2,B,4,D,6,F);
            var d = vbuild.parts(n, 8,1,A,3,C,5,E,7);
            Claim.eq(a,c);
            Claim.eq(b,d);

            var perm = Perms.natural(n16, (1,9), (3,B), (5,D), (7,F));
            var bg = perm.ToBitGrid();
            for(var i=0; i< bg.RowCount; i++)
                Claim.eq(bg.Row(i).As<byte>(), perm[i]);

            var swaps = perm.CalcSwaps().ToArray();
            Claim.eq(4,swaps.Length);

            Claim.eq(swaps[0].i, 1);
            Claim.eq(swaps[0].j, 9);
            Claim.eq(swaps[1].i, 3);
            Claim.eq(swaps[1].j, B);
            Claim.eq(swaps[2].i, 5);
            Claim.eq(swaps[2].j, D);
            Claim.eq(swaps[3].i, 7);
            Claim.eq(swaps[3].j, F);

            
            void report1()
            {
                for(var i=0; i< swaps.Length; i++)
                    Trace($"{swaps[i]}");
            }            

            void report2()
            {
                 Trace(perm.Format());
                 //Trace(bg.Format(showrow:true));

            }        

            // for(var i=0; i<bgA.RowCount; i++)
            //     Trace(bgA.Row(i).Format());
            



        }
        

        
        public void vblend_8x16_basecases()
        {
            var n = n128;
            var x = vbuild.parts(n, 0,2,4,6,8,A,C,E); 
            var y = vbuild.parts(n, 1,3,5,7,9,B,D,F); 
            
            Claim.eq(x, dinx.vblend(x,y, Blend8x16.LLLLLLLL));          
            Claim.eq(y, dinx.vblend(x,y, Blend8x16.RRRRRRRR));
            Claim.eq(vbuild.parts(n, 0,2,4,6,9,B,D,F), dinx.vblend(x,y, Blend8x16.LLLLRRRR));
            Claim.eq(vbuild.parts(n, 1,3,5,7,8,A,C,E), dinx.vblend(x,y, Blend8x16.RRRRLLLL));

        }

        public void vblend_4x64_basecases()
        {            
            var n = n256;
            var w = n64;
            var left = vbuild.parts(n,0,1,2,3);
            var right = vbuild.parts(n,4,5,6,7);

            Claim.eq(vbuild.parts(n,0,5,2,7),dinx.vblend(left, right, Blend4x64.LRLR));    
            Claim.eq(vbuild.parts(n,4,1,6,3),dinx.vblend(left, right, Blend4x64.RLRL));    
            Claim.eq(vbuild.parts(n,0,1,2,3),dinx.vblend(left, right, Blend4x64.LLLL));    
            Claim.eq(vbuild.parts(n,4,5,6,7),dinx.vblend(left, right, Blend4x64.RRRR));    
        }

        public void vblend_2x64_basecases()
        {
            var n = n128;
            var w = n64;
            var left =  vbuild.parts(n,0,1);
            var right = vbuild.parts(n,4,5);
            Claim.eq(vbuild.parts(n, 0, 5),dinx.vblend(left, right, Blend2x64.LR));
            Claim.eq(vbuild.parts(n, 4, 1),dinx.vblend(left, right, Blend2x64.RL));
            Claim.eq(vbuild.parts(n, 0, 1),dinx.vblend(left, right, Blend2x64.LL));
            Claim.eq(vbuild.parts(n, 4, 5),dinx.vblend(left, right, Blend2x64.RR));
        }

        public void vblend_4x32_basecases()
        {
            var n = n128;
            var w = n32;
            var left =  vbuild.parts(n,0,1,2,3);
            var right = vbuild.parts(n,4,5,6,7);
            Claim.eq(vbuild.parts(n,0,5,2,7), dinx.vblend(left,right,Blend4x32.LRLR));
            Claim.eq(vbuild.parts(n,4,1,6,3), dinx.vblend(left,right,Blend4x32.RLRL));
            Claim.eq(vbuild.parts(n,0,1,6,7), dinx.vblend(left,right,Blend4x32.LLRR));
            Claim.eq(vbuild.parts(n,4,5,2,3), dinx.vblend(left,right,Blend4x32.RRLL));
        }

        public void vblend_8x32_basecases()
        {
            var n = n256;
            var w = n32;    
            var left =  vbuild.parts(n,0,1,2,3,4,5,6,7);
            var right = vbuild.parts(n,8,9,A,B,C,D,E,F);            
            Claim.eq(vbuild.parts(n,0,9,2,B,4,D,6,F),dinx.vblend(left,right, Blend8x32.LRLRLRLR));
            Claim.eq(vbuild.parts(n,8,1,A,3,C,5,E,7),dinx.vblend(left,right, Blend8x32.RLRLRLRL));
            Claim.eq(vbuild.parts(n,0,1,A,B,4,5,E,F),dinx.vblend(left,right, Blend8x32.LLRRLLRR));
            Claim.eq(vbuild.parts(n,8,9,2,3,C,D,6,7),dinx.vblend(left,right, Blend8x32.RRLLRRLL));

            
            var lrpattern = v32u(vbuild.broadcast(n,((ulong)(uint.MaxValue) << 32)));
            for(var i=0; i < 8; i++)
                Claim.eq(vcell(lrpattern,i), even(i) ? 0u : uint.MaxValue);
            
            var zero = vbuild.zero<uint>(n);            
            var ones = vbuild.ones<uint>(n);
            Claim.eq(lrpattern, dinx.vblend(zero, ones, Blend8x32.LRLRLRLR));
            
        }

        public void vblend_32x8_256x32u_basecase()
        {
            var n = n256;
            var w = n32;
            var x = vbuild.parts(n,0,1,2,3,4,5,6,7);
            var y = vbuild.parts(n,8,9,A,B,C,D,E,F);
            var e = vbuild.parts(n,0,9,2,B,4,D,6,F);
            var o = vbuild.parts(n,8,1,A,3,C,5,E,7);
            var mEven = VData.blend(n,false,w);
            var mOdd = VData.blend(n,true,w);
            Claim.eq(e,ginx.vblend(x,y,mEven));
            Claim.eq(o,ginx.vblend(x,y,mOdd));

        }

        public void vblend_32x8_256x64u_basecase()
        {
            var n = n256;
            var w = n64;
            var x = vbuild.parts(n,0,1,2,3);
            var y = vbuild.parts(n,4,5,6,7);
            var e = vbuild.parts(n,0,5,2,7);
            var o = vbuild.parts(n,4,1,6,3);
            var mEven = VData.blend(n,false,w);
            var mOdd = VData.blend(n,true,w);
            Claim.eq(e,ginx.vblend(x,y,mEven));
            Claim.eq(o,ginx.vblend(x,y,mOdd));

        }

        public void vblend_32x8_256x64u()
        {
            var n = n256;

            var selectors = Random.Bits(SampleSize).ToArray();

            for(var sample=0; sample<SampleSize; sample++)
            {
                var xs = Random.Blocks<ulong>(n);
                var x = xs.LoadVector();
                Claim.eq(x,vbuild.parts(n, xs[0], xs[1], xs[2], xs[3]));

                var ys = Random.Blocks<ulong>(n);
                var y = ys.LoadVector();
                Claim.eq(y,vbuild.parts(n, ys[0], ys[1], ys[2], ys[3]));

                var m = VData.blend(n256,false,n64);

                var es = DataBlocks.single<ulong>(n);
                for(var i=0; i<es.CellCount; i++)
                    es[i] = odd(i) ? ys[i] : xs[i];
                var expect = es.LoadVector();
                var actual = ginx.vblend(x,y,m);

                Claim.eq(expect,actual);

            }
        }
    }
}