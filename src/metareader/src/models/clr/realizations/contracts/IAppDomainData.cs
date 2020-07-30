//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public interface IAppDomainData
    {
        IAppDomainHelpers Helpers { get; }

        string? Name { get; }

        int Id { get; }

        ulong Address { get; }
    }
}