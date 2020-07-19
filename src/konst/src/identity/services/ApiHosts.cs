//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    public readonly struct ApiHosts
    {
        [MethodImpl(Inline)]
        public static IApiHost<H> from<H>()
            where H : IApiHost<H>, new()
                => new H();
        
        public static ApiDataType[] DataTypeHosts(Assembly src)
        {
            var part = src.Id();
            return DataTypeHostTypes(src).Select(t => DataTypeHost(part, t));
        }

        public static ApiHost[] OperationHosts(Assembly src)
        {
            var part = src.Id();
            return OperationHostTypes(src).Select(h => OperationHost(part, h));    
        }

        public static ApiCatalog catalog(IPart part)            
            => new ApiCatalog(part, DataTypeHosts(part.Owner), OperationHosts(part.Owner), ServiceHostTypes(part.Owner));

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        static Type[] ServiceHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiDataTypeAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        static Type[] DataTypeHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<ApiDataTypeAttribute>());

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        static Type[] OperationHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<ApiHostAttribute>());

        /// <summary>
        /// Describes an api data type
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        static ApiDataType DataTypeHost(PartId part, Type t)
        {
            var attrib = t.Tag<ApiDataTypeAttribute>();
            var name =  text.ifblank(attrib.MapValueOrDefault(a => a.Name, t.Name),t.Name).ToLower();
            var uri = ApiHostUri.Define(part, name);
            return new ApiDataType(t, name, part, uri);
        }

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        static ApiHost OperationHost(PartId part, Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifblank(attrib.MapValueOrDefault(a => a.HostName, t.Name),t.Name).ToLower();
            var uri = ApiHostUri.Define(part, name);
            return new ApiHost(t, name, part, uri);
        }        
    }
}