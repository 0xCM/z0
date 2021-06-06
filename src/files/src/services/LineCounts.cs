//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct LineCounts
    {
        [Op]
        public static LineCount count(FS.FilePath src)
        {
            var file = MemoryFiles.map(src);
            var counted = TextTools.CountLines(file.View());
            file.Dispose();
            return (src, counted);
        }

        [Op]
        public static Index<LineCount> count(ReadOnlySpan<FS.FilePath> src)
        {
            var dst = bag<LineCount>();
            iter(src, path => dst.Add(count(path)), true);
            return dst.ToArray().Sort();
        }
    }
}