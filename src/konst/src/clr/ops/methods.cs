//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static ReflectionFlags;
    using static Part;

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrMethod> methods(Type src)
            => view(src.GetMethods(BF_All), ClrViews.method);
    }
}