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
        public static IPart[] KnownParts
            => ModuleArchives.executing().Parts.Where(r => r.Id != 0);

        public static Assembly[] KnownComponents
            => ModuleArchives.executing().Components;

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Option<IPart> part(Assembly src)
            => Option.Try(() => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Map(t => (IPart)Activator.CreateInstance(t)).FirstOrDefault());

        [Op]
        public static IPart[] parts(Assembly[] src)
            => src.Where(isPart).Select(part).Where(x => x.IsSome()).Select(x => x.Value);

        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
        public static Option<Assembly> assembly(FS.FilePath src)
            => Option.Try(src, x => Assembly.LoadFrom(x.Name));

        public static Assembly[] components(FS.FilePath[] src)
            => src.Map(assembly).Where(x => x.IsSome()).Select(x => x.Value).Where(isPart);

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
            => src.Components.Where(isPart);

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
        public static IPartCatalog catalog(IPart part)
            => new PartCatalog(part, dataTypes(part.Owner), apiHosts(part.Owner), svcHostTypes(part.Owner));

        [Op]
        public static IPartCatalog catalog(Assembly src)
            => new PartCatalog(src, dataTypes(src), apiHosts(src), svcHostTypes(src));

        [MethodImpl(Inline), Op]
        public static IApiSet apiset(IResolvedApi resolved)
            => new ApiSet(resolved);
    }
}