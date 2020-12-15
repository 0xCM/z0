//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static HexConst;
    using static z;
    using static Konst;

    partial class VexExamples
    {
        public static ReadOnlySpan<byte> AddPattern
            => new byte[32]{0,1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10,11,11,12,12,13,13,14,14,15,15,16};

        //Identity
        public static ReadOnlySpan<byte> IdentityPattern
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F};

        //Reversal
        public static ReadOnlySpan<byte> ReversalPattern
            => new byte[16]{F,E,D,C,B,A,9,8,7,6,5,4,3,2,1,0};

        /// <summary>
        /// Encodes a permutation on 16 unsigned shorts as a permutation on 32 bytes
        /// </summary>
        [Op]
        public static Vector256<byte> vshuffle_spec_256x16u(
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

            return vparts(w256,
                b0,b1, b2,b3, b4,b5, b6,b7, b8,b9,   bA,bB, bC,bD, bE,bF,
                b10,b11, b12,b13, b14,b15, b16,b17,  b18,b19, b1A,b1B, b1C,b1D, b1E,b1F
                );
        }

        /// <summary>
        /// Encodes a 256x16u component-oriented shuffle as an equivalent 256x8u component-oriented shuffle
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vshuffle_spec_1(Vector256<ushort> src)
            => vshuffle_spec_256x16u(
                vcell(src,0), vcell(src,1), vcell(src,2),vcell(src,3),
                vcell(src,4), vcell(src,5), vcell(src,6), vcell(src,7),
                vcell(src,8), vcell(src,9), vcell(src,10), vcell(src,11),
                vcell(src,12), vcell(src,13), vcell(src,14), vcell(src,15)
                );

        [MethodImpl(Inline), Op]
        public static Vector256<byte> vshuffle_spec_2(Vector256<ushort> src)
            => z.vcompact8u(src, gvec.vinc(w256, ScalarCast.uint16(16)),n256,z8);

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vshuf16x16(Vector256<ushort> a, Vector256<ushort> spec)
            => z.v16u(z.vshuf32x8(z.v8u(a), vshuffle_spec_1(spec)));

        [Op(ExampleGroups.Shuffles)]
        public void vshuf16x16()
        {
            var w = n256;
            var x = gvec.vinc(w,z16);
            var reverse = z.vdec<ushort>(w);
            var identity = z.vinc<ushort>(w);
            var pairswap = vparts(w256,1,0,3,2,5,4,7,6,9,8,11,10,13,11,15,12);

            var y1 = vshuf16x16(x,reverse);
            Claim.veq(reverse, y1);

            var y2 = vshuf16x16(x,identity);
            Claim.veq(identity,y2);

            var y3 = vshuf16x16(x,pairswap);
            Claim.veq(pairswap,y3);
        }

        [Op(ExampleGroups.Shuffles)]
        public void vshuf16x8_128x8u()
        {
            var w = w128;
            var x0 = z.vinc<byte>(w);
            var x0Spec = vload(w, z.first(IdentityPattern));
            var x0Dst = z.vshuf16x8(x0,x0Spec);
            Claim.veq(x0Spec,x0Dst);

            var x1 = z.vinc<byte>(w);
            var x1Spec = vload(w, z.first(ReversalPattern));
            var x1Dst = z.vshuf16x8(x1,x1Spec);
            Claim.veq(x1Spec,x1Dst);

            var x2 = z.vinc<byte>(w);
            var x2Spec = z.vrotl(n128, n8);
            var x2Dst = z.vshuf16x8(x2,x2Spec);
            Claim.veq(x2Spec,x2Dst);

            var x3 = z.vinc<byte>(w);
            var x3Spec = z.vrotr(n128, n8);
            var x3Dst = z.vshuf16x8(x3,x3Spec);
            Claim.veq(x3Spec,x3Dst);

            var x4 = z.vinc<byte>(w);
            var x4Spec1 = z.vrotl(n128, n8);
            var x4Spec2 = z.vrotr(n128, n8);
            var x4Dst = z.vshuf16x8(z.vshuf16x8(x4,x4Spec1), x4Spec2);
            Claim.veq(x4,x4Dst);

            var x5 = Random.CpuVector<byte>(w);
            var x5Spec = vbroadcast(w,(byte)0b10000000);
            var x5Dst = z.vshuf16x8(x5, x5Spec);
            Claim.veq(x5Dst, z.vbroadcast(w,(byte)0));
        }

        [Op(ExampleGroups.Shuffles)]
        public void vshuf16x8()
        {
            var reverse = PermSymbolic.reversed(n16);
            var perm = Permute.natural(reverse);
            for(int i=0,j=15; i<perm.Length; i++, j--)
                Claim.eq(perm[i], j);

            var increments = z.vinc<byte>(n128);
            var spec = perm.ToShuffleSpec();
            var dst = z.vshuf16x8(increments,spec);
            var expect = z.vdec<byte>(n128);
            Claim.veq(expect, dst);

            var identity = videntity_shuffle();
            for(var i=0; i<CycleCount; i++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = z.vshuf16x8(x, identity);
                Claim.veq(x,y);
            }
        }

        [Op]
        public static Vector256<byte> videntity_shuffle()
        {
            SpanBlock256<byte> mask = SpanBlocks.cellalloc<byte>(n256,1);

            //For the first 128-bit lane
            var half = mask.CellCount/2;
            for(byte i=0; i< half; i++)
                mask[i] = i;

            //For the second 128-bit lane
            for(byte i=0; i< half; i++)
                mask[i + half] = i;

            return mask.LoadVector();
        }
    }
}