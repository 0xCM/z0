//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    using static zfunc;

    public class t_vblendp : t_vinx<t_vblendp>
    {
        public void vblendp_perm32_g128x8u()
            => vblendp_check(n128, n32, BitMasks.Msb16, z8);

        public void vblendp_perm16_g128x16u()
            => vblendp_check(n128, n16, BitMasks.Msb32, z16);

        public void vblendp_perm8_g128x32u()
            => vblendp_check(n128, n8, BitMasks.Msb64, z32);

        public void vblendp_perm64_g256x8u()
            => vblendp_check(n256, n64, BitMasks.Msb16, z8);

        public void vblendp_perm32_g256x16u()
            => vblendp_check(n256, n32, BitMasks.Msb32, z16);

        public void vblendp_perm16_g256x32u()
            => vblendp_check(n256, n16, BitMasks.Msb64, z32);

        public void vblendp_perm64_256x8u()
        {
            var w = n256;
            var t = z8;
            var n = n64;
            var tf = 4;
            var pick = BitMask.msb(n1,n1,t);

            var pattern = DataBlocks.single(w,t);
            for(var i=0; i< pattern.CellCount; i++)
                pattern[i] = (i % tf == 0) ? pick : t;
            
            
            var spec = pattern.LoadVector();
            var x = vbuild.increments(w, t);
            var y = ginx.vadd(x, gmath.add(x.LastCell(), gmath.one(t)));            
            var z = ginx.vblendp(x,y,spec);       


            var dst = DataBlocks.alloc(w,2,t);
            ginx.vlo(z).StoreTo(dst,0);
            ginx.vhi(z).StoreTo(dst,1);

            var perm = Perms.define(dst.Data);            
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

        static Block128<T> swaps_pattern<T>(N128 w, int tf, T t = default)
            where T : unmanaged
        {
            var pick = BitMask.msb(n1,n1,t);
            var pattern = DataBlocks.single(w,t);
            for(var i=0; i< pattern.CellCount; i++)
                pattern[i] = (i % tf == 0) ? pick : t;
            return pattern;
        }

        static T enabled<T>(T t = default)
            where T : unmanaged
                => BitMask.msb(n1,n1,t);

        static Block128<T> rrll_pattern<T>(N128 w, T t = default)
            where T : unmanaged
                => ginxs.broadcast(BitMask.even(n2,n2,z64), enabled(t), DataBlocks.single(w,t));

        static Block128<T> llrr_pattern<T>(N128 w, T t = default)
            where T : unmanaged
                => ginxs.broadcast(BitMask.odd(n2,n2,z64), enabled(t), DataBlocks.single(w,t));

        static Block128<T> rl_pattern<T>(N128 w, T t = default)
            where T : unmanaged
                => ginxs.broadcast(BitMask.lsb(n2,n1,z64), enabled(t), DataBlocks.single(w,t));

        static Block128<T> lr_pattern<T>(N128 w, T t = default)
            where T : unmanaged
                => ginxs.broadcast(BitMask.msb(n2,n1,z64), enabled(t), DataBlocks.single(w,t));

        void vblendp_128x8u<T>(Block128<T> pattern, [Caller] string title = null)
            where T : unmanaged
        {
            var w = n128;
            var t = default(T);
            var pn = n32;

            Claim.eq(natval(pn),TypeMath.div(w,t) * 2);

            var spec = pattern.LoadVector();
            var left = vbuild.increments(w, t);
            var right = ginx.vadd(left, gmath.add(left.LastCell(), gmath.one(t)));            
            var blend = ginx.vblendp(left,right,spec);       


            var dst = DataBlocks.alloc(w,2,t);
            ginx.vlo(blend).StoreTo(dst,0);
            ginx.vhi(blend).StoreTo(dst,1);

            var perm = Perms.define(dst.Data);            
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

            Trace($"* {title}: vector width = {w}, swap count = {tc}, cell type = {typename(t)}, perm length = {pn}");
            Trace($"left:  {left.Format(pad:2)}");
            Trace($"right: {right.Format(pad:2)}");
            Trace(perm.Format());  
            Trace(string.Empty);  
        }


        public void vblendp_perm32_128x8u()
        {
            var w = n128;
            var t = z8;

            void swaps()
            {
                var title = nameof(swaps);
                vblendp_128x8u(swaps_pattern(w, 1,t), title);
                vblendp_128x8u(swaps_pattern(w, 2,t), title);
                vblendp_128x8u(swaps_pattern(w, 3,t), title);
                vblendp_128x8u(swaps_pattern(w, 4,t), title);
                vblendp_128x8u(swaps_pattern(w, 5,t), title);
                vblendp_128x8u(swaps_pattern(w, 6,t), title);
                vblendp_128x8u(swaps_pattern(w, 7,t), title);
            }

            void lr()
                => vblendp_128x8u(lr_pattern(n128,z8), nameof(lr));

            void rl()
                => vblendp_128x8u(rl_pattern(n128,z8), nameof(rl));

            void llrr()
                => vblendp_128x8u(llrr_pattern(n128,z8), nameof(llrr));

            void rrll()
                => vblendp_128x8u(rrll_pattern(n128,z8), nameof(rrll));

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
            var spec = vconvert(vbuild.broadcast(w, pattern),t);
            var x = vbuild.increments(w, t);
            var y = ginx.vadd(x, gmath.add(x.LastCell(), gmath.one(t)));            
            var z = ginx.vblendp(x,y,spec);         

            var dst = DataBlocks.alloc(w,2,t);
            ginx.vlo(z).StoreTo(dst,0);            
            ginx.vhi(z).StoreTo(dst,1);            

            var perm = Perms.define(dst.Data);
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
            var spec = vconvert(vbuild.broadcast(w, pattern),t);
            var x = vbuild.increments(w, t);
            var y = ginx.vadd(x, gmath.add(x.LastCell(), gmath.one(t)));            
            var z = ginx.vblendp(x,y,spec);         

            var dst = DataBlocks.alloc(w,2,t);
            z.Lo.StoreTo(dst,0);
            z.Hi.StoreTo(dst,1);

            var perm = Perms.define(dst.Data);
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