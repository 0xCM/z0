//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vgather : t_vinx<t_vgather>
    {

        public void vgather_128_outline()
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

            var v256Actual = CpuVector.vgather256(n128, ref src32);
            var v256Expect = CpuVector.vparts(n128,0, 63, 127, 255);
            Claim.eq(v256Expect,v256Actual);

            var v512Actual = CpuVector.vgather512(n128, ref src32);
            var v512Expect = CpuVector.vparts(n128,0, 127, 255, 511);
            Claim.eq(v512Expect,v512Actual);

            // Each claim below asserts that each gather operation is an identiy function
            // with respect to the defined indexes (ignoring the type of the underlying data)

            var i2x8 = CpuVector.vpartsi(n128, 8, 16);
            var v2x8 = CpuVector.vgather(n128, ref src64, i2x8);
            Claim.eq(i2x8, v64i(v2x8));            

            var i2x64 = CpuVector.vpartsi(n128, 64, 128);
            var v2x64 = CpuVector.vgather(n128, ref src64, i2x64);
            Claim.eq(i2x64, v64i(v2x64));            

            var i2x250 = CpuVector.vpartsi(n128, 250, 500);
            var v2x250 = CpuVector.vgather(n128, ref src64, i2x250);
            Claim.eq(i2x250, v64i(v2x250));            

            var i2x2 = CpuVector.vpartsi(n256, 2, 4, 8, 16);
            var v2x2 = CpuVector.vgather(n128, ref src32, i2x2);
            Claim.eq(dinx.vcompact(i2x2, n128, z32i), v32i(v2x2));            

            var i3x3 = CpuVector.vpartsi(n256, 3, 6, 12, 24);
            var v3x3 = CpuVector.vgather(n128, ref src32, i3x3); 
            Claim.eq(dinx.vcompact(i3x3, n128, z32i), v32i(v3x3));

            var i3_3 = CpuVector.vpartsi(n256, 3, 6, 9, 12);
            var v3_3 = CpuVector.vgather(n128, ref src32, i3_3); 
            Claim.eq(dinx.vcompact(i3_3, n128, z32i), v32i(v3_3));

            var i4x2 = CpuVector.vpartsi(n256, 4, 8, 16, 32);
            var v4x2 = CpuVector.vgather(n128, ref src32, i4x2);
            Claim.eq(dinx.vcompact(i4x2, n128, z32i), v32i(v4x2));

            var i5_5 = CpuVector.vpartsi(n256, 5, 10, 15, 20);
            var v5_5 = CpuVector.vgather(n128, ref src32, i5_5);
            Claim.eq(dinx.vcompact(i5_5, n128, z32i), v32i(v5_5));

            var i9_9 = CpuVector.vpartsi(n256, 9, 18, 27, 36);
            var v9_9 = CpuVector.vgather(n128, ref src32, i9_9);
            Claim.eq(dinx.vcompact(i9_9, n128, z32i), v32i(v9_9));

            var i10_10 = CpuVector.vpartsi(n256, 10, 20, 30, 40);
            var v10_10 = CpuVector.vgather(n128, ref src32, i10_10);
            Claim.eq(dinx.vcompact(i10_10, n128, z32i), v32i(v10_10));

            var i16x2 = CpuVector.vpartsi(n256, 16, 32, 64, 128);
            var v16x2 = CpuVector.vgather(n128, ref src32, i16x2);
            Claim.eq(dinx.vcompact(i16x2, n128, z32i), v32i(v16x2));

            var i20_5 = CpuVector.vpartsi(n256, 20, 25, 30, 35);
            var v20_5 = CpuVector.vgather(n128, ref src32, i20_5);
            Claim.eq(dinx.vcompact(i20_5, n128, z32i), v32i(v20_5));

            var i40_3 = CpuVector.vpartsi(n256, 40, 43, 46, 49);
            var v40_3 = CpuVector.vgather(n128, ref src32, i40_3);
            Claim.eq(dinx.vcompact(i40_3, n128, z32i), v32i(v40_3));

            var i4x128 = CpuVector.vpartsi(n256, 0, 128 - 1, 128*2 - 1, 128*4 - 1);
            var v4x128 = CpuVector.vgather512(n128, ref src32);
            Claim.eq(dinx.vcompact(i4x128, n128, z32i), v32i(v4x128));
            
        }

        public void vgather_256_outline()
        {
            Span<uint> data = new uint[Pow2.T09];
            for(var i=0; i<data.Length; i++)
                data[i] = (uint)i;
            ref var src = ref head(data);                

            var v256Expect = CpuVector.vparts(n256, 0, Pow2.T02 - 1, Pow2.T03 - 1, Pow2.T04 - 1, Pow2.T05 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1);
            var v256Actual = CpuVector.vgather256(n256, ref src);
            Claim.eq(v256Expect,v256Actual);

            var v512Expect = CpuVector.vparts(n256, 0, Pow2.T03 - 1, Pow2.T04 - 1, Pow2.T05 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1, Pow2.T09 - 1);
            var v512Actual = CpuVector.vgather512(n256, ref src);
            Claim.eq(v512Expect,v512Actual);

        }


        public void vgather_128x322_512x128x32i()
        {
            var n = n128;
            var w = n512;
            var ix = n128;

            var data = span(range(z32,(uint)(w-1)));
            Claim.eq(data.Length, w);

            ref var src = ref head(data);

            for(var i=0; i<RepCount; i++)
            {
                var vIdx = Random.CpuVector<int>(ix, 0, w);
                var vExpect = CpuVector.vparts(n, (uint)vcell(vIdx,0), (uint)vcell(vIdx,1), (uint)vcell(vIdx,2), (uint)vcell(vIdx,3));
                var vActual = CpuVector.vgather(n, ref src, vIdx);                                
                Claim.eq(vExpect, vActual);
            }            

        }

        public void vgather_128x64_512x128x64i()
        {
            var n = n128;
            var w = n512;
            var ix = n128;

            var data = span(range(z64,(ulong)(w-1)));
            Claim.eq(data.Length, w);

            ref var src = ref head(data);

            for(var i=0; i<RepCount; i++)
            {
                var vIdx = Random.CpuVector<long>(ix, 0, w);
                var vExpect = CpuVector.parts(n, (ulong)vcell(vIdx,0), (ulong)vcell(vIdx,1));
                var vActual = CpuVector.vgather(n, ref src, vIdx);                                
                Claim.eq(vExpect, vActual);
            }            
        }

        public void vgather_128x32u_512x256x64i()
        {
            var n = n128;
            var w = n512;            
            var ix = n256;

            var data = span(range(0u,(uint)(w-1)));
            Claim.eq(data.Length, w);

            ref var src = ref head(data);

            for(var i=0; i<RepCount; i++)
            {
                var vIdx = Random.CpuVector<long>(ix, 0, w);
                var vExpect = CpuVector.vparts(n, (uint)vcell(vIdx,0), (uint)vcell(vIdx,1), (uint)vcell(vIdx,2), (uint)vcell(vIdx,3));
                var vActual = CpuVector.vgather(n, ref src, vIdx);                
                Claim.eq(vExpect, vActual);
            }            
        }

        public void vgather_256x32i_1024x256x32i()
        {
            var n = n256;
            var w = n1024;
            var ix = n256;

            var data = span(range(0,w-1));
            Claim.eq(data.Length, w);
            
            ref var src = ref head(data);

            for(var i=0; i<RepCount; i++)
            {
                var vIdx = Random.CpuVector<int>(ix, 0, w);
                var vExpect = vIdx;
                var vActual = CpuVector.vgather(n, ref src, vIdx);                                
                Claim.eq(vExpect, vActual);
            }            
        }

        public void vgather_256x32u_1024x256x32i()
        {
            var n = n256;
            var w = n1024;
            var ix = n256;

            var data = span(range<uint>(0,(uint)(w-1)));
            Claim.eq(data.Length, w);

            ref var src = ref head(data);

            for(var i=0; i<RepCount; i++)
            {
                var vIdx = Random.CpuVector<int>(ix, 0, w);
                var vExpect = v32u(vIdx);
                var vActual = CpuVector.vgather(n, ref src, vIdx);                
                Claim.eq(vExpect, vActual);
            }            

        }

        const int MaxCells128 = 512;
                
        const int BlockLen128 = 4;
        
        // 128
        const int MaxBlocks128 = MaxCells128 / BlockLen128;


        public void vgather_128x32u_blocks_outline()
        {                
            var blocks = MaxBlocks128;
            var blocklen = BlockLen128;
            var w = n128;
            var t = z32;
            var A = DataBlocks.alloc(w,blocks, t);                
            var B = DataBlocks.alloc(w,blocks, t);

            var pattern0 = VMask.vlsb(w,n2,n1,t);
            var pattern1 = VMask.vmsb(w,n2,n1,t);

            for(var block = 0; block < blocks; block++)
            {
                var target = A.Block(block);
                var source = even(block) ? pattern0 : pattern1;
                source.StoreTo(target);
            }

            var a0 = CpuVector.vgather(w, ref A.Head, CpuVector.vpartsi(w,4*12, 4*24, 4*48, 4*64));
            Claim.eq(a0,pattern0);

            for(var block = 0; block < blocks; block++)
            {
                var i0 = block*blocklen;
                var i1 = i0 + 1;
                var i2 = i1 + 1;
                var i3 = i2 + 1;
                
                var indices = CpuVector.vpartsi(w,i0,i1,i2,i3);
                var result = CpuVector.vgather(w, ref A.Head, indices);
                var expect = even(block) ? pattern0 : pattern1;
                Claim.eq(result,expect);                
            }
        }

        public void vgather_256x64u_1024x256x64i()
        {
            var n = n256;
            var w = n1024;
            var ix = n256;

            var data = span(range(0ul,(ulong)(w-1)));
            Claim.eq(data.Length, w);

            ref var src = ref head(data);

            for(var i=0; i<RepCount; i++)
            {
                var vIdx = Random.CpuVector<long>(ix, 0, w);
                var vExpect = v64u(vIdx);            
                var vActual = CpuVector.vgather(n, ref src, vIdx);    
                Claim.eq(vExpect, vActual);
            }            

        }

        public void vgather_256x64u_1024x128x32i()
        {
            var n = n256;
            var w = n1024;
            var ix = n128;

            var data = span(range(0ul,(ulong)(w-1)));
            Claim.eq(data.Length, w);

            ref var src = ref head(data);

            for(var i=0; i<RepCount; i++)
            {
                var vIdx = Random.CpuVector<int>(ix, 0, w);
                var vExpect = CpuVector.vparts(n, (ulong)vcell(vIdx,0), (ulong)vcell(vIdx,1), (ulong)vcell(vIdx,2), (ulong)vcell(vIdx,3));
                var vActual = CpuVector.vgather(n, ref src, vIdx);
                Claim.eq(vExpect, vActual);
            }            
        }

    
        public void vgather_256x64u()
        {
            var n = 2048;
            var w = n256;
            
            Span<ulong> data = new ulong[n];
            ref var src = ref head(data);
            gmath.increments(n, ref src);
        
            var i0 = CpuVector.vpartsi(w, 0, n/4 - 1, n/2 - 1, n - 1);
            var v0 = CpuVector.vgather(w, ref src, i0);            
            var e0 = v64u(i0);
            Claim.eq(e0,v0);

        }

    }
}
