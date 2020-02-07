//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IOperationProvider
    {
        AssemblyId HostId {get;}

        Assembly HostAssembly {get;}

        IOperationCatalog Catalog {get;}

    }
}