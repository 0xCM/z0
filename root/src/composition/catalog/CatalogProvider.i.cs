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

    public interface IOpSvcProvisioner
    {
        string ServiceCollectionName {get;}
    }

    /// <summary>
    /// Characterizes a type that provides access to an operation catalog
    /// </summary>
    public interface ICatalogProvider : IAssemblyCatalog
    {
        /// <summary>
        /// The provided catalog
        /// </summary>
        IAssemblyCatalog Operations {get;}
    } 
}