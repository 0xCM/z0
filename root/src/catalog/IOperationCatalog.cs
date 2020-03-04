//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Characterizes a type that supports operation discovery
    /// </summary>
    public interface IOperationCatalog : IOpServiceProvider
    {
        /// <summary>
        /// The identity of the assembly that defines and owns the catalog
        /// </summary>
        AssemblyId OwnerId {get;}

        /// <summary>
        /// The assembly that defines and owns the catalog
        /// </summary>
        Assembly Owner {get;}

        /// <summary>
        /// The api hosts known to the catalog
        /// </summary>
        ApiHost[] ApiHosts {get;}
        
        /// <summary>
        /// The known generic api hosts
        /// </summary>
        IEnumerable<ApiHost> GenericApiHosts {get;}

        /// <summary>
        /// The known direct api hosts
        /// </summary>
        IEnumerable<ApiHost> DirectApiHosts {get;}

        /// <summary>
        /// The global data resource index
        /// </summary>
        DataResourceIndex Resources {get;}

        /// <summary>
        /// Specifies whether the catalog is vacuous
        /// </summary>
        bool IsEmpty
            => OwnerId == AssemblyId.None;
            
        /// <summary>
        /// The name of the catalog, which should be unique with respect to known catalogs
        /// </summary>
        string CatalogName
            => OwnerId.Format();        
    }

    /// <summary>
    /// Characterizes a type that provides access to an operation catalog
    /// </summary>
    public interface ICatalogProvider
    {
        /// <summary>
        /// The provided catalog
        /// </summary>
        IOperationCatalog Operations {get;}

        /// <summary>
        /// The owning assembly
        /// </summary>
        Assembly Owner {get;}

        AssemblyId OwnerId 
            => Operations.OwnerId;
    }


}