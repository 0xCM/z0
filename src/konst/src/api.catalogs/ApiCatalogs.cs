//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    using Q = ApiQuery;

    [ApiHost(ApiNames.ApiCatalogs, true)]
    public readonly struct ApiCatalogs
    {
        [Op]
        public static IDictionary<MethodInfo,Type> ClosureProviders(IEnumerable<Type> src)
        {
            var query = from t in src
                        from m in t.DeclaredStaticMethods()
                        let tag = m.Tag<ClosureProviderAttribute>()
                        where tag.IsSome()
                        select (m, tag.Value.ProviderType);
            return query.ToDictionary();
        }

        [Op]
        public static ApiHostMembers members(IApiHost src)
        {
            var generic = HostedGeneric(src);
            var direct = HostedDirect(src);
            var all = direct.Concat(generic).Array();
            return new ApiHostMembers(src, all.OrderBy(x => x.Method.MetadataToken));
        }

        [Op]
        static IEnumerable<ApiMember> HostedDirect(IApiHost src)
            => from m in ApiQuery.DirectApiMethods(src)
                let id = MultiDiviner.Service.Identify(m)
                let im = new IdentifiedMethod(id,m)
                let uri = OpUri.Define(ApiUriScheme.Type, src.Uri, m.Name, id)
                let located = ClrDynamic.jit(im)
                select new ApiMember(uri, located,  m.KindId());

        [Op]
        static IEnumerable<ApiMember> HostedGeneric(IApiHost src)
            =>  from m in ApiQuery.GenericApiMethods(src)
                from closure in ApiQuery.NumericClosureTypes(m)
                let reified = m.MakeGenericMethod(closure)
                let id = MultiDiviner.Service.Identify(reified)
                let im = new IdentifiedMethod(id,m)
                let uri = OpUri.Define(ApiUriScheme.Type, src.Uri, m.Name, id)
                let located = ClrDynamic.jit(im)
                select new ApiMember(uri, located, m.KindId());

        [MethodImpl(Inline), Op]
        public static ApiUriParser UriParser()
            => new ApiUriParser();

        [MethodImpl(Inline), Op]
        public static ApiPartIdParser PartIdParser()
            => new ApiPartIdParser();

        [MethodImpl(Inline), Op]
        public static LegalIdentityBuilder CodeIdentity()
            => LegalIdentity(CodeIdentityOptions());

        [MethodImpl(Inline), Op]
        public static LegalIdentityBuilder FileIdentity()
            => LegalIdentity(FileIdentityOptions());

        [MethodImpl(Inline), Op]
        public static LegalIdentityBuilder LegalIdentity(LegalIdentityOptions options)
            => new LegalIdentityBuilder(options);

        [MethodImpl(Inline), Op]
        public static ApiIdentities IdentityManager(IWfShell wf)
            => new ApiIdentities(wf);

        [MethodImpl(Inline), Op]
        static LegalIdentityOptions FileIdentityOptions()
            => new LegalIdentityOptions(
                TypeArgsOpen: Chars.LBracket,
                TypeArgsClose: Chars.RBracket,
                ArgsOpen: Chars.LParen,
                ArgsClose: Chars.RParen,
                ArgSep: Chars.Comma,
                ModSep: IDI.ModSep);

        [MethodImpl(Inline), Op]
        internal static LegalIdentityOptions CodeIdentityOptions()
            => new LegalIdentityOptions(
            TypeArgsOpen: SymNot.Lt,
            TypeArgsClose: SymNot.Gt,
            ArgsOpen: SymNot.Circle,
            ArgsClose: SymNot.Circle,
            ArgSep: SymNot.Dot,
            ModSep: (char)SymNotKind.Plus
            );

        [Op]
        public static ApiPartCatalog part(IPart src)
            => part(src.Owner);

        [Op]
        public static ApiPartCatalog part(Assembly src)
            => new ApiPartCatalog(src.Id(), src, datatypes(src), apiHosts(src), svcHostTypes(src));

        [Op]
        static ApiPartCatalog[] parts(params IPart[] parts)
            => parts.Select(part);

        [Op]
        static ISystemApiCatalog system(Assembly[] src)
        {
            var candidates = src.Where(Q.isPart);
            var parts = candidates.Select(TryGetPart).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id);
            return new SystemApiCatalog(parts);
        }

        public static SystemApiCatalog system(FS.Files paths)
            => new SystemApiCatalog(parts(paths.Data));


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
        static KeyedValues<PartId,Type>[] enums(ISystemApiCatalog src)
        {
            var x = from part in  src.Parts
                    let enums = part.Owner.Enums()
                        orderby part.Id
                        select Seq.keyed(part.Id, enums);
            return x;
        }

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        [Op]
        static Option<IPart> TryGetPart(Assembly src)
        {
            try
            {
                return z.some(src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Map(t => (IPart)Activator.CreateInstance(t)).FirstOrDefault());
            }
            catch(Exception e)
            {
                term.error(AppErrors.define(nameof(ApiCatalogs), text.format("Assembly {0} | {1}", src.GetSimpleName(), e)));
                return z.none<IPart>();
            }
        }

        [Op]
        static IPart[] parts(FS.FilePath[] paths)
            => paths.Select(part).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id);

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        [Op]
        static Option<IPart> part(FS.FilePath src)
                => from c in Q.component(src)
                from t in resolve(c)
                from p in resolve(t)
                from part in resolve(p)
                select part;

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
            => Try(src, x => (IPart)x.GetValue(null));

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        static Type[] apiHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<ApiHostAttribute>());

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        static Type[] svcHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        [Op]
        static ApiHost[] apiHosts(Assembly src)
        {
            var _id = Q.id(src);
            return apiHostTypes(src).Select(h => Q.host(_id, h));
        }

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiDataTypeAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        static ApiDataType[] datatypes(Assembly src)
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
                var name =  text.ifempty(attrib.MapValueOrDefault(a => a.Name, type.Name),type.Name).ToLower();
                var uri = new ApiHostUri(part, name);
                seek(dst,i) = new ApiDataType(type, name, part, uri);
            }
            return buffer;
        }
    }
}