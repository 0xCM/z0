//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines memory segmentation classifiers
    /// </summary>
    public enum MemoryClass : byte
    {
        None,

        /// <summary>
        /// A contiguous byte-aligned sequence of bits
        /// </summary>
        Cell = 1, 

        /// <summary>
        /// A contiguous sequence of cells
        /// </summary>
        Segment = 2,

        /// <summary>
        /// A contiguous sequence of segments
        /// </summary>
        Block  = 3,
    }
}