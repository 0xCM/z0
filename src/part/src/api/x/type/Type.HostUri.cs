//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XApi
    {
        [Op]
        public static ApiHostUri HostUri(this Type host)
        {
            if(host != null)
            {
                var tag = host.Tag<ApiHostAttribute>();
                var name = text.ifempty(tag.MapValueOrDefault(x => x.HostName), host.Name).ToLower();
                var owner = host.Assembly.Id();
                return new ApiHostUri(owner, name);
            }
            else
                return ApiHostUri.Empty;
        }
    }
}