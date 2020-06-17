//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Captures memory block statistics
    /// </summary>
    public readonly struct BlockStats
    {

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
            var calcs = new BlockStats(bc, bw, Unsafe.SizeOf<T>()*8);
            this.BlockCount = calcs.BlockCount;
            this.BlockWidth = calcs.BlockWidth;
            this.BlockLength = calcs.BlockLength;
            this.CellCount = calcs.CellCount;
            this.CellWidth = calcs.CellWidth;

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
    public readonly struct BlockStats<W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BlockStats(int blocks)
        {
            this.BlockCount = blocks;
            this.BlockWidth = (int)Widths.type<W>();
            this.CellWidth = Unsafe.SizeOf<T>()*8;
            var calcs = new BlockStats(BlockCount, BlockWidth, CellWidth);
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