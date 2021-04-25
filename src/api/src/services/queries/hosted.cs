//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    partial class ApiQuery
    {
        [MethodImpl(Inline), Op]
        public static ApiHostMethods hosted(IApiHost host, MethodInfo[] methods)
            => new ApiHostMethods(host, methods);

        [MethodImpl(Inline), Op]
        public static ApiHostMethods hosted(IApiHost src)
            => hosted(src, src.Methods);
    }
}