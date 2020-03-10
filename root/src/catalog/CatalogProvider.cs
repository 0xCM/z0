//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// Describes an assembly that provides cataloged operations
    /// </summary>
    public readonly struct CatalogProvider : ICatalogProvider, IAssemblyCatalog
    {        
        public static ICatalogProvider Define(AssemblyId id, Assembly src, IAssemblyCatalog catalog)
            => new CatalogProvider(id,src,catalog);

        CatalogProvider(AssemblyId id, Assembly src, IAssemblyCatalog catalog)
        {
            this.AssemblyId = id;
            this.CatalogedAssembly = src;
            this.Operations = catalog;
        }

        public AssemblyId AssemblyId {get;}

        public Assembly CatalogedAssembly {get;}

        /// <summary>
        /// Specifies whether the catalog is vacuous
        /// </summary>
        public bool IsUnidentified
            => AssemblyId ==  AssemblyId.None;
            
        /// <summary>
        /// The name of the catalog, which should be unique with respect to known catalogs
        /// </summary>
        string CatalogName
            => AssemblyId.Format();        

        public IAssemblyCatalog Operations {get;}

        Type[] IOpServiceProvider.ServiceHostTypes 
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