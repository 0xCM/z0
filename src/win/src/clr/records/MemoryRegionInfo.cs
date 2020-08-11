//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    /// <summary>
    /// Contains information about a range of memory.
    /// </summary>
    public struct MemoryRegionInfo
    {
        /// <summary>
        /// Gets the base address of the allocation.
        /// </summary>
        public ulong BaseAddress { get; }

        /// <summary>
        /// Gets the size of the allocation.
        /// </summary>
        public ulong Size { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="addr">Base address of the memory range.</param>
        /// <param name="size">The size of the memory range.</param>
        public MemoryRegionInfo(ulong addr, ulong size)
        {
            BaseAddress = addr;
            Size = size;
        }
    }
}