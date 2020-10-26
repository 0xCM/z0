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

    public class t_bg_layout : t_bitgrids<t_bg_layout>
    {
        public void bg_layout_21x32x32()
        {
            var a0 = GridCells.grid(n21,n32,0u);
            var b0 = GridCells.grid(21, 32, 32);
            Claim.Eq(a0,b0);

            var a1 = GridCells.grid(n32,n64,ushort.MinValue);
            var b1 = GridCells.grid(32, 64, 16);
            Claim.Eq(a1,b1);

            var a2 = GridCells.grid(n5,n15,byte.MinValue);
            var b2 = GridCells.grid(5, 15, 8);
            Claim.Eq(a2,b2);
        }

        public void bg_layout_32x8x8()
        {
            const ushort rows = 32;
            const ushort cols = 8;
            const ushort cellwidth = 8;
            var map = BitGrid.metrics(rows, cols, cellwidth);
            Claim.eq(8*32, map.StoreWidth);

            var current = 0;

            for(var row = 0; row < rows; row++)
            for(var col = 0; col < cols; col++, current++)
                Claim.eq(map.Position(row,col), current);

            Claim.eq(current, rows*cols);
            Claim.eq(current, map.CellCount);
        }

        public void bg_layout_17x11x8()
        {
            const ushort rows = 17;
            const ushort cols = 11;
            const ushort segwidth = 8;
            var points = rows*cols;
            var bytes = points/8 + (points % 8 != 0 ? 1 : 0);
            var bits = bytes/8;
            var map = BitGrid.metrics(rows,cols,segwidth);
            Claim.eq(bytes, map.CellCount);
            Claim.eq(points, map.CellCount);

            var current = 0;

            for(var row = 0; row < rows; row++)
            for(var col = 0; col < cols; col++, current++)
                Claim.eq(map.Position(row,col), current);

            Claim.eq(current, rows*cols);
            Claim.eq(current, map.CellCount);
        }

        public void bg_layout_8x8()
        {

            Span<byte> data = stackalloc byte[8];
            data.Fill(0b10101010);

            ref readonly var src = ref AsDeprecated.first64(data);
            var spec = GridCells.grid(n8, n8, byte.MinValue);
            var map = spec.Map();
            var state = Bit32.Off;
            Claim.eq(map.CellCount, data.Length * bitwidth<byte>());
            for(var row = 0; row < map.RowCount; row++)
            for(var col = 0; col < map.ColCount; col++)
            {
                var actual = gbits.testbit32(src, (byte)map.Position(row,col));
                Claim.Require(actual == state);
                state = !state;
            }
        }
    }
}