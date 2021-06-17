//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    partial class XApi
    {
        [Op]
        public static ApiHostUri HostUri(this Type host)
        {
            if(host != null)
            {
                var tag = host.Tag<ApiHostAttribute>();
                var name = minicore.ifempty(tag.MapValueOrDefault(x => x.HostName), host.Name).ToLower();
                var owner = host.Assembly.Id();
                return new ApiHostUri(owner, name);
            }
            else
                return ApiHostUri.Empty;
        }

        public static ApiHostUri[] ApiHosts(this Assembly src)
        {
            var dst = new List<ApiHostUri>();
            var types = src.Types().Tagged<ApiHostAttribute>();
            foreach(var t in types)
            {
                dst.Add(t.HostUri());
            }
            return dst.ToArray();
        }
    }
}