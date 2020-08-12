//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;

    /// <summary>
    /// This struct represents a single step in <see cref="ClrmdHeap"/>'s heap walk.  This is used for diagnostic purposes.
    /// </summary>
    [Table]
    public struct HeapWalkStep
    {
        public ulong Address;

        public ulong MethodTable;

        public uint Count;

        public int BaseSize;

        public int ComponentSize;
    }
}