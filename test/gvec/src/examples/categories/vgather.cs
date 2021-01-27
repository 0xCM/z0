//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class VexExamples
    {
        [Op(ExampleGroups.Gather)]
        public void vgather_128()
        {
            const int count = Pow2.T09;

            Span<uint> data32 = new uint[count];
            for(var i=0; i<data32.Length; i++)
                data32[i] = (uint)i;

            Span<ulong> data64 = new ulong[count];
            for(var i=0; i<data64.Length; i++)
                data64[i] = (ulong)i;

            ref var src32 = ref first(data32);
            ref var src64 = ref first(data64);

            var v256Actual = cpu.vgather(n128, in src32, VGather4x64uIndex);
            var v256Expect = cpu.vparts(n128,0, 63, 127, 255);
            Claim.veq(v256Expect,v256Actual);

            //[0,127,255,511]
            var v512idx = v64u(Vector256.Create(Pow2.T00 - 1, Pow2.T07 - 1, Pow2.T08 - 1, Pow2.T09 - 1));
            var v512Actual = cpu.vgather(n128, in src32, v512idx);
            var v512Expect = cpu.vparts(n128,0, 127, 255, 511);
            Claim.veq(v512Expect,v512Actual);

            // Each claim below asserts that each gather operation is an identity function
            // with respect to the defined indexes (ignoring the type of the underlying data)

            var i2x8 = cpu.vparts(n128, 8, 16);
            var v2x8 = cpu.vgather(n128, in src64, i2x8);
            Claim.veq(i2x8, v2x8);

            var i2x64 = cpu.vparts(n128, 64, 128);
            var v2x64 = cpu.vgather(n128, in src64, i2x64);
            Claim.veq(i2x64, v2x64);

            var i2x250 = cpu.vparts(n128, 250, 500);
            var v2x250 = cpu.vgather(n128, in src64, i2x250);
            Claim.veq(i2x250, v2x250);

            var i2x2 = cpu.vparts(n256, 2, 4, 8, 16);
            var v2x2 = cpu.vgather(n128, in src32, i2x2);
            Claim.veq(cpu.vcompact32u(i2x2, n128), v2x2);

            var i3x3 = cpu.vparts(n256, 3, 6, 12, 24);
            var v3x3 = cpu.vgather(n128, in src32, i3x3);
            Claim.veq(cpu.vcompact32u(i3x3, n128), v3x3);

            var i3_3 = cpu.vparts(n256, 3, 6, 9, 12);
            var v3_3 = cpu.vgather(n128, in src32, i3_3);
            Claim.veq(cpu.vcompact32u(i3_3, n128), v3_3);

            var i4x2 = cpu.vparts(n256, 4, 8, 16, 32);
            var v4x2 = cpu.vgather(n128, in src32, i4x2);
            Claim.veq(cpu.vcompact32u(i4x2, n128), v4x2);

            var i5_5 =cpu.vparts(n256, 5, 10, 15, 20);
            var v5_5 = cpu.vgather(n128, in src32, i5_5);
            Claim.veq(cpu.vcompact32u(i5_5, n128), v5_5);

            var i9_9 = cpu.vparts(n256, 9, 18, 27, 36);
            var v9_9 = cpu.vgather(n128, in src32, i9_9);
            Claim.veq(cpu.vcompact32u(i9_9, n128), v9_9);

            var i10_10 = cpu.vparts(n256, 10, 20, 30, 40);
            var v10_10 = cpu.vgather(n128, in src32, i10_10);
            Claim.veq(cpu.vcompact32u(i10_10, n128), v10_10);

            var i16x2 = cpu.vparts(n256, 16, 32, 64, 128);
            var v16x2 = cpu.vgather(n128, in src32, i16x2);
            Claim.veq(cpu.vcompact32u(i16x2, n128), v16x2);

            var i20_5 = cpu.vparts(n256, 20, 25, 30, 35);
            var v20_5 = cpu.vgather(n128, in src32, i20_5);
            Claim.veq(cpu.vcompact32u(i20_5, n128), v20_5);

            var i40_3 = cpu.vparts(n256, 40, 43, 46, 49);
            var v40_3 = cpu.vgather(n128, in src32, i40_3);
            Claim.veq(cpu.vcompact32u(i40_3, n128), v40_3);

            var i4x128 = cpu.vparts(w256i, 0, 128 - 1, 128*2 - 1, 128*4 - 1);
            var v4x128 = cpu.vgather(n128, in src32, v512idx);
            Claim.veq(cpu.vcompact32i(i4x128, n128), v32i(v4x128));
        }

        [Op(ExampleGroups.Gather)]
        public void vgather_256()
        {
            Span<uint> data = new uint[Pow2.T09];
            for(var i=0; i<data.Length; i++)
                data[i] = (uint)i;
            ref var src = ref first(data);

            //[0,3,7,15,31,63,127,255]
            var v256idx = cpu.vparts(n256,Pow2.T00 - 1, Pow2.T02 - 1, Pow2.T03 - 1, Pow2.T04 - 1, Pow2.T05 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1);
            var v256Expect = cpu.vparts(n256, 0, Pow2.T02 - 1, Pow2.T03 - 1, Pow2.T04 - 1, Pow2.T05 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1);
            var v256Actual = cpu.vgather(n256, in src, v256idx);
            Claim.veq(v256Expect,v256Actual);

            var v512Expect = cpu.vparts(n256, 0, Pow2.T03 - 1, Pow2.T04 - 1, Pow2.T05 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1, Pow2.T09 - 1);
            var v512Actual = cpu.vgather(n256, in src, VGather256x32x512Index);
            Claim.veq(v512Expect, v512Actual);
        }

        [Op(ExampleGroups.Gather)]
        public void vgather_blocks()
        {
            const int BlockLength = 4;
            const int CellCount = 512;
            const int BlockCount = CellCount / BlockLength;

            var w = n128;
            var t = z32;
            var A = SpanBlocks.alloc(w,BlockCount, t);
            var B = SpanBlocks.alloc(w,BlockCount, t);

            var pattern0 = BitMasks.vlsb(w,n2,n1,t);
            var pattern1 = BitMasks.vmsb(w,n2,n1,t);

            for(var block = 0; block<BlockCount; block++)
            {
                var target = A.Block(block);
                var source = gmath.even(block) ? pattern0 : pattern1;
                source.StoreTo(target);
            }

            var a0 = cpu.vgather(w, in A.First, cpu.vparts(w,4*12, 4*24, 4*48, 4*64));
            Claim.veq(a0,pattern0);

            for(var block = 0; block < BlockCount; block++)
            {
                uint i0 = (uint)(block*BlockLength);
                var i1 = i0 + 1;
                var i2 = i1 + 1;
                var i3 = i2 + 1;

                var indices = cpu.vparts(w,i0,i1,i2,i3);
                var result = cpu.vgather(w, in A.First, indices);
                var expect = gmath.even(block) ? pattern0 : pattern1;
                Claim.veq(result,expect);
            }
        }

        //[0, 63, 127, 255]
        static Vector256<ulong> VGather4x64uIndex
        {
            [MethodImpl(Inline)]
            get => cpu.vload(n256, in memory.first64(VGather256x64x256IndexData));
        }

        //[0, 63, 127, 255]
        static Vector256<long> VGather4x64iIndex
        {
            [MethodImpl(Inline)]
            get => cpu.vload(n256, in memory.first64i(VGather256x64x256IndexData));
        }

        //[0, 7, 15, 31, 63, 127, 255, 511]
        static Vector256<uint> VGather256x32x512Index
        {
            [MethodImpl(Inline)]
            get => z.vload<uint>(n256, in memory.first32(VGather256x32x512IndexData));
        }

        //[0, 63, 127, 255]
        static ReadOnlySpan<byte> VGather256x64x256IndexData => new byte[]{
            0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
            0x3f,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
            0x7f,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
            0xff,0x00,0x00,0x00,0x00,0x00,0x00,0x00
        };

        //[0, 7, 15, 31, 63, 127, 255, 511]
        static ReadOnlySpan<byte> VGather256x32x512IndexData => new byte[]{
            0x00,0x00,0x00,0x00,
            0x07,0x00,0x00,0x00,
            0x0f,0x00,0x00,0x00,
            0x1f,0x00,0x00,0x00,
            0x3f,0x00,0x00,0x00,
            0x7f,0x00,0x00,0x00,
            0xff,0x00,0x00,0x00,
            0xff,0x01,0x00,0x00
        };

        //[0, 4, 8, 12, 16, 20, 24, 28]
        static ReadOnlySpan<byte> VGather256x32x4IndexData => new byte[]{
            0,0x00,0x00,0x00,
            4,0x00,0x00,0x00,
            8,0x00,0x00,0x00,
            12,0x00,0x00,0x00,
            16,0x00,0x00,0x00,
            20,0x00,0x00,0x00,
            24,0x00,0x00,0x00,
            28,0x01,0x00,0x00
        };
    }
}