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
    using System.Reflection;

    using static Seed;

    partial class XTend
    {
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
    }
}