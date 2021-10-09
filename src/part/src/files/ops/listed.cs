//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    partial struct FS
    {
        public static Index<ListItem<string>> listed(FS.FilePath src, char delimiter = Chars.Comma)
            => core.items(src.ReadText().SplitClean(delimiter).Select(x => x.Trim()).Where(text.nonempty).ToReadOnlySpan());
    }
}