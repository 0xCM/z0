//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public abstract class t_bg<X> : t_bits<X>
        where X : t_bg<X>, new()
    {
        protected override int RepCount => Pow2.T04;

        protected override int CycleCount => Pow2.T03;

        protected void nbg_define_check<M,N,T>(M m = default, N n = default, T zero = default)
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
            
            for(var i=0; i< RepCount; i++)
            {
                var input = Random.BitString(grid.BitCount);
                for(var index=0; index<input.Length; index++)
                    grid.SetBit(index, input[index]);

                var output = grid.ToBitString();
                Claim.eq(input,output);                                            
            }
        }

        /// <summary>
        /// Verifies correct function of the natural bitgrid bitstring conversion
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The column count representative</param>
        /// <param name="zero">The cell representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The storage cell type</typeparam>
        protected void nbg_bitstring_check<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var sample = 0; sample < RepCount; sample++)
            {
                var bg = BitGrid.alloc(m,n,zero);
                var bs = Random.BitString((int)NatMath.mul(m,n));

                for(var i=0; i<bs.Length; i++)
                    bg.SetBit(i, bs[i]);
                
                Claim.eq(bg.ToBitString(), bs);        
            }
        }

        /// <summary>
        /// Verifies correct function of the generic bitgrid read operation
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        protected void gbg_bitread_check<T>(int rows, int cols)
            where T : unmanaged
        {
            for(var i = 0; i < RepCount; i++)
            {
                var src = Random.BitGrid<T>(rows,cols);
                var dstA = BitGrid.alloc<T>(rows,cols);
                var dstB = BitGrid.alloc<T>(rows,cols);                

                var bitpos = 0;
                for(var row = 0; row < rows; row++)
                for(var col = 0; col < cols; col++, bitpos++)
                {
                    var b1 = BitGrid.readbit(src.ColCount, in src.Head, row, col);
                    var b2 = BitGrid.readbit(in src.Head, bitpos);
                    Claim.yea(b1 == b2);

                    dstA[row,col] = b1;
                    dstB.SetBit(bitpos, b2);                    
                }
                var bsA = dstA.ToBitString();
                var bsB = dstB.ToBitString();
                Claim.eq(bsA, bsB);
            }
        }

        protected void bg_bitread_bench<T>(int M, int N, SystemCounter counter = default)
            where T : unmanaged
        {
            var last = bit.Off;
            for(var i = 0; i<CycleCount; i++)
            {
                var src = Random.BitGrid<T>(M,N);

                counter.Start();
                for(var row = 0; row< M; row++)
                for(var col = 0; col< N; col++)
                    last = src[row,col];
                counter.Stop();
            }

            ReportBenchmark($"gbg_read_{Identity.numericid<T>()}", CycleCount*M*N, counter);
        }

        protected void bm_bitread_bench<T>(SystemCounter counter = default)
            where T : unmanaged
        {
            var last = bit.Off;
            int M = bitsize<T>();
            int N = bitsize<T>();
            for(var i = 0; i<CycleCount; i++)
            {
                var src = Random.BitMatrix<T>();

                counter.Start();
                for(var row = 0; row< M; row++)
                for(var col = 0; col< N; col++)
                    last = src[row,col];
                counter.Stop();
            }

            ReportBenchmark($"gbm_bitread_{Identity.numericid<T>()}", CycleCount*M*N, counter);
        }

        protected void bg_bitwrite_bench<T>(ushort M, ushort N, SystemCounter counter = default)
            where T : unmanaged
        {
            var dst = BitGrid.alloc<T>(M,N);
            for(var i = 0; i<CycleCount; i++)
            {
                var src = Random.BitString(M*N);
                var pos = 0;
                
                counter.Start();
                for(var row = 0; row< M; row++)
                for(var col = 0; col< N; col++, pos++)
                    dst[row,col] = src[pos];
                counter.Stop();
            }

            ReportBenchmark($"gbg_bitwrite_{Identity.numericid<T>()}", CycleCount*M*N, counter);
        }

        void emit_grid_maps()
            => GridWriter.EmitGridMaps();

        protected void bg_and_check<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged,ITypeNat
            where N : unmanaged,ITypeNat
            where T : unmanaged
        {
            var gx = Random.BitGrid(m,n,t);
            var gy = Random.BitGrid(m,n,t);
            var gz = BitGrid.alloc(m,n,t);

            Claim.eq(gz.BlockCount, BitCalcs.tableblocks(n256,m,n,t));            
            Claim.eq(gz.CellCount, BitCalcs.tablecells(m,n,t));
            
            BitGrid.and(gx,gy,gz);
            
            for(var block=0; block<gx.BlockCount; block++)
                Claim.eq(ginx.vand(gx[block], gy[block]), gz[block]);   

        }

        protected void bg_xor_check<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged,ITypeNat
            where N : unmanaged,ITypeNat
            where T : unmanaged
        {
            var gx = Random.BitGrid(m,n,t);
            var gy = Random.BitGrid(m,n,t);
            var gz = BitGrid.alloc(m,n,t);

            Claim.eq(gz.BlockCount, BitCalcs.tableblocks(n256,m,n,t));            
            Claim.eq(gz.CellCount, BitCalcs.tablecells(m,n,t));
            
            BitGrid.xor(gx,gy,gz);
            
            for(var block=0; block<gx.BlockCount; block++)
                Claim.eq(ginx.vxor(gx[block], gy[block]), gz[block]);   
        }

        protected void bg_and_check<T>(int m, int n, T t = default)
            where T : unmanaged
        {
            var gx = Random.BitGrid(m,n,t);
            var gy = Random.BitGrid(m,n,t);
            var gz = BitGrid.alloc(m,n,t);

            Claim.eq(gz.BlockCount, BitCalcs.tableblocks(n256,m,n,t));            
            Claim.eq(gz.CellCount, BitCalcs.tablecells<T>(m,n));
            
            BitGrid.and(gx,gy,gz);
            
            for(var block=0; block<gx.BlockCount; block++)
                Claim.eq(ginx.vand(gx[block], gy[block]), gz[block]);   

        }

        protected void bg_xor_check<T>(int m, int n, T t = default)
            where T : unmanaged
        {
            var gx = Random.BitGrid(m,n,t);
            var gy = Random.BitGrid(m,n,t);
            var gz = BitGrid.alloc(m,n,t);

            Claim.eq(gz.BlockCount, BitCalcs.tableblocks(n256,m,n,t));            
            Claim.eq(gz.CellCount, BitCalcs.tablecells<T>(m,n));
            
            BitGrid.xor(gx,gy,gz);
            
            for(var block=0; block<gx.BlockCount; block++)
                Claim.eq(ginx.vxor(gx[block], gy[block]), gz[block]);   

        }
    }

}