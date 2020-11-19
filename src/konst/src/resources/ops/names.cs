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

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<string> names(Assembly src, utf8? match = null)
            => match != null && match.Value.IsNonEmpty
            ? src.ManifestResourceNames().Where(n => n.Contains(match.Value))
            : src.ManifestResourceNames();
    }
}