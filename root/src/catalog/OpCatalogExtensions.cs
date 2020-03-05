//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    using OP = OpCatalogProvider;

    public static class OpCatalogExtensions
    {    
        public static IOpCatalog OperationCatalog(this Assembly a)
            => a.Designator().Catalog;

        /// <summary>
        /// Queries a composition for a specified catalog provider
        /// </summary>
        /// <param name="src">The source composition</param>
        public static Option<ICatalogProvider> CatalogProvider(this IAssemblyComposition src, AssemblyId id)
            => from r in  src.Resolved.TryFind(x => x.Id == id)
                where !r.Catalog.IsEmpty
                select OP.Define(r.Id, r.Resolved, r.Catalog);

        /// <summary>
        /// Searches the resolutions for an identified nonempy catalog
        /// </summary>
        /// <param name="id">The defining assembly</param>
        public static Option<IOpCatalog> FindCatalog(this IAssemblyComposition src, AssemblyId id)
            => from a in src.FindAssembly(id)
                where !a.Catalog.IsEmpty
                select a.Catalog;
        
        public static IEnumerable<IOpCatalog> Catalogs(this IAssemblyComposition src)
            => from a in src.Resolved
                where !a.Catalog.IsEmpty
                select a.Catalog;


        /// <summary>
        /// Queries a composition for supported catalog providers
        /// </summary>
        /// <param name="src">The source composition</param>
        public static IEnumerable<ICatalogProvider> CatalogProviders(this IAssemblyComposition src)
            =>  from r in src.Resolved                
                where !r.Catalog.IsEmpty
                select OP.Define(r.Id, r.Resolved, r.Catalog);

        /// <summary>
        /// Queries a composition for supported catalog providers that are identified by a filter
        /// </summary>
        /// <param name="src">The source composition</param>
        /// <param name="filter">The filter criteria</param>
        public static IEnumerable<ICatalogProvider> CatalogProviders(this IAssemblyComposition src, IEnumerable<AssemblyId> filter)
            =>  from r in src.Resolved                
                where filter.Contains(r.Id) && !r.Catalog.IsEmpty
                select OP.Define(r.Id, r.Resolved, r.Catalog);

    }
}