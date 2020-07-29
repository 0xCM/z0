//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Immutable;

    public interface ICcwData
    {
        ulong Address { get; }

        ulong IUnknown { get; }

        ulong Object { get; }

        ulong Handle { get; }

        int RefCount { get; }

        int JupiterRefCount { get; }

        ImmutableArray<ComInterfaceData> GetInterfaces();
    }
}