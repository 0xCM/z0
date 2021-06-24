//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct TextFiles
    {
        [Op]
        public static LineCount linecount(FS.FilePath src)
        {
            var file = MemoryFiles.map(src);
            var counted = Lines.count(file.View());
            file.Dispose();
            return (src, counted);
        }

        [Op]
        public static Index<LineCount> linecounts(ReadOnlySpan<FS.FilePath> src)
        {
            var dst = bag<LineCount>();
            iter(src, path => dst.Add(linecount(path)), true);
            return dst.ToArray().Sort();
        }
    }
}