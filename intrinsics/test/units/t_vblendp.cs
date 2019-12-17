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
            var pick = BitMasks.Msb8;

            var pattern = DataBlocks.single(w,t);
            for(var i=0; i< pattern.CellCount; i++)
                pattern[i] = (i % 4 == 0) ? pick : t;
            
            
            /*
                |  0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59 60 61 62 63 |
                | 32  1  2  3 36  5  6  7 40  9 10 11 44 13 14 15 48 17 18 19 52 21 22 23 56 25 26 27 60 29 30 31  0 33 34 35  4 37 38 39  8 41 42 43 12 45 46 47 16 49 50 51 20 53 54 55 24 57 58 59 28 61 62 63 |

            */

            var spec = pattern.LoadVector();
            var x = vbuild.increments(w, t);
            var y = ginx.vadd(x, gmath.add(x.LastCell(), gmath.one(t)));            
            var z = ginx.vblendp(x,y,spec);       


            var dst = DataBlocks.alloc(w,2,t);
            ginx.vlo(z).StoreTo(dst,0);
            ginx.vhi(z).StoreTo(dst,1);

            var perm = Perm.natural(n,dst.Data);
            Trace(perm.Format());  
            
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

            var perm = Perm.natural(np,dst.Data);
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

            var perm = Perm.natural(np,dst.Data);
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