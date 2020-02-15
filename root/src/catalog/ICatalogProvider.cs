//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Characterizes a type that provides access to an operation catalog
    /// </summary>
    public interface ICatalogProvider
    {
        /// <summary>
        /// The provided catalog
        /// </summary>
        IOperationCatalog Catalog {get;}
    }
}