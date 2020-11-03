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
    public readonly struct ApiQuery
    {
        [Op]
        public static ApiHostInfo host(Type tHost)
        {
            var ass = tHost.Assembly;
            var part = id(ass);
            var u = uri(tHost);
            var methods = tHost.DeclaredMethods();
            return new ApiHostInfo(tHost, u, part, methods);
        }

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="tHost">The reifying type</param>
        [Op]
        public static ApiHost host(PartId part, Type tHost)
        {
            var attrib = tHost.Tag<ApiHostAttribute>();
            var name =  text.ifempty(attrib.MapValueOrDefault(a => a.HostName, tHost.Name), tHost.Name).ToLower();
            var uri = new ApiHostUri(part, name);
            return new ApiHost(tHost, name, part, uri);
        }

        [MethodImpl(Inline), Op]
        public static ApiPartCatalogQuery catalog(IApiPartCatalog src)
            => new ApiPartCatalogQuery(src);

        [MethodImpl(Inline), Op]
        public static ApiHostQuery host(IApiHost host)
            => new ApiHostQuery(host);

        [MethodImpl(Inline), Op]
        public static ApiQueries over(ApiMembers src)
            => new ApiQueries(src);

        [Op]
        public static ApiMemberCodeIndex MemberCodeIndex(ApiMemberIndex members, ApiOpIndex<ApiCodeBlock> code)
        {
            var apicode = from pair in intersect(members, code).Enumerated
                          let l = pair.Item1
                          let r = pair.Item2
                          select new ApiMemberCode(r.left, r.right);
            return new ApiMemberCodeIndex(create(apicode.Select(c => (c.Id, c))));
        }

        [Op, Closures(UInt64k)]
        public static ApiOpIndex<T> index<T>(IEnumerable<(OpIdentity,T)> src, bool deduplicate = true)
        {
            var items = src.ToArray();
            var identities = items.Select(x => x.Item1).ToArray();
            var duplicates = (from g in identities.GroupBy(i => i.Identifier)
                             where g.Count() > 1
                             select g.Key).ToHashSet();

            var HashTable = new Dictionary<OpIdentity,T>();

            if(duplicates.Count() != 0)
            {
                if(deduplicate)
                    HashTable = items.Where(i => !duplicates.Contains(i.Item1.Identifier)).ToDictionary();
                else
                    @throw(DuplicateKeyException(duplicates));
            }
            else
                HashTable = src.ToDictionary();

            return new ApiOpIndex<T>(HashTable, duplicates.Select(d => OpIdentityParser.parse(d)).Array());
        }

        [Op]
        public static uint identities(ReadOnlySpan<OpIdentity> src, Span<ApiIdentityToken> dst)
        {
            var count = min(src.Length,dst.Length);
            if(count == 0)
                return 0;

            var duplicates = 0u;
            ref readonly var source = ref first(src);

            for(var i=0u; i<count; i++)
            {
                ref readonly var identity = ref skip(source,i);
                var k = ApiIdentityTokens.key(identity);
                if(ApiIdentityTokens.Index.TryAdd(k, identity))
                    seek(dst,i) = new ApiIdentityToken(k);
                else
                {
                    seek(dst,i) = ApiIdentityToken.Empty;
                    duplicates++;
                }
            }
            return duplicates;
        }

        [Op]
        public static KeyedValues<PartId,Type>[] types(ClrTypeKind kind, ISystemApiCatalog src)
        {
            switch(kind)
            {
                case ClrTypeKind.Enum:
                    return enums(src);
                default:
                    return default;
            }
        }

        [Op]
        public static ApiMemberIndex index(ApiHostCatalog src)
        {
            var ix = index(src.Storage.Select(h => (h.Id, h)),true);
            return new ApiMemberIndex(ix.HashTable, ix.Duplicates);
        }

        [Op]
        public static ApiHostMemberCode code(ISystemApiCatalog api, ApiHostUri host, FolderPath root)
        {
            var catalog = ApiCatalogs.members(api.FindHost(host).Require());
            if(catalog.IsEmpty)
                return ApiHostMemberCode.Empty;

            var idx = index(catalog);
            var archive =  ApiFiles.capture(root);
            var paths =  HostCaptureArchive.create(root, host);
            var code = ApiHexReader.Service.Read(paths.HostX86Path);
            var opIndex =  CodeBlockIndex(code);
            return new ApiHostMemberCode(host, MemberCodeIndex(idx, opIndex));
        }

        [Op]
        public static HostedMethod[] DirectMethods(IApiHost host)
            => host.HostType.DeclaredMethods().NonGeneric().Where(ApiQuery.IsDirectApiMember).Select(m => new HostedMethod(host.Uri, m));

        [Op]
        public static HostedMethod[] GenericMethods(IApiHost host)
            => host.HostType.DeclaredMethods().OpenGeneric(1).Where(ApiQuery.IsGenericApiMember).Select(m => new HostedMethod(host.Uri, m));

        [Op]
        public static bool IsDirectApiMember(MethodInfo src)
            => src.Tagged<OpAttribute>() && !src.AcceptsImmediate();

        [Op]
        public static bool IsGenericApiMember(MethodInfo src)
            => src.Tagged<OpAttribute>() && src.Tagged<ClosuresAttribute>() && !src.AcceptsImmediate();

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

        [Op]
        public static bool nonempty(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Count() > 0;

        [Op]
        public static ApiHostInfo host<H>()
            => host(typeof(H));

        /// <summary>
        /// Determines the api host that owns the file, if any
        /// </summary>
        /// <param name="src">The source file</param>
        [Op]
        public static Option<ApiHostUri> host(FS.FileName src)
        {
            var components = src.WithoutExtension.Name.Split(Chars.Dot);
            if(components.Length == 2)
            {
                var owner = Z0.Enums.parse(components[0], PartId.None);
                if(owner.IsSome())
                    return z.some(new ApiHostUri(owner, components[1]));
            }
            return z.none<ApiHostUri>();
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
               let t = c.SystemType()
               where t != typeof(void)
               select t;

        [Op]
        static Exception DuplicateKeyException(IEnumerable<object> keys, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new Exception(text.concat($"Duplicate keys were detected {keys.FormatList()}",  caller,file, line));

        [Op]
        static KeyedValues<PartId,Type>[] enums(ISystemApiCatalog src)
        {
            var x = from part in  src.Parts
                    let enums = part.Owner.Enums()
                        orderby part.Id
                        select Seq.keyed(part.Id, enums);
            return x;
        }

        [Op, Closures(UInt64k)]
        static ApiOpIndex<(L left, R right)> intersect<L,R>(IApiOpIndex<L> left, IApiOpIndex<R> right)
        {
             var keys = left.Keys.ToHashSet();
             keys.IntersectWith(right.Keys);
             var keylist = keys.ToArray();
             var count = keylist.Length;
             var entries = Arrays.alloc<(OpIdentity,(L,R))>(count);
             for(var i=0; i<count; i++)
             {
                var key = keylist[i];
                entries[i] = (key, (left[key], right[key]));
             }
             return index(entries);
         }

        static ApiOpIndex<T> create<T>(IEnumerable<(OpIdentity,T)> src)
        {
            try
            {
                var items = src.ToArray();
                var identities = items.Select(x => x.Item1).ToArray();
                var duplicates = (from g in identities.GroupBy(i => i.Identifier)
                                where g.Count() > 1
                                select g.Key).ToHashSet();

                var dst = new Dictionary<OpIdentity,T>();
                if(duplicates.Count() != 0)
                    dst = items.Where(i => !duplicates.Contains(i.Item1.Identifier)).ToDictionary();
                else
                    dst = src.ToDictionary();
                return new ApiOpIndex<T>(dst, duplicates.Select(d => OpIdentityParser.parse(d)).Array());
            }
            catch(Exception e)
            {
                term.error(e);
                return ApiOpIndex<T>.Empty;
            }
        }

        /// <summary>
        /// Creates an operation index from a uri bitstream
        /// </summary>
        /// <param name="src">The source bits</param>
        [Op]
        static ApiOpIndex<ApiCodeBlock> CodeBlockIndex(ApiCodeBlock[] src)
            => index(src.Select(x => (x.OpUri.OpId, x)));

        /// <summary>
        /// Creates an operation index from an api member span, readonly that is
        /// </summary>
        /// <param name="src">The members to index</param>
        /// <typeparam name="M">The member type</typeparam>
        static ApiOpIndex<M> index<M>(ReadOnlySpan<M> src)
            where M : struct, IApiMember
                => index(src.MapArray(h => (h.Id, h)));

        static MethodInfo[] GenericMethods<K>(IApiHost src, K kind)
            where K : unmanaged, Enum
                => from m in src.HostType.DeclaredMethods().OpenGeneric(1)
                where m.Tagged<OpAttribute>()
                && m.Tagged<ClosuresAttribute>()
                && !m.AcceptsImmediate()
                && m.KindId().ToString() == kind.ToString()
                select m;

        static MethodInfo[] DirectMethods<K>(IApiHost src, K kind)
            where K : unmanaged, Enum
                => from m in src.HostType.DeclaredMethods().NonGeneric()
                where m.Tagged<OpAttribute>()
                && !m.AcceptsImmediate()
                && m.KindId().ToString() == kind.ToString()
                select m;

        /// <summary>
        /// Computes a types's numeric closures, predicated on available metadata
        /// </summary>
        /// <param name="t">The source type</param>
        [Op]
        static NumericKind[] NumericClosureKinds(Type t)
            => (from tag in t.Tag<ClosuresAttribute>()
                where tag.Kind == TypeClosureKind.Numeric
                let spec = (NumericKind)tag.Spec
                select spec.DistinctKinds().ToArray()).ValueOrElse(() => sys.empty<NumericKind>());

        /// <summary>
        /// Computes a method's natural closures, predicated on available metadata
        /// </summary>
        /// <param name="m">The source method</param>
        [Op]
        static Type[] NaturalClosureTypes(MethodInfo m)
            => (from tag in m.Tag<ClosuresAttribute>()
                where tag.Kind == TypeClosureKind.Natural
                let spec = (NatClosureKind)tag.Spec
                select NativeNaturals.FindTypes(spec).ToArray()).ValueOrElse(() => sys.empty<Type>());

      internal static Type[] ResAccessorTypes
            => new Type[]{typeof(ReadOnlySpan<byte>), typeof(ReadOnlySpan<char>)};
    }
}