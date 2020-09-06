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
    public readonly partial struct ApiQuery
    {
        public static ModuleArchive modules()
            => modules(Assembly.GetEntryAssembly(), Environment.GetCommandLineArgs());

        [MethodImpl(Inline)]
        public static ModuleArchive modules(Assembly control)
            => modules(control, Environment.GetCommandLineArgs());

        public static ModuleArchive modules(Assembly control, string[] args)
        {
            var parts = PartIdParser.parse(args);
            if(parts.Length != 0)
               return new ModuleArchive(control, parts);
            else
                return new ModuleArchive(control);
        }

        [MethodImpl(Inline)]
        public static ModuleArchive modules(FS.FolderPath src)
            => new ModuleArchive(src);

        /// <summary>
        /// Collects all resource accessors defined by a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static ResDeclarationIndex declarationIndex(Assembly src)
            => new ResDeclarationIndex(src, declarations(src));

        [Op]
        public static ResDeclarationIndex declarationIndex(FilePath src)
            => declarationIndex(Assembly.LoadFrom(src.Name));

        /// <summary>
        /// Collects all resource accessors defined by a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static ResourceDeclarations[] declarations(ResourceAccessor[] src)
            => (from a in src
                let t = a.Member.DeclaringType
                group a by t).Map(x => new ResourceDeclarations(x.Key, x.ToArray()));

        /// <summary>
        /// Collects all resource accessors defined by a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static ResourceDeclarations[] declarations(Assembly src)
            => (from a in ApiQuery.resources(src).Accessors
                let t = a.Member.DeclaringType
                group a by t).Map(x => new ResourceDeclarations(x.Key, x.ToArray()));

        static Type[] ResAccessorTypes
            => new Type[]{typeof(ReadOnlySpan<byte>), typeof(ReadOnlySpan<char>)};

        static ResourceFormat FormatAccessor(Type match)
        {
            ref readonly var src = ref first(span(ResAccessorTypes));
            var kind = ResourceFormat.None;
            if(skip(src,0).Equals(match))
                kind = ResourceFormat.ByteSpan;
            else if(skip(src,1).Equals(match))
                kind = ResourceFormat.CharSpan;
            return kind;
        }

        [MethodImpl(Inline)]
        public static ApiHostUri uri(Type host)
        {
            var tag = host.Tag<ApiHostAttribute>();
            var name = ifblank(tag.MapValueOrDefault(x => x.HostName), host.Name);
            var owner = host.Assembly.Id();
            return new ApiHostUri(owner, name);
        }

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

        [Op]
        public static string Format(TargetPart part)
            => text.concat(format(part.Source), PartConnector, format(part.Target));

        const string PartConnector = " -> ";

        [MethodImpl(Inline), Op]
        public static TargetPart target(PartId src, PartId dst)
            => new TargetPart(src,dst);

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

        public static bool test(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Count() > 0;

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
            return apiHostTypes(src).Select(h => host(_id, h));
        }

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
                var uri = new ApiHostUri(part, name);
                seek(dst,i) = new ApiDataType(type, name, part, uri);
            }
            return buffer;
        }

        [Op]
        public static PartCatalog[] catalogs(params IPart[] parts)
            => parts.Select(catalog);
    }
}