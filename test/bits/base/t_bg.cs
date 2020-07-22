//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public abstract class t_bitgrids<X> : t_bitgrids_base<X>
        where X : t_bitgrids<X>, new()
    {
        protected override int RepCount => Pow2.T04;

        protected override int CycleCount => Pow2.T03;

        protected void nbg_define_check<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var rows = (int)value(m);
            var cols = (int)value(n);
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


        protected void bg_bitread_bench<T>(uint M, uint N, SystemCounter counter = default)
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

            ReportBenchmark($"gbg_read_{Identify.numeric<T>()}", CycleCount*M*N, counter);
        }

        protected void bm_bitread_bench<T>(SystemCounter counter = default)
            where T : unmanaged
        {
            var last = bit.Off;
            int M = (int)bitsize<T>();
            int N = (int)bitsize<T>();
            for(var i = 0; i<CycleCount; i++)
            {
                var src = Random.BitMatrix<T>();

                counter.Start();
                for(var row = 0; row< M; row++)
                for(var col = 0; col< N; col++)
                    last = src[row,col];
                counter.Stop();
            }

            ReportBenchmark($"gbm_bitread_{Identify.numeric<T>()}", CycleCount*M*N, counter);
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

            ReportBenchmark($"gbg_bitwrite_{Identify.numeric<T>()}", CycleCount*M*N, counter);
        }

        protected void bg_and_check<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged,ITypeNat
            where N : unmanaged,ITypeNat
            where T : unmanaged
        {
            var gx = Random.BitGrid(m,n,t);
            var gy = Random.BitGrid(m,n,t);
            var gz = BitGrid.alloc(m,n,t);

            Claim.eq((uint)gz.BlockCount, BitCalcs.tableblocks(n256,m,n,t));            
            Claim.eq((uint)gz.CellCount, BitCalcs.tablecells(m,n,t));
            
            BitGrid.and(gx,gy,gz);
            
            for(var block=0; block<gx.BlockCount; block++)
                Claim.veq(gvec.vand(gx[block], gy[block]), gz[block]);   

        }

        protected void bg_xor_check<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged,ITypeNat
            where N : unmanaged,ITypeNat
            where T : unmanaged
        {
            var gx = Random.BitGrid(m,n,t);
            var gy = Random.BitGrid(m,n,t);
            var gz = BitGrid.alloc(m,n,t);

            Claim.eq((uint)gz.BlockCount, BitCalcs.tableblocks(n256,m,n,t));            
            Claim.eq((uint)gz.CellCount, BitCalcs.tablecells(m,n,t));
            
            BitGrid.xor(gx,gy,gz);
            
            for(var block=0; block<gx.BlockCount; block++)
                Claim.veq(gvec.vxor(gx[block], gy[block]), gz[block]);   
        }

        protected void bg_and_check<T>(uint m, uint n, T t = default)
            where T : unmanaged
        {
            var gx = Random.BitGrid(m,n,t);
            var gy = Random.BitGrid(m,n,t);
            var gz = BitGrid.alloc(m,n,t);

            Claim.eq((uint)gz.BlockCount, BitCalcs.tableblocks<T>(n256,m,n));            
            Claim.eq((uint)gz.CellCount, BitCalcs.tablecells<T>(m,n));
            
            BitGrid.and(gx,gy,gz);
            
            for(var block=0; block<gx.BlockCount; block++)
                Claim.veq(gvec.vand(gx[block], gy[block]), gz[block]);   

        }

        protected void bg_xor_check<T>(uint m, uint n, T t = default)
            where T : unmanaged
        {
            var gx = Random.BitGrid(m,n,t);
            var gy = Random.BitGrid(m,n,t);
            var gz = BitGrid.alloc(m,n,t);

            Claim.eq((uint)gz.BlockCount, BitCalcs.tableblocks<T>(n256,m,n));            
            Claim.eq((uint)gz.CellCount, BitCalcs.tablecells<T>(m,n));
            
            BitGrid.xor(gx,gy,gz);
            
            for(var block=0; block<gx.BlockCount; block++)
                Claim.veq(gvec.vxor(gx[block], gy[block]), gz[block]);   
        }
    }
}