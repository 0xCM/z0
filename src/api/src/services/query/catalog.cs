//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static memory;

    partial struct ApiQuery
    {
        /// <summary>
        /// Creates a system-level api catalog over a specified component set
        /// </summary>
        /// <param name="src">The source components</param>
        [Op]
        public static IApiCatalogDataset catalog(Index<Assembly> src)
        {
            var candidates = src.Where(x => x.IsPart());
            var parts = candidates.Select(TryGetPart).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id).Array();
            return new GlobalApiCatalog(parts);
        }

    }
}