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

    using static memory;

    [ApiHost]
    public readonly struct ApiCatalogs
    {
        [Op]
        internal static bool host(ApiHosts src, ApiHostUri uri, out IApiHost host)
        {   var count = src.Count;
            for(var i=0; i<count; i++)
            {
                var terms = src.View;
                ref readonly var candidate = ref skip(terms,i);
                if(candidate.Uri == uri)
                {
                    host = candidate;
                    return true;
                }
            }
            host = null;
            return false;
        }

        [Op]
        internal static bool host(ApiHosts src, Type t, out IApiHost host)
        {   var count = src.Count;
            for(var i=0; i<count; i++)
            {
                var terms = src.View;
                ref readonly var candidate = ref skip(terms,i);
                if(candidate.GetType() == t)
                {
                    host = candidate;
                    return true;
                }
            }
            host = null;
            return false;
        }

        [Op]
        public static IApiClassCatalog classes(IWfShell wf)
            => ApiClassCatalog.create(wf);

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="src">The reifying type</param>
        [Op]
        public static ApiHost ApiHost(Type src)
        {
            var part = src.Assembly.Id();
            var name =  HostName(src);
            return new ApiHost(src, name, part, new ApiHostUri(part, name));
        }

        [Op]
        public static Index<ApiHost> ApiHosts(Assembly src)
        {
            var _id = src.Id();
            return ApiHostTypes(src).Select(h => ApiHost(_id, h));
        }

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        [Op]
        public static ApiHost ApiHost(PartId part, Type t)
        {
            var name =  HostName(t);
            return new ApiHost(t, name, part, new ApiHostUri(part, name));
        }

        [Op]
        public static Identifier HostName(Type src)
        {
            var attrib = src.Tag<ApiHostAttribute>();
            return text.ifempty(attrib.MapValueOrDefault(a => a.HostName, src.Name), src.Name).ToLower();
        }

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static Index<Type> ApiHostTypes(Assembly src)
            => src.GetTypes().Where(IsApiHost);

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static Type[] ServiceHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> for a specified part
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog PartCatalog(IPart src)
            => PartCatalog(src.Owner);

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> over a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog PartCatalog(Assembly src)
            => new ApiPartCatalog(src.Id(), src, ApiTypes(src), ApiHosts(src), ServiceHostTypes(src));

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
                seek(dst, i) = new ApiRuntimeType(type, name, part, uri);
            }
            return buffer;
        }

        /// <summary>
        /// Creates a system-level api catalog over a set of path-identified components
        /// </summary>
        /// <param name="paths">The source paths</param>
        [Op]
        public static IGlobalApiCatalog GlobalCatalog(FS.Files paths)
            => new GlobalApiCatalog(paths.Storage.Select(part).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id));

        [Op]
        public static IGlobalApiCatalog GlobalCatalog(FS.FolderPath src, PartId[] parts)
        {
            var managed = src.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            return parts.Length != 0 ? new GlobalApiCatalog(GlobalCatalog(managed).Parts.Where(x => parts.Contains(x.Id))) : GlobalCatalog(managed);
        }

        [Op]
        public static IGlobalApiCatalog GlobalCatalog(Assembly src, PartId[] parts)
            => GlobalCatalog(FS.path(src.Location).FolderPath, parts);


        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        [Op]
        static Option<IPart> part(FS.FilePath src)
                => from c in WfShell.component(src)
                from t in resolve(c)
                from p in resolve(t)
                from part in resolve(p)
                select part;

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        static Option<Type> resolve(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part resolution property
        /// </summary>
        static Option<PropertyInfo> resolve(Type src)
            => src.StaticProperties().Where(p => p.Name == "Resolved").FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part from a resolution property
        /// </summary>
        [Op]
        static Option<IPart> resolve(PropertyInfo src)
            => root.@try(src, x => (IPart)x.GetValue(null));

        [Op]
        static bool IsApiHost(Type src)
            => src.Tagged<ApiHostAttribute>();
    }
}