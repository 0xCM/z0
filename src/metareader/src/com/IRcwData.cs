//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Immutable;

    public interface IRcwData
    {
        ulong Address { get; }

        ulong IUnknown { get; }

        ulong VTablePointer { get; }

        int RefCount { get; }

        ulong ManagedObject { get; }

        bool Disconnected { get; }

        ulong CreatorThread { get; }

        ImmutableArray<ComInterfaceData> GetInterfaces();
    }
}