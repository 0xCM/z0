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

    public static class ApiCatalogOps
    {    
        /// <summary>
        /// Queries a composition for a specified catalog provider
        /// </summary>
        /// <param name="src">The source composition</param>
        public static Option<IApiCatalogProvider> CatalogProvider(this IApiComposition src, PartId id)
            => from c in src.FindCatalog(id) select OP.Define(id, c.Part, c);

        /// <summary>
        /// Searches the resolutions for an identified nonempy catalog
        /// </summary>
        /// <param name="id">The defining assembly</param>
        public static Option<IApiCatalog> FindCatalog(this IApiComposition src, PartId id)
        {
            var c = src.ApiCatalogs().Where(c => c.PartId == id).FirstOrDefault();
            if(c != null)
                return Option.some(c);
            else
                return Option.none<IApiCatalog>();
        }
            
        public static IEnumerable<IApiCatalog> ApiCatalogs(this IApiComposition src)
            => src.Resolved.Select( r => r.ApiCatalog());

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