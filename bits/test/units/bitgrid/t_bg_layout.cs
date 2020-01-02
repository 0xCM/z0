//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bg_layout : t_bg<t_bg_layout>
    {        

        public void bg_layout_21x32x32()
        {
            var a0 = GridSpec.Define(n21,n32,0u);
            var b0 = GridSpec.Define(21, 32, 32);
            Claim.eq(a0,b0);

            var a1 = GridSpec.Define(n32,n64,ushort.MinValue);
            var b1 = GridSpec.Define(32, 64, 16);
            Claim.eq(a1,b1);

            var a2 = GridSpec.Define(n5,n15,byte.MinValue);
            var b2 = GridSpec.Define(5, 15, 8);
            Claim.eq(a2,b2);
        }

        public void bg_layout_249x128x64()
        {
            ushort M = 249;
            ushort N = 128;
            var moniker = GridMoniker.FromDim<ulong>(M,N);
            int segwidth = bitsize<ulong>();
            var segorder = (int)math.log2(segwidth);

            var map = GridMap.Define<ulong>(M,N);
            var points = M*N;
            var segs = (points >> segorder) + (points % segwidth != 0 ? 1 : 0);
            Claim.eq(map.SegCount, segs);
        
            var src = Random.Blocks<ulong>(n256,1);
            var bg = BitGrid.load(src,M,N);

            for(var row = 0; row< M; row++)
            for(var col = 0; col< N; col++)
            {
                var pos = N*row + col;
                var seg = pos >> segorder;
                var offset = pos % segwidth;

                Claim.eq(map.Pos(row,col), pos);
                Claim.eq(map.Seg(row,col), seg);
                Claim.eq(map.Offset(row,col), offset);
                
                var b1 = BitGrid.readbit(N, in head(src), row, col);
                var b2 = bg[row,col];
                Claim.eq(b1,b2);
            }            
        }

        public void bg_layout_32x8x8()
        {
            const ushort rows = 32;
            const ushort cols = 8;            
            const ushort cellwidth = 8;
            var map = GridMap.Define(rows, cols, cellwidth);
            Claim.eq(8*32, map.StorageBits);
            
            var current = 0;

            for(var row = 0; row < rows; row++)
            for(var col = 0; col < cols; col++, current++)
                Claim.eq(map.Pos(row,col), current);

            Claim.eq(current, rows*cols);
            Claim.eq(current, map.PointCount);
        }

        public void bg_layout_17x11x8()
        {
            const ushort rows = 17;
            const ushort cols = 11;            
            const ushort segwidth = 8;
            var points = rows*cols;
            var bytes = points/8 + (points % 8 != 0 ? 1 : 0);
            var bits = bytes/8;
            var map = GridMap.Define(rows,cols,segwidth);
            Claim.eq(bytes, map.SegCount);
            Claim.eq(points, map.PointCount);

            var current = 0;

            for(var row = 0; row < rows; row++)
            for(var col = 0; col < cols; col++, current++)
                Claim.eq(map.Pos(row,col), current);
                
            Claim.eq(current, rows*cols);
            Claim.eq(current, map.PointCount);
        
        }

        public void bg_layout_8x8()
        {
            
            Span<byte> data = stackalloc byte[8];
            data.Fill(0b10101010);

            ref readonly var src = ref head64(data);
            var spec = GridSpec.Define(n8, n8, byte.MinValue);
            var map = spec.Map();
            var state = bit.Off;
            Claim.eq(map.PointCount, data.Length * bitsize<byte>());
            for(var row = 0; row < map.RowCount; row++)
            for(var col = 0; col < map.ColCount; col++)
            {
                var actual = gbits.test(src, (uint)map.Pos(row,col));
                Claim.yea(actual == state);
                state = !state;
            }        
        }

    }

}