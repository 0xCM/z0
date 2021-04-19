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
    using static Root;

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrMethod> methods(Type src)
            => adapt(methods(src, out var _));

        [MethodImpl(Inline), Op]
        public static MethodInfo[] methods(Type src, out MethodInfo[] dst)
            => dst = src.GetMethods(BF);
    }
}