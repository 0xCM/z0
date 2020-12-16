//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ApiQuery
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
        public static ApiHostQuery host(IApiHost host)
            => new ApiHostQuery(host);

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
                    return Option.some(new ApiHostUri(owner, components[1]));
            }
            return Option.none<ApiHostUri>();
        }
   }
}