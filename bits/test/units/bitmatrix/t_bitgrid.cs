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
        public void EmitGridMaps()
        {
            void Emit(int segwidth, int minsegs, int maxsegs)
            {
                var filename = FileName.Define($"GridMap{segwidth}.csv");
                using var dst = LogArea.Test.LogWriter(filename);
                dst.WriteLine(BitGrid.header());
                var points = (
                    from r1 in range(minsegs,maxsegs)
                    from r2 in range(minsegs,maxsegs)
                    let count = r1*r2
                    orderby count
                    select (r1, r2)).ToArray();

                for(var i = 0; i<points.Length; i++)
                {
                    (var r, var c) = points[i];
                    var gs = BitGrid.map(r,c,segwidth).Stats();
                        if(gs.Vec256Remainder == 0 || gs.Vec128Remainder == 0)
                            dst.WriteLine(gs.Format());
                }
                             
                dst.Flush();
            }

            Emit(8, 1, 256);
            Emit(16,1, 256);
            Emit(32,1, 256);
            Emit(64,1, 256);

        }

        public void layout_8x8()
        {
            
            Span<byte> data = stackalloc byte[8];
            data.Fill(0b10101010);

            ref readonly var src = ref head64(data);
            var spec = BitGrid.specify(n8, n8, byte.MinValue);
            var map = spec.Map();
            var state = bit.Off;
            Claim.eq(map.PointCount, data.Length * bitsize<byte>());
            for(var row = 0; row < map.RowCount; row++)
            for(var col = 0; col < map.ColCount; col++)
            {
                var index = map.Cell(row,col);
                var actual = gbits.test(src, index.Position);
                Claim.yea(actual == state);
                state = !state;
            }        
        }

        public void bitread_bench()
        {
            bitread_bench<ulong>(249,128, Pow2.T08);
            bitread_bench<byte>(249,128, Pow2.T08);
            bitread_bench<ulong>(64,64, Pow2.T08);


            bitmatrix_bitread_bench<ulong>(Pow2.T08);
        }

        public void bitset_bench()
        {
            bitset_bench<ulong>(249,128, Pow2.T08);
            bitset_bench<byte>(249,128, Pow2.T08);
        }

        void bitread_bench<T>(int M, int N, int cycles, SystemCounter counter = default)
            where T : unmanaged
        {
            var last = bit.Off;
            for(var i = 0; i<cycles; i++)
            {
                var src = Random.BitGrid<T>(M,N);

                counter.Start();
                for(var row = 0; row< M; row++)
                for(var col = 0; col< N; col++)
                    last = src[row,col];
                counter.Stop();
            }

            Benchmark($"gridread_{moniker<T>()}", counter, cycles*M*N);
        }

        void bitmatrix_bitread_bench<T>(int cycles, SystemCounter counter = default)
            where T : unmanaged
        {
            var last = bit.Off;
            int M = bitsize<T>();
            int N = bitsize<T>();
            for(var i = 0; i<cycles; i++)
            {
                var src = Random.BitMatrix<T>();

                counter.Start();
                for(var row = 0; row< M; row++)
                for(var col = 0; col< N; col++)
                    last = src[row,col];
                counter.Stop();
            }

            Benchmark($"bitmatrix_bitread_{moniker<T>()}", counter, cycles*M*N);
        }

        void bitset_bench<T>(int M, int N, int cycles, SystemCounter counter = default)
            where T : unmanaged
        {
            var dst = BitGrid.alloc<T>(M,N);
            for(var i = 0; i<cycles; i++)
            {
                var src = Random.BitString(M*N);
                var pos = 0;
                
                counter.Start();
                for(var row = 0; row< M; row++)
                for(var col = 0; col< N; col++, pos++)
                    dst[row,col] = src[pos];
                counter.Stop();
            }

            Benchmark($"gridset_{moniker<T>()}", counter, cycles*M*N);
        }

        public void bg_249x128x64()
        {
            var M = 249;
            var N = 128;
            int segwidth = bitsize<ulong>();
            var segorder = (int)math.log2(segwidth);

            var map = BitGrid.map<ulong>(M,N);
            var points = M*N;
            var segs = (points >> segorder) + (points % segwidth != 0 ? 1 : 0);
            Claim.eq(map.SegCount, segs);
        

            var src = Random.Span<ulong>(segs);
            var bg = BitGrid.load(src,M,N);

            for(var row = 0; row< M; row++)
            for(var col = 0; col< N; col++)
            {
                var pos = N*row + col;
                var seg = pos >> segorder;
                var offset = pos % segwidth;

                Claim.eq(map.Pos(row,col), pos);
                Claim.eq(map.Cell(pos).Segment, seg);
                Claim.eq(map.Cell(pos).Offset, offset);
                
                var b1 = BitGrid.bitread(in head(src), N, row,col);
                var b2 = bg[row,col];
                Claim.eq(b1,b2);
            }

            
        }


        public void layout_32x8x8()
        {
            const int rows = 32;
            const int cols = 8;            
            const int cellwidth = 8;
            var map = BitGrid.map(rows, cols, cellwidth);
            Claim.eq(8*32, map.StorageBits);
            
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
            Claim.eq(current, map.PointCount);
        }

        public void bg_17x11x8_layout_check()
        {
            const int rows = 17;
            const int cols = 11;            
            const int segwidth = 8;
            var points = rows*cols;
            var bytes = points/8 + (points % 8 != 0 ? 1 : 0);
            var bits = bytes/8;
            var map = BitGrid.map(rows,cols,segwidth);
            Claim.eq(bytes, map.SegCount);
            Claim.eq(points, map.PointCount);

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
            Claim.eq(current, map.PointCount);
        
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
            => bg_check(n30,n30, uint.MinValue);

        void bg_check<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var rows = inat(m);
            var cols = inat(n);
            var points = rows*cols;
            var bytes = points/8 + (points % 8 != 0 ? 1 : 0);
            var bits = bytes*8;
            var segbytes = size<T>();
            var segments = bytes/segbytes + (bytes % segbytes != 0 ? 1 : 0);

            var grid = BitGrid.alloc(m,n,zero);
            var bitmap = grid.BitMap;

            Claim.eq(bitmap.PointCount, points);
            Claim.eq(bitmap.StorageBits, bits);
            Claim.eq(bitmap.SegCount, segments);

            
            for(var i=0; i< SampleSize; i++)
            {
                var input = Random.BitString(grid.BitMap.PointCount);
                for(var pos=0; pos<input.Length; pos++)
                    grid[pos] = input[pos];

                var output = grid.ToBitString();
                Claim.eq(input,output);                                            
            }

        }

    }

}