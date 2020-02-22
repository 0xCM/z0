//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Root;
    using static nfunc;

    /// <summary>
    /// Captures memory block statistics
    /// </summary>
    public readonly struct BlockStats
    {
        /// <summary>
        /// Calculates memory block statistics for specified parameters
        /// </summary>
        /// <param name="bc">The block count</param>
        /// <param name="bw">The block width</param>
        /// <param name="cw">The cell width</param>
        [MethodImpl(Inline)]
        public static BlockStats Calc(int bc, int bw, int cw)
            => new BlockStats(bc, bw, cw);

        /// <summary>
        /// Calculates memory block statistics for specified function and type parameters
        /// </summary>
        /// <param name="bc">The block count</param>
        /// <param name="bw">The block width</param>
        /// <typeparam name="T">The type that determines cell width</typeparam>
        [MethodImpl(Inline)]
        public static BlockStats<T> Calc<T>(int bc, int bw)
            where T : unmanaged
                => new BlockStats<T>(bc, bw);

        /// <summary>
        /// Calculates memory block statistics for specified function and type parameters
        /// </summary>
        /// <param name="bc">The block count</param>
        /// <param name="bw">The block width representative</param>
        /// <param name="t">The block cell type representative</param>
        /// <typeparam name="N">The type that dermines block width</typeparam>
        /// <typeparam name="T">The type that determines cell width</typeparam>
        [MethodImpl(Inline)]
        public static BlockStats<N,T> Calc<N,T>(int bc, N bw = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BlockStats<N,T>(bc);

        [MethodImpl(Inline)]
        public BlockStats(int blocks, int blockwidth, int cellwidth)
        {
            this.BlockCount = blocks;
            this.BlockWidth = blockwidth;
            this.CellWidth = cellwidth;
            this.BlockLength = BlockWidth / CellWidth;
            this.CellCount = (BlockWidth * BlockCount)/CellWidth;
        }

        /// <summary>
        /// The number of blocks being described
        /// </summary>
        public readonly int BlockCount;

        /// <summary>
        /// The bit-width of a block
        /// </summary>
        public readonly int BlockWidth;

        /// <summary>
        /// The bit-width of a cell
        /// </summary>
        public readonly int CellWidth;

        /// <summary>
        /// The number of cells in a block
        /// </summary>
        public readonly int BlockLength;

        /// <summary>
        /// The total number of covered cells
        /// </summary>
        public readonly int CellCount;

        /// <summary>
        /// The total number of covered bits
        /// </summary>
        public readonly int BitCount
            => CellCount * CellWidth;
    }

    /// <summary>
    /// Captures statistics for memory blocks over generic T-cells
    /// </summary>
    /// <typeparam name="T">The cell type</typeparam>
    public readonly struct BlockStats<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BlockStats(int bc, int bw)
        {
            this.BlockCount = bc;
            this.BlockWidth = bw;
            this.CellWidth = Unsafe.SizeOf<T>()*8;
            var calcs = BlockStats.Calc(BlockCount, BlockWidth, CellWidth);
            this.BlockLength = calcs.BlockLength;
            this.CellCount = calcs.CellCount;
        }

        /// <summary>
        /// The number of blocks being described
        /// </summary>
        public readonly int BlockCount;

        /// <summary>
        /// The bit-width of a block
        /// </summary>
        public readonly int BlockWidth;

        /// <summary>
        /// The bit-width of a cell
        /// </summary>
        public readonly int CellWidth;

        /// <summary>
        /// The number of cells in a block
        /// </summary>
        public readonly int BlockLength;

        /// <summary>
        /// The total number of covered cells
        /// </summary>
        public readonly int CellCount;

        /// <summary>
        /// The total number of covered bits
        /// </summary>
        public readonly int BitCount
            => CellCount * CellWidth;
    }

    /// <summary>
    /// Captures memory block statistics for blocks of natural width N over generic T-cells
    /// </summary>
    /// <typeparam name="T">The cell type</typeparam>
    public readonly struct BlockStats<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BlockStats(int blocks)
        {
            this.BlockCount = blocks;
            this.BlockWidth = natval<N>();
            this.CellWidth = Unsafe.SizeOf<T>()*8;
            var calcs = BlockStats.Calc(BlockCount, BlockWidth, CellWidth);
            this.BlockLength = calcs.BlockLength;
            this.CellCount = calcs.CellCount;
        }

        /// <summary>
        /// The number of blocks being described
        /// </summary>
        public readonly int BlockCount;

        /// <summary>
        /// The bit-width of a block
        /// </summary>
        public readonly int BlockWidth;

        /// <summary>
        /// The bit-width of a cell
        /// </summary>
        public readonly int CellWidth;

        /// <summary>
        /// The number of cells in a block
        /// </summary>
        public readonly int BlockLength;

        /// <summary>
        /// The total number of covered cells
        /// </summary>
        public readonly int CellCount;

        /// <summary>
        /// The total number of covered bits
        /// </summary>
        public readonly int BitCount
            => CellCount * CellWidth;
    }
}