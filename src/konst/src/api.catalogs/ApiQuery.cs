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

    [ApiHost]
    public readonly partial struct ApiQuery
    {
        /// <summary>
        /// Creates a view over a specified catalog
        /// </summary>
        /// <param name="src">The catalog to query</param>
        [MethodImpl(Inline), Op]
        public static PartCatalogQuery catalog(IApiPartCatalog src)
            => new PartCatalogQuery(src);

        [MethodImpl(Inline), Op]
        public static HostMemberQuery host(IApiHost host)
            => new HostMemberQuery(host);

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

        static Type[] ResAccessorTypes
            => new Type[]{typeof(ReadOnlySpan<byte>), typeof(ReadOnlySpan<char>)};

        static ApiResourceKind FormatAccessor(Type match)
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
    }
}