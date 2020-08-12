//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Generic;

    using Z0.Dac;
    
    public interface IHeapHelpers
    {
        IDataReader DataReader { get; }
        
        ITypeFactory Factory { get; }

        IEnumerable<(ulong, ulong)> EnumerateDependentHandleLinks();
        bool CreateSegments(
            ClrHeap clrHeap,
            out IReadOnlyList<ClrSegment> segemnts,
            out IReadOnlyList<AllocationContext> allocationContexts,
            out IReadOnlyList<FinalizerQueueSegment> fqRoots,
            out IReadOnlyList<FinalizerQueueSegment> fqObjects);
    }    
}