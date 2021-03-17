//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Linq;

    using static Part;

    partial struct ImageMaps
    {
        [MethodImpl(Inline), Op]
        public static Index<LocatedImage> index()
            => index(Process.GetCurrentProcess());

        [Op]
        public static Index<LocatedImage> index(Process src)
            => src.Modules.Cast<ProcessModule>().Map(locate).OrderBy(x => x.BaseAddress);
    }
}