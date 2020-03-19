//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    /// <summary>
    /// Characterizes a type that supports operation discovery
    /// </summary>
    public interface IApiCatalog : IApiServiceHosts
    {
        /// <summary>
        /// The identity of the assembly that defines and owns the catalog
        /// </summary>
        AssemblyId AssemblyId {get;}

        /// <summary>
        /// The assembly that defines and owns the catalog
        /// </summary>
        Assembly CatalogedAssembly {get;}

        /// <summary>
        /// The api hosts known to the catalog
        /// </summary>
        ApiHost[] ApiHosts {get;}
        
        /// <summary>
        /// The known generic api hosts
        /// </summary>
        ApiHost[] GenericApiHosts {get;}

        /// <summary>
        /// The known direct api hosts
        /// </summary>
        ApiHost[] DirectApiHosts {get;}

        /// <summary>
        /// The global data resource index
        /// </summary>
        DataResourceIndex Resources {get;}

        /// <summary>
        /// Specifies whether the catalog contains content from an identifid assembly
        /// </summary>
        bool IsIdentified
            => AssemblyId != 0;

        /// <summary>
        /// Specifies the number of api hosts described by the catalog
        /// </summary>
        int ApiHostCount => ApiHosts.Length;

        /// <summary>
        /// Specifies whether the catalog describes any api hosts
        /// </summary>
        bool HasApiHostContent => ApiHostCount != 0;

        /// <summary>
        /// The name of the catalog, which should be unique with respect to known catalogs
        /// </summary>
        string CatalogName
            => AssemblyId.Format();        
    }
    /// <summary>
    /// Characterizes a type that provides access to an operation catalog
    /// </summary>
    public interface IApiCatalogProvider : IApiCatalog
    {
        /// <summary>
        /// The provided catalog
        /// </summary>
        IApiCatalog Operations {get;}
    } 
}