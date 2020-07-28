//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public struct AllocationContext
    {
        public ulong Pointer { get; }
        public ulong Limit { get; }

        public AllocationContext(ulong pointer, ulong limit)
        {
            Pointer = pointer;
            Limit = limit;

            DebugOnly.Assert(Pointer < Limit);
            DebugOnly.Assert(Limit != 0);
        }
    }

}