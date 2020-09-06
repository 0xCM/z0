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
            => new PartCatalog(part, dataTypes(part.Owner), apiHosts(part.Owner), svcHostTypes(part.Owner));

        [Op]
        public static IPartCatalog catalog(Assembly src)
            => new PartCatalog(src, dataTypes(src), apiHosts(src), svcHostTypes(src));
    }
}