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
    
    public class t_vshuffle : t_vinx<t_vshuffle>
    {        
        static ReadOnlySpan<byte> perm_add_data 
            => new byte[32]{0,1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10,11,11,12,12,13,13,14,14,15,15,16};

        static Vector256<byte> perm_add
            => ginx.vload(n256, in head(perm_add_data));

        static Vector256<byte> perm16x16_spec(Vector256<ushort> src)
            => perm16x16_spec(
                vcell(src,0), vcell(src,1),vcell(src,2),vcell(src,3),vcell(src,4),vcell(src,5),vcell(src,6),vcell(src,7),
                vcell(src,8), vcell(src,9),vcell(src,10),vcell(src,11),vcell(src,12),vcell(src,13),vcell(src,14),vcell(src,15)
                );

        static Vector256<byte> broadcast(Vector256<ushort> src, out Vector256<byte> dst)
            => dst = v8u(dinx.vor(dinx.vsll(src,8),src));

        static Vector256<byte> perm16x16_spec(
            ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7,
            ushort x8, ushort x9, ushort xA, ushort xB, ushort xC, ushort xD, ushort xE, ushort xF
            )
        {
            var b0 = (byte)(x0 + x0);
            var b1 = (byte)(x0 + x0 + 1);
            
            var b2 = (byte)(x1 + x1);
            var b3 = (byte)(x1 + x1 + 1);
            
            var b4 = (byte)(x2 + x2);
            var b5 = (byte)(x2 + x2 + 1);
            
            var b6 = (byte)(x3 + x3);
            var b7 = (byte)(x3 + x3 + 1);

            var b8 = (byte)(x4 + x4);
            var b9 = (byte)(x4 + x4 + 1);

            var bA = (byte)(x5 + x5);
            var bB = (byte)(x5 + x5 + 1);

            var bC = (byte)(x6 + x6);
            var bD = (byte)(x6 + x6 + 1);
            
            var bE = (byte)(x7 + x7);            
            var bF = (byte)(x7 + x7 + 1);

            var b10 = (byte)(x8 + x8);
            var b11 = (byte)(x8 + x8 + 1);

            var b12 = (byte)(x9 + x9);
            var b13 = (byte)(x9 + x9 + 1);

            var b14 = (byte)(xA + xA);
            var b15 = (byte)(xA + xA + 1);

            var b16 = (byte)(xB + xB);            
            var b17 = (byte)(xB + xB + 1);

            var b18 = (byte)(xC + xC);
            var b19 = (byte)(xC + xC + 1);

            var b1A = (byte)(xD + xD);
            var b1B = (byte)(xD + xD + 1);

            var b1C = (byte)(xE + xD);
            var b1D = (byte)(xE*2 + 1);

            var b1E = (byte)(xF + xF);
            var b1F = (byte)(xF + xF + 1);

            return dinx.vparts(n256,
                b0,b1, b2,b3, b4,b5, b6,b7, b8,b9, bA,bB, bC,bD, bE,bF, b10,b11, b12,b13, b14,b15, b16,b17, b18,b19, b1A,b1B, b1C,b1D, b1E,b1F);
        }

        public static Vector256<ushort> vshuf16x16(Vector256<ushort> a, Vector256<ushort> spec)
            => v16u(dinx.vshuf32x8(v8u(a), perm16x16_spec(spec)));

        public void vshuf_16x16()
        {
            var x = ginx.vincrements<ushort>(n256).AsByte();            
            var spec = perm16x16_spec(15,14,13,12,11,10,9,8,7,6,5,4,3,2,1,0);
            var y = dinx.vshuf32x8(x,spec);                    
            var z = broadcast(ginx.vincrements<ushort>(n256), out Vector256<byte> _);
        }
    
        public void shuffle_16x8_128x8u_basecase()
        {
            var n = n128;
            //var x0 = ginx.vload(n, in head(Inc8u));
            var x0 = ginx.vincrements<byte>(n);
            var x0Spec = ginx.vload(n, in head(Pattern1));
            var x0Dst = dinx.vshuf16x8(x0,x0Spec);
            Claim.eq(x0Spec,x0Dst);

            var x1 = ginx.vincrements<byte>(n);
            var x1Spec = ginx.vload(n, in head(Pattern2));
            var x1Dst = dinx.vshuf16x8(x1,x1Spec);
            Claim.eq(x1Spec,x1Dst);

            var x2 = ginx.vincrements<byte>(n);
            var x2Spec = PatternData.rotl(n128, n8);
            var x2Dst = dinx.vshuf16x8(x2,x2Spec);
            Claim.eq(x2Spec,x2Dst);

            var x3 = ginx.vincrements<byte>(n);
            var x3Spec = PatternData.rotr(n128, n8);
            var x3Dst = dinx.vshuf16x8(x3,x3Spec);
            Claim.eq(x3Spec,x3Dst);

            var x4 = ginx.vincrements<byte>(n);
            var x4Spec1 = PatternData.rotl(n128, n8);
            var x4Spec2 = PatternData.rotr(n128, n8);
            var x4Dst = dinx.vshuf16x8(dinx.vshuf16x8(x4,x4Spec1), x4Spec2);
            Claim.eq(x4,x4Dst);

            var x5 = Random.CpuVector<byte>(n);
            var x5Spec = ginx.vbroadcast(n,(byte)0b10000000);
            var x5Dst = dinx.vshuf16x8(x5, x5Spec);
            Claim.eq(x5Dst,ginx.vbroadcast(n,(byte)0));                        

        }

        public void vperm_4x32_128x32u_basecase()
        {
            var n = n128;
            var src = dinx.vparts(n128,1,2,3,4);
            var spec = Perm4.ABCD;
            var y = dinx.vparts(n128,4,3,2,1);
            var x = dinx.vperm4x32(src, Perm4.ABCD);
            Claim.eq(x, src);

            y = dinx.vparts(n128,4,3,2,1);
            spec = Perm4.DCBA;
            x = dinx.vperm4x32(src,spec);
            Claim.eq(x, y); 

            y = dinx.vparts(4u,3u,2u,1u);
            spec = Perm4.DCBA;
            x = dinx.vperm4x32(src,spec);
            Claim.eq(x, y); 

            Claim.eq(dinx.vperm4x32(dinx.vparts(0,1,2,3), Perm4.ADCB), dinx.vparts(0,3,2,1));
            Claim.eq(dinx.vperm4x32(dinx.vparts(0,1,2,3), Perm4.DBCA), dinx.vparts(3,1,2,0));

        }

        public void vshuf_16x8()
        {
            var src = ginx.vincrements<byte>(n128);
            var perm = PermSpec.natural(PermSpec.reversed(n16));
            for(int i=0,j=15; i<perm.Length; i++, j--)
                Claim.eq(perm[i],j);

            var shufspec = perm.ToShuffleSpec();
            var dst = dinx.vshuf16x8(src,shufspec);
            var expect = PatternData.decrements<byte>(n128);
            Claim.eq(expect, dst);

            var dstPerm = dst.ToPerm();
            var expectPerm = expect.ToPerm();
            Claim.eq(dstPerm, expectPerm);

        }

        public void vperm_4x16_basecase()
        {
            var id = dinx.vparts(n128,0,1,2,3,6,7,8,9);
            Claim.eq(dinx.vperm4x16(dinx.vparts(n128,0,1,2,3,6,7,8,9), Perm4.ADCB, Perm4.ADCB), dinx.vparts(n128,0,3,2,1,6,9,8,7));
        }

        public void vperm_4x32_128x32u()
        {
            var trace = false;
            var pSrc = Random.EnumValues<Perm4>(x => (byte)x > 5);
            
            for(var i=0; i<CycleCount; i++)
            {
                var v1 = Random.CpuVector<uint>(n128); 
                var v1s = v1.ToSpan();
                var p = pSrc.First();
                
                // Disassemble the spec
                var p0 = Bits.gather((byte)p, (byte)0b11);                
                var p1 = Bits.gather((byte)p, (byte)0b1100);
                var p2 = Bits.gather((byte)p, (byte)0b110000);
                var p3 = Bits.gather((byte)p, (byte)0b11000000);
                
                // Reassemble the spec
                Perm4 q = (Perm4)(p0 | p1 << 2 | p2 << 4 | p3 << 6);
                
                // Same?
                Claim.eq(p,q);

                // Permute vector via api
                var v2 = dinx.vperm4x32(v1,p);

                // Permute vector manually
                var v3 = dinx.vparts(v1s[p0],v1s[p1],v1s[p2],v1s[p3]);

                // Same?
                Claim.eq(v3,v2);

                if(trace)
                {
                    Trace("v1",v1.FormatHex());                
                    Trace("p", p.Format());
                    Trace("perm(v1,p)", v2.FormatHex());
                }
                                
            }
        }

        //Identity
        static ReadOnlySpan<byte> Pattern1  
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F};

        //Reversal
        static ReadOnlySpan<byte> Pattern2  
            => new byte[16]{F,E,D,C,B,A,9,8,7,6,5,4,3,2,1,0};
    }
}
