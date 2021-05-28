//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct Resources
    {
        [Op]
        public static string[] names(Assembly src, utf8? match)
            => match != null && match.Value.IsNonEmpty
            ? src.ManifestResourceNames().Where(n => n.Contains(match.Value))
            : src.ManifestResourceNames();

        [MethodImpl(Inline), Op]
        public static string[] names(Assembly src)
            => src.GetManifestResourceNames();
    }
}