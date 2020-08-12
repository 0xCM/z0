//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;

    [Table]
    public struct AllocationContext
    {
        public ulong Pointer;

        public ulong Limit;

        public AllocationContext(ulong pointer, ulong limit)
        {
            Pointer = pointer;
            Limit = limit;
        }
    }

}