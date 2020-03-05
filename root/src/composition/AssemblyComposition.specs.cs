//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;    
    
    /// <summary>
    /// Characterizes, in dependency injection vernacular, composition roots
    /// </summary>
    public interface IAssemblyComposition : ICustomFormattable
    {
        /// <summary>
        /// The resolved assemblies that comprise the composition
        /// </summary>
        IAssemblyResolution[] Resolved {get;}   

        /// <summary>
        /// Searches the resolutions for an identified assembly
        /// </summary>
        /// <param name="id">The defining assembly</param>
        Option<IAssemblyResolution> FindAssembly(AssemblyId id)
            => Resolved.TryFind(r => r.Id == id);

        IEnumerable<IOperationCatalog> Catalogs
            => from a in Resolved
                where !a.Catalog.IsEmpty
                select a.Catalog;
    }

    public interface IAssemblyComposition<T> :  IAssemblyComposition, IFormattable<T>
        where T : IAssemblyComposition<T>
    {


    }
}