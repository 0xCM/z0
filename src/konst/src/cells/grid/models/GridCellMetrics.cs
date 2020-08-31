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
    public readonly struct GridCellMetrics
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
        public GridCellMetrics(int blocks, int blockwidth, int cellwidth)
        {
            BlockCount = blocks;
            BlockWidth = blockwidth;
            CellWidth = cellwidth;
            BlockLength = BlockWidth / CellWidth;
            CellCount = (BlockWidth * BlockCount)/CellWidth;
        }
    }
}