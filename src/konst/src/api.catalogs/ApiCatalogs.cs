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
        /// <summary>
        /// Creates a system-level api catalog over a set of path-identified components
        /// </summary>
        /// <param name="paths">The source paths</param>
        [Op]
        public static SystemApiCatalog system(FS.Files paths)
            => new SystemApiCatalog(parts(paths.Data));

        [Op]
        public static ISystemApiCatalog siblings(Assembly src, PartId[] parts)
        {
            var path = FS.path(src.Location).FolderPath;
            var managed = path.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            var catalog =
                parts.Length != 0
                ? new SystemApiCatalog(system(managed).Parts.Where(x => parts.Contains(x.Id)))
                : system(managed);
            return catalog;
        }

        /// <summary>
        /// Creates a system-level api catalog over a specified component set
        /// </summary>
        /// <param name="src">The source components</param>
        [Op]
        public static ISystemApiCatalog system(Assembly[] src)
        {
            var candidates = src.Where(Q.isPart);
            var parts = candidates.Select(TryGetPart).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id);
            return new SystemApiCatalog(parts);
        }

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> over a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog part(Assembly src)
            => new ApiPartCatalog(src.Id(), src, datatypes(src), apiHosts(src), svcHostTypes(src));

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> over a specified part
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog part(IPart src)
            => part(src.Owner);

        [Op]
        public static ApiHostCatalog members(IApiHost src)
        {
            var generic = HostedGeneric(src);
            var direct = HostedDirect(src);
            var all = direct.Concat(generic).Array();
            return new ApiHostCatalog(src, all.OrderBy(x => x.Method.MetadataToken));
        }

        [Op]
        static ApiMember[] HostedDirect(IApiHost src)
        {
            var methods = @readonly(ApiQuery.DirectApiMethods(src).Array());
            var count = methods.Length;
            var members = alloc<ApiMember>(count);
            var dst = span(members);
            for(var i=0u; i<count; i++)
            {
                ref readonly var m = ref skip(methods,i);
                var id = MultiDiviner.Service.Identify(m);
                var im = new IdentifiedMethod(id,m);
                var uri = OpUri.Define(ApiUriScheme.Type, src.Uri, m.Name, id);
                var located = ClrDynamic.jit(im);
                var mKind = m.KindId();
                var member = new ApiMember(uri, located,  mKind);
                seek(dst,i) = member;
            }
            return members;
        }

        [Op]
        static ApiMember[] HostedGeneric(IApiHost src)
        {
            var methods = @readonly(ApiQuery.GenericApiMethods(src).Array());
            var count = methods.Length;
            var members = alloc<ApiMember>(count);
            var dst = span(members);
            for(var i=0u; i<count; i++)
            {
                ref readonly var m = ref skip(methods,i);
                var closure = ApiQuery.NumericClosureTypes(m);
                var reified = m.MakeGenericMethod(closure);
                var id = MultiDiviner.Service.Identify(reified);
                var im = new IdentifiedMethod(id,m);
                var uri = OpUri.Define(ApiUriScheme.Type, src.Uri, m.Name, id);
                var located = ClrDynamic.jit(im);
                var mKind = m.KindId();
                var member = new ApiMember(uri, located, mKind);
                seek(dst,i) = member;
            }
            return members;
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