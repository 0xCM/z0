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

    partial class XTend
    {    
        /// <summary>
        /// Streams the catalogs defined by a composition
        /// </summary>
        /// <param name="src">The composition</param>
        public static IEnumerable<IApiCatalog> ApiCatalogs(this IApiComposition src)
            => src.Resolved.Select( r => r.ApiCatalog());    
    }
}