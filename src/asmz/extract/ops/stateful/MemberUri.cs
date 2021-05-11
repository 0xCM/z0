//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Part;
    using static memory;

    partial class ApiExtractor
    {
        [Op]
        OpUri MemberUri(ApiHostUri host, MethodInfo method)
            => ApiUri.define(ApiUriScheme.Located, host, method.Name, Identity.Identify(method));
    }
}