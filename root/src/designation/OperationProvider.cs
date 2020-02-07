//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Describes an assembly that provides cataloged operations
    /// </summary>
    public readonly struct OperationProvider : IOperationProvider
    {        
        public static IOperationProvider Define(AssemblyId id, Assembly src, IOperationCatalog catalog)
            => new OperationProvider(id,src,catalog);

        OperationProvider(AssemblyId id, Assembly src, IOperationCatalog catalog)
        {
            this.HostId = id;
            this.HostAssembly = src;
            this.Catalog = catalog;
        }

        public AssemblyId HostId {get;}

        public Assembly HostAssembly {get;}

        public IOperationCatalog Catalog {get;}
    }
}