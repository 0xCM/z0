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
    /// This struct represents a single step in <see cref="ClrmdHeap"/>'s heap walk.  This is used for diagnostic purposes.
    /// </summary>
    public struct HeapWalkStep
    {
        public ulong Address { get; set; }

        public ulong MethodTable { get; set; }

        public uint Count { get; set; }

        public int BaseSize { get; set; }

        public int ComponentSize { get; set; }
    }
}