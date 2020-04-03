//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using OP = ApiCatalogProvider;

    partial class XTend
    {    
        /// <summary>
        /// Queries a composition for a specified catalog provider
        /// </summary>
        /// <param name="src">The source composition</param>
        public static Option<IApiCatalogProvider> CatalogProvider(this IApiComposition src, PartId id)
            => from c in src.FindCatalog(id) select OP.Define(id, c.Part, c);

        /// <summary>
        /// Queries a composition for supported catalog providers that are identified by a filter
        /// </summary>
        /// <param name="src">The source composition</param>
        /// <param name="filter">The filter criteria</param>
        public static IEnumerable<IApiCatalogProvider> CatalogProviders(this IApiComposition src, IEnumerable<PartId> filter)
            => from c in src.ApiCatalogs() 
                where filter.Contains(c.PartId)
                select OP.Define(c.PartId, c.Part, c);
    }
}