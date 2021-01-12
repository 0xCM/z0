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
        public static ApiHostInfo hostinfo(Type t)
        {
            var ass = t.Assembly;
            var part = id(ass);
            var u = uri(t);
            var methods = t.DeclaredMethods();
            return new ApiHostInfo(t, u, part, methods);
        }

        [Op]
        public static ApiHostInfo hostinfo<T>()
            => hostinfo(typeof(T));
    }
}