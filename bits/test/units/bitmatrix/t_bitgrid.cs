//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bitgrid : BitMatrixTest<t_bitgrid>
    {
        
        public unsafe void memtest()
        {
            var data = new uint[40];
            ref var h = ref first(data);
            // var h2 = __makeref(data);
            // ref var h = ref Unsafe.AsRef<uint>(&(h2));
                        
            Random.StreamTo(40, ref first(data));
            var result = 0xFu;
            //ref var h = ref head(ref data);
            for(var i=0; i<40; i++)
                result ^= seek(ref h, i);

        }

        public void layout_8x8()
        {
            
            Span<byte> data = stackalloc byte[8];
            data.Fill(0b10101010);

            ref readonly var src = ref head64(data);
            var spec = GridLayout.specify(n8, n8, byte.MinValue);
            var map = spec.ToGridMap();
            var state = bit.Off;
            Claim.eq(map.Volume, data.Length * bitsize<byte>());
            for(var row = 0; row < map.RowCount; row++)
            for(var col = 0; col < map.ColCount; col++)
            {
                var index = map.Cell(row,col);
                var actual = gbits.test(src, index.Position);
                Claim.yea(actual == state);
                state = !state;
            }        
        }

        public void layout_32x8x8()
        {
            const int rows = 32;
            const int cols = 8;            
            const int cellwidth = 8;
            var map = GridLayout.map(rows, cols, cellwidth);
            Claim.eq(8*32, map.Storage);
            
            var current = 0;

            for(var row = 0; row < rows; row++)
            for(var col = 0; col < cols; col++, current++)
            {
                var pos1 = map[row,col].Position;
                var pos2 = map[current].Position;

                Claim.eq(pos1, current);
                Claim.eq(pos2, current);
                
            }

            Claim.eq(current, rows*cols);
            Claim.eq(current, map.Volume);
        }

        public void bg_17x11x8_layout_check()
        {
            const int rows = 17;
            const int cols = 11;            
            const int segwidth = 8;
            const int volume = rows*cols;
            const int storage = volume + (volume % segwidth != 0 ? segwidth : 0);
            const int segments = storage/segwidth;
            
            var map = GridLayout.map(rows, cols, segwidth);
            Claim.eq(map.Storage, storage);
            Claim.eq(map.Segments, segments);

            var current = 0;

            for(var row = 0; row < rows; row++)
            for(var col = 0; col < cols; col++, current++)
            {
                var pos1 = map[row,col].Position;
                var pos2 = map[current].Position;

                Claim.eq(pos1, current);
                Claim.eq(pos2, current);
                
            }

            Claim.eq(current, rows*cols);
            Claim.eq(current, map.Volume);
        
        }

        public void bg_32x32x32_check()
        {
            var n = n32;
            var zero = 0u;
            var matrix = Random.BitMatrix(n);
            var grid = matrix.ToGrid();
            for(var row = 0; row < n; row++)
            for(var col = 0; col < n; col++)
                Claim.eq(grid[row,col], matrix[row,col]);

            bg_check(n,n,zero);
        }

        public void bg_64x64x64_check()
        {
            var n = n64;
            var zero = 0ul;
            var matrix = Random.BitMatrix(n);
            var grid = matrix.ToGrid();
            for(var row = 0; row < n; row++)
            for(var col = 0; col < n; col++)
                Claim.eq(grid[row,col], matrix[row,col]);

            bg_check(n,n,zero);                
        }

        public void bg_3x5x8_check()
            => bg_check(n3,n5, byte.MinValue);

        public void bg_17x11x8_check()
            => bg_check(n17,n11,byte.MinValue);

        public void bg_30x30x32_check()
            => bg_check(n30,n30,uint.MinValue);

        void bg_check<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var rows = unat(m);
            var cols = unat(n);
            var vol = rows*cols;
            var segwidth = (int)bitsize<T>();                        
            var storage = vol + (vol % segwidth != 0 ? segwidth : 0);
            var segments = storage/segwidth;

            var grid = BitGrid.alloc(m,n,zero);
            var bitmap = grid.BitMap;

            Claim.eq(bitmap.Volume, vol);
            Claim.eq(bitmap.Storage, storage);
            Claim.eq(bitmap.Segments, segments);

            
            for(var i=0; i< SampleSize; i++)
            {
                var input = Random.BitString(grid.BitMap.Volume);
                for(var pos=0; pos<input.Length; pos++)
                    grid[pos] = input[pos];

                var output = grid.ToBitString();
                Claim.eq(input,output);                                            
            }

        }

    }

}