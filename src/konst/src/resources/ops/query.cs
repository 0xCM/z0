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
        public static ResourceQuery query(Assembly src, string match = null)
            => new ResourceQuery(src, Resources.descriptors(src, match));
    }
}