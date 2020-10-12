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

    using static Konst;
    using static z;

    [ApiHost(ApiNames.ApiQuery, true)]
    public readonly struct ApiQuery
    {
        [Op]
        public static BitMaskRow[] bitmasks(Type src)
            => BitMasks.rows(src);

        [Op]
        public static PartId id(Assembly src)
        {
            if(isPart(src))
                return ((PartIdAttribute)Attribute.GetCustomAttribute(src, typeof(PartIdAttribute))).Id;
            else
                return PartId.None;
        }

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
        /// Creates a view over a specified catalog
        /// </summary>
        /// <param name="src">The catalog to query</param>
        [MethodImpl(Inline), Op]
        public static PartCatalogQuery catalog(IApiPartCatalog src)
            => new PartCatalogQuery(src);

        [MethodImpl(Inline), Op]
        public static ApiHostMemberQuery host(IApiHost host)
            => new ApiHostMemberQuery(host);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ApiDependency<T> needs<T>(T src, T dst)
            => new ApiDependency<T>(src,dst);

        [MethodImpl(Inline), Op]
        public static ApiPartTypes types(IPart src)
            => new ApiPartTypes(src.Id, src.Owner.Types());

        [Op]
        public static ApiHostUri uri(Type host)
        {
            if(host != null)
            {
                var tag = host.Tag<ApiHostAttribute>();
                var name = ifempty(tag.MapValueOrDefault(x => x.HostName), host.Name);
                var owner = host.Assembly.Id();
                return new ApiHostUri(owner, name);
            }
            else
                return ApiHostUri.Empty;
        }

        internal static Type[] ResAccessorTypes
            => new Type[]{typeof(ReadOnlySpan<byte>), typeof(ReadOnlySpan<char>)};

        internal static ApiResourceKind FormatAccessor(Type match)
        {
            ref readonly var src = ref first(span(ResAccessorTypes));
            var kind = ApiResourceKind.None;
            if(skip(src,0).Equals(match))
                kind = ApiResourceKind.ByteSpan;
            else if(skip(src,1).Equals(match))
                kind = ApiResourceKind.CharSpan;
            return kind;
        }

        [MethodImpl(Inline), Op]
        public static string format(PartId src)
            => Part.format(src);

        public static bool nonempty(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Count() > 0;


        [Op]
        public static ApiHostInfo host<H>()
            => host(typeof(H));

        [Op]
        public static ApiHostInfo host(Type t)
        {
            var ass = t.Assembly;
            var part = id(ass);
            var u = uri(t);
            var methods = t.DeclaredMethods();
            return new ApiHostInfo(t, u, part, methods);
        }

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        [Op]
        public static ApiHost host(PartId part, Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifempty(attrib.MapValueOrDefault(a => a.HostName, t.Name),t.Name).ToLower();
            var uri = new ApiHostUri(part, name);
            return new ApiHost(t, name, part, uri);
        }

        /// <summary>
        /// Determines the api host that owns the file, if any
        /// </summary>
        /// <param name="src">The source file</param>
        [MethodImpl(Inline)]
        public static Option<ApiHostUri> host(FS.FilePath src)
            => host(src.FileName);

        /// <summary>
        /// Determines the api host that owns the file, if any
        /// </summary>
        /// <param name="src">The source file</param>
        public static Option<ApiHostUri> host(FS.FileName src)
        {
            var components = src.WithoutExtension.Name.Split(Chars.Dot);
            if(components.Length == 2)
            {
                var owner = Z0.Enums.Parse(components[0], PartId.None);
                if(owner.IsSome())
                    return z.some(new ApiHostUri(owner, components[1]));
            }
            return z.none<ApiHostUri>();
        }

        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
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

        [Op]
        public static ApiPartSet components(FS.FolderPath src)
            => new ApiPartSet(src);
    }
}