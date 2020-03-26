//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
        
    /// <summary>
    /// Characterizes, in dependency injection vernacular, composition roots
    /// </summary>
    public interface IApiComposition : ICustomFormattable
    {
        /// <summary>
        /// The resolved assemblies that comprise the composition
        /// </summary>
        IApiPart[] Resolved {get;}   

        /// <summary>
        /// Searches the resolutions for an identified assembly
        /// </summary>
        /// <param name="id">The defining assembly</param>
        Option<IApiPart> FindPart(PartId id)
            => Resolved.TryFind(r => r.Id == id);

        IEnumerable<IApiCatalog> Catalogs
            => from a in Resolved
                where a.Catalog.IsIdentified 
                select a.Catalog;
    }

    public interface IApiComposition<T> :  IApiComposition, IFormattable<T>
        where T : IApiComposition<T>
    {

    }
}