//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrModule> modules(Assembly src)
            => view(src.Modules());

        [MethodImpl(Inline), Op]
        public static ClrModule manifest(Assembly src)
            => view(src.ManifestModule);
    }
}