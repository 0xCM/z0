//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct StoreMetrics
    {
        /// <summary>
        /// The bss index, relative to other bss allocations
        /// </summary>
        public Hex16 Id;

        /// <summary>
        /// The bss base address
        /// </summary>
        public MemoryAddress Base;

        /// <summary>
        /// The number of blocks covered by the allocation
        /// </summary>
        public uint BlockCount;

        /// <summary>
        /// The factor by which to scale the segment to determine the block size
        /// </summary>
        public byte SegScale;

        /// <summary>
        /// The number of bytes covered by a segment
        /// </summary>
        public uint SegSize;

        /// <summary>
        /// The size of a block
        /// </summary>
        public uint BlockSize;

        /// <summary>
        /// The total allocation size
        /// </summary>
        public uint TotalSize;
    }
}