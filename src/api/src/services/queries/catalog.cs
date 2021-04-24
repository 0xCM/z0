//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ApiQuery
    {
        [Op]
        public static IApiRuntimeCatalog catalog(params IPart[] parts)
        {
            var catalogs = parts.Select(x => partcat(x) as IApiPartCatalog).Where(c => c.IsIdentified);
            var dst = new ApiRuntimeCatalog(parts,
                parts.Select(p => p.Owner),
                catalogs,
                catalogs.SelectMany(c => c.ApiHosts.Storage),
                parts.Select(p => p.Id),
                catalogs.SelectMany(x => x.Operations)
                );
            return dst;
        }
    }
}