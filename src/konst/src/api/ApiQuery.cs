//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct ApiQuery
    {
        /// <summary>
        /// Attempts to parse a part identifier; if unsuccessful, returns none
        /// </summary>
        /// <param name="name">The literal name</param>
        [MethodImpl(Inline), Op]
        public static PartId id(string name)
            => Enums.Parse(name, PartId.None);

        [MethodImpl(Inline), Op]
        public static string format(PartId src)
            => Part.format(src);

        public static PartId[] validParts(params string[] args)
            => args.Map(arg => Enums.Parse<PartId>(arg).ValueOrDefault()).WhereSome();

        [Op]
        public static string Format(TargetPart part)
            => text.concat(format(part.Source), PartConnector, format(part.Target));

        const string PartConnector = " -> ";

        [MethodImpl(Inline), Op]
        public static TargetPart target(PartId src, PartId dst)
            => new TargetPart(src,dst);

        public static IPart[] parts()
            => ModuleArchives.entry().Parts;

        public static PartIndex index(Type src)
            => ApiQuery.index(ModuleArchives.from(src).Parts);

        [MethodImpl(Inline), Op]
        public static bool contains(in PartIndex src, PartId id)
            => src.Data.ContainsKey(id);

        [MethodImpl(Inline), Op]
        public static Option<IPart> search(in PartIndex src, PartId id)
            => src.Data.TryGetValue(id, out var part) ? some(part) : none<IPart>();

        public static PartIndex index(IPart[] src)
        {
            var dst = new Dictionary<PartId,IPart>();
            foreach(var part in src)
                dst.TryAdd(part.Id, part);
            return new PartIndex(dst);
        }

        public static IPart[] parts(string exclude = EmptyString)
            => ModuleArchives.exclude(exclude).Parts.Where(r => r.Id != 0);

        public static Assembly[] assemblies()
            => ModuleArchives.entry().Owners;

        public static Assembly[] assemblies(string exclude = EmptyString)
            => ModuleArchives.exclude(exclude).Owners;

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Option<IPart> part(Assembly src)
        {
            try
            {
                return some(src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Map(t => (IPart)Activator.CreateInstance(t)).FirstOrDefault());
            }
            catch(Exception e)
            {
                term.error(AppErrors.define(nameof(ApiQuery), text.format("Assembly {0} | {1}", src.GetSimpleName(), e)));
                return none<IPart>();
            }
        }

        [Op]
        public static IPart[] parts(Assembly[] src)
            => src.Where(isPart).Select(part).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id);

        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
        public static Option<Assembly> assembly(FS.FilePath src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
        {
            try
            {
                return Assembly.LoadFrom(src.Name);
            }
            catch(Exception e)
            {
                term.error($"An attempt to load the file {src} resulted in abject failure: {e}", caller, file, line);
                return default;
            }
        }

        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
        internal static Option<Assembly> assembly(FilePath src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
        {
            try
            {
                return Assembly.LoadFrom(src.Name);
            }
            catch(Exception e)
            {
                term.error($"An attempt to load the file {src} resulted in abject failure: {e}", caller, file, line);
                return default;
            }
        }

        /// <summary>
        /// Creates an index over the known parts
        /// </summary>
        public static PartIndex index()
            => ApiQuery.index(ModuleArchives.entry().Parts);

        public static bool test(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Count() > 0;

        public static Assembly[] parts(FilePath[] src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => src.Map(f => ApiQuery.assembly(f, caller, file, line))
                      .Where(x => x.IsSome()).Select(x => x.Value).Where(test);

        public static Assembly[] parts(FS.FilePath[] src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => src.Map(f => ApiQuery.assembly(f, caller, file, line))
                      .Where(x => x.IsSome()).Select(x => x.Value).Where(test);

        public static Assembly[] components(FS.FilePath[] src)
            => src.Map(f => assembly(f)).Where(x => x.IsSome()).Select(x => x.Value).Where(isPart);

        [MethodImpl(Inline), Op]
        public static bool isSvc(PartId a)
            => (a & PartId.Svc) != 0;

        [MethodImpl(Inline), Op]
        public static bool isTest(PartId a)
            => (a & PartId.Test) != 0;

        [MethodImpl(Inline), Op]
        public static bool isPart(Assembly src)
            => Attribute.IsDefined(src, typeof(PartIdAttribute));

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        [Op]
        public static ApiHost apiHost(PartId part, Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifblank(attrib.MapValueOrDefault(a => a.HostName, t.Name),t.Name).ToLower();
            var uri = ApiHostUri.Define(part, name);
            return new ApiHost(t, name, part, uri);
        }

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static Type[] apiHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<ApiHostAttribute>());

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static Type[] svcHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        public static ApiHost[] apiHosts(Assembly src)
        {
            var _id = id(src);
            return apiHostTypes(src).Select(h => apiHost(_id, h));
        }

        [MethodImpl(Inline), Op]
        public static PartId[] identities(Assembly[] src)
            => Part.identities(src);

        [MethodImpl(Inline), Op]
        public static Assembly[] components(in ModuleArchive src)
            => src.Owners.Where(isPart);

        [MethodImpl(Inline), Op]
        public static ApiPart assemble(params IPart[] parts)
            => new ApiPart(parts);

        [MethodImpl(Inline), Op]
        public static ApiSet set(params IPart[] parts)
            => new ApiSet(assemble(parts));

        [MethodImpl(Inline), Op]
        public static ApiPart assemble(IEnumerable<IPart> parts)
            => new ApiPart(parts.ToArray());

        /// <summary>
        /// Retrieves the part identifier, if any, of a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static PartId id(Assembly src)
        {
            if(isPart(src))
                return ((PartIdAttribute)Attribute.GetCustomAttribute(src, typeof(PartIdAttribute))).Id;
            else
                return PartId.None;
        }

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiDataTypeAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static ApiDataType[] dataTypes(Assembly src)
        {
            var part = src.Id();
            var types = span(src.GetTypes().Where(t => t.Tagged<ApiDataTypeAttribute>()));
            var count = types.Length;
            var buffer = alloc<ApiDataType>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var type = ref skip(types,i);
                var attrib = type.Tag<ApiDataTypeAttribute>();
                var name =  text.ifblank(attrib.MapValueOrDefault(a => a.Name, type.Name),type.Name).ToLower();
                var uri = ApiHostUri.Define(part, name);
                seek(dst,i) = new ApiDataType(type, name, part, uri);
            }
            return buffer;
        }

        [Op]
        public static PartCatalog catalog(IPart part)
            => new PartCatalog(part, dataTypes(part.Owner), apiHosts(part.Owner), svcHostTypes(part.Owner));

        [Op]
        public static PartCatalog[] catalogs(params IPart[] parts)
            => parts.Select(catalog);

        [Op]
        public static IPartCatalog catalog(Assembly src)
            => new PartCatalog(src, dataTypes(src), apiHosts(src), svcHostTypes(src));

        [MethodImpl(Inline), Op]
        public static IApiSet apiset(IResolvedApi resolved)
            => new ApiSet(resolved);

        public static IPart[] resolve(FS.Files paths)
            => resolve(paths.Data);

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        public static Option<IPart> resolve(FilePath src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => from component in ApiQuery.assembly(src, caller, file, line)
                    from type in resolve(component)
                    from prop in resolve(type)
                    from part in resolve(prop)
                    select part;

        public static IPart[] resolve(FilePath[] paths,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => paths.Select(p => resolve(p, caller, file, line)).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id);

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        public static Option<IPart> resolve(FS.FilePath src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => from component in ApiQuery.assembly(src)
                from type in resolve(component)
                from prop in resolve(type)
                from part in resolve(prop)
                select part;

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        internal static Option<Type> resolve(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part resolution property
        /// </summary>
        internal static Option<PropertyInfo> resolve(Type src)
            => src.StaticProperties().Where(p => p.Name == "Resolved").FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part from a resolution property
        /// </summary>
        internal static Option<IPart> resolve(PropertyInfo src)
            => Try(src, x => (IPart)x.GetValue(null));
    }
}