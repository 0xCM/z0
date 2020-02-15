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

    /// <summary>
    /// Characterizes a type that supports operation discovery
    /// </summary>
    public interface IOperationCatalog
    {
        /// <summary>
        /// The known types that reify contracted operation services
        /// </summary>
        IEnumerable<Type> ServiceHosts {get;}
        
        /// <summary>
        /// The known generic api hosts
        /// </summary>
        IEnumerable<ApiHost> GenericApiHosts {get;}

        /// <summary>
        /// The known direct api hosts
        /// </summary>
        IEnumerable<ApiHost> DirectApiHosts {get;}

        /// <summary>
        /// Th global data resource index
        /// </summary>
        DataResourceIndex Resources {get;}

        /// <summary>
        /// Identifies the declaring assembly
        /// </summary>
        AssemblyId AssemblyId {get;}

        /// <summary>
        /// Specifies whether the catalog is vacuous
        /// </summary>
        bool IsEmpty
            => AssemblyId == AssemblyId.Empty || AssemblyId == AssemblyId.None;
            
        /// <summary>
        /// The name of the catalog, which should be unique with respect to known catalogs
        /// </summary>
        string CatalogName
            => AssemblyId.Format();
        
        IEnumerable<ApiHost> ApiHosts
            => DirectApiHosts.Union(GenericApiHosts);
    }
}