//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
            
        public void vblend_256x32f_outline()
        {
            var w = n256;
            var x = CpuVector.vpartsf(w, 0f, 1f, 2f, 3f, 4f, 5f, 6f, 7f);
            var y = CpuVector.vpartsf(w, 8f, 9f, 10f, 11f, 12f, 13f, 14f, 15f);
            var spec = CpuVector.vpartsf(w, 0f,-1,0f,-1,0f,-1,0f,-1);
            var z = dinx.vblendv(x,y,spec);
        }

        public void vblend_256x8u_outline()
        {
            var w = n256;
            var x = VPattern.vincrements(w, z8);
            var y = VPattern.vdecrements(w, u8max);
            var spec = v8u(CpuVector.vbroadcast(w, (ushort)((ushort)Pow2.T07 << 8)));
            var z = ginx.vblend(x,y,spec);            
        }        

        public void vblend_128x16u_outline()
        {
            var w = n128;
            var alt = (uint)BitMasks.Msb16x8x1 << 16; 
            dinx.vcover(v16u(CpuVector.vbroadcast(w,alt)), out Vector128<byte> spec);
            var x = VPattern.vincrements(w,z16);
            var y = VPattern.vdecrements(w,u16max);
            var z = ginx.vblend(x,y,spec);
        }

        public void vblend_256x16u_outline()
        {
            var w = n256;
            var altOdd = (uint)BitMasks.Msb16x8x1 << 16; 
            var altEven = (uint)BitMasks.Msb16x8x1; 
            dinx.vcover(v16u(CpuVector.vbroadcast(w,altOdd)), out Vector256<byte> spec);
            var x = VPattern.vincrements(w,z16);
            var y = VPattern.vdecrements(w,u16max);
            var z = ginx.vblend(x,y,spec);
        }

        public void valignr_examples()
        {
            void example1()
            {
                var n = n128;
                var x = CpuVector.vbroadcast(n, (byte)1);
                var y = CpuVector.vbroadcast(n, (byte)2);
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
                var x = CpuVector.vbroadcast(n, (byte)1);
                var y = CpuVector.vbroadcast(n, (byte)2);
                Trace($"x{n}", x.Format(seplanes:true));
                Trace($"y{n}", y.Format(seplanes:true));                
                Trace("valignr/3",ginx.valignr(x,y, 3).Format(seplanes:true));
                Trace("valignr/4",ginx.valignr(x,y, 4).Format(seplanes:true));
                Trace("valignr/5",ginx.valignr(x,y, 5).Format(seplanes:true));
                Trace("valignr/6",ginx.valignr(x,y, 6).Format(seplanes:true));
                Trace("valignr/7",ginx.valignr(x,y, 7).Format(seplanes:true));
                Trace("valignr/8",ginx.valignr(x,y, 8).Format(seplanes:true));
            }

        }

                
        public void vblend_8x16_basecases()
        {
            var n = n128;
            var x = CpuVector.vparts(n, 0,2,4,6,8,A,C,E); 
            var y = CpuVector.vparts(n, 1,3,5,7,9,B,D,F); 
            
            Claim.eq(x, dinx.vblend(x,y, Blend8x16.LLLLLLLL));          
            Claim.eq(y, dinx.vblend(x,y, Blend8x16.RRRRRRRR));
            Claim.eq(CpuVector.vparts(n, 0,2,4,6,9,B,D,F), dinx.vblend(x,y, Blend8x16.LLLLRRRR));
            Claim.eq(CpuVector.vparts(n, 1,3,5,7,8,A,C,E), dinx.vblend(x,y, Blend8x16.RRRRLLLL));

        }

        public void vblend_4x64_basecases()
        {            
            var n = n256;
            var w = n64;
            var left = CpuVector.vparts(n,0,1,2,3);
            var right = CpuVector.vparts(n,4,5,6,7);

            Claim.eq(CpuVector.vparts(n,0,5,2,7),dinx.vblend(left, right, Blend4x64.LRLR));    
            Claim.eq(CpuVector.vparts(n,4,1,6,3),dinx.vblend(left, right, Blend4x64.RLRL));    
            Claim.eq(CpuVector.vparts(n,0,1,2,3),dinx.vblend(left, right, Blend4x64.LLLL));    
            Claim.eq(CpuVector.vparts(n,4,5,6,7),dinx.vblend(left, right, Blend4x64.RRRR));    
        }

        public void vblend_2x64_basecases()
        {
            var n = n128;
            var w = n64;
            var left =  CpuVector.vparts(n,0,1);
            var right = CpuVector.vparts(n,4,5);
            Claim.eq(CpuVector.vparts(n, 0, 5),dinx.vblend(left, right, Blend2x64.LR));
            Claim.eq(CpuVector.vparts(n, 4, 1),dinx.vblend(left, right, Blend2x64.RL));
            Claim.eq(CpuVector.vparts(n, 0, 1),dinx.vblend(left, right, Blend2x64.LL));
            Claim.eq(CpuVector.vparts(n, 4, 5),dinx.vblend(left, right, Blend2x64.RR));
        }

        public void vblend_4x32_basecases()
        {
            var n = n128;
            var w = n32;
            var left =  CpuVector.vparts(n,0,1,2,3);
            var right = CpuVector.vparts(n,4,5,6,7);
            Claim.eq(CpuVector.vparts(n,0,5,2,7), dinx.vblend(left,right,Blend4x32.LRLR));
            Claim.eq(CpuVector.vparts(n,4,1,6,3), dinx.vblend(left,right,Blend4x32.RLRL));
            Claim.eq(CpuVector.vparts(n,0,1,6,7), dinx.vblend(left,right,Blend4x32.LLRR));
            Claim.eq(CpuVector.vparts(n,4,5,2,3), dinx.vblend(left,right,Blend4x32.RRLL));
        }

        public void vblend_8x32_basecases()
        {
            var n = n256;
            var w = n32;    
            var left =  CpuVector.vparts(n,0,1,2,3,4,5,6,7);
            var right = CpuVector.vparts(n,8,9,A,B,C,D,E,F);            
            Claim.eq(CpuVector.vparts(n,0,9,2,B,4,D,6,F),dinx.vblend(left,right, Blend8x32.LRLRLRLR));
            Claim.eq(CpuVector.vparts(n,8,1,A,3,C,5,E,7),dinx.vblend(left,right, Blend8x32.RLRLRLRL));
            Claim.eq(CpuVector.vparts(n,0,1,A,B,4,5,E,F),dinx.vblend(left,right, Blend8x32.LLRRLLRR));
            Claim.eq(CpuVector.vparts(n,8,9,2,3,C,D,6,7),dinx.vblend(left,right, Blend8x32.RRLLRRLL));

            
            var lrpattern = v32u(CpuVector.vbroadcast(n,((ulong)(uint.MaxValue) << 32)));
            for(var i=0; i < 8; i++)
                Claim.eq(vcell(lrpattern,i), even(i) ? 0u : uint.MaxValue);
            
            var zero = CpuVector.vzero<uint>(n);            
            var ones = VPattern.vones<uint>(n);
            Claim.eq(lrpattern, dinx.vblend(zero, ones, Blend8x32.LRLRLRLR));
            
        }

        public void vblend_32x8_256x32u_basecase()
        {
            var n = n256;
            var w = n32;
            var x = CpuVector.vparts(n,0,1,2,3,4,5,6,7);
            var y = CpuVector.vparts(n,8,9,A,B,C,D,E,F);
            var e = CpuVector.vparts(n,0,9,2,B,4,D,6,F);
            var o = CpuVector.vparts(n,8,1,A,3,C,5,E,7);
            var mEven = VData.blendspec(n,false,w);
            var mOdd = VData.blendspec(n,true,w);
            Claim.eq(e,ginx.vblend(x,y,mEven));
            Claim.eq(o,ginx.vblend(x,y,mOdd));
        }

        public void vblend_32x8_256x64u_basecase()
        {
            var n = n256;
            var w = n64;
            var x = CpuVector.vparts(n,0,1,2,3);
            var y = CpuVector.vparts(n,4,5,6,7);
            var e = CpuVector.vparts(n,0,5,2,7);
            var o = CpuVector.vparts(n,4,1,6,3);
            var mEven = VData.blendspec(n,false,w);
            var mOdd = VData.blendspec(n,true,w);
            Claim.eq(e,ginx.vblend(x,y,mEven));
            Claim.eq(o,ginx.vblend(x,y,mOdd));

        }

        public void vblend_32x8_256x64u()
        {
            var n = n256;

            var selectors = Random.Bits(RepCount).ToArray();

            for(var sample=0; sample<RepCount; sample++)
            {
                var xs = Random.Blocks<ulong>(n);
                var x = xs.LoadVector();
                Claim.eq(x,CpuVector.vparts(n, xs[0], xs[1], xs[2], xs[3]));

                var ys = Random.Blocks<ulong>(n);
                var y = ys.LoadVector();
                Claim.eq(y,CpuVector.vparts(n, ys[0], ys[1], ys[2], ys[3]));

                var m = VData.blendspec(n256,false,n64);

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