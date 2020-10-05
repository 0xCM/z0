//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        [Op]
        public static ApiPartCatalog catalog(IPart part)
            => new ApiPartCatalog(part, datatypes(part.Owner), apiHosts(part.Owner), svcHostTypes(part.Owner));

        [Op]
        public static ApiPartCatalog[] catalogs(params IPart[] parts)
            => parts.Select(catalog);
    }
}