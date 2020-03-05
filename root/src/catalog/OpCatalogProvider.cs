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
    public readonly struct OpCatalogProvider : ICatalogProvider, IOpCatalog
    {        
        public static ICatalogProvider Define(AssemblyId id, Assembly src, IOpCatalog catalog)
            => new OpCatalogProvider(id,src,catalog);

        OpCatalogProvider(AssemblyId id, Assembly src, IOpCatalog catalog)
        {
            this.OwnerId = id;
            this.Owner = src;
            this.Operations = catalog;
        }

        public AssemblyId OwnerId {get;}

        public Assembly Owner {get;}

        /// <summary>
        /// Specifies whether the catalog is vacuous
        /// </summary>
        public bool IsEmpty
            => OwnerId ==  AssemblyId.None;
            
        /// <summary>
        /// The name of the catalog, which should be unique with respect to known catalogs
        /// </summary>
        string CatalogName
            => OwnerId.Format();        

        public IOpCatalog Operations {get;}


        IEnumerable<Type> IOpServiceProvider.ServiceHostTypes 
            => Operations.ServiceHostTypes;

        IEnumerable<ApiHost> IOpCatalog.GenericApiHosts 
            => Operations.GenericApiHosts;

        IEnumerable<ApiHost> IOpCatalog.DirectApiHosts 
            => Operations.DirectApiHosts;

        DataResourceIndex IOpCatalog.Resources 
            => Operations.Resources;

        public ApiHost[] ApiHosts 
            => Operations.ApiHosts;
    }

}