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
        public static ApiHostUri hosturi(Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifempty(attrib.MapValueOrDefault(a => a.HostName, t.Name), t.Name).ToLower();
            return new ApiHostUri(t.Assembly.Id(), name);
        }

        public static ApiHostUri hosturi<T>()
            => hosturi(typeof(T));

        /// <summary>
        /// Determines the api host that owns the file, if any
        /// </summary>
        /// <param name="src">The source file</param>
        [Op]
        public static Option<ApiHostUri> hosturi(FS.FileName src)
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