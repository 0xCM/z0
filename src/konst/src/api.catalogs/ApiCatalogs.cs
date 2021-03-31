//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using static memory;

    [ApiHost]
    public readonly struct ApiCatalogs
    {
        [Op]
        public static IApiParts parts()
            => parts(root.controller(), Environment.GetCommandLineArgs());

        [Op]
        public static IApiParts parts(FS.FolderPath src)
            => new ApiPartSet(src);

        /// <summary>
        /// Creates a <see cref='ApiPartSet'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        [Op]
        public static IApiParts parts(Assembly control, Index<PartId> identifiers)
        {
            if(identifiers.IsNonEmpty)
               return new ApiPartSet(FS.path(control.Location).FolderPath, identifiers);
            else
                return new ApiPartSet(FS.path(control.Location).FolderPath);
        }

        /// <summary>
        /// Creates a <see cref='ApiPartSet'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// where the entry assembly is assumed to be the locus of control
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        [Op]
        public static IApiParts parts(Index<PartId> identifiers)
            => parts(root.controller(), identifiers);

        [Op]
        public static IApiParts parts(Assembly control, string[] args)
        {
            if(args.Length != 0)
            {
                var identifiers = ApiPartIdParser.parse(args);
                if(identifiers.Length != 0)
                    return new ApiPartSet(FS.path(control.Location).FolderPath, identifiers);
            }

            return new ApiPartSet(FS.path(control.Location).FolderPath);
        }

        [Op]
        public static ApiHostInfo hostinfo(Type t)
        {
            var ass = t.Assembly;
            var part = ass.Id();
            var uri = t.HostUri();
            var methods = t.DeclaredMethods();
            return new ApiHostInfo(t, uri, part, methods, index(methods));
        }

        [Op]
        public static ApiHostInfo hostinfo<T>()
            => hostinfo(typeof(T));

        public static Dictionary<string,MethodInfo> index(Index<MethodInfo> methods)
        {
            var index = new Dictionary<string, MethodInfo>();
            root.iter(methods, m => index.TryAdd(ApiIdentity.identify(m).IdentityText, m));
            return index;
        }

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="type">The reifying type</param>
        [Op]
        public static ApiHost host(Type type)
        {
            var part = type.Assembly.Id();
            var name =  ApiParts.hostname(type);
            var declared = type.DeclaredMethods();
            return new ApiHost(type, name, part, new ApiHostUri(part, name), declared, index(declared));
        }

        [Op]
        public static Index<ApiHost> hosts(Assembly src)
        {
            var _id = src.Id();
            return ApiParts.ApiHostTypes(src).Select(h => host(_id, h));
        }

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        [Op]
        public static ApiHost host(PartId part, Type type)
        {
            var name =  ApiParts.hostname(type);
            var declared = type.DeclaredMethods();
            return new ApiHost(type, name, part, new ApiHostUri(part, name), declared, index(declared));
        }

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> for a specified part
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog catalog(IPart src)
            => catalog(src.Owner);

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> over a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog catalog(Assembly src)
            => new ApiPartCatalog(src.Id(), src, ApiTypes(src), hosts(src), ApiParts.ServiceHostTypes(src));

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiCompleteAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static ApiRuntimeType[] ApiTypes(Assembly src)
        {
            var part = src.Id();
            var types = span(src.GetTypes().Where(t => t.Tagged<ApiCompleteAttribute>()));
            var count = types.Length;
            var buffer = alloc<ApiRuntimeType>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var type = ref skip(types,i);
                var attrib = type.Tag<ApiCompleteAttribute>();
                var name =  text.ifempty(attrib.MapValueOrDefault(a => a.Name, type.Name),type.Name).ToLower();
                var uri = new ApiHostUri(part, name);
                var declared = type.DeclaredMethods();
                seek(dst, i) = new ApiRuntimeType(type, name, part, uri, declared, index(declared));
            }
            return buffer;
        }

        public static IApiCatalogDataset dataset(IPart[] parts)
        {
            var catalogs = parts.Select(x => catalog(x) as IApiPartCatalog).Where(c => c.IsIdentified);
            var dst = new ApiCatalogDataset(parts,
                parts.Select(p => p.Owner),
                catalogs,
                catalogs.SelectMany(c => c.ApiHosts.Storage),
                parts.Select(p => p.Id),
                catalogs.SelectMany(x => x.Operations)
                );
            return dst;
        }

        [Op]
        public static IApiCatalogDataset dataset(FS.Files paths)
            => dataset(paths.Storage.Select(ApiParts.part).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id));

        [Op]
        public static IApiCatalogDataset dataset(FS.FolderPath src, PartId[] parts)
            => dataset(src.Exclude("System.Private.CoreLib").Where(f => FS.managed(f)));

        [Op]
        public static IApiCatalogDataset datset(Assembly src, PartId[] parts)
            => dataset(FS.path(src.Location).FolderPath, parts);
    }
}