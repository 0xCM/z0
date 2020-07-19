//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiHosts
    {
        [MethodImpl(Inline)]
        public static IApiHost<H> from<H>()
            where H : IApiHost<H>, new()
                => new H();

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static Type[] ServiceTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiDataTypeAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static Type[] DataTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<ApiDataTypeAttribute>());

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static Type[] HostTypes(Assembly src)
            => src.GetTypes().Tagged<ApiHostAttribute>();

        /// <summary>
        /// Describes an api data type
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        public static ApiDataType ApiDataType(PartId part, Type t)
        {
            var attrib = t.Tag<ApiDataTypeAttribute>();
            var name =  text.ifblank(attrib.MapValueOrDefault(a => a.Name, t.Name),t.Name).ToLower();
            var uri = ApiHostUri.Define(part, name);
            return new ApiDataType(name, part, uri, t);
        }

        public static ApiDataType[] ApiDataTypes(Assembly src)
            => DataTypes(src).Select(t => ApiDataType(src.Id(), t));

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        public static ApiHost ApiHost(PartId part, Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifblank(attrib.MapValueOrDefault(a => a.HostName, t.Name),t.Name).ToLower();
            var kind = attrib.MapValueOrDefault(a => a.HostKind, ApiHostKind.DirectAndGeneric);
            var uri = ApiHostUri.Define(part, name);
            return new ApiHost(name, kind, part, uri, t);
        }

        /// <summary>
        /// Instantiates the api hosts defined in a .net assembly
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static ApiHost[] Hosts(Assembly src)
            => HostTypes(src).Select(h => ApiHost(h.Assembly.Id(), h));    

        public static ApiCatalog catalog(IPart part)            
        {
            var owner = part.Owner;
            var id = part.Id;
            var hosts = Hosts(owner);
            return new ApiCatalog(
                PartId: id,
                Owner: owner,
                Hosts: hosts,
                DataTypes: ApiDataTypes(owner),
                ServiceTypes: ServiceTypes(owner),
                DirectHosts: hosts.Where(h => h.HostKind.DefinesDirectOps()),
                GenericHosts: hosts.Where(h => h.HostKind.DefinesGenericOps())
                );
        }
    }
}