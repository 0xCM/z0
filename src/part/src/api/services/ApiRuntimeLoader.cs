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

    public readonly struct ApiRuntimeLoader
    {
        public static IApiParts parts()
            => parts(core.controller(), Environment.GetCommandLineArgs());

        public static IApiParts parts(Assembly control, string[] args)
        {
            if(args.Length != 0)
            {
                var identifiers = ApiPartIdParser.parse(args);
                if(identifiers.Length != 0)
                    return new ApiParts(control, identifiers);
            }

            return new ApiParts(control, dir(control));
        }

        /// <summary>
        /// Creates a <see cref='ApiParts'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// where the entry assembly is assumed to be the locus of control
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        public static IApiParts parts(Index<PartId> identifiers)
            => parts(core.controller(), identifiers);

        /// <summary>
        /// Creates a <see cref='ApiParts'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        [Op]
        public static IApiParts parts(Assembly control, Index<PartId> identifiers)
        {
            if(identifiers.IsNonEmpty)
               return new ApiParts(control, identifiers);
            else
                return new ApiParts(control, FS.path(control.Location).FolderPath);
        }

        public static IApiParts parts(Assembly control)
            => new ApiParts(control, array(control.Id()));

        public static FS.FilePath path(Assembly src)
            => FS.path(src.Location);

        public static FS.FolderPath dir(Assembly src)
            => path(src).FolderPath;

        [Op]
        internal static FS.Files managed(FS.FolderPath dir)
            => dir.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        [Op]
        static Option<IPart> part(FS.FilePath src)
            => from c in assembly(src)
            from t in resolve(c)
            from p in resolve(t)
            from part in resolve(p)
            select part;

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

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        static Type[] svchosts(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        public static IApiCatalog catalog(FS.FolderPath location)
        {
            var candidates = assemblies(location,true).Where(x => x.Id() != 0).View;
            var count = candidates.Length;
            var parts = root.list<IPart>();
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

        [Op]
        public static Assembly[] assemblies(FS.FilePath[] src)
            => src.Where(x => FS.managed(x)).Map(assembly).Where(x => x.IsSome()).Select(x => x.Value);

        public static Index<Assembly> assemblies(FS.FolderPath dir, bool justParts)
        {
            var dst = list<Assembly>();
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



        static IPart[] LoadParts(FS.FolderPath dir, params PartId[] identities)
        {
            var query = from p in identities
                        let @base = "z0." + p.Format()
                        from f in core.array(FS.file(@base, FS.Dll), FS.file(@base,FS.Exe))
                        let path = dir + f
                        where path.Exists
                        let part = part(path)
                        where part.IsSome()
                        select part.Value;
            return query.ToArray();
        }

        static bool TryLoadPart(Assembly src, out IPart dst)
        {
            var attempt = src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Map(t => (IPart)Activator.CreateInstance(t)).ToArray();
            if(attempt.Length != 0)
            {
                dst = attempt.First();
                return true;
            }
            else
            {
                 dst = default;
                 return false;
            }
        }

        [Op]
        static Option<IPart> TryLoadPart(Assembly src)
        {
            if(TryLoadPart(src, out var dst))
                return Option.some(dst);
            else
                return Option.none<IPart>();
        }

        static IPart[] FindParts(PartContext context)
            => from component in context.Assemblies.Array().Where(x => x.Id() != 0)
                let part = TryLoadPart(component)
                where part.IsSome()
                select part.Value;

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
                Console.WriteLine(e);
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
            => Option.Try(src, x => (IPart)x.GetValue(null));
    }
}