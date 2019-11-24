//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bitgrid : BitMatrixTest<t_bitgrid>
    {        
        public void bg_row_8x4()
        {
            var m = n8;
            var n = n4;
            var data = Random.Next<uint>();
            var bs = data.ToBitString();
            var bg = data.ToBitGrid(m,n);            

            for(var r = 0; r < m; r++)
            {                
                var bv1 = BitGrid.row(bg,r);
                var bs1 = bs.Slice(r*n,n);
                Claim.eq(bv1, bs1.ToBitVector(n4));                
            }
        }

        public void bg_col_32x2()
        {
            var m = n32;
            var n = n2;
            var xg = Random.BitGrid(m,n);
            var xs = xg.ToSpan().ToBitString().Transpose(m,n);

            for(var i=0; i<n; i++)
            {
                var bv1 = BitGrid.col(xg,i);     
                var bv2 = xs.Slice(i*m, m).ToBitVector(m);                    
                Claim.eq(bv1, bv2);
            }            
        }

        public void bg_row_16x16()
        {
            var m = n16;
            var n = n16;
            var grid = Random.BitGrid<ulong>(m,n);
            var data = grid.ToSpan().AsUInt16();
            for(var i = 0; i<m; i++)
            {
                var row1 = BitGrid.row(grid,i);
                var row2 = data[i].ToBitVector();
                Claim.eq(row1,row2);
            }

        }


        public void bg_col_8x4()
        {
            var m = n8;
            var n = n4;
            var xg = Random.BitGrid(m,n);
            var xs = xg.ToSpan().ToBitString().Transpose(m,n);

            for(var i=0; i<n; i++)
            {
                var bv1 = BitGrid.col(xg,i);     
                var bv2 = xs.Slice(i*m, m).ToBitVector(m);                    
                Claim.eq(bv1, bv2);
            }            
        }

        public void bg_col_64()
        {

            var m = n8;
            var n = n8;
            var xg = Random.BitGrid(m,n);
            var xs = xg.ToSpan().ToBitString().Transpose(m,n);
            for(var i=0; i<n; i++)
            {
                var bv1 = BitGrid.col(xg,i);     
                var bv2 = xs.Slice(i*m, m).ToBitVector(m);                    
                Claim.eq(bv1, bv2);
            }            

        }

        public void bg_col_256()
        {
            var block = n256;
            var m = n32;
            var n = n8;
            var xg = Random.BitGrid<ulong>(m,n);
            var xs = xg.ToSpan().ToBitString().Transpose(m,n);
            for(var i=0; i<n; i++)
            {
                var bv1 = BitGrid.col(xg,i);     
                var bv2 = xs.Slice(i*m, m).ToBitVector(m);                    
                Claim.eq(bv1, bv2);
            }            
        }

        public void bg_col_128()
        {
            var block = n128;
            var m = n16;
            var n = n8;
            var xg = Random.BitGrid<ulong>(m,n);
            var xs = xg.ToSpan().ToBitString().Transpose(m,n);
            for(var i=0; i<n; i++)
            {
                var bv1 = BitGrid.col(xg,i);     
                var bv2 = xs.Slice(i*m, m).ToBitVector(m);                    
                Claim.eq(bv1, bv2);
            }            

        }

        void emit_factors()
        {
            var k = 8u;
            
            for(var j = 1u; j<= 32u; j*=2)
                Trace($"{j*k}", gmath.factor(j*k).FormatPairs(PairFormat.Dim));

        }
        public void emit_grid_maps()
            => GridWriter.EmitGridMaps();

        public void layout_8x8()
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

        public void bgbs_11x3x16u()
            => bg_bs_check(n11,n3,ushort.MinValue);
            
        public void bgbs_64x4x8u()
            => bg_bs_check(n64,n4,byte.MinValue);

        public void bgbs_113x201x64u()
            => bg_bs_check(natseq(n1,n1,n3), natseq(n2,n0,n1), ulong.MinValue);

        void bg_bs_check<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var sample = 0; sample < SampleSize; sample++)
            {
                var bg = BitGrid.alloc(m,n,zero);
                var bs = Random.BitString((int)NatMath.mul(m,n));

                for(var i=0; i<bs.Length; i++)
                    bg[i] = bs[i];
                
                Claim.eq(bg.ToBitString(), bs);        
            }
        }

        public void natural_layout()
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
        

        void bitread_check<T>(ushort rows, ushort cols)
            where T : unmanaged
        {
            for(var i = 0; i < SampleSize; i++)
            {
                var src = Random.BitGrid<T>(rows,cols);
                var dstA = BitGrid.alloc<T>(rows,cols);
                var dstB = BitGrid.alloc<T>(rows,cols);                

                var bitpos = 0;
                for(var row = 0; row < rows; row++)
                for(var col = 0; col < cols; col++, bitpos++)
                {
                    var b1 = BitGrid.readbit(src.Width, in src.Head, row, col);
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
            var moniker = GridMoniker.FromDim<ulong>(M,N);
            int segwidth = bitsize<ulong>();
            var segorder = (int)math.log2(segwidth);

            var map = GridMap.Define<ulong>(M,N);
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
                Claim.eq(map.Seg(row,col), seg);
                Claim.eq(map.Offset(row,col), offset);
                
                var b1 = BitGrid.readbit(N, in head(src), row, col);
                var b2 = bg[row,col];
                Claim.eq(b1,b2);
            }            
        }

        public void layout_32x8x8()
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

        public void bg_17x11x8_layout_check()
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
                var input = Random.BitString(grid.PointCount);
                for(var pos=0; pos<input.Length; pos++)
                    grid[pos] = input[pos];

                var output = grid.ToBitString();
                Claim.eq(input,output);                                            
            }

        }

    }

}