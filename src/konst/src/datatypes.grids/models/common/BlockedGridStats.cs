//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    /// <summary>
    /// Captures memory block statistics
    /// </summary>
    public readonly struct BlockedGridStats
    {
        /// <summary>
        /// The number of blocks being described
        /// </summary>
        public int BlockCount {get;}

        /// <summary>
        /// The bit-width of a block
        /// </summary>
        public int BlockWidth {get;}

        /// <summary>
        /// The bit-width of a cell
        /// </summary>
        public int CellWidth {get;}

        /// <summary>
        /// The number of cells in a block
        /// </summary>
        public int BlockLength {get;}

        /// <summary>
        /// The total number of covered cells
        /// </summary>
        public int CellCount {get;}

        /// <summary>
        /// The total number of covered bits
        /// </summary>
        public readonly int BitCount
            => CellCount * CellWidth;

        [MethodImpl(Inline)]
        public BlockedGridStats(int blocks, int blockwidth, int cellwidth)
        {
            BlockCount = blocks;
            BlockWidth = blockwidth;
            CellWidth = cellwidth;
            BlockLength = BlockWidth / CellWidth;
            CellCount = (BlockWidth * BlockCount)/CellWidth;
        }
    }
}