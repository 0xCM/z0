//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vgather : IntrinsicTest<t_vgather>
    {

        public void vgather_128_basecase()
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

            var v256Actual = dinx.vgather256(n128, ref src32);
            var v256Expect = dinx.vparts(n128,0, 63, 127, 255);
            Claim.eq(v256Expect,v256Actual);

            var v512Actual = dinx.vgather512(n128, ref src32);
            var v512Expect = dinx.vparts(n128,0, 127, 255, 511);
            Claim.eq(v512Expect,v512Actual);

            //Each claim below asserts that each gather operation is an identiy function
            //with respect to the defined indexes (and ignoring the type of the underlying data)

            var i2x8 = dinx.vpartsi(n128, 8, 16);
            var v2x8 = dinx.vgather(n128, ref src64, i2x8);
            Claim.eq(i2x8, v64i(v2x8));            

            var i2x64 = dinx.vpartsi(n128, 64, 128);
            var v2x64 = dinx.vgather(n128, ref src64, i2x64);
            Claim.eq(i2x64, v64i(v2x64));            

            var i2x250 = dinx.vpartsi(n128, 250, 500);
            var v2x250 = dinx.vgather(n128, ref src64, i2x250);
            Claim.eq(i2x250, v64i(v2x250));            

            var i2x2 = dinx.vpartsi(n256, 2, 4, 8, 16);
            var v2x2 = dinx.vgather(n128, ref src32, i2x2);
            Claim.eq(dinx.vcontract(i2x2, out var _), v32i(v2x2));            

            var i3x3 = dinx.vpartsi(n256, 3, 6, 12, 24);
            var v3x3 = dinx.vgather(n128, ref src32, i3x3); 
            Claim.eq(dinx.vcontract(i3x3, out var _), v32i(v3x3));

            var i3_3 = dinx.vpartsi(n256, 3, 6, 9, 12);
            var v3_3 = dinx.vgather(n128, ref src32, i3_3); 
            Claim.eq(dinx.vcontract(i3_3, out var _), v32i(v3_3));

            var i4x2 = dinx.vpartsi(n256, 4, 8, 16, 32);
            var v4x2 = dinx.vgather(n128, ref src32, i4x2);
            Claim.eq(dinx.vcontract(i4x2, out var _), v32i(v4x2));

            var i5_5 = dinx.vpartsi(n256, 5, 10, 15, 20);
            var v5_5 = dinx.vgather(n128, ref src32, i5_5);
            Claim.eq(dinx.vcontract(i5_5, out var _), v32i(v5_5));

            var i9_9 = dinx.vpartsi(n256, 9, 18, 27, 36);
            var v9_9 = dinx.vgather(n128, ref src32, i9_9);
            Claim.eq(dinx.vcontract(i9_9, out var _), v32i(v9_9));

            var i10_10 = dinx.vpartsi(n256, 10, 20, 30, 40);
            var v10_10 = dinx.vgather(n128, ref src32, i10_10);
            Claim.eq(dinx.vcontract(i10_10, out var _), v32i(v10_10));

            var i16x2 = dinx.vpartsi(n256, 16, 32, 64, 128);
            var v16x2 = dinx.vgather(n128, ref src32, i16x2);
            Claim.eq(dinx.vcontract(i16x2, out var _), v32i(v16x2));

            var i20_5 = dinx.vpartsi(n256, 20, 25, 30, 35);
            var v20_5 = dinx.vgather(n128, ref src32, i20_5);
            Claim.eq(dinx.vcontract(i20_5, out var _), v32i(v20_5));

            var i40_3 = dinx.vpartsi(n256, 40, 43, 46, 49);
            var v40_3 = dinx.vgather(n128, ref src32, i40_3);
            Claim.eq(dinx.vcontract(i40_3, out var _), v32i(v40_3));

            var i4x128 = dinx.vpartsi(n256, 0, 128 - 1, 128*2 - 1, 128*4 - 1);
            var v4x128 = dinx.vgather512(n128, ref src32);
            Claim.eq(dinx.vcontract(i4x128, out var _), v32i(v4x128));

            
        }

        public void vgather_256_basecase()
        {
            Span<uint> data = new uint[Pow2.T09];
            for(var i=0; i<data.Length; i++)
                data[i] = (uint)i;
            ref var src = ref head(data);                

            var v256Expect = dinx.vparts(n256, 0, Pow2.T02 - 1, Pow2.T03 - 1, Pow2.T04 - 1, Pow2.T05 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1);
            var v256Actual = dinx.vgather256(n256, ref src);
            Claim.eq(v256Expect,v256Actual);

            var v512Expect = dinx.vparts(n256, 0, Pow2.T03 - 1, Pow2.T04 - 1, Pow2.T05 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1, Pow2.T09 - 1);
            var v512Actual = dinx.vgather512(n256, ref src);
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

            for(var i=0; i<SampleSize; i++)
            {
                var vIdx = Random.CpuVector<int>(ix, 0, w);
                var vExpect = dinx.vparts(n, (uint)vcell(vIdx,0), (uint)vcell(vIdx,1), (uint)vcell(vIdx,2), (uint)vcell(vIdx,3));
                var vActual = dinx.vgather(n, ref src, vIdx);                                
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

            for(var i=0; i<SampleSize; i++)
            {
                var vIdx = Random.CpuVector<long>(ix, 0, w);
                var vExpect = dinx.vparts(n, (ulong)vcell(vIdx,0), (ulong)vcell(vIdx,1));
                var vActual = dinx.vgather(n, ref src, vIdx);                                
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

            for(var i=0; i<SampleSize; i++)
            {
                var vIdx = Random.CpuVector<long>(ix, 0, w);
                var vExpect = dinx.vparts(n, (uint)vcell(vIdx,0), (uint)vcell(vIdx,1), (uint)vcell(vIdx,2), (uint)vcell(vIdx,3));
                var vActual = dinx.vgather(n, ref src, vIdx);                
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

            for(var i=0; i<SampleSize; i++)
            {
                var vIdx = Random.CpuVector<int>(ix, 0, w);
                var vExpect = vIdx;
                var vActual = dinx.vgather(n, ref src, vIdx);                                
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

            for(var i=0; i<SampleSize; i++)
            {
                var vIdx = Random.CpuVector<int>(ix, 0, w);
                var vExpect = v32u(vIdx);
                var vActual = dinx.vgather(n, ref src, vIdx);                
                Claim.eq(vExpect, vActual);
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

            for(var i=0; i<SampleSize; i++)
            {
                var vIdx = Random.CpuVector<long>(ix, 0, w);
                var vExpect = v64u(vIdx);            
                var vActual = dinx.vgather(n, ref src, vIdx);    
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

            for(var i=0; i<SampleSize; i++)
            {
                var vIdx = Random.CpuVector<int>(ix, 0, w);
                var vExpect = dinx.vparts(n, (ulong)vcell(vIdx,0), (ulong)vcell(vIdx,1), (ulong)vcell(vIdx,2), (ulong)vcell(vIdx,3));
                var vActual = dinx.vgather(n, ref src, vIdx);
                Claim.eq(vExpect, vActual);
            }            
        }
    }
}
