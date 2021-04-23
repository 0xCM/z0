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

    [ApiHost(ApiNames.ApiQuery, true)]
    public readonly partial struct ApiQuery
    {
        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> over a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog catalog(Assembly src)
            => new ApiPartCatalog(src.Id(), src, ApiTypes(src), hosts(src), ServiceHostTypes(src));

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        [Op]
        public static Option<IPart> part(FS.FilePath src)
            => from c in component(src)
            from t in resolve(c)
            from p in resolve(t)
            from part in resolve(p)
            select part;

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> for a specified part
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog catalog(IPart src)
            => catalog(src.Owner);

        public static IApiRuntimeCatalog runtime(IPart[] parts)
        {
            var catalogs = parts.Select(x => catalog(x) as IApiPartCatalog).Where(c => c.IsIdentified);
            var dst = new ApiRuntimeCatalog(parts,
                parts.Select(p => p.Owner),
                catalogs,
                catalogs.SelectMany(c => c.ApiHosts.Storage),
                parts.Select(p => p.Id),
                catalogs.SelectMany(x => x.Operations)
                );
            return dst;
        }

        [Op]
        public static IApiRuntimeCatalog runtime(PartId[] identities)
            => runtime(PartsFromIdentities(identities));

        public static IPart[] PartsFromIdentities(PartId[] identities)
        {
            var dir = FS.path(root.controller().Location).FolderPath;
            var query = from p in identities
                        let @base = "z0." + p.Format()
                        from f in root.seq(FS.file(@base, FS.Dll), FS.file(@base,FS.Exe))
                        let path = dir + f
                        where path.Exists
                        let part = part(path)
                        where part.IsSome()
                        select part.Value;
            return query.ToArray();
        }

        [Op]
        public static IApiRuntimeCatalog runtime(FS.Files paths)
            => runtime(paths.Storage.Select(part).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id));

        [Op]
        public static IApiRuntimeCatalog runtime(FS.FolderPath src, PartId[] parts)
            => runtime(src.Exclude("System.Private.CoreLib").Where(f => FS.managed(f)));


        [Op]
        public static Identifier hostname(Type src)
        {
            var attrib = src.Tag<ApiHostAttribute>();
            return text.ifempty(attrib.MapValueOrDefault(a => a.HostName, src.Name), src.Name).ToLower();
        }

        [Op]
        public static IApiParts parts()
            => parts(root.controller(), Environment.GetCommandLineArgs());

        [Op]
        public static IApiParts parts(FS.FolderPath src)
            => new ApiParts(src);

        /// <summary>
        /// Creates a <see cref='ApiParts'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        [Op]
        public static IApiParts parts(Assembly control, Index<PartId> identifiers)
        {
            if(identifiers.IsNonEmpty)
               return new ApiParts(identifiers);
            else
                return new ApiParts(FS.path(control.Location).FolderPath);
        }

        /// <summary>
        /// Creates a <see cref='ApiParts'/> predicated an optionally-specified <see cref='PartId'/> sequence
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
                    return new ApiParts(identifiers);
            }

            return new ApiParts(FS.path(control.Location).FolderPath);
        }

        [Op]
        public static bool IsApiHost(Type src)
            => src.Tagged<ApiHostAttribute>();

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static Index<Type> ApiHostTypes(Assembly src)
            => src.GetTypes().Where(IsApiHost);

        [Op]
        public static IPart part(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Map(t => (IPart)Activator.CreateInstance(t)).Single();

        [Op]
        public static ApiPartTypes types(IPart src)
            => new ApiPartTypes(src.Id, src.Owner.Types());

        [Op]
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
        /// <param name="t">The reifying type</param>
        [Op]
        public static ApiHost host(PartId part, Type type)
        {
            var name = hostname(type);
            var declared = type.DeclaredMethods();
            return new ApiHost(type, name, part, new ApiHostUri(part, name), declared, index(declared));
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
            var name =  hostname(type);
            var declared = type.DeclaredMethods();
            return new ApiHost(type, name, part, new ApiHostUri(part, name), declared, index(declared));
        }

        [Op]
        public static ApiHostInfo hostinfo(Type t)
        {
            var methods = t.DeclaredMethods();
            return new ApiHostInfo(t, t.HostUri(), t.Assembly.Id(), methods, index(methods));
        }

        [Op]
        public static ApiHostInfo hostinfo<T>()
            => hostinfo(typeof(T));

        [Op]
        public static Index<ApiHost> hosts(Assembly src)
        {
            var _id = src.Id();
            return ApiHostTypes(src).Select(h => host(_id, h));
        }


        [Op]
        public static ApiHostUri hosturi(Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifempty(attrib.MapValueOrDefault(a => a.HostName, t.Name), t.Name).ToLower();
            return new ApiHostUri(t.Assembly.Id(), name);
        }

        public static ApiGroupNG[] ImmDirect(IApiHost host, RefinementClass kind)
            => from g in direct(host)
                let imm = ImmGroup(host, g, kind)
                where !imm.IsEmpty
                select g;

        public static ApiMethodG[] ImmGeneric(IApiHost host, RefinementClass kind)
            => generic(host).Where(op => op.Method.AcceptsImmediate(kind));

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static Type[] ServiceHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        public static FS.Files colocated()
            => FS.dir(root.controller().Location).TopFiles;

        public static Index<Assembly> components(PartId[] identities)
        {
            var dst = root.list<Assembly>();
            var dir = FS.dir(root.controller().Location);
            var candidates = colocated();
            foreach(var path in candidates)
            {
                if((path.Is(FS.Dll) || path.Is(FS.Exe)) && FS.managed(path))
                {
                    foreach(var id in identities)
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
        /// Loads an assembly from a potential part path
        /// </summary>
        [Op]
        public static Option<Assembly> component(FS.FilePath src)
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

        [Op]
        public static Assembly[] components(FS.FilePath[] src)
            => src.Map(component).Where(x => x.IsSome()).Select(x => x.Value).Where(nonempty);


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
                seek(dst, i) = new ApiRuntimeType(type, name, part, uri, declared, ApiQuery.index(declared));
            }
            return buffer;
        }

        [Op]
        public static Index<ApiHostUri> NestedHosts(Type src)
        {
            var dst = root.list<ApiHostUri>();
            var nested = @readonly(src.GetNestedTypes());
            var count = nested.Length;
            for(var i=0; i<count; i++)
            {
                var candidate = skip(nested,i);
                var uri = candidate.HostUri();
                if(uri.IsNonEmpty)
                    dst.Add(uri);
            }
            return dst.ToArray();
        }

        [Op]
        public static JittedMethod[] GenericMethods(IApiHost host)
            => host.HostType.DeclaredMethods().OpenGeneric(1).Where(IsGeneric).Select(m => new JittedMethod(host.Uri, m));

        [Op]
        public static bool IsGeneric(MethodInfo src)
            => src.Tagged<OpAttribute>() && src.Tagged<ClosuresAttribute>() && !src.AcceptsImmediate();

        [Op]
        public static JittedMethod[] DirectMethods(IApiHost host)
            => host.HostType.DeclaredMethods().NonGeneric().Where(IsDirect).Select(m => new JittedMethod(host.Uri, m));

        [Op]
        public static bool IsDirect(MethodInfo src)
            => src.Tagged<OpAttribute>() && !src.AcceptsImmediate();

         [Op]
        static bool nonempty(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Count() > 0;

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

        static MethodInfo[] TaggedOps(IApiHost src)
            => src.Methods.Storage.Tagged<OpAttribute>();

        static ApiGroupNG[] direct(IApiHost src)
            => (from d in DirectOpSpecs(src).GroupBy(op => op.Method.Name)
                select new ApiGroupNG(ApiUri.opid(d.Key), src, d)).Array();

        static IEnumerable<ApiMethodNG> DirectOpSpecs(IApiHost src)
            => from m in TaggedOps(src).NonGeneric() select new ApiMethodNG(src, Diviner.Identify(m), m);

        static MethodInfo GenericDefintion(MethodInfo src)
            => src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();

        static IMultiDiviner Diviner
            => MultiDiviner.Service;

        static ApiMethodG[] generic(IApiHost src)
             => from m in TaggedOps(src).OpenGeneric()
                let closures = ApiIdentityKinds.NumericClosureKinds(m)
                where closures.Length != 0
                select new ApiMethodG(src, Diviner.GenericIdentity(m), GenericDefintion(m), closures);

        static ApiGroupNG ImmGroup(IApiHost host, ApiGroupNG g, RefinementClass kind)
            => new ApiGroupNG(g.GroupId, host,
                g.Members.Storage.Where(m => m.Method.AcceptsImmediate(kind) && m.Method.ReturnsVector()));
    }
}