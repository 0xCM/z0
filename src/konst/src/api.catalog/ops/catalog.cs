//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        [Op]
        public static PartCatalog catalog(IPart part)
            => new PartCatalog(part, datatypes(part.Owner), apiHosts(part.Owner), svcHostTypes(part.Owner));

        // [Op]
        // public static IPartCatalog catalog(Assembly src)
        //     => new PartCatalog(src, datatypes(src), apiHosts(src), svcHostTypes(src));

        [Op]
        public static PartCatalog[] catalogs(params IPart[] parts)
            => parts.Select(catalog);
    }
}