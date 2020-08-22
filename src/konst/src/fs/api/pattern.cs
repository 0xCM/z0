//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static string pattern(params FileExt[] src)
            => text.join(Chars.Pipe, src.Select(x => x.SearchPattern));
    }
}