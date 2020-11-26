//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class t_bg_bitread : t_bitgrids<t_bg_bitread>
    {
        public void bg_bitread_20x20x32()
            => check_bitgrid_read<uint>(20,20);

        public void bg_bitread_21x30x32()
            => check_bitgrid_read<uint>(21,30);

        public void bg_bitread_17x25x32()
            => check_bitgrid_read<uint>(17,25);

        public void bg_bitread_256x67x64()
            => check_bitgrid_read<ulong>(256,67);

        public void bg_bitread_250x67x64()
            => check_bitgrid_read<ulong>(250,67);

        public void bg_bitread_250x67x8()
            => check_bitgrid_read<byte>(250,67);

        public void bg_bitread_250x67x16()
            => check_bitgrid_read<ushort>(250,67);

        public void bg_bitread_250x67x32()
            => check_bitgrid_read<uint>(250,67);

        public void bg_bitread_249x128x64_bench()
            => bg_bitread_bench<ulong>(249,128);

        public void bg_bitread_249x128x8_bench()
            => bg_bitread_bench<byte>(249,128);

        public void bg_bitread_64x64x64_bench()
            => bg_bitread_bench<byte>(64,64);

        public void bm_bitread_64x64x64_bench()
            => bm_bitread_bench<ulong>();

        public void bg_bitwrite_249x128x64_bench()
            => bg_bitwrite_bench<ulong>(249,128);

        public void bg_bitwrite_249x128x8_bench()
            => bg_bitwrite_bench<byte>(249,128);

        /// <summary>
        /// Verifies correct function of the generic bitgrid read operation
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        void check_bitgrid_read<T>(uint rows, uint cols)
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
                    var b1 = BitGrid.readbit(src.ColCount, src.Head, row, col);
                    var b2 = BitGrid.readbit(src.Head, bitpos);
                    Claim.Require(b1 == b2);

                    dstA[row,col] = b1;
                    dstB.SetBit(bitpos, b2);
                }
                var bsA = dstA.ToBitString();
                var bsB = dstB.ToBitString();
                Claim.eq(bsA, bsB);
            }
        }
    }
}