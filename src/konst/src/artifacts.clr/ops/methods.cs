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
    using static z;
    using static ReflectionFlags;

    partial struct ClrArtifacts
    {
        [MethodImpl(Inline), Op]
        public static MethodInfo[] methods(Type src)
            => src.GetMethods(BF_All);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<MethodView> vMethods(Type src)
            => View(methods(src), method);
    }
}