//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public interface IHeapBuilder
    {
        IHeapHelpers HeapHelpers { get; }

        public bool IsServer { get; }

        int LogicalHeapCount { get; }

        ulong ArrayMethodTable { get; }

        ulong StringMethodTable { get; }

        ulong ObjectMethodTable { get; }

        ulong ExceptionMethodTable { get; }

        ulong FreeMethodTable { get; }

        bool CanWalkHeap { get; }
    }
}