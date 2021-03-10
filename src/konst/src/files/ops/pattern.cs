//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static string pattern(params FileExt[] src)
            => Z0.text.join(Chars.Pipe, src.Select(x => x.SearchPattern));
    }
}