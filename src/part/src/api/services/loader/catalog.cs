//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Root;
    using static core;

    partial struct ApiRuntimeLoader
    {
        public static IApiCatalog catalog(FS.FolderPath location, PartId[] identities)
            => catalog(LoadParts(location, identities));

        public static IApiCatalog catalog(FS.Files paths)
            => catalog(paths.Storage.Select(part).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id));

        public static IApiCatalog catalog(PartContext context)
            => catalog(FindParts(context));

        public static IApiCatalog catalog(Index<IPart> parts)
            => catalog(parts.Storage);

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> for a specified part
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static ApiPartCatalog catalog(IPart src)
            => catalog(src.Owner);

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> over a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static ApiPartCatalog catalog(Assembly src)
            => new ApiPartCatalog(src.Id(), src, ApiRuntimeType.complete(src), ApiHost.hosts(src), svchosts(src));

        public static IApiCatalog catalog(FS.FolderPath dir)
        {
            var candidates = assemblies(dir,true).Where(x => x.Id() != 0).View;
            var count = candidates.Length;
            var parts = list<IPart>();
            for(var i=0; i<count; i++)
            {
                if(TryLoadPart(skip(candidates,i), out var part))
                    parts.Add(part);
            }

            return catalog(parts.Array());
        }

        [Op]
        public static IApiCatalog catalog(IPart[] parts)
        {
            var catalogs = parts.Select(x => catalog(x)).Where(c => c.IsIdentified);
            var dst = new ApiRuntimeCatalog(parts,
                parts.Select(p => p.Owner),
                catalogs,
                catalogs.SelectMany(c => c.ApiHosts.Storage).Where(h => nonempty(h.HostUri.HostName)),
                parts.Select(p => p.Id),
                catalogs.SelectMany(x => x.Methods)
                );
            return dst;
        }
    }
}