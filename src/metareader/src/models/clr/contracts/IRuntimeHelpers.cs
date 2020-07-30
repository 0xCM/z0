//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Buffers;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    public interface IRuntimeHelpers : IDisposable
    {
        ITypeFactory Factory { get; }

        IDataReader DataReader { get; }

        ImmutableArray<ClrThread> GetThreads(ClrRuntime runtime);

        ImmutableArray<ClrAppDomain> GetAppDomains(ClrRuntime runtime, out ClrAppDomain? system, out ClrAppDomain? shared);

        IEnumerable<ClrHandle> EnumerateHandleTable(ClrRuntime runtime);

        void FlushCachedData();

        ulong GetMethodDesc(ulong ip);

        string? GetJitHelperFunctionName(ulong ip);

        ClrModule? GetBaseClassLibrary(ClrRuntime runtime);
    }
}