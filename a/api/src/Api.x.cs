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

    public static partial class XTend
    {
        /// <summary>
        /// Defines a query service over a catalog
        /// </summary>
        /// <param name="src">The source catalog</param>
        [MethodImpl(Inline)]
        public static ApiQuery Query(this IApiCatalog src)
            => ApiQuery.Over(src);
    }
}