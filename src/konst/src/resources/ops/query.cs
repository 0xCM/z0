//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static ResQuery query(Assembly src)
            => new ResQuery(src, Resources.descriptors(src));

        [MethodImpl(Inline), Op]
        public static ResQuery query(Assembly src, utf8 match)
            => new ResQuery(src, Resources.descriptors(src, match));
    }
}