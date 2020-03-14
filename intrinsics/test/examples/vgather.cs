//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static dvec;

    partial class vexamples
    {
        public void vgather_128()
        {
            const int count = Pow2.T09;
            
            Span<uint> data32 = new uint[count];
            for(var i=0; i<data32.Length; i++)
                data32[i] = (uint)i;

            Span<ulong> data64 = new ulong[count];
            for(var i=0; i<data64.Length; i++)
                data64[i] = (ulong)i;

            ref var src32 = ref head(data32);
            ref var src64 = ref head(data64);

            var v256Actual = vgather(n128, in src32, VGather4x64uIndex);
            var v256Expect = vgeneric.vparts(n128,0, 63, 127, 255);
            Claim.eq(v256Expect,v256Actual);

            //[0,127,255,511]
            var v512idx = v64u(Vector256.Create(Pow2.T00 - 1, Pow2.T07 - 1, Pow2.T08 - 1, Pow2.T09 - 1));
            var v512Actual = vgather(n128, in src32, v512idx);
            var v512Expect = vgeneric.vparts(n128,0, 127, 255, 511);
            Claim.eq(v512Expect,v512Actual);

            // Each claim below asserts that each gather operation is an identiy function
            // with respect to the defined indexes (ignoring the type of the underlying data)

            var i2x8 = vgeneric.vparts(n128, 8, 16);
            var v2x8 = vgather(n128, in src64, i2x8);
            Claim.eq(i2x8, v2x8);            

            var i2x64 = vgeneric.vparts(n128, 64, 128);
            var v2x64 = vgather(n128, in src64, i2x64);
            Claim.eq(i2x64, v2x64);            

            var i2x250 = vgeneric.vparts(n128, 250, 500);
            var v2x250 = vgather(n128, in src64, i2x250);
            Claim.eq(i2x250, v2x250);            

            var i2x2 = vgeneric.vparts(n256, 2, 4, 8, 16);
            var v2x2 = vgather(n128, in src32, i2x2);
            Claim.eq(dvec.vcompact(i2x2, n128, z32i), v2x2);            

            var i3x3 = vgeneric.vparts(n256, 3, 6, 12, 24);
            var v3x3 = vgather(n128, in src32, i3x3); 
            Claim.eq(dvec.vcompact(i3x3, n128, z32i), v3x3);

            var i3_3 = vgeneric.vparts(n256, 3, 6, 9, 12);
            var v3_3 = vgather(n128, in src32, i3_3); 
            Claim.eq(dvec.vcompact(i3_3, n128, z32i), v3_3);

            var i4x2 = vgeneric.vparts(n256, 4, 8, 16, 32);
            var v4x2 = vgather(n128, in src32, i4x2);
            Claim.eq(dvec.vcompact(i4x2, n128, z32i), v4x2);

            var i5_5 = vgeneric.vparts(n256, 5, 10, 15, 20);
            var v5_5 = vgather(n128, in src32, i5_5);
            Claim.eq(dvec.vcompact(i5_5, n128, z32i), v5_5);

            var i9_9 = vgeneric.vparts(n256, 9, 18, 27, 36);
            var v9_9 = vgather(n128, in src32, i9_9);
            Claim.eq(dvec.vcompact(i9_9, n128, z32i), v9_9);

            var i10_10 = vgeneric.vparts(n256, 10, 20, 30, 40);
            var v10_10 = vgather(n128, in src32, i10_10);
            Claim.eq(dvec.vcompact(i10_10, n128, z32i), v10_10);

            var i16x2 = vgeneric.vparts(n256, 16, 32, 64, 128);
            var v16x2 = vgather(n128, in src32, i16x2);
            Claim.eq(dvec.vcompact(i16x2, n128, z32i), v16x2);

            var i20_5 = vgeneric.vparts(n256, 20, 25, 30, 35);
            var v20_5 = vgather(n128, in src32, i20_5);
            Claim.eq(dvec.vcompact(i20_5, n128, z32i), v20_5);

            var i40_3 = vgeneric.vparts(n256, 40, 43, 46, 49);
            var v40_3 = vgather(n128, in src32, i40_3);
            Claim.eq(dvec.vcompact(i40_3, n128, z32i), v40_3);

            var i4x128 = vgeneric.vpartsi(n256, 0, 128 - 1, 128*2 - 1, 128*4 - 1);
            var v4x128 = vgather(n128, in src32, v512idx);
            Claim.eq(dvec.vcompact(i4x128, n128, z32i), v32i(v4x128));            
        }

        public void vgather_256()
        {
            Span<uint> data = new uint[Pow2.T09];
            for(var i=0; i<data.Length; i++)
                data[i] = (uint)i;
            ref var src = ref head(data);                

            //[0,3,7,15,31,63,127,255]
            var v256idx = vgeneric.vparts(n256,Pow2.T00 - 1, Pow2.T02 - 1, Pow2.T03 - 1, Pow2.T04 - 1, Pow2.T05 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1);
            var v256Expect = vgeneric.vparts(n256, 0, Pow2.T02 - 1, Pow2.T03 - 1, Pow2.T04 - 1, Pow2.T05 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1);
            var v256Actual = vgather(n256, in src, v256idx);
            Claim.eq(v256Expect,v256Actual);

            var v512Expect = vgeneric.vparts(n256, 0, Pow2.T03 - 1, Pow2.T04 - 1, Pow2.T05 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1, Pow2.T09 - 1);
            var v512Actual = vgather(n256, in src, VGather256x32x512Index);
            Claim.eq(v512Expect,v512Actual);
        }

        public void vgather_128x32u_blocks()
        {                
            const int BlockLength = 4;
            const int CellCount = 512;
            const int BlockCount = CellCount / BlockLength;

            var w = n128;
            var t = z32;
            var A = Blocks.alloc(w,BlockCount, t);                
            var B = Blocks.alloc(w,BlockCount, t);

            var pattern0 = vgbits.vlsb(w,n2,n1,t);
            var pattern1 = vgbits.vmsb(w,n2,n1,t);

            for(var block = 0; block < BlockCount; block++)
            {
                var target = A.Block(block);
                var source = parity.even(block) ? pattern0 : pattern1;
                source.StoreTo(target);
            }

            var a0 = vgather(w, in A.Head, vgeneric.vparts(w,4*12, 4*24, 4*48, 4*64));
            Claim.eq(a0,pattern0);

            for(var block = 0; block < BlockCount; block++)
            {
                uint i0 = (uint)(block*BlockLength);
                var i1 = i0 + 1;
                var i2 = i1 + 1;
                var i3 = i2 + 1;
                
                var indices = vgeneric.vparts(w,i0,i1,i2,i3);
                var result = vgather(w, in A.Head, indices);
                var expect = parity.even(block) ? pattern0 : pattern1;
                Claim.eq(result,expect);                
            }
        }

        //[0, 63, 127, 255]
        static Vector256<ulong> VGather4x64uIndex
        {
            [MethodImpl(Inline)]
            get => vgeneric.vload(n256, in refs.head64(VGather256x64x256IndexData));
        }

        //[0, 63, 127, 255]
        static Vector256<long> VGather4x64iIndex
        {
            [MethodImpl(Inline)]
            get => vgeneric.vload(n256, in refs.head64i(VGather256x64x256IndexData));
        }

        //[0, 7, 15, 31, 63, 127, 255, 511]
        static Vector256<uint> VGather256x32x512Index
        {
            [MethodImpl(Inline)]
            get => vgeneric.vload<uint>(n256, in refs.head32(VGather256x32x512IndexData));
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