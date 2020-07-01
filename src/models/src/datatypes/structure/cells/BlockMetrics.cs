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
    public readonly struct BlockMetrics
    {
        /// <summary>
        /// Calculates memory block statistics for specified parameters
        /// </summary>
        /// <param name="bc">The block count</param>
        /// <param name="bw">The block width</param>
        /// <param name="cw">The cell width</param>
        [MethodImpl(Inline), Op]
        public static BlockMetrics calc(int bc, int bw, int cw)
            => new BlockMetrics(bc, bw, cw);

        /// <summary>
        /// Calculates memory block statistics for specified function and type parameters
        /// </summary>
        /// <param name="bc">The block count</param>
        /// <param name="bw">The block width</param>
        /// <typeparam name="T">The type that determines cell width</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static BlockMetrics<T> calc<T>(int bc, int bw)
            where T : unmanaged
                => new BlockMetrics<T>(bc, bw);

        /// <summary>
        /// Calculates memory block statistics for specified function and type parameters
        /// </summary>
        /// <param name="bc">The block count</param>
        /// <param name="bw">The block width representative</param>
        /// <param name="t">The block cell type representative</param>
        /// <typeparam name="N">The type that dermines block width</typeparam>
        /// <typeparam name="T">The type that determines cell width</typeparam>
        [MethodImpl(Inline)]
        public static BlockMetrics<W,T> calc<W,T>(int bc, W bw = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new BlockMetrics<W,T>(bc);

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

        [MethodImpl(Inline)]
        public BlockMetrics(int blocks, int blockwidth, int cellwidth)
        {
            BlockCount = blocks;
            BlockWidth = blockwidth;
            CellWidth = cellwidth;
            BlockLength = BlockWidth / CellWidth;
            CellCount = (BlockWidth * BlockCount)/CellWidth;
        }
    }

    /// <summary>
    /// Captures statistics for memory blocks over generic T-cells
    /// </summary>
    /// <typeparam name="T">The cell type</typeparam>
    public readonly struct BlockMetrics<T>
        where T : unmanaged
    {
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
        [MethodImpl(Inline)]
        public BlockMetrics(int bc, int bw)
        {
            var calcs = new BlockMetrics(bc, bw, Unsafe.SizeOf<T>()*8);
            BlockCount = calcs.BlockCount;
            BlockWidth = calcs.BlockWidth;
            BlockLength = calcs.BlockLength;
            CellCount = calcs.CellCount;
            CellWidth = calcs.CellWidth;
        }
    }

    /// <summary>
    /// Captures memory block statistics for blocks of natural width N over generic T-cells
    /// </summary>
    /// <typeparam name="T">The cell type</typeparam>
    public readonly struct BlockMetrics<W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
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

        [MethodImpl(Inline)]
        public BlockMetrics(int blocks)
        {
            BlockCount = blocks;
            BlockWidth = (int)Widths.type<W>();
            CellWidth = Unsafe.SizeOf<T>()*8;
            var calcs = new BlockMetrics(BlockCount, BlockWidth, CellWidth);
            BlockLength = calcs.BlockLength;
            CellCount = calcs.CellCount;
        }
    }
}