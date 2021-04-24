//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static memory;

    [ApiHost]
    public readonly struct ApiDeployment
    {
        [Op]
        public static PartContext context(FS.FilePath src, bool collectible = true)
            => new PartContext(src, collectible);

        [Op]
        public static PartContext context(PartId part, bool collectible = true)
            => new PartContext(part, collectible);

        [Op]
        public static FS.Files managed(FS.FolderPath dir)
            => dir.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));

        [Op]
        public static Assembly[] assemblies(FS.FilePath[] src)
            => src.Where(x => FS.managed(x)).Map(assembly).Where(x => x.IsSome()).Select(x => x.Value);

        public static Index<Assembly> assemblies(FS.FolderPath dir, bool justParts)
        {
            var dst = root.list<Assembly>();
            var candidates = managed(dir);
            foreach(var path in candidates)
            {
                var component = Assembly.LoadFrom(path.Name);
                if(justParts)
                {
                    if(component.Id() != 0)
                        dst.Add(component);
                }
                else
                    dst.Add(component);
            }

            return dst.ToArray();
        }

        public static IPart[] parts(PartContext context)
            => from component in context.Assemblies.Array().Where(x => x.Id() != 0)
                let part = ApiQuery.part(component)
                where part.IsSome()
                select part.Value;

        public static IPart[] parts(FS.FolderPath dir, params PartId[] identities)
        {
            var query = from p in identities
                        let @base = "z0." + p.Format()
                        from f in root.stream(FS.file(@base, FS.Dll), FS.file(@base,FS.Exe))
                        let path = dir + f
                        where path.Exists
                        let part = part(path)
                        where part.IsSome()
                        select part.Value;
            return query.ToArray();
        }

        [Op]
        public static IApiRuntimeCatalog catalog(PartContext context)
            => ApiQuery.catalog(parts(context));

        [Op]
        public static IApiRuntimeCatalog catalog(Index<IPart> parts)
            => ApiQuery.catalog(parts);

        [Op]
        public static IApiRuntimeCatalog rooted(FS.FolderPath location)
        {
            var candidates = assemblies(location,true).Where(x => x.Id() != 0).View;
            var count = candidates.Length;
            var parts = root.list<IPart>();
            for(var i=0; i<count; i++)
            {
                if(ApiQuery.part(skip(candidates,i), out var part))
                    parts.Add(part);
            }

            return ApiQuery.catalog(parts.Array());
        }

        [Op]
        public static IApiRuntimeCatalog catalog(FS.FolderPath location, params PartId[] identities)
            => ApiQuery.catalog(parts(location, identities));

        [Op]
        public static IApiRuntimeCatalog catalog(FS.Files paths)
            => ApiQuery.catalog(paths.Storage.Select(part).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id));

        public static Index<Assembly> assemblies(FS.FolderPath dir, PartId[] parts)
        {
            var dst = root.list<Assembly>();
            var candidates = dir.TopFiles;
            foreach(var path in candidates)
            {
                if((path.Is(FS.Dll) || path.Is(FS.Exe)) && FS.managed(path))
                {
                    foreach(var id in parts)
                    {
                        var match = dir + FS.component(id, path.Ext);
                        if(match.Equals(path))
                            dst.Add(Assembly.LoadFrom(match.Name));
                    }
                }
            }

            return dst.ToArray();
        }

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        [Op]
        public static Option<IPart> part(FS.FilePath src)
            => from c in assembly(src)
            from t in resolve(c)
            from p in resolve(t)
            from part in resolve(p)
            select part;

        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
        [Op]
        static Option<Assembly> assembly(FS.FilePath src)
        {
            try
            {
                return Assembly.LoadFrom(src.Name);
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        static Option<Type> resolve(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part resolution property
        /// </summary>
        static Option<PropertyInfo> resolve(Type src)
            => src.StaticProperties().Where(p => p.Name == PartResolution.ResolutionProperty).FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part from a resolution property
        /// </summary>
        [Op]
        static Option<IPart> resolve(PropertyInfo src)
            => root.@try(src, x => (IPart)x.GetValue(null));
    }
}