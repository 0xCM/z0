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
    using static z;

    public readonly struct ApiHosts
    {
        [MethodImpl(Inline)]
        public static IApiHost<H> from<H>()
            where H : IApiHost<H>, new()
                => new H();

        public static IPartCatalog catalog(IPart part)
            => new PartCatalog(part, dataTypeHosts(part.Owner), opHosts(part.Owner), svcHostTypes(part.Owner));

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiDataTypeAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        static ApiDataType[] dataTypeHosts(Assembly src)
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

        static ApiHost[] opHosts(Assembly src)
        {
            var part = src.Id();
            return opHostTypes(src).Select(h => opHost(part, h));
        }

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        static Type[] svcHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        static Type[] opHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<ApiHostAttribute>());

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        static ApiHost opHost(PartId part, Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifblank(attrib.MapValueOrDefault(a => a.HostName, t.Name),t.Name).ToLower();
            var uri = ApiHostUri.Define(part, name);
            return new ApiHost(t, name, part, uri);
        }
    }
}