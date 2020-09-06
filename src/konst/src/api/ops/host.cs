//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        [Op]
        public static ApiHost host(PartId part, Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifblank(attrib.MapValueOrDefault(a => a.HostName, t.Name),t.Name).ToLower();
            var uri = new ApiHostUri(part, name);
            return new ApiHost(t, name, part, uri);
        }

        /// <summary>
        /// Determines the api host that owns the file, if any
        /// </summary>
        /// <param name="src">The source file</param>
        [MethodImpl(Inline)]
        public static Option<ApiHostUri> host(FilePath src)
            => host(src.FileName);

        /// <summary>
        /// Determines the api host that owns the file, if any
        /// </summary>
        /// <param name="src">The source file</param>
        public static Option<ApiHostUri> host(FileName src)
        {
            var components = src.WithoutExtension.Name.Split(Chars.Dot);
            if(components.Length == 2)
            {
                var owner = Z0.Enums.Parse(components[0], PartId.None);
                if(owner.IsSome())
                    return z.some(new ApiHostUri(owner, components[1]));
            }
            return z.none<ApiHostUri>();
        }
    }
}