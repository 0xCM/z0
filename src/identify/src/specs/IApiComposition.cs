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
        IPart[] Resolved {get;}   

        IEnumerable<IApiCatalog> Catalogs 
            => from part in Resolved
                let c = ApiCatalogProvider.Catalog(part)
                where c.IsIdentified 
                select c;

    }
}