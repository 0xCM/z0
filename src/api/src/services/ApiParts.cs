//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static core;

    public class ApiParts : IApiParts
    {
        [Op]
        public static IApiParts load()
            => load(core.controller(), Environment.GetCommandLineArgs());

        [Op]
        public static IApiParts load(Assembly control, string[] args)
        {
            if(args.Length != 0)
            {
                term.inform(string.Format("Parsing {0}", args.Delimited()));
                var identifiers = ApiPartIdParser.parse(args);
                if(identifiers.Length != 0)
                    return new ApiParts(identifiers);
            }

            return new ApiParts(FS.path(control.Location).FolderPath);
        }

        public static IPart[] load(PartContext context)
            => from component in context.Assemblies.Array().Where(x => x.Id() != 0)
                let part = load(component)
                where part.IsSome()
                select part.Value;

        public static IPart[] load(FS.FolderPath dir, params PartId[] identities)
        {
            var query = from p in identities
                        let @base = "z0." + p.Format()
                        from f in array(FS.file(@base, FS.Dll), FS.file(@base,FS.Exe))
                        let path = dir + f
                        where path.Exists
                        let part = load(path)
                        where part.IsSome()
                        select part.Value;
            return query.ToArray();
        }

        [Op]
        public static bool load(Assembly src, out IPart dst)
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
        public static Option<IPart> load(Assembly src)
        {
            if(load(src, out var dst))
                return Option.some(dst);
            else
                return Option.none<IPart>();
        }

        /// <summary>
        /// Creates a <see cref='ApiParts'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// where the entry assembly is assumed to be the locus of control
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        [Op]
        public static IApiParts load(Index<PartId> identifiers)
            => load(core.controller(), identifiers);

        /// <summary>
        /// Creates a <see cref='ApiParts'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        [Op]
        public static IApiParts load(Assembly control, Index<PartId> identifiers)
        {
            if(identifiers.IsNonEmpty)
               return new ApiParts(identifiers);
            else
                return new ApiParts(FS.path(control.Location).FolderPath);
        }

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        [Op]
        public static Option<IPart> load(FS.FilePath src)
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
            => @try(src, x => (IPart)x.GetValue(null));

        /// <summary>
        /// The root of the archive one which the api module set is predicated
        /// </summary>
        public FS.FolderPath Source {get;}

        public FS.Files ManagedSources {get;}

        public Index<Assembly> Components
            => RuntimeCatalog.Components;

        public IApiCatalog RuntimeCatalog {get;}

        public ApiParts(PartId[] parts)
        {
            var control =  FS.path(core.controller().Location);
            Source = control.FolderPath;
            ManagedSources = Source.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            RuntimeCatalog = ApiDeployment.catalog(Source,parts);
        }

        public ApiParts(FS.FolderPath source)
        {
            Source = source;
            ManagedSources = Source.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            RuntimeCatalog = ApiDeployment.catalog(ManagedSources);
        }
    }
}