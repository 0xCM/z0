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

    using static z;

    using Q = ApiQuery;

    [ApiHost(ApiNames.ApiCatalogs, true)]
    public readonly struct ApiCatalogs
    {
        [Op]
        public static IApiClassCatalog classes(IWfShell wf)
            => ApiClassCatalog.create(wf);

        [Op]
        public static ApiHostCatalog host(IWfShell wf, IApiHost src)
        {
            var jitter = wf.ApiServices.ApiJit();
            var members = jitter.Jit(src);
            return members.Length == 0 ? ApiHostCatalog.Empty : new ApiHostCatalog(src, members);
        }

        /// <summary>
        /// Creates a system-level api catalog over a set of path-identified components
        /// </summary>
        /// <param name="paths">The source paths</param>
        [Op]
        public static IGlobalApiCatalog create(FS.Files paths)
            => new GlobalApiCatalog(paths.Storage.Select(part).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id));

        /// <summary>
        /// Creates a system-level api catalog over a specified component set
        /// </summary>
        /// <param name="src">The source components</param>
        [Op]
        public static IGlobalApiCatalog create(Assembly[] src)
        {
            var candidates = src.Where(Q.isPart);
            var parts = candidates.Select(TryGetPart).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id);
            return new GlobalApiCatalog(parts);
        }

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> over a specified part
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog create(IPart src)
            => create(src.Owner);

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> over a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog create(Assembly src)
            => new ApiPartCatalog(src.Id(), src, apitypes(src), apiHosts(src), svcHostTypes(src));

        [Op]
        public static IGlobalApiCatalog siblings(Assembly src, PartId[] parts)
        {
            var path = FS.path(src.Location).FolderPath;
            var managed = path.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            return parts.Length != 0 ? new GlobalApiCatalog(create(managed).Parts.Where(x => parts.Contains(x.Id))) : create(managed);
        }

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        [Op]
        static Option<IPart> TryGetPart(Assembly src)
        {
            try
            {
                return root.some(src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Map(t => (IPart)Activator.CreateInstance(t)).FirstOrDefault());
            }
            catch(Exception e)
            {
                term.error(WfEvents.error(nameof(ApiCatalogs), text.format("Assembly {0} | {1}", src.GetSimpleName(), e)));
                return root.none<IPart>();
            }
        }

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        [Op]
        static Option<IPart> part(FS.FilePath src)
                => from c in Q.component(src)
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
            => @try(src, x => (IPart)x.GetValue(null));

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        static Type[] apiHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<ApiHostAttribute>());

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        static Type[] svcHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        [Op]
        static ApiHost[] apiHosts(Assembly src)
        {
            var _id = Q.id(src);
            return apiHostTypes(src).Select(h => host(_id, h));
        }

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiDeepAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        static ApiRuntimeType[] apitypes(Assembly src)
        {
            var part = src.Id();
            var types = span(src.GetTypes().Where(t => t.Tagged<ApiDeepAttribute>()));
            var count = types.Length;
            var buffer = alloc<ApiRuntimeType>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var type = ref skip(types,i);
                var attrib = type.Tag<ApiDeepAttribute>();
                var name =  text.ifempty(attrib.MapValueOrDefault(a => a.Name, type.Name),type.Name).ToLower();
                var uri = new ApiHostUri(part, name);
                seek(dst,i) = new ApiRuntimeType(type, name, part, uri);
            }
            return buffer;
        }

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        [Op]
        static ApiHost host(PartId part, Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifempty(attrib.MapValueOrDefault(a => a.HostName, t.Name), t.Name).ToLower();
            return new ApiHost(t, name, part, new ApiHostUri(part, name));
        }
    }
}