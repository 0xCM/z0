//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static memory;

    partial struct ApiQuery
    {
        [Op]
        public static ApiHostUri hosturi(Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifempty(attrib.MapValueOrDefault(a => a.HostName, t.Name), t.Name).ToLower();
            return new ApiHostUri(t.Assembly.Id(), name);
        }
    }
}