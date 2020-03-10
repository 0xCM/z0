//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Describes an assembly that provides cataloged operations
    /// </summary>
    readonly struct CatalogProvider : ICatalogProvider
    {        
        public AssemblyId AssemblyId {get;}

        public Assembly CatalogedAssembly {get;}           
 
        public IAssemblyCatalog Operations {get;}

        [MethodImpl(Inline)]
        public static ICatalogProvider Define(AssemblyId id, Assembly src, IAssemblyCatalog catalog)
            => new CatalogProvider(id,src,catalog);

        [MethodImpl(Inline)]
        CatalogProvider(AssemblyId id, Assembly src, IAssemblyCatalog catalog)
        {
            this.AssemblyId = id;
            this.CatalogedAssembly = src;
            this.Operations = catalog;
        }

        Type[] IOpSvcHostProvider.ServiceHostTypes 
            => Operations.ServiceHostTypes;

        ApiHost[] IAssemblyCatalog.GenericApiHosts 
            => Operations.GenericApiHosts;

        ApiHost[] IAssemblyCatalog.DirectApiHosts 
            => Operations.DirectApiHosts;

        DataResourceIndex IAssemblyCatalog.Resources 
            => Operations.Resources;

        public ApiHost[] ApiHosts 
            => Operations.ApiHosts;
    }
}