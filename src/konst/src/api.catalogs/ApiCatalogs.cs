//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    [ApiHost(ApiNames.ApiCatalogs, true)]
    public readonly struct ApiCatalogs
    {
        [Op]
        public static ApiPartCatalog part(IPart src)
            => part(src.Owner);

        [Op]
        public static ApiPartCatalog part(Assembly src)
            => new ApiPartCatalog(src.Id(), src, ApiQuery.datatypes(src), ApiQuery.apiHosts(src), ApiQuery.svcHostTypes(src));

        [Op]
        public static ApiPartCatalog[] parts(params IPart[] parts)
            => parts.Select(part);

        [Op]
        public static ISystemApiCatalog system(Assembly[] src)
            => new SystemApiCatalog(src.Where(ApiQuery.isPart).Select(ApiQuery.part).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id));

        public static SystemApiCatalog system(FS.Files paths)
            => new SystemApiCatalog(ApiQuery.parts(paths.Data));

        public static KeyedValues<PartId,Type>[] types(ClrTypeKind kind, ISystemApiCatalog src)
        {
            switch(kind)
            {
                case ClrTypeKind.Enum:
                    return enums(src);
                default:
                    return default;
            }
        }

        static KeyedValues<PartId,Type>[] enums(ISystemApiCatalog src)
        {
            var x = from part in  src.Parts
                    let enums = part.Owner.Enums()
                        orderby part.Id
                        select KeyedValues.@from(part.Id, enums);
            return x;
        }
    }
}