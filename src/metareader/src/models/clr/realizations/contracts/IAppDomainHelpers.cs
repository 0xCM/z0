//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Generic;

    public interface IAppDomainHelpers
    {
        string? GetConfigFile(ClrAppDomain domain);

        string? GetApplicationBase(ClrAppDomain domain);

        IEnumerable<ClrModule> EnumerateModules(ClrAppDomain domain);
    }
}