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
    using static As;
    using static Root;
    
    partial class vexamples
    {        
        static ReadOnlySpan<byte> perm_add_data 
            => new byte[32]{0,1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10,11,11,12,12,13,13,14,14,15,15,16};

        /// <summary>
        /// Encodes a permutation on 16 unsigned shorts as a permutation on 32 bytes
        /// </summary>
        static Vector256<byte> ToShuffleSpec(
            ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7,
            ushort x8, ushort x9, ushort xA, ushort xB, ushort xC, ushort xD, ushort xE, ushort xF)
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

            var b1C = (byte)(xE + xE);
            var b1D = (byte)(xE + xE + 1);

            var b1E = (byte)(xF + xF);
            var b1F = (byte)(xF + xF + 1);

            return Vectors.vparts(n256, 
                b0,b1, b2,b3, b4,b5, b6,b7, b8,b9,   bA,bB, bC,bD, bE,bF, 
                b10,b11, b12,b13, b14,b15, b16,b17,  b18,b19, b1A,b1B, b1C,b1D, b1E,b1F
                );
        }

        /// <summary>
        /// Encodes a 256x16u component-oriented shuffle as an equivalent 256x8u component-oriented shuffle
        /// </summary>
        static Vector256<byte> ToShuffleSpec(Vector256<ushort> src)
            => ToShuffleSpec(
                Vectors.vcell(src,0), Vectors.vcell(src,1), Vectors.vcell(src,2),Vectors.vcell(src,3), 
                Vectors.vcell(src,4), Vectors.vcell(src,5), Vectors.vcell(src,6), Vectors.vcell(src,7),
                Vectors.vcell(src,8), Vectors.vcell(src,9), Vectors.vcell(src,10), Vectors.vcell(src,11), 
                Vectors.vcell(src,12), Vectors.vcell(src,13), Vectors.vcell(src,14), Vectors.vcell(src,15)
                );

        static Vector256<byte> ToShuffleSpec2(Vector256<ushort> src)
            => dvec.vcompact(src, gvec.vinc(n256, As.uint16(16)),n256,z8);

        public static Vector256<ushort> vshuf16x16(Vector256<ushort> a, Vector256<ushort> spec)
            => v16u(dvec.vshuf32x8(v8u(a), ToShuffleSpec(spec)));

        public void vshuf16x16()
        {
            var w = n256;
            var x = gvec.vinc(w,z16);            
            var reverse = VData.decrements<ushort>(w);
            var identity = VData.vincrements<ushort>(w);
            var pairswap = Vectors.vparts(w,1,0,3,2,5,4,7,6,9,8,11,10,13,11,15,12);

            var y1 = vshuf16x16(x,reverse);
            Claim.veq(reverse, y1);

            var y2 = vshuf16x16(x,identity);
            Claim.veq(identity,y2);

            var y3 = vshuf16x16(x,pairswap);
            Claim.veq(pairswap,y3);
        }

        public void vshuf16x8_128x8u()
        {
            var n = n128;
            var x0 = VData.vincrements<byte>(n);
            var x0Spec = Vectors.vload(n, in head(Pattern1));
            var x0Dst = dvec.vshuf16x8(x0,x0Spec);
            Claim.veq(x0Spec,x0Dst);

            var x1 = VData.vincrements<byte>(n);
            var x1Spec = Vectors.vload(n, in head(Pattern2));
            var x1Dst = dvec.vshuf16x8(x1,x1Spec);
            Claim.veq(x1Spec,x1Dst);

            var x2 = VData.vincrements<byte>(n);
            var x2Spec = VData.rotl(n128, n8);
            var x2Dst = dvec.vshuf16x8(x2,x2Spec);
            Claim.veq(x2Spec,x2Dst);

            var x3 = VData.vincrements<byte>(n);
            var x3Spec = VData.rotr(n128, n8);
            var x3Dst = dvec.vshuf16x8(x3,x3Spec);
            Claim.veq(x3Spec,x3Dst);

            var x4 = VData.vincrements<byte>(n);
            var x4Spec1 = VData.rotl(n128, n8);
            var x4Spec2 = VData.rotr(n128, n8);
            var x4Dst = dvec.vshuf16x8(dvec.vshuf16x8(x4,x4Spec1), x4Spec2);
            Claim.veq(x4,x4Dst);

            var x5 = Random.CpuVector<byte>(n);
            var x5Spec = Vectors.vbroadcast(n,(byte)0b10000000);
            var x5Dst = dvec.vshuf16x8(x5, x5Spec);
            Claim.veq(x5Dst,Vectors.vbroadcast(n,(byte)0));                        
        }


        public void vshuf16x8()
        {
            var src = VData.vincrements<byte>(n128);
            var perm = Permute.natural(Symbolic.reversed(n16));
            for(int i=0,j=15; i<perm.Length; i++, j--)
                Claim.eq(perm[i],j);

            var shufspec = perm.ToShuffleSpec();
            var dst = dvec.vshuf16x8(src,shufspec);
            var expect = VData.decrements<byte>(n128);
            Claim.veq(expect, dst);

            var identity = ShuffleIdentityMask();
            for(var i=0; i<CycleCount; i++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = dvec.vshuf16x8(x, identity);
                Claim.veq(x,y);
            }
        }

        public void vperm4x16()
        {
            var id = Vectors.vparts(n128,0,1,2,3,6,7,8,9);
            Claim.veq(dvec.vperm4x16(Vectors.vparts(n128,0,1,2,3,6,7,8,9), Perm4L.ADCB, Perm4L.ADCB), Vectors.vparts(n128,0,3,2,1,6,9,8,7));
        }

        public void vperm4x32_128x32u_example1()
        {
            var trace = false;
            var pSrc = Random.EnumValues<Perm4L>(x => (byte)x > 5);
            
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
                Perm4L q = (Perm4L)(p0 | p1 << 2 | p2 << 4 | p3 << 6);
                
                // Same?
                Claim.Eq(p,q);

                // Permute vector via api
                var v2 = dvec.vperm4x32(v1,p);

                // Permute vector manually
                var v3 = Vectors.vparts(v1s[p0],v1s[p1],v1s[p2],v1s[p3]);

                // Same?
                Claim.veq(v3,v2);

                if(trace)
                {
                    base.Trace("v1", v1.FormatHex());                
                    base.Trace("p", p.Format());
                    base.Trace("perm(v1,p)", v2.FormatHex());
                }                                
            }
        }

        public void vperm4x32_128x32u_example2()
        {
            var n = n128;
            var src = Vectors.vparts(n128,1,2,3,4);
            var spec = Perm4L.ABCD;
            var y = Vectors.vparts(n128,4,3,2,1);
            var x = dvec.vperm4x32(src, Perm4L.ABCD);
            Claim.veq(x, src);

            y = Vectors.vparts(n128,4,3,2,1);
            spec = Perm4L.DCBA;
            x = dvec.vperm4x32(src,spec);
            Claim.veq(x, y); 

            y = Vectors.vparts(4u,3u,2u,1u);
            spec = Perm4L.DCBA;
            x = dvec.vperm4x32(src,spec);
            Claim.veq(x, y); 

            Claim.veq(dvec.vperm4x32(Vectors.vparts(0,1,2,3), Perm4L.ADCB), Vectors.vparts(0,3,2,1));
            Claim.veq(dvec.vperm4x32(Vectors.vparts(0,1,2,3), Perm4L.DBCA), Vectors.vparts(3,1,2,0));
        }

        static Vector256<byte> ShuffleIdentityMask()
        {
            Block256<byte> mask = Blocks.cellalloc<byte>(n256,1);

            //For the first 128-bit lane
            var half = mask.CellCount/2;
            for(byte i=0; i< half; i++)
                mask[i] = i;

            //For the second 128-bit lane
            for(byte i=0; i< half; i++)
                mask[i + half] = i;

            return mask.LoadVector();
        }

        //Identity
        static ReadOnlySpan<byte> Pattern1  
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F};

        //Reversal
        static ReadOnlySpan<byte> Pattern2  
            => new byte[16]{F,E,D,C,B,A,9,8,7,6,5,4,3,2,1,0};
    }
}