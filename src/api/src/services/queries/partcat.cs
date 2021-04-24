//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial struct ApiQuery
    {
        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> for a specified part
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog partcat(IPart src)
            => partcat(src.Owner);

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> over a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog partcat(Assembly src)
            => new ApiPartCatalog(src.Id(), src, complete(src), apihosts(src), svchosts(src));
    }
}