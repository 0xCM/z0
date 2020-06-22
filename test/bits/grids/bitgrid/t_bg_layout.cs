//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    
    public class t_bg_layout : t_bg<t_bg_layout>
    {        
        public void bg_layout_21x32x32()
        {
            var a0 = BitGrid.specify(n21,n32,0u);
            var b0 = BitGrid.specify(21, 32, 32);
            Claim.eq(a0,b0);

            var a1 = BitGrid.specify(n32,n64,ushort.MinValue);
            var b1 = BitGrid.specify(32, 64, 16);
            Claim.eq(a1,b1);

            var a2 = BitGrid.specify(n5,n15,byte.MinValue);
            var b2 = BitGrid.specify(5, 15, 8);
            Claim.eq(a2,b2);
        }

        public void bg_layout_32x8x8()
        {
            const ushort rows = 32;
            const ushort cols = 8;            
            const ushort cellwidth = 8;
            var map = BitGrid.gridmap(rows, cols, cellwidth);
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
            var map = BitGrid.gridmap(rows,cols,segwidth);
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

            ref readonly var src = ref Spans.head64(data);
            var spec = BitGrid.specify(n8, n8, byte.MinValue);
            var map = spec.Map();
            var state = bit.Off;
            Claim.eq(map.PointCount, data.Length * bitsize<byte>());
            for(var row = 0; row < map.RowCount; row++)
            for(var col = 0; col < map.ColCount; col++)
            {
                var actual = gbits.testbit(src, (byte)map.Pos(row,col));
                Claim.require(actual == state);
                state = !state;
            }        
        }
    }
}