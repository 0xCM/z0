//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// Characterizes a type that supports operation discovery
    /// </summary>
    public interface IOperationCatalog
    {
        /// <summary>
        /// The name of the catalog, unique with respect to known catalogs
        /// </summary>
        string CatalogName {get;}

        /// <summary>
        /// The known generic operations
        /// </summary>
        IEnumerable<GenericOpInfo> GenericOps {get;}                       

        /// <summary>
        /// The known direct operations
        /// </summary>
        IEnumerable<DirectOpInfo> DirectOps {get;}       

        /// <summary>
        /// The known types that reify contracted operation services
        /// </summary>
        IEnumerable<Type> ServiceHosts {get;}
        
        /// <summary>
        /// The known generic api hosts
        /// </summary>
        IEnumerable<Type> GenericApiHosts {get;}

        /// <summary>
        /// The known direct api hosts
        /// </summary>
        IEnumerable<Type> DirectApiHosts {get;}
        
        /// <summary>
        /// The assembly that implements the operations described by the catalog
        /// </summary>
        Assembly DeclaringAssembly {get;}         

    }
}