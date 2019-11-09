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
        public void emit_grid_maps()
            => GridWriter.EmitGridMaps();

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

        public void natural_layout()
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

        public void bitread_check()
        {
            bitread_check<uint>(20,20);
            bitread_check<uint>(21,30);
            bitread_check<uint>(17,25);
            bitread_check<ulong>(250,67);
            bitread_check<byte>(250,67);
            bitread_check<ushort>(250,67);
        }



        public void bitgrid_store()
        {
            // var g1 = Random.BitGrid<uint>(20,20);
            var dst = DataBlocks.alloc(n128);
            var dst8u = dst.AsBytes();
            for(var i=0; i<16; i++)
                dst8u[i] = Random.Next<byte>();
            var bs1 = dst.ToBitString();
            var bs2 = dst8u.ToBitString();
            Claim.eq(bs1,bs2);

            var a = Random.Span128<byte>();
            var b = DataBlocks.alloc(n128);
            DataBlocks.store(in a.Head, 16, ref b);
            Claim.eq(a, b.AsBytes());






            


            
            
            

        }



        void bitread_check<T>(ushort rows, ushort cols)
            where T : unmanaged
        {
            for(var i = 0; i < SampleSize; i++)
            {
                var src = Random.BitGrid<T>(rows,cols);
                var moniker = src.Moniker;
                Claim.eq(moniker, BitGrid.moniker<T>(rows,cols));

                var dstA = BitGrid.alloc<T>(rows,cols);
                var dstB = BitGrid.alloc<T>(rows,cols);                

                var bitpos = 0;
                for(var row = 0; row < rows; row++)
                for(var col = 0; col < cols; col++, bitpos++)
                {
                    var b1 = BitGrid.readbit(moniker, in src.Head, row, col);
                    var b2 = BitGrid.readbit(in src.Head, bitpos);
                    Claim.yea(b1 == b2);

                    dstA[row,col] = b1;
                    dstB[bitpos] = b2;                    
                }
                var bsA = dstA.ToBitString();
                var bsB = dstB.ToBitString();
                Claim.eq(bsA, bsB);
            }

        }
        void bitread_bench<T>(ushort M, ushort N, int cycles, SystemCounter counter = default)
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

        void bitset_bench<T>(ushort M, ushort N, int cycles, SystemCounter counter = default)
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
            ushort M = 249;
            ushort N = 128;
            var moniker = GridMoniker.Define<ulong>(M,N);
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
                
                var b1 = BitGrid.readbit(moniker, in head(src), row,col);
                var b2 = bg[row,col];
                Claim.eq(b1,b2);
            }            
        }

        public void layout_32x8x8()
        {
            const ushort rows = 32;
            const ushort cols = 8;            
            const ushort cellwidth = 8;
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
            const ushort rows = 17;
            const ushort cols = 11;            
            const ushort segwidth = 8;
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
            var rows = natval(m);
            var cols = natval(n);
            var points = rows*cols;
            var bytes = points/8 + (points % 8 != 0 ? 1 : 0);
            var bits = bytes*8;
            var segbytes = size<T>();
            var segments = bytes/segbytes + (bytes % segbytes != 0 ? 1 : 0);

            var grid = BitGrid.alloc(m,n,zero);

            
            for(var i=0; i< SampleSize; i++)
            {
                var input = Random.BitString(grid.Moniker.PointCount);
                for(var pos=0; pos<input.Length; pos++)
                    grid[pos] = input[pos];

                var output = grid.ToBitString();
                Claim.eq(input,output);                                            
            }

        }

    }

}