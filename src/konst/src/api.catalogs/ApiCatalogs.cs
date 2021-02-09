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

    using Q = ApiQuery;

    [ApiHost(ApiNames.ApiCatalogs, true)]
    public readonly struct ApiCatalogs
    {
        [Op]
        public static IApiClassCatalog classes(IWfShell wf)
            => ApiClassCatalog.create(wf);

        /// <summary>
        /// Returns a <see cref='ApiHostCatalog'/> for a specified host
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="src">The host type</param>
        [Op]
        public static ApiHostCatalog host(IWfShell wf, IApiHost src)
        {
            var members = wf.ApiServices.ApiJit().Jit(src);
            return members.Length == 0 ? ApiHostCatalog.Empty : ApiHostCatalog.create(src, members);
        }

        /// <summary>
        /// Returns a <see cref='ApiHostCatalog'/> for a specified host
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="src">The host type</param>
        [Op]
        public static ApiHostCatalog host(IWfShell wf, Type src)
            => host(wf, ApiRuntime.ApiHost(src));

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> for a specified part
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog part(IPart src)
            => part(src.Owner);

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> over a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog part(Assembly src)
            => new ApiPartCatalog(src.Id(), src, ApiRuntime.ApiTypes(src), ApiRuntime.ApiHosts(src), ApiRuntime.ServiceHostTypes(src));

        /// <summary>
        /// Creates a system-level api catalog over a set of path-identified components
        /// </summary>
        /// <param name="paths">The source paths</param>
        [Op]
        public static IGlobalApiCatalog global(FS.Files paths)
            => new GlobalApiCatalog(paths.Storage.Select(part).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id));

        /// <summary>
        /// Creates a system-level api catalog over a specified component set
        /// </summary>
        /// <param name="src">The source components</param>
        [Op]
        public static IGlobalApiCatalog global(Index<Assembly> src)
        {
            var candidates = src.Where(Q.isPart);
            var parts = candidates.Select(TryGetPart).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id).Array();
            return new GlobalApiCatalog(parts);
        }

        [Op]
        public static IGlobalApiCatalog global(FS.FolderPath src, PartId[] parts)
        {
            var managed = src.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            return parts.Length != 0 ? new GlobalApiCatalog(global(managed).Parts.Where(x => parts.Contains(x.Id))) : global(managed);
        }

        [Op]
        public static IGlobalApiCatalog global(Assembly src, PartId[] parts)
            => global(FS.path(src.Location).FolderPath, parts);

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
            => root.@try(src, x => (IPart)x.GetValue(null));
    }
}