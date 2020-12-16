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
    using System.Collections.Generic;

    using static Konst;
    using static z;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    [ApiHost(ApiNames.ApiQuery, true)]
    public readonly partial struct ApiQuery
    {
        [MethodImpl(Inline), Op]
        public static ApiPartCatalogQuery catalog(IApiPartCatalog src)
            => new ApiPartCatalogQuery(src);

        [MethodImpl(Inline), Op]
        public static ApiQueries over(ApiMembers src)
            => new ApiQueries(src);

        [Op]
        public static HostedMethod[] DirectMethods(IApiHost host)
            => host.HostType.DeclaredMethods().NonGeneric().Where(IsDirect).Select(m => new HostedMethod(host.Uri, m));

        [Op]
        public static HostedMethod[] GenericMethods(IApiHost host)
            => host.HostType.DeclaredMethods().OpenGeneric(1).Where(IsGeneric).Select(m => new HostedMethod(host.Uri, m));

        [Op]
        static bool IsDirect(MethodInfo src)
            => src.Tagged<OpAttribute>() && !src.AcceptsImmediate();

        [Op]
        static bool IsGeneric(MethodInfo src)
            => src.Tagged<OpAttribute>() && src.Tagged<ClosuresAttribute>() && !src.AcceptsImmediate();

        [Op]
        public static BitMaskInfo[] bitmasks(Type src)
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
        public static bool isPart(Assembly src)
            => Attribute.IsDefined(src, typeof(PartIdAttribute));

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

        [Op]
        internal static ApiResKind FormatAccessor(Type match)
        {
            ref readonly var src = ref first(span(ResAccessorTypes));
            var kind = ApiResKind.None;
            if(skip(src,0).Equals(match))
                kind = ApiResKind.ByteSpan;
            else if(skip(src,1).Equals(match))
                kind = ApiResKind.CharSpan;
            return kind;
        }

        /// <summary>
        /// Computes a method's numeric closures, predicated on available metadata
        /// </summary>
        /// <param name="m">The source method</param>
        [Op]
        public static NumericKind[] NumericClosureKinds(MethodInfo m)
            => (from tag in m.Tag<ClosuresAttribute>()
                where tag.Kind == TypeClosureKind.Numeric
                let spec = (NumericKind)tag.Spec
                select spec.DistinctKinds().ToArray()).ValueOrElse(() => sys.empty<NumericKind>());

        [Op]
        public static Type[] NumericClosureTypes(MethodInfo m)
            => from c in NumericClosureKinds(m)
               let t = c.ToSystemType()
               where t != typeof(void)
               select t;

        // [Op]
        // static Exception DuplicateKeyException(IEnumerable<object> keys, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        //     => new Exception(text.concat($"Duplicate keys were detected {keys.FormatList()}",  caller,file, line));


        /// <summary>
        /// Creates an operation index from a uri bitstream
        /// </summary>
        /// <param name="src">The source bits</param>
        [Op]
        static ApiOpIndex<ApiCodeBlock> CodeBlockIndex(ApiCodeBlock[] src)
            => index(src.Select(x => (x.OpUri.OpId, x)),true);

         internal static Type[] ResAccessorTypes
            => new Type[]{typeof(ReadOnlySpan<byte>), typeof(ReadOnlySpan<char>)};
    }
}