//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    using static root;
    using static Nats;
    using static vgeneric;

    public class t_vblendp : UnitTest<t_vblendp>
    {
        bool EmitInfo
            => false;

        public void vblendp_perm32_g128x8u()
            => vblendp_check(n128, n32, BitMasks.Msb16x16x1, z8);

        public void vblendp_perm16_g128x16u()
            => vblendp_check(n128, n16, BitMasks.Msb32x32x1, z16);

        public void vblendp_perm8_g128x32u()
            => vblendp_check(n128, n8, BitMasks.Msb64x64x1, z32);

        public void vblendp_perm64_g256x8u()
            => vblendp_check(n256, n64, BitMasks.Msb16x16x1, z8);

        public void vblendp_perm32_g256x16u()
            => vblendp_check(n256, n32, BitMasks.Msb32x32x1, z16);

        public void vblendp_perm16_g256x32u()
            => vblendp_check(n256, n16, BitMasks.Msb64x64x1, z32);


        static string describe<F,D,T,S>(IMaskSpec<F,D,T> maskspec, S sample, Vector512<T> source, Vector512<T> target)
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
            where S : unmanaged
        {
            var description = text.factory.Builder();
            var indent = "/// ";
            var bits = BitString.scalar(sample).Format(specifier:true);
            var header = $"{indent}512x{bitsize(default(T))}, {maskspec}, {bits}";            
            description.AppendLine(header);
            description.AppendLine($"{indent}source: {source.Format(pad:2)}");
            description.AppendLine($"{indent}target: {target.Format(pad:2)}");            
            return description.ToString();
        }

        /// <summary>
        /// 512x64, msb, f:2, d:1, t:64u, 0b10101010
        /// source: [ 0,  1,  2,  3,  4,  5,  6,  7]
        /// target: [ 0,  5,  2,  7,  4,  1,  6,  3]
        /// </summary>
        public void vblendp_512x64_Msb2x1()
        {
            var w = n512;
            var t = z64;
            var maskspec = MaskSpecs.msb(n2,n1,t);

            var source = gvec.vincrements(w,t);
            var blendspec = gvec.vbroadcast(n256, BitMask.mask(maskspec), maxval(t));
            var target = gvec.vblendp(source, blendspec);
            var expect = vgeneric.vparts(w,0,5,2,7,4,1,6,3);
            Claim.yea(gvec.vsame(expect,target));

            var descrition = describe(maskspec, BitMask.mask(maskspec.As(z8)), source,target);
            if(EmitInfo)
                Notify(descrition);
            
        }

        /// <summary>
        /// 512x64, msb, f:4, d:1, t:64u, 0b10001000
        /// source: [ 0,  1,  2,  3,  4,  5,  6,  7]
        /// target: [ 0,  1,  2,  7,  4,  5,  6,  3]
        /// </summary>
        public void vblendp_512x64_Msb4x1()
        {
            var w = n512;
            var t = z64;
            var maskspec = MaskSpecs.msb(n4,n1,t);

            var source = gvec.vincrements(w,t);
            var blendspec = gvec.vbroadcast(n256, BitMask.mask(maskspec), maxval(t));
            var target = gvec.vblendp(source, blendspec);
            var expect = vgeneric.vparts(w,0,1,2,7,4,5,6,3);
            Claim.yea(gvec.vsame(expect,target));

            var descrition = describe(maskspec, BitMask.mask(maskspec.As(z8)), source,target);
            if(EmitInfo)
                Notify(descrition);
            
        }

        /// <summary>
        /// 512x64, lsb, f:2, d:1, t:64u, 0b01010101
        /// source: [ 0,  1,  2,  3,  4,  5,  6,  7]
        /// target: [ 4,  1,  6,  3,  0,  5,  2,  7]
        /// </summary>
        public void vblendp_512x64_Lsb2x1()
        {
            var w = n512;
            var t = z64;
            var maskspec = MaskSpecs.lsb(n2,n1,t);

            var source = gvec.vincrements(w,t);
            var blendspec = gvec.vbroadcast(n256, BitMask.mask(maskspec), maxval(t));
            var target = gvec.vblendp(source, blendspec);
            var expect = vgeneric.vparts(w,4,1,6,3,0,5,2,7);
            Claim.yea(gvec.vsame(expect,target));

            var descrition = describe(maskspec, BitMask.mask(maskspec.As(z8)), source,target);
            if(EmitInfo)
                Notify(descrition);            
        }

        /// <summary>
        /// 512x64, jsb, f:8, d:2, t:64u, 0b11000011
        /// source: [ 0,  1,  2,  3,  4,  5,  6,  7]
        /// target: [ 4,  5,  2,  3,  0,  1,  6,  7]
        /// </summary>
        public void vblendp_512x64_Jsb8x2()
        {
            var w = n512;
            var t = z64;
            var maskspec = MaskSpecs.jsb(n8,n2,t);

            var source = gvec.vincrements(w,t);
            var blendspec = gvec.vbroadcast(n256, BitMask.mask(maskspec), maxval(t));
            var target = gvec.vblendp(source, blendspec);
            var expect = vgeneric.vparts(w,4,5,2,3,0,1,6,7);
            Claim.yea(gvec.vsame(expect,target));

            var descrition = describe(maskspec, BitMask.mask(maskspec.As(z8)), source,target);
            if(EmitInfo)
                Notify(descrition);            
        }

        /// <summary>
        /// 512x32, jsb, f:8, d:2, t:32u, 0b1100001111000011
        /// source: [ 0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15]
        /// target: [ 8,  9,  2,  3,  4,  5, 14, 15,  0,  1, 10, 11, 12, 13,  6,  7]
        /// </summary>
        public void vblendp_512x32_Jsb8x2()
        {
            var w = n512;
            var t = z32;
            var maskspec = MaskSpecs.jsb(n8,n2,t);

            var source = gvec.vincrements(w,t);
            var blendspec = gvec.vbroadcast(n256, BitMask.mask(maskspec), maxval(t));
            var target = gvec.vblendp(source, blendspec);
            var expect = vgeneric.vparts(w,8,  9,  2,  3,  4,  5, 14, 15,  0,  1, 10, 11, 12, 13,  6,  7);
            
            Claim.yea(gvec.vsame(expect,target));

            var descrition = describe(maskspec, BitMask.mask(maskspec.As(z16)), source,target);
            if(EmitInfo)
                Notify(descrition);            
        }

        /// <summary>
        /// 512x16, jsb, f:8, d:2, t:16u, 0b11000011110000111100001111000011
        /// source: [ 0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31]
        /// target: [16, 17,  2,  3,  4,  5, 22, 23, 24, 25, 10, 11, 12, 13, 30, 31,  0,  1, 18, 19, 20, 21,  6,  7,  8,  9, 26, 27, 28, 29, 14, 15]
        /// </summary>
        public void vblendp_512x16_Jsb8x2()
        {
            var w = n512;
            var t = z16;
            var maskspec = MaskSpecs.jsb(n8,n2,t);

            var source = gvec.vincrements(w,t);
            var blendspec = gvec.vbroadcast(n256, BitMask.mask(maskspec), maxval(t));
            var target = gvec.vblendp(source, blendspec);
            var expect = vgeneric.vparts(w,16, 17,  2,  3,  4,  5, 22, 23, 24, 25, 10, 11, 12, 13, 30, 31,  0,  1, 18, 19, 20, 21,  6,  7,  8,  9, 26, 27, 28, 29, 14, 15);
            Claim.eq(expect,target);

            var descrition = describe(maskspec, BitMask.mask(maskspec.As(z32)), source,target);
            if(EmitInfo)
                Notify(descrition);            
        }

        /// <summary>
        /// 512x8, jsb, f:8, d:2, t:8u, 0b1100001111000011110000111100001111000011110000111100001111000011
        /// source: [ 0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63]
        /// target: [32, 33,  2,  3,  4,  5, 38, 39,  8,  9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31,  0,  1, 34, 35, 36, 37,  6,  7, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63]
        /// </summary>
        public void vblendp_512x8_Jsb8x2_outline()
        {
            var w = n512;
            var t = z8;
            var maskspec = MaskSpecs.jsb(n8,n2,t);

            var source = gvec.vincrements(w,t);
            var blendspec = gvec.vbroadcast(n256, BitMask.mask(maskspec), maxval(t));
            var target = gvec.vblendp(source, blendspec);

            var descrition = describe(maskspec, BitMask.mask(maskspec.As(z64)), source,target);
            if(EmitInfo)
                Notify(descrition);            
        }

        public void vblendp_512x8_Jsb8x2()
        {
            var w = n512;
            var t = z8;
            var maskspec = MaskSpecs.jsb(n8,n2,t);
            var blendspec = gvec.vbroadcast(n256, BitMask.mask(maskspec), maxval(t));

            var maskbits = BitMask.mask(maskspec.As(z64));

            for(var samples=0; samples< RepCount; samples++)
            {
                var source = Random.CpuVector(w,t);                
                var target = gvec.vblendp(source,blendspec);
                

            }

        }

        public void vblendp_perm64_256x8u()
        {
            var w = n256;
            var t = z8;
            var n = n64;
            var tf = 4;
            var pick = BitMask.msb(n1,n1,t);
            var pattern = Blocks.single(w,t);
            for(var i=0; i< pattern.CellCount; i++)
                pattern[i] = (i % tf == 0) ? pick : t;
            
            
            var spec = pattern.LoadVector();
            var x = gvec.vinc(w, t);
            var y = gvec.vadd(x, gmath.add(x.LastCell(), one(t)));            
            var z = gvec.vblendp(x,y,spec);       


            var dst = Blocks.alloc(w,2,t);
            gvec.vlo(z).StoreTo(dst,0);
            gvec.vhi(z).StoreTo(dst,1);

            var perm = Permute.define(dst.Data);            
            for(var i=0; i< perm.Length; i++)
            {
                var identity = i == perm[i];
                if(!identity)
                {
                    var j = perm[i];
                    var k = perm[j];
                    Claim.eq(i,k);
                }
            }
        }

        static Vector128<T> swaps_pattern<T>(N128 w, int tf, T t = default)
            where T : unmanaged
        {
            var pick = BitMask.msb(n1,n1,t);
            var pattern = Blocks.single(w,t);
            for(var i=0; i< pattern.CellCount; i++)
                pattern[i] = (i % tf == 0) ? pick : t;
            return pattern.LoadVector();
        }

        static T enabled<T>(T t = default)
            where T : unmanaged
                => BitMask.msb(n1,n1,t);

        static Vector128<T> rrll_pattern<T>(N128 w, T t = default)
            where T : unmanaged
                => gvec.broadcast(BitMask.even(n2,n2,z64), enabled(t), Blocks.single(w,t)).LoadVector();

        static Vector128<T> llrr_pattern<T>(N128 w, T t = default)
            where T : unmanaged
                => gvec.broadcast(BitMask.odd(n2,n2,z64), enabled(t), Blocks.single(w,t)).LoadVector();

        static Vector128<T> rl_pattern<T>(N128 w, T t = default)
            where T : unmanaged
                => gvec.broadcast(BitMask.lsb(n2,n1,z64), enabled(t), Blocks.single(w,t)).LoadVector();

        static Vector128<T> lr_pattern<T>(N128 w, T t = default)
            where T : unmanaged
                => gvec.broadcast(BitMask.msb(n2,n1,z64), enabled(t), Blocks.single(w,t)).LoadVector();

        static Vector256<T> rl_pattern<T>(N256 w, T t = default)
            where T : unmanaged
                => gvec.broadcast(BitMask.lsb(n2,n1,t), enabled(t), Blocks.single(w,t)).LoadVector();


        void vblendp_check<T>(Vector128<T> spec, [Caller] string title = null)
            where T : unmanaged
        {
            var w = n128;
            var t = default(T);
            var pn = n32;

            Claim.eq(natval(pn),TypeMath.div(w,t) * 2);

            var left = gvec.vinc(w, t);
            var right = gvec.vadd(left, gmath.add(left.LastCell(), one(t)));            
            var blend = gvec.vblendp(left,right,spec);       


            var dst = Blocks.alloc(w,2,t);
            gvec.vlo(blend).StoreTo(dst,0);
            gvec.vhi(blend).StoreTo(dst,1);

            var perm = Permute.define(dst.Data);            
            var tc = 0;
            for(var i=0; i< perm.Length; i++)
            {
                var ti = convert<T>(i);
                var identity = gmath.eq(ti ,perm[i]);
                if(!identity)
                {
                    var j = perm[i];
                    var k = perm[j];
                    Claim.eq(ti,k);
                    tc++;                    
                }
            }

            if(EmitInfo)
            {
                Notify($"* {title}: vector width = {w}, swap count = {tc}, cell type = {typeof(T).DisplayName()}, perm length = {pn}");
                Notify($"left:  {left.FormatAsList(pad:2)}");
                Notify($"right: {right.FormatAsList(pad:2)}");
                Notify(perm.Format());  
                Notify(string.Empty);  
            }
        }


        public void vblendp_perm32_128x8u()
        {
            var w = n128;
            var t = z8;

            void swaps()
            {
                var title = nameof(swaps);
                vblendp_check(swaps_pattern(w, 1,t), title);
                vblendp_check(swaps_pattern(w, 2,t), title);
                vblendp_check(swaps_pattern(w, 3,t), title);
                vblendp_check(swaps_pattern(w, 4,t), title);
                vblendp_check(swaps_pattern(w, 5,t), title);
                vblendp_check(swaps_pattern(w, 6,t), title);
                vblendp_check(swaps_pattern(w, 7,t), title);
            }

            void lr()
                => vblendp_check(lr_pattern(n128,z8), nameof(lr));

            void rl()
                => vblendp_check(rl_pattern(n128,z8), nameof(rl));

            void llrr()
                => vblendp_check(llrr_pattern(n128,z8), nameof(llrr));

            void rrll()
                => vblendp_check(rrll_pattern(n128,z8), nameof(rrll));

            lr();
            rl();
            llrr();
            rrll();

            /*

            * lr: vector width = 128, swap count = 16, cell type = byte, perm length = 32
            left:  [ 0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15]
            right: [16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31]
            |  0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 |
            |  0 17  2 19  4 21  6 23  8 25 10 27 12 29 14 31 16  1 18  3 20  5 22  7 24  9 26 11 28 13 30 15 |

            * rl: vector width = 128, swap count = 16, cell type = byte, perm length = 32
            left:  [ 0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15]
            right: [16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31]
            |  0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 |
            | 16  1 18  3 20  5 22  7 24  9 26 11 28 13 30 15  0 17  2 19  4 21  6 23  8 25 10 27 12 29 14 31 |

            * llrr: vector width = 128, swap count = 16, cell type = byte, perm length = 32
            left:  [ 0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15]
            right: [16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31]
            |  0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 |
            |  0  1 18 19  4  5 22 23  8  9 26 27 12 13 30 31 16 17  2  3 20 21  6  7 24 25 10 11 28 29 14 15 |

            * rrll: vector width = 128, swap count = 16, cell type = byte, perm length = 32
            left:  [ 0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15]
            right: [16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31]
            |  0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 |
            | 16 17  2  3 20 21  6  7 24 25 10 11 28 29 14 15  0  1 18 19  4  5 22 23  8  9 26 27 12 13 30 31 |

            */
        }

        protected void vblendp_check<P,S,T>(N128 w, P np, S pattern, T t = default)
            where T : unmanaged
            where S : unmanaged
            where P : unmanaged, ITypeNat             
        {
            var spec = vto(vgeneric.vbroadcast(w, pattern),t);
            var x = gvec.vinc(w, t);
            var y = gvec.vadd(x, gmath.add(x.LastCell(), one(t)));            
            var z = gvec.vblendp(x,y,spec);         

            var dst = Blocks.alloc(w,2,t);
            gvec.vlo(z).StoreTo(dst,0);            
            gvec.vhi(z).StoreTo(dst,1);            

            var perm = Permute.define(dst.Data);
            for(var i=0; i< perm.Length; i++)
            {
                var identity = gmath.eq(convert<T>(i), perm[i]);
                if(!identity)
                {
                    var j = perm[i];
                    var k = perm[j];

                    Claim.yea(gmath.eq(convert<T>(i),k));
                }
            }
        }

        protected void vblendp_check<P,S,T>(N256 w, P np, S pattern, T t = default)
            where T : unmanaged
            where S : unmanaged
            where P : unmanaged, ITypeNat             
        {
            var spec = vto(vgeneric.vbroadcast(w, pattern),t);
            var x = gvec.vinc(w, t);
            var y = gvec.vadd(x, gmath.add(x.LastCell(), one(t)));            
            var z = gvec.vblendp(x,y,spec);         

            var dst = Blocks.alloc(w,2,t);
            z.Lo.StoreTo(dst,0);
            z.Hi.StoreTo(dst,1);

            var perm = Permute.define(dst.Data);
            for(var i=0; i< perm.Length; i++)
            {
                var identity = gmath.eq(convert<T>(i), perm[i]);
                if(!identity)
                {
                    var j = perm[i];
                    var k = perm[j];

                    Claim.yea(gmath.eq(convert<T>(i),k));
                }
            }
        }
    }
}