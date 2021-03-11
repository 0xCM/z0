//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public class t_bg_broken : t_bitgrids<t_bg_broken>
    {
        public override bool Enabled => false;

        public void nbg_describe_dim()
        {
            var g1 = Dimensions.dim<N128,N4,N32,uint>();
            Claim.eq(g1.BitCount,128);
            Claim.eq(g1.BlockLength,4);
            Claim.eq(g1.BlockWidth,128);
            Claim.eq(g1.ByteCount,16);
            Claim.eq(g1.CellCount,4);
            Claim.eq(g1.CellWidth,32);
            Claim.eq(g1.ColCount, 32);
            Claim.eq(g1.RowCount, 4);
            Claim.eq(g1.BlockCount,1);

            var g2 = Dimensions.dim<N256,N16,N16,byte>();
            Claim.eq(g2.BitCount,256);
            Claim.eq(g2.BlockLength,32);
            Claim.eq(g2.BlockWidth,256);
            Claim.eq(g2.ByteCount,32);
            Claim.eq(g2.CellCount,32);
            Claim.eq(g2.CellWidth,8);
            Claim.eq(g2.ColCount, 16);
            Claim.eq(g2.RowCount, 16);
            Claim.eq(g2.BlockCount,1);
        }

        public void bg_layout_32x8x8()
        {
            const ushort rows = 32;
            const ushort cols = 8;
            const ushort cellwidth = 8;
            var map = GridCalcs.metrics(rows, cols, cellwidth);
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
            var map = GridCalcs.metrics(rows,cols,segwidth);
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

            ref readonly var src = ref memory.first64u(data);
            var spec = GridCalcs.grid(n8, n8, byte.MinValue);
            var map = spec.Map();
            var state = bit.Off;
            Claim.eq(map.CellCount, data.Length * width<byte>());
            for(var row = 0; row < map.RowCount; row++)
            for(var col = 0; col < map.ColCount; col++)
            {
                var actual = bit.test(src, (byte)map.Position(row,col));
                Claim.Require(actual == state);
                state = !state;
            }
        }
    }
}